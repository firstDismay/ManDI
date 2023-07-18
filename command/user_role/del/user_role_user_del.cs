using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user_role.del
{
    /// <summary>
    /// Команда удаляет пользовательскую роль БД
    /// </summary>
    public class user_role_user_del : IParametersFunction
    {
        /// <summary>
        /// Системное имя роли
        /// </summary>
        public string inamesys { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("inamesys", NpgsqlDbType.Varchar);
                Parameter.Value = inamesys;
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
                return "user_role_user_del";
            }
        }

        public string? Condition { get; set; }
    }
}
