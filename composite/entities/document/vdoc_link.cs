namespace ManDI.composite.entities.document
{
    /// <summary>
    /// Композитный тип ссылок документов
    /// </summary>
    public class vdoc_link
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public long id_document { get; set; }
        public long id_category { get; set; }
        public string name { get; set; }
        public string regnum { get; set; }
        public DateTime regdate { get; set; }
        public int id_entity { get; set; }
        public long id_entity_instance { get; set; }
        public long id_sub_entity_instance { get; set; }
    }
}