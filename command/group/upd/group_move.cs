using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.upd
{
    /// <summary>
    /// Команда перемещает группу
    /// </summary>
    public class group_move : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Идентификатор целевой группы
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
                ListParameter.Add(Parameter);

                return ListParameter;
            }
        }

        /// <summary>
        /// Наименование функции API
        /// </summary>
        public string NameFunction
        {
            get
            {
                return "group_move";
            }
        }
    }
}
