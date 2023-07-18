using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.export
{
    /// <summary>
    /// Команда оболочка для базовой функции экспорта в Excel exp_base_entity_to_excel
    public class exp_base_entity_to_excel : IParametersFunction
    {

        /// <summary>
        /// Команда экспорта
        /// </summary>
        public String command_export { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("command_export", NpgsqlDbType.Text);
                Parameter.Value = command_export;
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
                return "exp_base_entity_to_excel";
            }
        }

        public string? Condition { get; set; }
    }
}