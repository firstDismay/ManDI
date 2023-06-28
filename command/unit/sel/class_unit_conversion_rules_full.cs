using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.unit.sel
{
    /// <summary>
    /// Команда возвращает список назначений правил пересчета по идентификатору класса
    /// </summary>
    public class class_unit_conversion_rules_full : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_class{ get; set; }

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
                return "class_unit_conversion_rules_full";
            }
        }
    }
}