using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.sel
{
    /// <summary>
    /// Команда возвращает список групп по идентификатору класса родителя
    /// </summary>
    public class group_by_id_parent : IParametersFunction
    {
        /// <summary>
        /// Идентификатор родительской группы
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_con { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_con", NpgsqlDbType.Bigint);
                Parameter.Value = iid_con;
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
                return "group_by_id_parent";
            }
        }
    }
}
