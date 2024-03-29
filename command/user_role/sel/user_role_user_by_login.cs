﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.user_role.sel
{
    /// <summary>
    /// Команда возвращает список пользовательских ролей пользователя по логину
    /// </summary>
    public class user_role_user_by_login : IParametersFunction
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string ilogin { get; set; }

        /// <summary>
        /// Признак рекурсивной выборки
        /// </summary>
        public bool irecursive { get; set; }

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

                Parameter = new NpgsqlParameter("irecursive", NpgsqlDbType.Boolean);
                Parameter.Value = irecursive;
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
                return "user_role_user_by_login";
            }
        }

        public string? Condition { get; set; }
    }
}
