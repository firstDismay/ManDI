using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов-значений объектного свойства объекта по идентификатору свойства объекта
    /// </summary>
    public class object_object_prop_by_id_object_carrier : IParametersFunction
    {

        /// <summary>
        /// Идентификатор объекта носителя
        /// </summary>
        public long iid_object_carrier { get; set; }

        /// <summary>
        /// Идентификатор объектного свойства
        /// </summary>
        public long iid_class_prop { get; set; }

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

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
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
                return "object_object_prop_by_id_object_carrier";
            }
        }
    }
}