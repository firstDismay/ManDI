using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.category.del
{
    /// <summary>
    /// Команда удаляет категорию документов по идентификатору категории
    public class doc_category_del : IParametersFunction
    {

        /// <summary>
        /// Идентификатор категории
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
                return "doc_category_del";
            }
        }
    }
}