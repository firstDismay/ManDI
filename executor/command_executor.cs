using ManDI.command.common;
using ManDI.command.objects;
using ManDI.executor.common;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.executor
{
    /// <summary>
    /// Команда добавляет новый объект в указанное расположение
    /// </summary>
    public class command_executor : ICommandExecutor
    {
        ISignatureFunction _function;
        NpgsqlDataSource _data_source;

        public command_executor(ISignatureFunction Function, NpgsqlDataSource DataSource)
        {
            if (Function == null) throw new ArgumentNullException("Function");
            if (DataSource == null) throw new ArgumentNullException("DataSource");

            _function = Function;
            _data_source = DataSource;
        }

        public int ExecuteNonQuery()
        {
            NpgsqlCommand cmd;

            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(_function, cn);
                return cmd.ExecuteNonQuery();
            }
        }
        public object ExecuteScalar()
        {
            NpgsqlCommand cmd;

            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                cmd = prepare_cmd(_function, cn);
                return cmd.ExecuteScalar();
            }
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
            }
            return table;
        }

        /// <summary>
        /// Функция подготовки основной команды
        /// </summary>
        NpgsqlCommand prepare_cmd(ISignatureFunction signature, NpgsqlConnection cn)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = cn;
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