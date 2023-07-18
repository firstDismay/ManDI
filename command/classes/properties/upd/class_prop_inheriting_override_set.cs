using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.upd
{
    /// <summary>
    /// Команда изменяет флаг переопределяемости значения в наследующих свойствах указанного свойства класса
    /// </summary>
    public class class_prop_inheriting_override_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Признак переопределяемости значения свойства
        /// </summary>
        public bool ion_override { get; set; }

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

                Parameter = new NpgsqlParameter("ion_override", NpgsqlDbType.Boolean);
                Parameter.Value = ion_override;
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
                return "class_prop_inheriting_override_set";
            }
        }

        public string? Condition { get; set; }
    }
}