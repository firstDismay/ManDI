using ManDI.build;
using ManDI.command;
using ManDI.extractor;
using Npgsql;
using System.Data;

namespace ManDI.executor
{
    /// <summary>
    /// Класс исполнителя подготовленных команд экспорта
    /// </summary>
    public class export_executor : IExportExecutor
    {
        IDataService data_service;
        ISignatureExtractor signature_extractor;
        public export_executor(ISignatureExtractor SignatureExtractor, IDataService DataService)
        {
            if (DataService == null) throw new ArgumentNullException("DataSource");
            this.data_service = DataService;

            if (DataService == null) throw new ArgumentNullException("SignatureExtractor");
            this.signature_extractor = SignatureExtractor;
        }

        public Byte[] Export(IParametersFunction function)
        {
            Byte[] result;
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                result = (Byte[])cmd.ExecuteScalar();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
            }
            return result;
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