using Npgsql;
using NpgsqlTypes;
using ManDI.command;

namespace ManDI.command.postemp.upd
{
    /// <summary>
    /// Команда добавляет шаблон позиции
    /// </summary>
    public class pos_temp_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Наименование шаблона позиции
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Признак включенного шаблона
        /// </summary>
        public bool ion { get; set; }

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

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);


                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
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
                return "pos_temp_upd";
            }
        }
    }
}