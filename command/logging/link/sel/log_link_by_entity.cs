using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.link.sel
{
    /// <summary>
    /// Команда возвращает ссылки записи журнала по идентификатору сущности
    /// </summary>
    public class log_link_by_entity : IParametersFunction
    {
        /// <summary>
        /// Идентификатор записи журнала
        /// </summary>
        public long iid_log { get; set; }

        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public long iid_entity { get; set; }

        /// <summary>
        /// Идентификатор экземпляра сущности
        /// </summary>
        public long iid_entity_instance { get; set; }

        /// <summary>
        /// Идентификатор экземпляра сущности, дополнительный
        /// </summary>
        public long iid_sub_entity_instance { get; set; }

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

                Parameter = new NpgsqlParameter("iid_entity", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity_instance;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_sub_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_sub_entity_instance;
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
                return "log_link_by_entity";
            }
        }

        public string? Condition { get; set; }
    }
}