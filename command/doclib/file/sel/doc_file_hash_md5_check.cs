using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.file.sel
{
    /// <summary>
    /// Команда вычисляет хеш файла по MD5 и идентификатору файла документа
    public class doc_file_hash_md5_check : IParametersFunction
    {

        /// <summary>
        /// Идентификатор файла документа
        /// </summary>
        public long iid_doc_file { get; set; }

        /// <summary>
        /// Размер фрейма
        /// </summary>
        public long isizepage { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_doc_file", NpgsqlDbType.Bigint);
                Parameter.Value = iid_doc_file;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("isizepage", NpgsqlDbType.Integer);
                Parameter.Value = isizepage;
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
                return "doc_file_hash_md5_check";
            }
        }
    }
}