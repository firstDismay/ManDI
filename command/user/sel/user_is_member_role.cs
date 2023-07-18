using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user.sel
{
    /// <summary>
    /// Команда проверяет членство пользователя в указанной роли
    /// </summary>
    public class user_is_member_role : IParametersFunction
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string ilogin { get; set; }

        /// <summary>
        /// Роль, членство в которой необходимо проверить
        /// </summary>
        public string irole { get; set; }

        /// <summary>
        /// Признак рекурсивной проверки членства
        /// </summary>
        public bool irecursive { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("ilogin", NpgsqlDbType.Varchar);
                Parameter.Value = ilogin;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("irole", NpgsqlDbType.Varchar);
                Parameter.Value = irole;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("irecursive", NpgsqlDbType.Boolean);
                Parameter.Value = irecursive;
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
                return "user_is_member_role";
            }
        }

        public string? Condition { get; set; }
    }
}
