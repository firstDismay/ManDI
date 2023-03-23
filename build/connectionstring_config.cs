﻿using Npgsql;

namespace ManDI
{
    /// <summary>
    /// Конфигурация обязательных значений строки подключения
    /// </summary>
    public partial class mandi
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