using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.doclib.file
{
    /// <summary>
    /// Команда обновляет файл к документу библиотеки документов
    public class doc_file_upd : IParametersFunction
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
        /// Включение полнотекстового поиска
        /// </summary>
        public Boolean ifulltxtsrch_on { get; set; }

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

                Parameter = new NpgsqlParameter("ifulltxtsrch_on", NpgsqlDbType.Boolean);
                Parameter.Value = ifulltxtsrch_on;
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
                return "doc_file_upd";
            }
        }
    }
}