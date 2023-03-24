using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.upd
{
    /// <summary>
    /// Команда обновляет запись журнала
    /// </summary>
    public class log_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long iid_log { get; set; }

        /// <summary>
        /// Идентификатор категории записи
        /// </summary>
        public long iid_category { get; set; }

        /// <summary>
        /// Автор записи
        /// </summary>
        public string iuser_author { get; set; }

        /// <summary>
        /// Дата записи
        /// </summary>
        public DateTime idatetime { get; set; }

        /// <summary>
        /// Заголовок записи
        /// </summary>
        public string ititle { get; set; }

        /// <summary>
        /// Текст записи
        /// </summary>
        public string imessage { get; set; }

        /// <summary>
        /// Класс сообщения
        /// </summary>
        public string iclass_body { get; set; }

        /// <summary>
        /// Тело сообщения в формате JSON
        /// </summary>
        public string ibody { get; set; }

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

                Parameter = new NpgsqlParameter("iid_category", NpgsqlDbType.Bigint);
                Parameter.Value = iid_category;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iuser_author", NpgsqlDbType.Text);
                Parameter.Value = iuser_author;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idatetime", NpgsqlDbType.Timestamp);
                Parameter.Value = idatetime;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ititle", NpgsqlDbType.Text);
                Parameter.Value = ititle;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iclass_body", NpgsqlDbType.Text);
                Parameter.Value = iclass_body;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imessage", NpgsqlDbType.Text);
                Parameter.Value = imessage;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ibody", NpgsqlDbType.Jsonb);
                Parameter.Value = ibody;
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
                return "log_upd";
            }
        }
    }
}