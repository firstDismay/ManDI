using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.properties.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставляемой сущности
    /// </summary>
    public class object_prop_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Идентификатор объекта носителя
        /// </summary>
        public long iid_object_carrier { get; set; }

        /// <summary>
        /// Штамп времени объекта носителя
        /// </summary>
        public DateTime itimestamp_object_carrier { get; set; }

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

                Parameter = new NpgsqlParameter("iid_object_carrier", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_carrier;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_object_carrier", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_object_carrier;
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
                return "object_prop_is_actual";
            }
        }

        public string? Condition { get; set; }
    }
}