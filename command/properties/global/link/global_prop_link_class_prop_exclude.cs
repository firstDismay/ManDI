using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.link
{
    /// <summary>
    /// Команда исключает ссылку глобального свойства на определяющее свойства класса 
    /// </summary>
    public class global_prop_link_class_prop_exclude : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        /// Идентификатор определяющего свойства класса
        /// </summary>
        public long iid_class_prop_definition { get; set; }

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

                Parameter = new NpgsqlParameter("iid_class_prop_definition", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop_definition;
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
                return "global_prop_link_class_prop_exclude";
            }
        }
    }
}