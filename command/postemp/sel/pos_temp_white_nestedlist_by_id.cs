using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает список шаблонов входящие в белый лист текущего шаблона
    /// </summary>
    public class pos_temp_white_nestedlist_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  шаблона позиции
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Идентификатор  концепции
        /// </summary>
        public long iid_con { get; set; }

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

                Parameter = new NpgsqlParameter("iid_con", NpgsqlDbType.Bigint);
                Parameter.Value = iid_con;
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
                return "pos_temp_white_nestedlist_by_id";
            }
        }
    }
}
