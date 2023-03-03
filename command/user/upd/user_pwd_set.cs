using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.user.upd
{
    /// <summary>
    /// Команда установливает пароль пользователя программы. Доступен для пользователя
    /// </summary>
    public class user_pwd_set : IParametersFunction
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string ilogin { get; set; }

        /// <summary>
        /// Старый пароль пользователя
        /// </summary>
        public string ioldpwd { get; set; }

        /// <summary>
        /// Новый пароль
        /// </summary>
        public string inewpwd1 { get; set; }

        /// <summary>
        /// Подтверждение пароля
        /// </summary>
        public string inewpwd2 { get; set; }

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

                Parameter = new NpgsqlParameter("ioldpwd", NpgsqlDbType.Varchar);
                Parameter.Value = ioldpwd;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("inewpwd1", NpgsqlDbType.Varchar);
                Parameter.Value = inewpwd1;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("inewpwd2", NpgsqlDbType.Varchar);
                Parameter.Value = inewpwd2;
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
                return "user_pwd_set";
            }
        }
    }
}
