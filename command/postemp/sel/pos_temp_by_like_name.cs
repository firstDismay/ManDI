using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает шаблоны позиции по идентификатору концепции и маске наименования
    /// </summary>
    public class pos_temp_by_like_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  концепции
        /// </summary>
        public long iid_con { get; set; }

        /// <summary>
        /// Идентификатор наименования
        /// </summary>
        public string iname { get; set; }

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

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
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
                return "pos_temp_by_like_name";
            }
        }
    }
}
