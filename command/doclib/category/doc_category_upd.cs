using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.doclib.category
{
    /// <summary>
    /// Команда изменяет категорию документов концепции по идентификатору
    public class doc_category_upd : IParametersFunction
    {

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание группы
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Признак разрешения на группировку
        /// </summary>
        public bool ion_grouping { get; set; }

        /// <summary>
        /// Признак включенной категории
        /// </summary>
        public bool ion { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_grouping", NpgsqlDbType.Boolean);
                Parameter.Value = ion_grouping;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
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
                return "doc_category_upd";
            }
        }
    }
}