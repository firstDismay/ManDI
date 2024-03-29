﻿using ManDI.build;
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
        IDataService data_service;
        ISignatureExtractor signature_extractor;
        public command_executor(ISignatureExtractor SignatureExtractor, IDataService DataService)
        {
            if (DataService == null) throw new ArgumentNullException("DataSource");
            this.data_service = DataService;

            if (DataService == null) throw new ArgumentNullException("SignatureExtractor");
            this.signature_extractor = SignatureExtractor;
        }

        public int ExecuteNonQuery(IParametersFunction function)
        {
            int result;
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                result = cmd.ExecuteNonQuery();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
                cn.CloseAsync();
            }
            return result;
        }
        public object ExecuteScalar(IParametersFunction function)
        {
            object result;
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                result = cmd.ExecuteScalar();
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
                cn.CloseAsync();
            }
            return result;
        }

        public DataTable Fill(IParametersFunction function)
        {
            var table = new DataTable();
            NpgsqlCommand cmd;

            using (var cn = this.data_service.GetDataSource().CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(function, cn);
                var adapter = new NpgsqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (cmd.Transaction != null)
                    cmd.Transaction.Commit();
                cn.CloseAsync();
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