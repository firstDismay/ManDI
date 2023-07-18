using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.add
{
    /// <summary>
    /// Команда добавляет правило пересчета для указанной измеряемой величины
    /// </summary>
    public class unit_conversion_rule_add : IParametersFunction
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
        /// Обозначение единиц измерения
        /// </summary>
        public string icunit { get; set; }

        /// <summary>
        /// Коэффициент пересчета из базовой единицы измерения
        /// </summary>
        public decimal imc { get; set; }

        /// <summary>
        /// Признак единичного учета
        /// </summary>
        public bool ion_single { get; set; }

        /// <summary>
        /// Точность округления
        /// </summary>
        public int iround { get; set; }

        /// <summary>
        /// Описание правила пересчета
        /// </summary>
        public string idesc { get; set; }

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

                Parameter = new NpgsqlParameter("icunit", NpgsqlDbType.Varchar);
                Parameter.Value = icunit;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imc", NpgsqlDbType.Numeric);
                Parameter.Value = imc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_single", NpgsqlDbType.Boolean);
                Parameter.Value = ion_single;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iround", NpgsqlDbType.Integer);
                Parameter.Value = iround;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
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
                return "unit_conversion_rule_add";
            }
        }

        public string? Condition { get; set; }
    }
}
