using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.conception.upd
{
    /// <summary>
    /// Команда обновляет/восстанавливает концепцию  по идентификатору концепции
    /// <summary>
    public class conception_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Наименование концепции
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание концепции
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Признак включенной концепции
        /// </summary>
        public bool ion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ion_root_create { get; set; }

        /// <summary>
        /// Признак концепции по умолчанию
        /// </summary>
        public bool idefault { get; set; }

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

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Text);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_root_create", NpgsqlDbType.Boolean);
                Parameter.Value = ion_root_create;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idefault", NpgsqlDbType.Boolean);
                Parameter.Value = idefault;
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
                return "conception_upd";
            }
        }
    }
}