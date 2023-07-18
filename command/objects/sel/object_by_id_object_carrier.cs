using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору объекта носителя
    /// </summary>
    public class object_by_id_object_carrier : IParametersFunction
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
                return "object_by_id_object_carrier";
            }
        }

        public string? Condition { get; set; }
    }
}