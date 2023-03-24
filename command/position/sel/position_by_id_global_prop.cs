using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.sel
{
    /// <summary>
    /// Команда возвращает список позиций по идентификатору глобального свойства
    /// </summary>
    public class position_by_id_global_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  глобального свойства позиции
        /// </summary>
        public long iid_global_prop { get; set; }

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
                return "position_by_id_global_prop";
            }
        }
    }
}
