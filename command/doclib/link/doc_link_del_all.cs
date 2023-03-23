using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.doclib.link
    {
    /// <summary>
    /// Команда удаляет все ссылки документа на сущности БД по идентификатору документа
    public class doc_link_del_all : IParametersFunction
    {
        /// <summary>
        /// Идентификатор ссылки на документ
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
                return "doc_link_del_all";
            }
        }
    }
}