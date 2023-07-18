using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.nesting_rule.postemp
{
    /// <summary>
    /// Команда включает шаблон в список доступных к вложению шаблонов 
    /// с учетом лимита на количество вкладываемых позиций шаблона
    /// </summary>
    public class pos_temp_nested_include : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции
        /// </summary>
        public long iid_pos_temp { get; set; }

        /// <summary>
        /// Идентификатор вложенного шаблона позиции
        /// </summary>
        public long iid_pos_temp_nested { get; set; }

        /// <summary>
        ///Максимальное количество встраиваемых позиций
        /// </summary>
        public long ipos_temp_nested_limit { get; set; }

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

                Parameter = new NpgsqlParameter("iid_pos_temp_nested", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_nested;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ipos_temp_nested_limit", NpgsqlDbType.Integer);
                Parameter.Value = ipos_temp_nested_limit;
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
                return "pos_temp_nested_include";
            }
        }

        public string? Condition { get; set; }
    }
}