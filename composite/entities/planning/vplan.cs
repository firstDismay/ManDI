namespace ManDI.composite.entities.group
{
    /// <summary>
    /// Композитный тип плана
    /// </summary>
    public class vplan
    {
        public long id { get; set; }
        public long id_parent { get; set; }
        public long id_root { get; set; }
        public int level { get; set; }
        public long id_conception { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool on { get; set; }
        public bool on_crossing { get; set; }
        public int plan_max { get; set; }
        public int range_max { get; set; }
        public bool on_freeze { get; set; }
        public bool has_child_plan { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime timestamp_child_change { get; set; }
        public string path { get; set; }
    }
}