using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.properties.sel
{
    /// <summary>
    /// Команда возвращает список свойств позиции STEP3 по идентификатору позиции
    /// </summary>
    public class position_prop_by_id_position : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  позиции
        /// </summary>
        public long iid_position_carrier { get; set; }

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
                return "position_prop_by_id_position";
            }
        }

        public string? Condition { get; set; }
    }
}
