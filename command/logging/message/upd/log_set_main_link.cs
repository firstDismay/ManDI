using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.upd
{
    /// <summary>
    /// Команда обновляет запись журнала
    /// </summary>
    public class log_set_main_link : IParametersFunction
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long iid_log { get; set; }

        /// <summary>
        /// Идентификатор новой основной ссылки записи лога
        /// </summary>
        public long iid_log_link { get; set; }



        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_log", NpgsqlDbType.Bigint);
                Parameter.Value = iid_log;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_log_link", NpgsqlDbType.Bigint);
                Parameter.Value = iid_log_link;
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
                return "log_set_main_link";
            }
        }

        public string? Condition { get; set; }
    }
}