using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.properties.sel
{
    /// <summary>
    /// Команда возвращает список свойств объекта по идентификатору объекта носителя
    /// </summary>
    public class object_prop_by_id_object : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта носителя
        /// </summary>
        public long iid_object_carrier { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object_carrier", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_carrier;
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
                return "object_prop_by_id_object";
            }
        }

        public string? Condition { get; set; }
    }
}