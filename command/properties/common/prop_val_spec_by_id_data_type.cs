using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда озвращает значения спецификаторов пределов значений данных по идентификатору типа данных
    /// </summary>
    public class prop_val_spec_by_id_data_type : IParametersFunction
    {
        /// <summary>
        /// Идентификатор типа данных свойства
        /// </summary>
        public long iid_data_type { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_data_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_data_type;
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
                return "prop_val_spec_by_id_data_type";
            }
        }
    }
}
