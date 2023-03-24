namespace ManDI.composite.entities.document
{
    /// <summary>
    /// Композитный тип расширенного документа
    /// </summary>
    public class vdocument_ext
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
        public vdoc_file[] doc_file_list { get; set; }
        public vdoc_link[] doc_link_list { get; set; }
        public vdoc_category[] doc_category_list { get; set; }
    }
}