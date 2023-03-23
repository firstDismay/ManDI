using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.sel
{
    /// <summary>
    /// Команда возвращает записи журнала по идентификатору шаблона позиции
    /// </summary>
    public class log_by_id_pos_temp_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();
                
                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
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
                return "log_by_id_pos_temp_prop";
            }
        }
    }
}