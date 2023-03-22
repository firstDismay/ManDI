namespace ManDI.composite.entities.common
{
    /// <summary>
    /// Композитный тип объектов пути
    /// </summary>
    public class path
    {
        public long id { get; set; }
        public long id_parent { get; set; }
        public long id_root { get; set; }
        public string name { get; set; }
        public int level { get; set; }
    }
}