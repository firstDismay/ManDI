using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.executor.common
{
    public interface ICommandExecutor
    {
        /// <summary>
		/// Выполнение команды в режиме без вывода результата, возвращает количество затронутых строк или -1
		/// </summary>
		Int32 ExecuteNonQuery();

        /// <summary>
        /// Выполнение команды в режиме с выводом результата в указанный контейнер
        /// </summary>
        DataTable Fill();

        /// <summary>
        /// Выполнение команды в режиме без вывода результата, возвращает содержимое первой строки первого столбца результата команды
        /// </summary>
        Object ExecuteScalar();
    }
}
