using ManDI.command;
using System.Data;

namespace ManDI.executor
{

    /// <summary>
    /// Интерфейс класса исполнителя подготовленных команд
    /// </summary>
    public interface ICommandExecutor
    {
        /// <summary>
		/// Выполнение команды в режиме без вывода результата, возвращает количество затронутых строк или -1
		/// </summary>
		Int32 ExecuteNonQuery(IParametersFunction function);

        /// <summary>
        /// Выполнение команды в режиме с выводом результата в указанный контейнер
        /// </summary>
        DataTable Fill(IParametersFunction function);

        /// <summary>
        /// Выполнение команды в режиме без вывода результата, возвращает содержимое первой строки первого столбца результата команды
        /// </summary>
        Object ExecuteScalar(IParametersFunction function);
    }
}
