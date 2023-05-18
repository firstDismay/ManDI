namespace ManDI.enums
{
    /// <summary>
    /// Класс определяющий режимы экстракции сигнатур выполнения команд, определяющие формат выходных данных
    /// </summary>
    public enum eSignatureExtractorMode
    {
        /// <summary>
        /// Извлечение сигнатуры для формирования композитного выходного типа
        /// </summary>
        SignatureExtractorForComposite,
        /// <summary>
        /// Извлечение сигнатуры для формирования универсального набора кортежей DataTable
        /// </summary>
        SignatureExtractorForTable
    }
}
