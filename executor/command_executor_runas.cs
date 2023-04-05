using ManDI.command;
using ManDI.extractor;
using Npgsql;
using System.Data;

namespace ManDI.executor
{
    /// <summary>
    /// Класс исполнителя подготовленных команд с переключением на указанную роль
    /// </summary>
    public class command_executor_runas : ICommandExecutorAs
    {
        IDataService data_service;
        ISignatureExtractor signature_extractor;
        public command_executor_runas(ISignatureExtractor SignatureExtractor, IDataService DataService)
        {
            if (DataService == null) throw new ArgumentNullException("DataSource");
            this.data_service = DataService;

            if (DataService == null) throw new ArgumentNullException("SignatureExtractor");
            this.signature_extractor = SignatureExtractor;
        }

        public int ExecuteNonQuery(IParametersFunction function, UserContextRole user)
        {
            int result;
            NpgsqlCommand set_role;
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                set_role = prepare_set_role(user.Role, cn, cmd.Transaction);
                set_role.ExecuteNonQuery();
                result = cmd.ExecuteNonQuery();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }

        public object ExecuteScalar(IParametersFunction function, UserContextRole user)
        {
            object result;
            NpgsqlCommand set_role;
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                set_role = prepare_set_role(user.Role, cn, cmd.Transaction);
                set_role.ExecuteNonQuery();
                result = cmd.ExecuteScalar();
                cmd.Transaction.Commit();
            }
            return result;
        }

        public DataTable Fill(IParametersFunction function, UserContextRole user)
        {
            var table = new DataTable();
            NpgsqlCommand set_role;
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                set_role = prepare_set_role(user.Role, cn, cmd.Transaction);
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
        NpgsqlCommand prepare_cmd(IParametersFunction function, NpgsqlConnection cn)
        {
            var trans = cn.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = this.signature_extractor.GetSignatureFunction(function);

            foreach (NpgsqlParameter p in function.Parameters)
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