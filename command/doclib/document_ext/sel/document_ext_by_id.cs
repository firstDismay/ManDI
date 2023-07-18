using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.document_ext.sel
{
    /// <summary>
    /// Команда возвращает расширенный документ по идентификатору документа
    public class document_ext_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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
                return "document_ext_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}