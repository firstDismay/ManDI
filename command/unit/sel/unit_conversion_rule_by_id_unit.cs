using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.sel
{
    /// <summary>
    /// Команда возвращает список правил пересчета по идентификаторам концепции и измеряемой величины
    /// </summary>
    public class unit_conversion_rule_by_id_unit : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_con { get; set; }

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

                Parameter = new NpgsqlParameter("iid_con", NpgsqlDbType.Bigint);
                Parameter.Value = iid_con;
                ListParameter.Add(Parameter);

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
                return "unit_conversion_rule_by_id_unit";
            }
        }
    }
}
