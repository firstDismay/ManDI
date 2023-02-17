using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.sel
{
    /// <summary>
    /// Команда возвращает список групп по идентификатору класса родителя и маске имени
    /// </summary>
    public class group_by_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор родительской группы
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Маска наименования группы
        /// </summary>
        public long iname { get; set; }

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

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
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
                return "group_by_name";
            }
        }
    }
}
