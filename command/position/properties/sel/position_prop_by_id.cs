using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.properties.sel
{
    /// <summary>
    /// Команда возвращает свойство позиции по идентификатору
    /// </summary>
    public class position_prop_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  позиции
        /// </summary>
        public long iid_position_carrier { get; set; }

        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }


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
                return "position_prop_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}
