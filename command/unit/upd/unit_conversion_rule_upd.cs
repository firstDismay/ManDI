using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.add
{
    /// <summary>
    /// Команда обновляет правило пересчета
    /// </summary>
    public class unit_conversion_rule_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор правила пересчета
        /// </summary>
        public long iid { get; set; }

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
        /// Признак разрешенного правила
        /// </summary>
        public bool ion { get; set; }

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

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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

                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
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
                return "unit_conversion_rule_upd";
            }
        }

        public string? Condition { get; set; }
    }
}
