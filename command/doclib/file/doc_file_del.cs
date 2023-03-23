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
    /// Команда удаляет файл документа библиотеки документов по идентификатору файла документа
    public class doc_file_del : IParametersFunction
    {

        /// <summary>
        /// Идентификатор файла документа
        /// </summary>
        public long iid_doc_file { get; set; }

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
                return "doc_file_del";
            }
        }
    }
}