using ManDI.command;
using System.Data;

namespace ManDI.executor
{
    /// <summary>
    /// Интерфейс класса исполнителя подготовленных команд с переключением на указанную роль
    /// </summary>
    public interface ICommandExecutorAs
    {
        /// <summary>
		/// Выполнение команды в режиме без вывода результата, возвращает количество затронутых строк или -1
		/// </summary>
		Int32 ExecuteNonQuery(IParametersFunction function, UserContextRole user);

        /// <summary>
        /// Выполнение команды в режиме с выводом результата в указанный контейнер
        /// </summary>
        DataTable Fill(IParametersFunction function, UserContextRole user);

        /// <summary>
        /// Выполнение команды в режиме без вывода результата, возвращает содержимое первой строки первого столбца результата команды
        /// </summary>
        Object ExecuteScalar(IParametersFunction function, UserContextRole user);
    }
}
