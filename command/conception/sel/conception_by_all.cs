using Npgsql;

namespace ManDI.command.conception.sel
{
    /// <summary>
    /// Команда возвращает таблицу доступных концепций 
    /// </summary>
    public class conception_by_all : IParametersFunction
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
                return "conception_by_all";
            }
        }

        public string? Condition { get; set; }
    }
}
