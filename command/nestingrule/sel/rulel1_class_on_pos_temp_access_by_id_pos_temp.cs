using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.properties.sel
{
    /// <summary>
    /// Команда возвращает список разрешений на основе правила уровня L1 типа класс на шаблон по идентификатору шаблона позиции
    /// </summary>
    public class rulel1_class_on_pos_temp_access_by_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиций
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
                return "rulel1_class_on_pos_temp_access_by_id_pos_temp";
            }
        }

        public string? Condition { get; set; }
    }
}