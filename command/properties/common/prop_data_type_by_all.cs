using Npgsql;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда возвращает список доступных типов данных свойств
    /// </summary>
    public class prop_data_type_by_all : IParametersFunction
    {
        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
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
                return "prop_data_type_by_all";
            }
        }
    }
}
