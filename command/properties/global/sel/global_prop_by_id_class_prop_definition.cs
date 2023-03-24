using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.sel
{
    /// <summary>
    /// Команда возвращает список глобальных свойств по идентификатору определяющего свойства класса
    /// </summary>
    public class global_prop_by_id_class_prop_definition : IParametersFunction
    {
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
                return "global_prop_by_id_class_prop_definition";
            }
        }
    }
}
