using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.document.sel
{
    /// <summary>
    /// Команда возвращает документы свойства шаблона по идентификатору
    public class document_by_id_pos_temp_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long id_pos_temp_prop { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("id_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = id_pos_temp_prop;
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
                return "document_by_id_pos_temp_prop";
            }
        }

        public string? Condition { get; set; }
    }
}