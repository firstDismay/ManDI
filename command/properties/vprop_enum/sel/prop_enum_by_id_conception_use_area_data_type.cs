using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.sel
{
    /// <summary>
    /// Команда возвращает список перечислений по идентификаторам концепции, области применения и типа данных
    /// </summary>
    public class prop_enum_by_id_conception_use_area_data_type : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Идентификатор области видимости перечисления
        /// </summary>
        public int iid_prop_enum_use_area { get; set; }

        /// <summary>
        /// Идентификатор типа данных свойства
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

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
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
                return "prop_enum_by_id_conception_use_area_data_type";
            }
        }
    }
}