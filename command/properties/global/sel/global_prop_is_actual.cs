using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставлямой сущности
    /// </summary>
    public class global_prop_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Штамп времени глобального свойства
        /// </summary>
        public DateTime timestamp_entity { get; set; }

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

                Parameter = new NpgsqlParameter("timestamp_entity", NpgsqlDbType.Bigint);
                Parameter.Value = timestamp_entity;
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
                return "global_prop_is_actual";
            }
        }

        public string? Condition { get; set; }
    }
}
