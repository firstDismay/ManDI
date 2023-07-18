using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает записи журнала по идентификатору пользователя
    /// </summary>
    public class log_by_id_user : IParametersFunction
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public long iid_user { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_user", NpgsqlDbType.Bigint);
                Parameter.Value = iid_user;
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
                return "log_by_id_user";
            }
        }

        public string? Condition { get; set; }
    }
}