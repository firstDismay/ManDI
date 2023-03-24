using Npgsql;

namespace ManDI.command.user.sel
{
    /// <summary>
    /// Команда возвращает пользователя текущей сессии
    /// </summary>
    public class user_by_current : IParametersFunction
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
                return "user_by_current";
            }
        }
    }
}
