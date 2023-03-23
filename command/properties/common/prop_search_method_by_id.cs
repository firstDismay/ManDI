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
    /// Команда возвращает доступные методы поиска для указанного типа свойства и типа данных
    /// </summary>
    public class prop_search_method_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор типа свойства
        /// </summary>
        public int iid_prop_type { get; set; }

        /// <summary>
        /// Идентификатор  типа данных свойства
        /// </summary>
        public int iid_data_type { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prop_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_prop_type;
                ListParameter.Add(Parameter);

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
                return "prop_search_method_by_id";
            }
        }
    }
}
