using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает шаблон позиции по идентификатору
    /// </summary>
    public class pos_temp_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  шаблона позиции
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
                return "pos_temp_by_id";
            }
        }
    }
}
