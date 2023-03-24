using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.sel
{
    /// <summary>
    /// Команда возвращает список видимых глобальных свойств по идентификатору концепции
    /// </summary>
    public class global_prop_visible_by_id_conception : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
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
                return "global_prop_visible_by_id_conception";
            }
        }
    }
}
