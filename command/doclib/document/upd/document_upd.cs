using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ManDI.command.doclib.document.upd
{
    /// <summary>
    /// Команда обновляет атрибуты документа
    public class document_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        public long iid_document { get; set; }

        /// <summary>
        /// Идентификатор категории документа
        /// </summary>
        public long iid_category { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание группы
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string iregnum { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime iregdate { get; set; }

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

                Parameter = new NpgsqlParameter("iid_category", NpgsqlDbType.Bigint);
                Parameter.Value = iid_category;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iregnum", NpgsqlDbType.Varchar);
                Parameter.Value = iregnum;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iregdate", NpgsqlDbType.Timestamp);
                Parameter.Value = iregdate;
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
                return "document_upd";
            }
        }
    }
}