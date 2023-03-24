using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.add
{
    /// <summary>
    /// Команда создает объекты как единичные юниты с количеством одна единица в текущих правилах
    /// </summary>
    public class object_add_by_single_unit : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса объекта
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Идентификатор правила пересчета количества объектов
        /// </summary>
        public int iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Количество объектов в текущем правиле пересчета
        /// </summary>
        public decimal icquantity { get; set; }

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

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit_conversion_rule;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("icquantity", NpgsqlDbType.Numeric);
                Parameter.Value = icquantity;
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
                return "object_add_by_single_unit";
            }
        }
    }
}
