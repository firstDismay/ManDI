using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.extractor
{
    /// <summary>
    /// Интерфейс обеспечивает извлечение сигнатуры вызова функции API из аргумента команды
    /// </summary>
    public interface ISignatureExtractor
    {
        /// <summary>
        /// Метод возвращает строковое представление сигнатуры связанной функции
        /// </summary>
        public string Signature { get; }

        /// <summary>
        /// Метод возвращает список параметров связанной функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters { get; }
    }
}
