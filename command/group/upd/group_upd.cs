using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.group.upd
{
    /// <summary>
    /// Команда обновляет группу
    public class group_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание группы
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Признак разрешения на добавление классов
        /// </summary>
        public bool ion_class { get; set; }

        /// <summary>
        /// Порядок сортировки
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

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("isort", NpgsqlDbType.Integer);
                Parameter.Value = isort;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_class", NpgsqlDbType.Boolean);
                Parameter.Value = ion_class;
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
                return "group_upd";
            }
        }
    }
}