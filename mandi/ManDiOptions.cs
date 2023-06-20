using ManDI.enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ManDI
{
    /// <summary>
    /// Класс опциональной настройки поставщика API ManDI
    /// </summary>
    public class ManDiOptions
    {
        /// <summary>
        /// Маска строки подключения
        /// </summary>
        public String ConnectionStrings { get; set; }
    }
}
