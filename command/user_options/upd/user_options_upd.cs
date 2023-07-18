using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user.upd
{
    /// <summary>
    /// Команда определяет для пользователя концепцию по умолчанию
    /// </summary>
    public class user_options_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long ipref_conception { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("ipref_conception", NpgsqlDbType.Bigint);
                Parameter.Value = ipref_conception;
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
                return "user_options_upd";
            }
        }

        public string? Condition { get; set; }
    }
}
