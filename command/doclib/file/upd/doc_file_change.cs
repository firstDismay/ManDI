using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.file.upd
{
    /// <summary>
    /// Команда заменяет файл у документа библиотеки документов
    public class doc_file_change : IParametersFunction
    {

        /// <summary>
        /// Идентификатор файла документа
        /// </summary>
        public long iid_doc_file { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string ifilename { get; set; }

        /// <summary>
        /// Версия
        /// </summary>
        public string iversion { get; set; }

        /// <summary>
        ///  Дата версии
        /// </summary>
        public DateTime iversiondate { get; set; }

        /// <summary>
        /// Расширение файла
        /// </summary>
        public string iextension { get; set; }

        /// <summary>
        /// Двоичные данные
        /// </summary>
        public byte file_data { get; set; }

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

                Parameter = new NpgsqlParameter("iid_doc_file", NpgsqlDbType.Bigint);
                Parameter.Value = iid_doc_file;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ifilename", NpgsqlDbType.Varchar);
                Parameter.Value = ifilename;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iversion", NpgsqlDbType.Varchar);
                Parameter.Value = iversion;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iversiondate", NpgsqlDbType.Timestamp);
                Parameter.Value = iversiondate;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iextension", NpgsqlDbType.Varchar);
                Parameter.Value = iextension;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("file_data", NpgsqlDbType.Bytea);
                Parameter.Value = file_data;
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
                return "doc_file_change";
            }
        }

        public string? Condition { get; set; }
    }
}