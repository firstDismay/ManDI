using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.user_role.upd
{
    /// <summary>
    /// Команда добавляет пользователя в члены пользовательской роли
    public class user_role_user_grant : IParametersFunction
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string ilogin { get; set; }

        /// <summary>
        /// Пользовательская роль
        /// </summary>
        public string irole_user { get; set; }

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

                Parameter = new NpgsqlParameter("irole_user", NpgsqlDbType.Varchar);
                Parameter.Value = irole_user;
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
                return "user_role_user_grant";
            }
        }
    }
}
