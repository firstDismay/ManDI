using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ManDI.command.objects.properties.sel
{
    /// <summary>
    /// Команда возвращает свойство объекта по идентификатору определяющего свойства объекта
    /// </summary>
    public class object_prop_by_id_prop_definition : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта носителя
        /// </summary>
        public long iid_object_carrier { get; set; }

        /// <summary>
        /// Идентификатор определяющего свойства класса
        /// </summary>
        public long iid_prop_definition { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object_carrier", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_carrier;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_prop_definition", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_definition;
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
                return "object_prop_by_id_prop_definition";
            }
        }
    }
}