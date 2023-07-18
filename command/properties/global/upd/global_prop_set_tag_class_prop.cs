using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.upd
{
    /// <summary>
    /// Команда устанавливает тэг определяющих свойств класса, связанных с указанным глобальным свойством
    /// </summary>
    public class global_prop_set_tag_class_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        /// Тег глобального свойства
        /// </summary>
        public string itag { get; set; }

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

                Parameter = new NpgsqlParameter("itag", NpgsqlDbType.Varchar);
                Parameter.Value = itag;
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
                return "global_prop_set_tag_class_prop";
            }
        }

        public string? Condition { get; set; }
    }
}
