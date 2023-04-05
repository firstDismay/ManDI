﻿using Npgsql;

namespace ManDI.command
{
    /// <summary>
    /// Интерфейс источника данных на базе библиотеки NPGSQL версии 7.хх и выше
    /// </summary>
    public interface IDataService
    {
        public NpgsqlDataSource GetDataSource();
    }
}