namespace ManDI.composite.entities.document
{
    /// <summary>
    /// Композитный тип файлов документов
    /// </summary>
    public class vdoc_file
    {
        public long id { get; set; }
        public string uuid { get; set; }
        public string md5 { get; set; }
        public long id_conception { get; set; }
        public int catalog { get; set; }
        public long id_document { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public string version { get; set; }
        public DateTime versiondate { get; set; }
        public bool fulltxtsrch_on { get; set; }
        public DateTime timestamp { get; set; }
        public int data_length { get; set; }
    }
}