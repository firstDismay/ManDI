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
    /// Команда возвращает список активных представлений классов по маске значения глобального свойства
    /// </summary>
    public class class_act_by_msk_global_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        ///  Маска имени класса
        /// </summary>
        public string find_mask { get; set; }

        /// <summary>
        /// Признак выбора вещественных классов
        /// </summary>
        public bool class_real_only { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_global_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_global_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("find_mask", NpgsqlDbType.Varchar);
                Parameter.Value = find_mask;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("class_real_only", NpgsqlDbType.Boolean);
                Parameter.Value = class_real_only;
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
                return "class_act_by_msk_global_prop";
            }
        }
    }
}
