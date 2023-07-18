using Npgsql;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда возвращает список всех типов свойств
    /// </summary>
    public class prop_type_by_all : IParametersFunction
    {
        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

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
                return "prop_type_by_all";
            }
        }

        public string? Condition { get; set; }
    }
}
