namespace ManDI.composite.entities.vlog
{
    /// <summary>
    /// Композитный тип категории записи журнала
    /// </summary>
    public class vlog_category
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int level { get; set; }
        public bool on { get; set; }
        public DateTime timestamp { get; set; }
    }
}