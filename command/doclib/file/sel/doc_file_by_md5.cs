using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.file.sel
{
    /// <summary>
    /// Команда возвращает файл документа по идентификатору документа и хэшу md5 файла
    public class doc_file_by_md5 : IParametersFunction
    {

        /// <summary>
        /// Идентификатор файла документа
        /// </summary>
        public long iid_document { get; set; }

        /// <summary>
        /// Хэш двоичных данных
        /// </summary>
        public string imd5 { get; set; }

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

                Parameter = new NpgsqlParameter("imd5", NpgsqlDbType.Varchar);
                Parameter.Value = imd5;
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
                return "doc_file_by_md5";
            }
        }
    }
}