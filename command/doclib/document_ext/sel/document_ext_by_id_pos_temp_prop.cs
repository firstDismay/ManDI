using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.document_ext.sel
{
    /// <summary>
    /// Команда возвращает расширенные документы  по идентификатору свойства шаблона позиции
    public class document_ext_by_id_pos_temp_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long id_pos_temp_prop { get; set; }

        /// <summary>
        /// Идентификатор экземпляра дочерней сущности
        /// </summary>
        public long iid_sub_entity_instance { get; set; }

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
                return "document_ext_by_id_pos_temp_prop";
            }
        }

        public string? Condition { get; set; }
    }
}