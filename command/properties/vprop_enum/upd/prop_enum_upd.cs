using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.upd
{
    /// <summary>
    /// Команда обновляет перечисление в указанную концепцию
    /// </summary>
    public class prop_enum_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор перечисления
        /// </summary>
        public long iid_prop_enum { get; set; }

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Наименование перечисления
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание перечисления
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Область видимости перечисления
        /// </summary>
        public int iid_prop_enum_use_area { get; set; }

        /// <summary>
        /// Тип данных перечисления
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

                Parameter = new NpgsqlParameter("iid_prop_enum", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_prop_enum_use_area", NpgsqlDbType.Integer);
                Parameter.Value = iid_prop_enum_use_area;
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
                return "prop_enum_upd";
            }
        }
    }
}