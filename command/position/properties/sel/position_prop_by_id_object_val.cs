using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.properties.sel
{
    /// <summary>
    /// Команда возвращает объектное свойство позиции по идентификатору объекта значения
    /// </summary>
    public class position_prop_by_id_object_val : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  объекта значения
        /// </summary>
        public long iid_object_val { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_val;
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
                return "position_prop_by_id_object_val";
            }
        }
    }
}
