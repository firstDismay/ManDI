using ManDI.command;
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
        ManDI data_source;
        ISignatureExtractor signature_extractor;
        public command_executor(ISignatureExtractor SignatureExtractor, ManDI DataSource)
        {
            if (DataSource == null) throw new ArgumentNullException("DataSource");
            this.data_source = DataSource;
            
            if (DataSource == null) throw new ArgumentNullException("SignatureExtractor");
            this.signature_extractor = SignatureExtractor;
        }

        public int ExecuteNonQuery(IParametersFunction function)
        {
            int result;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                result = cmd.ExecuteNonQuery();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }
        public object ExecuteScalar(IParametersFunction function)
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

        public DataTable Fill(IParametersFunction function)
        {
            var table = new DataTable();
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
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
    }
}