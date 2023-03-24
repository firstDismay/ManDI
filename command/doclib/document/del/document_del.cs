using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.document.del
{
    /// <summary>
    /// Команда удаляет документ указанный по идентификатору
    public class document_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public long iid_document { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_document", NpgsqlDbType.Bigint);
                Parameter.Value = iid_document;
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
                return "document_del";
            }
        }
    }
}