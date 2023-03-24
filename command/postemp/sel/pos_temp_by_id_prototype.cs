using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает шаблоны позиции по идентификатору концепции и прототипа
    /// </summary>
    public class pos_temp_by_id_prototype : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  концепции
        /// </summary>
        public long iid_con { get; set; }

        /// <summary>
        /// Идентификатор прототипа
        /// </summary>
        public long iid_prototype { get; set; }

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

                Parameter = new NpgsqlParameter("iid_prototype", NpgsqlDbType.Integer);
                Parameter.Value = iid_prototype;
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
                return "pos_temp_by_id_prototype";
            }
        }
    }
}
