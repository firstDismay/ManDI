using ManDI.enums;

namespace ManDI
{
    /// <summary>
    /// Класс опциональной настройки поставщика API ManDI
    /// </summary>
    public class ManDiOptions
    {
        /// <summary>
        /// Режимы экстракции сигнатур выполнения команд, определяющие формат выходных данных
        /// </summary>
        public eSignatureExtractorMode SignatureExtractorMode { get; set; } = eSignatureExtractorMode.SignatureExtractorForComposite;

        /// <summary>
        /// Маска строки подключения
        /// </summary>
        public String ConnectionStrings { get; set; }
    }
}
