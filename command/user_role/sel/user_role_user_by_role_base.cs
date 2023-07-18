using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user_role.sel
{
    /// <summary>
    /// Команда возвращает список пользовательских ролей, членов базовой роли по имени базовой роли
    /// </summary>
    public class user_role_user_by_role_base : IParametersFunction
    {
        /// <summary>
        /// Системное имя роли
        /// </summary>
        public string irole_base { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("irole_base", NpgsqlDbType.Varchar);
                Parameter.Value = irole_base;
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
                return "user_role_user_by_role_base";
            }
        }

        public string? Condition { get; set; }
    }
}
