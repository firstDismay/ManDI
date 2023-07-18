using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.nesting_rule.sel
{
    /// <summary>
    /// Команда возвращает правило назначения уровня L2 типа класс на позицию по идентификатору позиции
    /// </summary>
    public class rulel2_class_on_position_by_id_position : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
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
                return "rulel2_class_on_position_by_id_position";
            }
        }

        public string? Condition { get; set; }
    }
}