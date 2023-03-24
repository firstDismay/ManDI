using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.sel
{
    /// <summary>
    /// Команда возвращает правило пересчета единиц измерения по идентификатору правила пересчета
    /// </summary>
    public class unit_conversion_rule_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор правила пересчета
        /// </summary>
        public long iid { get; set; }

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
                return "unit_conversion_rule_by_id";
            }
        }
    }
}
