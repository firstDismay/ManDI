using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.add
{
    /// <summary>
    /// Команда добавляет шаблон позиции
    /// </summary>
    public class pos_temp_copy : IParametersFunction
    {
        /// <summary>
        /// Наименование шаблона позиции
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_con { get; set; }

        /// <summary>
        /// Идентификатор прототипа позиции
        /// </summary>
        public long iid_prototype { get; set; }

        /// <summary>
        /// Идентификатор лимита вложения
        /// </summary>
        public bool inested_limit { get; set; }

        /// <summary>
        /// Описание класса
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_con", NpgsqlDbType.Bigint);
                Parameter.Value = iid_con;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_prototype", NpgsqlDbType.Integer);
                Parameter.Value = iid_prototype;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("inested_limit", NpgsqlDbType.Boolean);
                Parameter.Value = inested_limit;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
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
                return "pos_temp_copy";
            }
        }
    }
}