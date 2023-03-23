using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.upd
{
    /// <summary>
    /// Команда добавляет область значений глобального свойства
    /// </summary>
    public class global_prop_area_val_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        /// Идентификатор области значений
        /// </summary>
        public long iid_area_val { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_global_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_global_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_area_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_area_val;
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
                return "global_prop_area_val_add";
            }
        }
    }
}
