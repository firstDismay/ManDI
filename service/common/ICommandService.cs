using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.common
{
    public interface ICommandService<TCommand>
    {
        /// <summary>
		/// Выполнение команды в режиме без вывода результата, возвращает количество затронутых строк или -1
		/// </summary>
		Int32 ExecuteNonQuery(TCommand argument);

        /// <summary>
        /// Выполнение команды в режиме с выводом результата в указанный контейнер
        /// </summary>
        DataTable Fill(TCommand argument);

        /// <summary>
        /// Выполнение команды в режиме без вывода результата, возвращает содержимое первой строки первого столбца результата команды
        /// </summary>
        Object ExecuteScalar(TCommand argument);
    }
}
