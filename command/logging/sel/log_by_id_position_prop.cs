using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.sel
{
    /// <summary>
    /// Команда возвращает записи журнала свойства позиции по идентификатору
    /// </summary>
    public class log_by_id_position_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства позиции
        /// </summary>
        public long iid_position_prop { get; set; }

        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_object", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object;
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
                return "log_by_id_position_prop";
            }
        }
    }
}