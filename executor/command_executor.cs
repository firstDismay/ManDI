using Npgsql;
using System.Data;
using ManDI.extractor;

namespace ManDI.executor
{
    /// <summary>
    /// Класс исполнителя подготовленных команд
    /// </summary>
    public class command_executor : ICommandExecutor
    {
        ISignatureExtractor _function;
        NpgsqlDataSource _data_source;

        public command_executor(ISignatureExtractor Function, NpgsqlDataSource DataSource)
        {
            if (Function == null) throw new ArgumentNullException("Function");
            if (DataSource == null) throw new ArgumentNullException("DataSource");

            _function = Function;
            _data_source = DataSource;
        }

        public int ExecuteNonQuery()
        {
            int result;
            NpgsqlCommand cmd;

            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(_function, cn);
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

            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(_function, cn);
                result =  cmd.ExecuteScalar();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }

        public DataTable Fill()
        {
            var table = new DataTable();
            NpgsqlCommand cmd;

            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(_function, cn);
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