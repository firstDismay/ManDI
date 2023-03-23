using Npgsql;

namespace ManDI.command.unit.sel
{
    /// <summary>
    /// Команда возвращает список доступных величин измерения
    /// </summary>
    public class units_by_all : IParametersFunction
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
                return "units_by_all";
            }
        }
    }
}
