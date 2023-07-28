using ManDI.command;
using System.Data;

namespace ManDI.executor
{

    /// <summary>
    /// Интерфейс класса исполнителя подготовленных команд
    /// </summary>
    public interface IExportExecutor
    {
        /// <summary>
        /// Выполнение команды в режиме экспорта данных в двоичном формате
        /// </summary>
        Byte[] Export(IParametersFunction function);
    }
}
