using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.nesting_rule.postemp
{
    /// <summary>
    /// Команда возвращает минимальное допустимое количество позиций определенного шаблона, вложенных в указанную позицию
    /// </summary>
    public class pos_temp_nested_limit_min : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции
        /// </summary>
        public long iid_pos_temp { get; set; }

        /// <summary>
        /// Идентификатор вложенного шаблона позиции
        /// </summary>
        public long iid_pos_temp_nested { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pos_temp", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp_nested", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_nested;
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
                return "pos_temp_nested_limit_min";
            }
        }

        public string? Condition { get; set; }
    }
}