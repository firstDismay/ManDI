using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user.sel
{
    /// <summary>
    /// Команда удаляет пользователя БД
    /// </summary>
    public class user_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  пользователя
        /// </summary>
        public long ilogin { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("ilogin", NpgsqlDbType.Bigint);
                Parameter.Value = ilogin;
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
                return "user_del";
            }
        }
    }
}
