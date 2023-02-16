using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по маске имени родителя 
    /// </summary>
    public class class_act_by_id_parent_msk_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор родителького класса
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Маска имени класса
        /// </summary>
        public long name_mask { get; set; }

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

                Parameter = new NpgsqlParameter("name_mask", NpgsqlDbType.Varchar);
                Parameter.Value = name_mask;
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
                return "class_act_by_id_parent_msk_name";
            }
        }
    }
}
