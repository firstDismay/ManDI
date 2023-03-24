using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.sel
{
    /// <summary>
    /// Команда определяет готовность свойства к линковке с глобальными свойствами по идентификатору свойства класса
    /// </summary>
    public class class_prop_state_for_global_prop_link : IParametersFunction
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
                return "class_prop_state_for_global_prop_link";
            }
        }
    }
}