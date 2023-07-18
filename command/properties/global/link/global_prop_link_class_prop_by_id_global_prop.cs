using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.link
{
    /// <summary>
    /// Команда возвращает список ссылок глобального свойств на определяющие 
    /// свойства класса по идентификатору глобального свойства
    /// </summary>
    public class global_prop_link_class_prop_by_id_global_prop : IParametersFunction
    {
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
                return "global_prop_link_class_prop_by_id_global_prop";
            }
        }

        public string? Condition { get; set; }
    }
}