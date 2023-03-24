using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда возвращает данные значения объектного свойства класса по идентификатору
    /// </summary>
    public class class_prop_object_val_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор данных значения
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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
                return "class_prop_object_val_by_id";
            }
        }
    }
}