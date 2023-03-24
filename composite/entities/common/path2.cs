namespace ManDI.composite.entities.common
{
    /// <summary>
    /// Композитный тип объектов пути
    /// </summary>
    public class path2
    {
        public long id { get; set; }
        public DateTime timestamp { get; set; }
        public long id_parent { get; set; }
        public DateTime timestamp_parent { get; set; }
        public string tablename { get; set; }
        public long id_root { get; set; }
        public string name { get; set; }
        public int level { get; set; }
    }
}

