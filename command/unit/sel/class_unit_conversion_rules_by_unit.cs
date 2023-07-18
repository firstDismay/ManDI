using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.sel
{
    /// <summary>
    /// Команда возвращает список назначений правил пересчета по идентификатору измеряемой величины
    /// </summary>
    public class class_unit_conversion_rules_by_unit : IParametersFunction
    {
        /// <summary>
        /// Идентификатор измеряемой величины
        /// </summary>
        public int iid_unit { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_unit", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit;
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
                return "class_unit_conversion_rules_by_unit";
            }
        }

        public string? Condition { get; set; }
    }
}