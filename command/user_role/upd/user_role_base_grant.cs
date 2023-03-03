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
    /// Команда назначает базовую роль, для указанной роли пользователя 
    public class user_role_base_grant : IParametersFunction
    {
        /// <summary>
        /// Пользовательская роль определенная на уровне архитектуры концепции
        /// </summary>
        public string irole_user { get; set; }

        /// <summary>
        /// Базовая роль фиксированная роль
        /// </summary>
        public string irole_base { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("irole_user", NpgsqlDbType.Varchar);
                Parameter.Value = irole_user;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("irole_base", NpgsqlDbType.Varchar);
                Parameter.Value = irole_base;
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
                return "user_role_base_grant";
            }
        }
    }
}
