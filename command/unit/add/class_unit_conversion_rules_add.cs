using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.add
{
    /// <summary>
    /// Команда связывает правило пересчета с вещественным классом, 
    /// разрешая его использование, по идентификатору класса и правилу пересчета
    /// </summary>
    public class class_unit_conversion_rules_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_class{ get; set; }

        /// <summary>
        /// Идентификатор правила пересчета
        /// </summary>
        public long iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Bigint);
                Parameter.Value = iid_unit_conversion_rule;
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
                return "class_unit_conversion_rules_add";
            }
        }

        public string? Condition { get; set; }
    }
}