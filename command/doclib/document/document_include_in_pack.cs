using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ManDI.command.doclib.document
        {
    /// <summary>
    /// Команда включает документ в пакет документов
    public class document_include_in_pack : IParametersFunction
    {
        /// <summary>
        /// Идентификатор пакета документа
        /// </summary>
        public long id_document_pack { get; set; }

        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public long iid_document { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("id_document_pack", NpgsqlDbType.Bigint);
                Parameter.Value = id_document_pack;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_document", NpgsqlDbType.Bigint);
                Parameter.Value = iid_document;
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
                return "document_include_in_pack";
            }
        }
    }
}