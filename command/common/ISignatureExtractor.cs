using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.common
{
    /// <summary>
    /// Интерфейс обеспечивает извлечение сигнатуры вызова функции API из аргумента команды
    /// </summary>
    public interface ISignatureExtractor
    {
        /// <summary>
        /// Метод возвращает строковое представление сигнатуры связанной функции
        /// </summary>
        public String Signature { get; }

        /// <summary>
        /// Метод возвращает список параметров связанной функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters { get; }
    }
}
