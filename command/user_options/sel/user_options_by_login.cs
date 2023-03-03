using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.user_options.sel
{
    /// <summary>
    /// Команда возвращает позицию по идентификатору
    /// </summary>
    public class user_options_by_login : IParametersFunction
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string ilogin { get; set; }

        
        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("ilogin", NpgsqlDbType.Varchar);
                Parameter.Value = ilogin;
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
                return "user_options_by_login";
            }
        }
    }
}
