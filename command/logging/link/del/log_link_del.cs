using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.link.sel
{
    /// <summary>
    /// Команда удаляет ссылку записи журнала по идентификатору ссылки
    /// </summary>
    public class log_link_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор ссылки записи журнала
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
                return "log_link_del";
            }
        }

        public string? Condition { get; set; }
    }
}