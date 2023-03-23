using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.sel
{
    /// <summary>
    /// Команда возвращает список записей журнала по идентификатору категории записей
    /// </summary>
    public class log_by_id_category : IParametersFunction
    {   
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
                return "log_by_id_category";
            }
        }
    }
}