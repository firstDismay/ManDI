using Npgsql;
using NpgsqlTypes;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда добавляет выбранный тип данных в указанную концепцию
    /// </summary>
    public class con_prop_data_type_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Идентификатор типа данных свойства
        /// </summary>
        public int iid_prop_data_type { get; set; }

        /// <summary>
        /// Алиас типа данных свойства в применяемый в рамках концепции
        /// </summary>
        public String ialias { get; set; }

        /// <summary>
        /// Ключ сортировки типов концепции
        /// </summary>
        public int isort { get; set; }

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

                Parameter = new NpgsqlParameter("iid_prop_data_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_prop_data_type;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ialias", NpgsqlDbType.Varchar);
                Parameter.Value = ialias;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("isort", NpgsqlDbType.Integer);
                Parameter.Value = isort;
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
                return "con_prop_data_type_set";
            }
        }

        public string? Condition { get; set; }
    }
}
