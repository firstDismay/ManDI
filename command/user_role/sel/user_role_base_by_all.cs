using Npgsql;

namespace ManDI.command.user_role.sel
{
    /// <summary>
    /// Команда возвращает список базовых ролей
    /// </summary>
    public class user_role_base_by_all : IParametersFunction
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
                return "user_role_base_by_all";
            }
        }

        public string? Condition { get; set; }
    }
}
