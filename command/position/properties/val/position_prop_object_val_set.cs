using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.properties.upd
{
    /// <summary>
    /// Команда встраивает выбранный объект в указанное значение объектного свойства STEP №03
    /// </summary>
    public class position_prop_object_val_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position_carrier { get; set; }

        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        ///  Идентификатор объекта значения свойства
        public long iid_object_val { get; set; }

        /// <summary>
        ///  Идентификатор текущего количества единиц
        /// </summary>
        public decimal icquantity { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position_carrier", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position_carrier;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_object_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_val;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("icquantity", NpgsqlDbType.Numeric);
                Parameter.Value = icquantity;
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
                return "position_prop_object_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}
