using Npgsql;
using NpgsqlTypes;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда возвращает список типов данных для указанной концепции по идентификаторам концепции и типа свойства
    /// </summary>
    public class con_prop_data_type_by_id_prop_type : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Идентификатор типа свойства
        /// </summary>
        public int iid_prop_type { get; set; }


        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_prop_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_prop_type;
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
                return "con_prop_data_type_by_id_prop_type";
            }
        }

        public string? Condition { get; set; }
    }
}
