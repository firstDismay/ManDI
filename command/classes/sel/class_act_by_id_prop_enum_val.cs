using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по идентификатору элемента свойства перечисления
    /// </summary>
    public class class_act_by_id_prop_enum_val : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  класса
        /// </summary>
        public long iid_prop_enum_val { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prop_enum_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum_val;
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
                return "class_act_by_id_prop_enum_val";
            }
        }

        /// <summary>
        /// Дополнительные параметры вызова функции добавляемые к основному запросу
        /// </summary>
        public string? Condition { get; set; }
    }
}
