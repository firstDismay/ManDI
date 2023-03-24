using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.logging.message.sel
{
    /// <summary>
    /// Команда возвращает записи журнала объекта по идентификатору объекта
    /// </summary>
    public class log_by_id_object : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Включить в выборку записи классов
        /// </summary>
        public bool class_on { get; set; }

        /// <summary>
        /// Включить в выборку записи групп
        /// </summary>
        public bool group_on { get; set; }

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

                Parameter = new NpgsqlParameter("iid_object", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("class_on", NpgsqlDbType.Boolean);
                Parameter.Value = class_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("group_on", NpgsqlDbType.Boolean);
                Parameter.Value = group_on;
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
                return "log_by_id_object";
            }
        }
    }
}