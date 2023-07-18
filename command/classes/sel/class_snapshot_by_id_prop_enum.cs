using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список снимков классов по идентификатору перечисления
    /// </summary>
    public class class_snapshot_by_id_prop_enum : IParametersFunction
    {
        /// <summary>
        /// Идентификатор перечисления
        /// </summary>
        public long iid_prop_enum { get; set; }

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
                return "class_snapshot_by_id_prop_enum";
            }
        }

        public string? Condition { get; set; }
    }
}