using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user.sel
{
    /// <summary>
    /// Команда возвращает пользователей, членов указанной роли
    /// </summary>
    public class user_by_roles : IParametersFunction
    {
        /// <summary>
        /// Групповая роль
        /// </summary>
        public string irole { get; set; }


        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("irole", NpgsqlDbType.Varchar);
                Parameter.Value = irole;
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
                return "user_by_roles";
            }
        }

        public string? Condition { get; set; }
    }
}
