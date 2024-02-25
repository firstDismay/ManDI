using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.val
{
    /// <summary>
    /// Команда добавляет элемент перечисления
    /// </summary>
    public class prop_enum_val_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор перечисления
        /// </summary>
        public long iid_prop_enum { get; set; }

        /// <summary>
        /// Числовое значение элемента перечисления
        /// </summary>
        public decimal? ival_numeric { get; set; } = null;

        /// <summary>
        /// Строковое значение элемента перечисления
        /// </summary>
        public string? ival_varchar { get; set; } = null;

        /// <summary>
        /// Порядок сортировки элемента перечисления
        /// </summary>
        public long isort { get; set; }

        /// <summary>
        /// Ссылка на объектное значение элемента перечисления
        /// </summary>
        public long? iid_object_reference { get; set; } = null;

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prop_enum", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_numeric", NpgsqlDbType.Numeric);
                Parameter.Value = ival_numeric != null ? ival_numeric : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_varchar", NpgsqlDbType.Varchar);
                Parameter.Value = ival_varchar != null ? ival_varchar : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("isort", NpgsqlDbType.Bigint);
                Parameter.Value = isort;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_object_reference", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_reference != null ? iid_object_reference : DBNull.Value;
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
                return "prop_enum_val_add";
            }
        }

        public string? Condition { get; set; }
    }
}