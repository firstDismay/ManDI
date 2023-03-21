namespace ManDI.composite.entities.document
{
    /// <summary>
    /// Композитный тип категории документов
    /// </summary>
    public class vdoc_category
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool on { get; set; }
        public bool on_grouping { get; set; }
        public long doc_count { get; set; }
        public bool is_use { get; set; }
        public DateTime timestamp { get; set; }
    }
}