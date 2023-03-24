using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает записи журнала свойства объекта по идентификатору
    /// </summary>
    public class log_by_id_object_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства объекта
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_object", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object;
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
                return "log_by_id_object_prop";
            }
        }
    }
}