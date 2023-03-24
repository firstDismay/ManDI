using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.val
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставляемой сущности
    /// </summary>
    public class class_prop_link_val_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Штамп времени
        /// </summary>
        public DateTime itimestamp_class { get; set; }

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

                Parameter = new NpgsqlParameter("itimestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class;
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
                return "class_prop_link_val_is_actual";
            }
        }
    }
}