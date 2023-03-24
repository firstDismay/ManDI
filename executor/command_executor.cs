using ManDI.extractor;
using Npgsql;
using System.Data;

namespace ManDI.executor
{
    /// <summary>
    /// Класс исполнителя подготовленных команд
    /// </summary>
    public class command_executor : ICommandExecutor
    {
        ISignatureExtractor function;
        mandi data_source;

        public command_executor(ISignatureExtractor Function, mandi DataSource)
        {
            if (Function == null) throw new ArgumentNullException("Function");
            if (DataSource == null) throw new ArgumentNullException("DataSource");

            this.function = Function;
            this.data_source = DataSource;
        }

        public int ExecuteNonQuery()
        {
            int result;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(this.function, cn);
                result = cmd.ExecuteNonQuery();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }
        public object ExecuteScalar()
        {
            object result;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                result = cmd.ExecuteScalar();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }

        public DataTable Fill()
        {
            var table = new DataTable();
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(this.function, cn);
                var adapter = new NpgsqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return table;
        }

        /// <summary>
        /// Функция подготовки основной команды
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
    }
}