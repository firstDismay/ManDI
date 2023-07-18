using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.nesting_rule.sel
{
    /// <summary>
    /// Команда возвращает список правил назначений уровня L1 типа класс на шаблон по идентификатору шаблона
    /// </summary>
    public class rulel1_class_on_pos_temp_by_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции
        /// </summary>
        public long iid_pos_temp { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pos_temp", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp;
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
                return "rulel1_class_on_pos_temp_by_id_pos_temp";
            }
        }

        public string? Condition { get; set; }
    }
}