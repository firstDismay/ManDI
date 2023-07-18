using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user.del
{
    /// <summary>
    /// Команда возвращает пользователя по логину
    /// </summary>
    public class user_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  пользователя
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
                return "user_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}
