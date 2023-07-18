using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.category.add
{
    /// <summary>
    /// Команда добавляет новую категорию записей
    /// </summary>
    public class log_category_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Наименование категории
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание категории
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Уровень категории
        /// </summary>
        public int ilevel { get; set; }

        /// <summary>
        /// Признак доступности категории для создания записей
        /// </summary>
        public bool ion { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ilevel", NpgsqlDbType.Integer);
                Parameter.Value = ilevel;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
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
                return "log_category_add";
            }
        }

        public string? Condition { get; set; }
    }
}