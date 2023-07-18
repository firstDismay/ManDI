using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user_role.add
{
    /// <summary>
    /// Команда назначает базовую роль, для указанной роли пользователя 
    public class user_role_user_add : IParametersFunction
    {
        /// <summary>
        /// Наименование пользовательской роли
        /// </summary>
        public string irole_name { get; set; }

        /// <summary>
        /// Описание пользовательской роли
        /// </summary>
        public string irole_description { get; set; }

        /// <summary>
        /// Системное имя пользовательской роли
        /// </summary>
        public string irole_namesys { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("irole_name", NpgsqlDbType.Varchar);
                Parameter.Value = irole_name;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("irole_description", NpgsqlDbType.Varchar);
                Parameter.Value = irole_description;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("irole_namesys", NpgsqlDbType.Varchar);
                Parameter.Value = irole_namesys;
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
                return "user_role_user_add";
            }
        }

        public string? Condition { get; set; }
    }
}
