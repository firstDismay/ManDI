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
    /// Интерфейс поддерживает соглашение определяющее порядок вызова связанной функции
    /// </summary>
    public interface ISignatureFunction
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
