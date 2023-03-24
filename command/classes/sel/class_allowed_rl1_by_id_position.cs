using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список разрешенных активных классов на основе разрешения уровня 1 группа на шаблон по идентификатору позиции
    /// </summary>
    public class class_allowed_rl1_by_id_position : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
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
                return "class_allowed_rl1_by_id_position";
            }
        }
    }
}