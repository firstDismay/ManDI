using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.link.sel
{
    /// <summary>
    /// Команда возвращает ссылку записи журнала по идентификатору ссылки
    /// </summary>
    public class log_link_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор ссылки записи журнала
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
                return "log_link_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}