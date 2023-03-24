using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.sel
{
    /// <summary>
    /// Команда возвращает историческое представление свойства класса по идентификатору глобального свойства
    /// </summary>
    public class class_prop_snapshot_by_id_global_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор снимка класса
        /// </summary>
        public long iid_class_snapshot { get; set; }

        /// <summary>
        /// Штамп времени снимка класса
        /// </summary>
        public DateTime itimestamp_class_snapshot { get; set; }

        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_snapshot", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_snapshot;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class_snapshot", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class_snapshot;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_global_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_global_prop;
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
                return "class_prop_snapshot_by_id_global_prop";
            }
        }
    }
}