using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает список записей журнала по идентификатору группы
    /// </summary>
    public class log_by_id_group : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public long iid_group { get; set; }

        /// <summary>
        /// Включить в выборку записи классов
        /// </summary>
        public bool class_on { get; set; }

        /// <summary>
        /// Включить в выборку записи объектов класса
        /// </summary>
        public bool object_on { get; set; }

        /// <summary>
        /// Выполнить рекурсивно
        /// </summary>
        public bool recursive_on { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_group", NpgsqlDbType.Bigint);
                Parameter.Value = iid_group;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("class_on", NpgsqlDbType.Boolean);
                Parameter.Value = class_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("object_on", NpgsqlDbType.Boolean);
                Parameter.Value = object_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("recursive_on", NpgsqlDbType.Boolean);
                Parameter.Value = recursive_on;
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
                return "log_by_id_group";
            }
        }
    }
}