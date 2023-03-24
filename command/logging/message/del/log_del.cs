using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;

namespace ManDI.command.logging.message.del
{
    /// <summary>
    /// Команда удаляет запись журнала по идентификатору записи
    /// </summary>
    public class log_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public long iid_log { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_log", NpgsqlDbType.Bigint);
                Parameter.Value = iid_log;
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
                return "log_del";
            }
        }
    }
}