﻿using Npgsql;

namespace ManDI.command.user.sel
{
    /// <summary>
    /// Команда возвращает полный полный список пользователей определенных через API
    /// </summary>
    public class user_by_all : IParametersFunction
    {
        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

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
                return "user_by_all";
            }
        }

        public string? Condition { get; set; }
    }
}
