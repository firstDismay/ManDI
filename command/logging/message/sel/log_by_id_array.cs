using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает записи журнала по массиву идентификаторов записей
    /// </summary>
    public class log_by_id_array : IParametersFunction
    {
        /// <summary>
        /// Массив идентификаторов записей журнала
        /// </summary>
        public long[] log_array { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("log_array", NpgsqlDbType.Array | NpgsqlDbType.Bigint);
                Parameter.Value = log_array;
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
                return "log_by_id_array";
            }
        }
    }
}