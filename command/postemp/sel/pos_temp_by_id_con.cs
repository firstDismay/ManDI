using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает шаблоны позиций по идентификатору концепции
    /// </summary>
    public class pos_temp_by_id_con : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона концепции
        /// </summary>
        public long iid_con { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_con", NpgsqlDbType.Bigint);
                Parameter.Value = iid_con;
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
                return "pos_temp_by_id_con";
            }
        }
    }
}
