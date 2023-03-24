namespace ManDI.composite.entities.document
{
    /// <summary>
    /// Композитный тип документа
    /// </summary>
    public class vdocument
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public long id_parent { get; set; }
        public long id_category { get; set; }
        public bool on_grouping { get; set; }
        public bool package_item { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string regnum { get; set; }
        public DateTime regdate { get; set; }
        public bool has_link { get; set; }
        public bool has_doc { get; set; }
        public bool has_file { get; set; }
        public DateTime timestamp { get; set; }
        public bool is_inside { get; set; }
    }
}