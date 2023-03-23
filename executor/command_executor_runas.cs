using Npgsql;
using System.Data;
using ManDI.extractor;
using System.Diagnostics;

namespace ManDI.executor
{
    /// <summary>
    /// Декоратор класса исполнителя команд выполняет команду в контексте указанного пользователя
    /// </summary>
    public class command_executor_runas : ICommandExecutor
    {
        ISignatureExtractor function;
        UserContextRole user_context;
        mandi data_source;

        public command_executor_runas(ISignatureExtractor Function, UserContextRole UserContext, mandi DataSource)
        {
            if (Function == null) throw new ArgumentNullException("Function");
            if (UserContext == null) throw new ArgumentNullException("UserContext");
            if (DataSource == null) throw new ArgumentNullException("DataSource");

            this.function = Function;
            this.user_context = UserContext;
            this.data_source = DataSource;
        }

        public int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar()
        {
            object result;
            NpgsqlCommand set_role;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(this.function, cn);
                set_role = prepare_set_role(this.user_context.Role, cn, cmd.Transaction);
                set_role.ExecuteNonQuery();
                result = cmd.ExecuteScalar();
                cmd.Transaction.Commit();
            }
            return result;
        }

        public DataTable Fill()
        {
            var table = new DataTable();
            NpgsqlCommand set_role;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(this.function, cn);
                set_role = prepare_set_role(this.user_context.Role, cn, cmd.Transaction);
                set_role.ExecuteNonQuery();

                var adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                cmd.Transaction.Commit();
            }
            return table;
        }
        /// <summary>
        /// Подготовка основной функции со сменой роли
        /// </summary>
        NpgsqlCommand prepare_cmd(ISignatureExtractor signature, NpgsqlConnection cn)
        {
            var trans = cn.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = signature.Signature;

            foreach (NpgsqlParameter p in signature.Parameters)
            {
                cmd.Parameters.Add(p);
            }
            return cmd;
        }

        //Смена роли
        NpgsqlCommand prepare_set_role(string Role, NpgsqlConnection cn, NpgsqlTransaction trans)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("SET ROLE '{0}';", Role);
            return cmd;
        }
    }
}