using ManDI.command.common;
using ManDI.command.objects;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.service.objects
{
    /// <summary>
    /// Команда добавляет новый объект в указанное расположение
    /// </summary>
    public class object_by_id_position_service : ICommandService<object_by_id_position>
    {
        private NpgsqlDataSource _DataSource;
        public object_by_id_position_service(NpgsqlDataSource DataSource)
        {
            if (DataSource != null)
            { 
                _DataSource = DataSource;
            }
            else { throw new ArgumentNullException(); }
        }
        public int ExecuteNonQuery(object_by_id_position argument)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(object_by_id_position argument)
        {
            throw new NotImplementedException();
        }

        public DataTable Fill(object_by_id_position argument)
        {
            using (var cmd = _DataSource.CreateCommand())
            {
                NpgsqlParameter parameter;
                var table = new DataTable("vobject_general");

                cmd.CommandType = CommandType.Text;
                String scmd = String.Format(@"Select bpd.{0}(1314)", argument.proname().ToString());
                cmd.CommandText = scmd;

                parameter = cmd.Parameters.Add("iid_position", NpgsqlTypes.NpgsqlDbType.Bigint);
                parameter.Value = argument.iid_position;
                
                cmd.ExecuteNonQuery();
                var adapter = new NpgsqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                return table;
            }
        }
    }
}
