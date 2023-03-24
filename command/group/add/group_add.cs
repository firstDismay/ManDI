using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.group.add
{
    /// <summary>
    /// Команда добавляет группу
    public class group_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор родительской группы
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_con { get; set; }

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

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_con", NpgsqlDbType.Bigint);
                Parameter.Value = iid_con;
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
                return "group_add";
            }
        }
    }
}