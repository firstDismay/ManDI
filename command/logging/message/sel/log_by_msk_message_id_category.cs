using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает записи журнала по идентификатору категории и маске сообщения
    /// </summary>
    public class log_by_msk_message_id_category : IParametersFunction
    {
        /// <summary>
        /// Маска сообщения
        /// </summary>
        public string imessage { get; set; }

        /// <summary>
        /// Идентификатор категории записей
        /// </summary>
        public long iid_category { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("imessage", NpgsqlDbType.Varchar);
                Parameter.Value = imessage;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_category", NpgsqlDbType.Bigint);
                Parameter.Value = iid_category;
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
                return "log_by_msk_message_id_category";
            }
        }
    }
}