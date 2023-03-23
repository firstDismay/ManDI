using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.add
{
    /// <summary>
    /// Команда добавляет глобальное свойство концепции
    /// </summary>
    public class global_prop_add : IParametersFunction
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
        /// Идентификатор типа данных свойства
        /// </summary>
        public int iid_data_type { get; set; }

        /// <summary>
        /// Наименование свойства
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание свойства
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Признак видимости свойства
        /// </summary>
        public string ivisible { get; set; }

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

                Parameter = new NpgsqlParameter("iid_data_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_data_type;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ivisible", NpgsqlDbType.Boolean);
                Parameter.Value = ivisible;
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
                return "global_prop_add";
            }
        }
    }
}
