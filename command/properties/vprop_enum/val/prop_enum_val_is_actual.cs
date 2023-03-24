using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.val
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставлямой сущности
    /// </summary>
    public class prop_enum_val_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор элемента перечисления
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Штамп времени перечисления
        /// </summary>
        public DateTime itimestamp { get; set; }

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

                Parameter = new NpgsqlParameter("itimestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp;
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
                return "prop_enum_val_is_actual";
            }
        }
    }
}