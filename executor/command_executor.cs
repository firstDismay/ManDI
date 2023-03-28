using ManDI.extractor;
using Npgsql;
using System.Data;

namespace ManDI.executor
{
    /// <summary>
    /// Класс исполнителя подготовленных команд
    /// </summary>
    public class command_executor : ICommandExecutor<ISignatureExtractor>
    {
        mandi data_source;

        public command_executor( mandi DataSource)
        {
            if (DataSource == null) throw new ArgumentNullException("DataSource");
            this.data_source = DataSource;
        }

        public int ExecuteNonQuery(ISignatureExtractor command)
        {
            int result;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(command, cn);
                result = cmd.ExecuteNonQuery();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }
        public object ExecuteScalar(ISignatureExtractor command)
        {
            object result;
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(command, cn);
                result = cmd.ExecuteScalar();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
        }

        public DataTable Fill(ISignatureExtractor command)
        {
            var table = new DataTable();
            NpgsqlCommand cmd;

            using (var cn = this.data_source.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(command, cn);
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