using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.sel
{
    /// <summary>
    /// Команда возвращает область применения перечисления по идентификатору области
    /// </summary>
    public class prop_enum_use_area_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор области применения перечисления
        /// </summary>
        public long iid { get; set; }

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
                return "prop_enum_use_area_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}