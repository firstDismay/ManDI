using ManDI.composite.entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManDI
{
    /// <summary>
    /// Конфигурация обязательных значений строки подключения
    /// </summary>
    public partial class ManDiBuilder
    {
        /// <summary>
        /// Настройка обязательных значений строки подключения
        /// </summary>
        public void ConnectionStringConfiguration(NpgsqlConnectionStringBuilder ConnectionStringBuilder)
        {
            ConnectionStringBuilder.SearchPath = "bpd";
            ConnectionStringBuilder.LoadTableComposites = true;
        }
    }
}
