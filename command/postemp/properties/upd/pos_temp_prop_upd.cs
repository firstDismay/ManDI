using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.properties.upd
{
    /// <summary>
    /// Команда изменяет свойство шаблона позиции
    /// </summary>
    public class pos_temp_prop_upd : IParametersFunction
    {

        /// <summary>
        /// Идентификатор шаблона позиции
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

                Parameter = new NpgsqlParameter("iid_data_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_data_type;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
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
                return "pos_temp_prop_upd";
            }
        }
    }
}