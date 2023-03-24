using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает запись журнала по идентификатору
    /// </summary>
    public class log_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор записи
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
                return "log_by_id";
            }
        }
    }
}