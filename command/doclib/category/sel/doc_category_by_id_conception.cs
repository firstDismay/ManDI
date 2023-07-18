using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.category.sel
{
    /// <summary>
    /// Команда возвращает список категорий документов по идентификатору концепции
    public class doc_category_by_id_conception : IParametersFunction
    {

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
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
                return "doc_category_by_id_conception";
            }
        }

        public string? Condition { get; set; }
    }
}