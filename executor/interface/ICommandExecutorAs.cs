using ManDI.executor;
using System.Data;

namespace ManDI.executor
{
    /// <summary>
    /// Интерфейс класса исполнителя подготовленных команд с переключением на указанную роль
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface ICommandExecutorAs<TCommand>
    {
        /// <summary>
		/// Выполнение команды в режиме без вывода результата, возвращает количество затронутых строк или -1
		/// </summary>
		Int32 ExecuteNonQuery(TCommand command, UserContextRole user);

        /// <summary>
        /// Выполнение команды в режиме с выводом результата в указанный контейнер
        /// </summary>
        DataTable Fill(TCommand command, UserContextRole user);

        /// <summary>
        /// Выполнение команды в режиме без вывода результата, возвращает содержимое первой строки первого столбца результата команды
        /// </summary>
        Object ExecuteScalar(TCommand command, UserContextRole user);
    }
}
