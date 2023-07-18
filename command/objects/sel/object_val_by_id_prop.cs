using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Функция возвращает список объектов значений по идентификатору объектного свойства, ШАГ №03 
    /// </summary>
    public class object_val_by_id_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса объектов
        /// </summary>
        public long iid_class_prop_snapshot { get; set; }

        /// <summary>
        /// Идентификатор класса объектов
        /// </summary>
        public DateTime itimestamp_class { get; set; }

        /// <summary>
        /// Идентификатор класса объектов
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

                Parameter = new NpgsqlParameter("iid_class_prop_snapshot", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop_snapshot;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class;
                ListParameter.Add(Parameter);

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
                return "object_val_by_id_prop";
            }
        }

        public string? Condition { get; set; }
    }
}
