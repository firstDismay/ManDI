using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.upd
{
    /// <summary>
    /// Команда изменяет текущую сортировку свойств активного класса на сортировку по имени
    /// </summary>
    public class class_prop_sort_by_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
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
                return "class_prop_sort_by_name";
            }
        }
    }
}