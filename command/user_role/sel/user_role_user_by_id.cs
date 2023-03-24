using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user_role.sel
{
    /// <summary>
    /// Команда возвращает пользовательскую роль по идентификатору
    /// </summary>
    public class user_role_user_by_id : IParametersFunction
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public long iid { get; set; }


        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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
                return "user_role_user_by_id";
            }
        }
    }
}
