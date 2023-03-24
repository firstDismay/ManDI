using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает список шаблонов позиций по идентификатору элемента перечисления
    /// </summary>
    public class pos_temp_by_id_prop_enum_val : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  элемента свойства перечисления
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
                return "pos_temp_by_id_prop_enum_val";
            }
        }
    }
}
