using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ManDI.command.doclib.document_ext
        {
    /// <summary>
    /// Команда возвращает расширенные документы  по идентификатору концепции и маске имени
    public class document_ext_by_msk_name_id_conception : IParametersFunction
    {

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string iname { get; set; }

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

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

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
                return "document_ext_by_msk_name_id_conception";
            }
        }
    }
}