using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.user.upd
{
    /// <summary>
    /// Команда определяет доступность смены пароля управляющего пользователя для подчиненного
    /// </summary>
    public class user_pwd_can_change : IParametersFunction
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string ilogin { get; set; }

        /// <summary>
        /// Коректируемый логин
        /// </summary>
        public string icorrectable_login { get; set; }
        
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

                Parameter = new NpgsqlParameter("icorrectable_login", NpgsqlDbType.Varchar);
                Parameter.Value = icorrectable_login;
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
                return "user_pwd_can_change";
            }
        }
    }
}
