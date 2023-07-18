using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает записи журнала по идентификатору категории и маске описания
    /// </summary>
    public class log_by_msk_title_id_category : IParametersFunction
    {
        /// <summary>
        /// Маска описания
        /// </summary>
        public string ititle { get; set; }

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

                Parameter = new NpgsqlParameter("ititle", NpgsqlDbType.Varchar);
                Parameter.Value = ititle;
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
                return "log_by_msk_title_id_category";
            }
        }

        public string? Condition { get; set; }
    }
}