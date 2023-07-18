using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.upd
{
    /// <summary>
    /// Команда изменяет свойство класса
    /// </summary>
    public class class_prop_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Идентификатор типа свойства
        /// </summary>
        public int iid_prop_type { get; set; }

        /// <summary>
        /// Признак переопределяемости значения свойства
        /// </summary>
        public bool ion_override { get; set; }

        /// <summary>
        /// Признак наследования значения свойства
        /// </summary>
        public bool ion_inherit { get; set; }

        /// <summary>
        /// Идентификатор типа данных свойства
        /// </summary>
        public int iid_data_type { get; set; }

        /// <summary>
        /// Наименование свойства
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание свойства
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Тэг свойства
        /// </summary>
        public string itag { get; set; }

        /// <summary>
        /// Индекс сортировки свойства
        /// </summary>
        public int isort { get; set; }


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

                Parameter = new NpgsqlParameter("iid_prop_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_prop_type;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_override", NpgsqlDbType.Boolean);
                Parameter.Value = ion_override;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_inherit", NpgsqlDbType.Boolean);
                Parameter.Value = ion_inherit;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_data_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_data_type;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itag", NpgsqlDbType.Varchar);
                Parameter.Value = itag;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("isort", NpgsqlDbType.Integer);
                Parameter.Value = isort;
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
                return "class_prop_upd";
            }
        }

        public string? Condition { get; set; }
    }
}