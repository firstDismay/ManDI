using Npgsql;
using NpgsqlTypes;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда возвращает список доступных типов данных для указанной концепции по идентификатору концепции
    /// </summary>
    public class con_prop_data_type_full_by_id_con : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }
        
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
                return "con_prop_data_type_full_by_id_con";
            }
        }
        public string? Condition { get; set; }
    }
}
