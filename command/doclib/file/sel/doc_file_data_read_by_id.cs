using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.file.sel
{
    /// <summary>
    /// Команда возвращает файл документа по идентификатору файла документа
    public class doc_file_data_read_by_id : IParametersFunction
    {

        /// <summary>
        /// Идентификатор файла документа
        /// </summary>
        public long iid_doc_file { get; set; }

        /// <summary>
        /// Смещение фрейма в байтах
        /// </summary>
        public long iseek { get; set; }

        /// <summary>
        /// Размер фрейма в байтах
        /// </summary>
        public long icount { get; set; }

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

                Parameter = new NpgsqlParameter("iseek", NpgsqlDbType.Integer);
                Parameter.Value = iseek;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("icount", NpgsqlDbType.Integer);
                Parameter.Value = icount;
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
                return "doc_file_data_read_by_id";
            }
        }
    }
}