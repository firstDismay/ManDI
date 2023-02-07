using ManDI.command.common;
using ManDI.command.objects;
using ManDI.executor.common;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ManDI.executor
{
    /// <summary>
    /// Декоратор выполняет функцию в контексте указанного пользователя
    /// </summary>
    public class command_executor_runas : ICommandExecutor
    {
        ISignatureFunction _function;
        UserContextRole _user_context;
        NpgsqlDataSource _data_source;

        public command_executor_runas(ISignatureFunction Function, UserContextRole UserContext, NpgsqlDataSource DataSource)
        {
            if (Function == null) throw new ArgumentNullException("Function");
            if (UserContext == null) throw new ArgumentNullException("UserContext");
            if (DataSource == null) throw new ArgumentNullException("DataSource");

            _function = Function;
            _user_context = UserContext;
            _data_source = DataSource;
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


            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                var trans = cn.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);
                cmd = prepare_cmd(_function, cn, trans);
                set_role = prepare_set_role(_user_context.Role, cn, trans);
                set_role.ExecuteNonQuery();

                result = cmd.ExecuteScalar();
                trans.Commit();
            }
            return result;
        }

        public DataTable Fill()
        {
            var table = new DataTable();
            NpgsqlCommand set_role;
            NpgsqlCommand cmd;

            using (var cn = _data_source.CreateConnection())
            {
                cn.Open();
                var trans = cn.BeginTransaction(System.Data.IsolationLevel.RepeatableRead);
                cmd = prepare_cmd(_function, cn, trans);
                set_role = prepare_set_role(_user_context.Role, cn, trans);
                set_role.ExecuteNonQuery();

                var adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                trans.Commit();
            }
            return table;
        }
        /// <summary>
        /// Подготовка основной функции со сменой роли
        /// </summary>
        NpgsqlCommand prepare_cmd(ISignatureFunction signature, NpgsqlConnection cn, NpgsqlTransaction trans)
        {
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
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("SET ROLE '{0}';", Role);
            return cmd;
        }
    }
}
