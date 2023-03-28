﻿using System.Data;

namespace ManDI.executor
{

    /// <summary>
    /// Интерфейс класса исполнителя подготовленных команд
    /// </summary>
    public interface ICommandExecutor<TCommand>
    {
        /// <summary>
		/// Выполнение команды в режиме без вывода результата, возвращает количество затронутых строк или -1
		/// </summary>
		Int32 ExecuteNonQuery(TCommand command);

        /// <summary>
        /// Выполнение команды в режиме с выводом результата в указанный контейнер
        /// </summary>
        DataTable Fill(TCommand command);

        /// <summary>
        /// Выполнение команды в режиме без вывода результата, возвращает содержимое первой строки первого столбца результата команды
        /// </summary>
        Object ExecuteScalar(TCommand command);
    }
}
