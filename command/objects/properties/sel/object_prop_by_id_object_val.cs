using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ManDI.command.objects.properties.sel
{
    /// <summary>
    /// Команда возвращает свойство объекта по идентификатору объекта-значения свойства
    /// </summary>
    public class object_prop_by_id_object_val : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта значения свойства
        /// </summary>
        public long iid_object_val { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_val;
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
                return "object_prop_by_id_object_val";
            }
        }
    }
}