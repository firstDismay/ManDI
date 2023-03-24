using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.link.sel
{
    /// <summary>
    /// Команда возвращает ссылку документа по идентификатору ссылки
    public class doc_link_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор ссылки
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
                return "doc_link_by_id";
            }
        }
    }
}