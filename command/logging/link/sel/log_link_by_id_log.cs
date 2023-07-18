using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.link.sel
{
    /// <summary>
    /// Команда возвращает ссылки записи журнала по идентификатору записи журнала
    /// </summary>
    public class log_link_by_id_log : IParametersFunction
    {
        /// <summary>
        /// Идентификатор записи журнала
        /// </summary>
        public long iid_log { get; set; }

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
                return "log_link_by_id_log";
            }
        }

        public string? Condition { get; set; }
    }
}