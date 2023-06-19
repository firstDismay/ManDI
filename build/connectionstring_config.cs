using Npgsql;

namespace ManDI.build
{
    /// <summary>
    /// Конфигурация обязательных значений строки подключения
    /// </summary>
    public partial class ManDiDataService
    {
        /// <summary>
        /// Настройка обязательных значений строки подключения
        /// </summary>
        public void ConnectionStringConfiguration(NpgsqlConnectionStringBuilder ConnectionStringBuilder)
        {
            ConnectionStringBuilder.SearchPath = "bpd";
            ConnectionStringBuilder.LoadTableComposites = true;
            ConnectionStringBuilder.Pooling = true;
            ConnectionStringBuilder.MaxPoolSize = 10;
        }
    }
}
