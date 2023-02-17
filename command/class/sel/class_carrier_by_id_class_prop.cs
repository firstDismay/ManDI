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
    /// Команда возвращает активное/историческое представление класса носителя по идентификатору свойства
    /// </summary>
    public class class_carrier_by_id_class_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Штамп времени класса
        /// </summary>
        public DateTime itimestamp_class { get; set; }

        /// <summary>
        /// Тип хранилища данных класса
        /// Active/History
        /// </summary>
        public string storagetype { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("storagetype", NpgsqlDbType.Varchar);
                Parameter.Value = storagetype;
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
                return "class_carrier_by_id_class_prop";
            }
        }
    }
}