using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.executor.common
{
    public class UserContextRole 
    {
        /// <summary>
        /// Роль авторизованного пользователя
        /// </summary>
        public string Role { get; set; }
    }
}
