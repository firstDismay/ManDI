using Npgsql;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.executor
{
    public class UserContextRole
    {
        /// <summary>
        /// Роль авторизованного пользователя
        /// </summary>
        public string Role { get; set; }
    }
}
