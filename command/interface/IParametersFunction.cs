using Npgsql;

namespace ManDI.command
{
    /// <summary>
    /// Интерфейс поддерживает соглашение определяющее порядок вызова связанной функции
    /// </summary>
    public interface IParametersFunction
    {
        public string NameFunction { get; }

        /// <summary>
        /// Метод возвращает список параметров связанной функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters { get; }
    }
}
