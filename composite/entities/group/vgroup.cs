namespace ManDI.composite.entities.group
{
    /// <summary>
    /// Композитный тип групп классов
    /// </summary>
    public class vgroup
    {
        public long id { get; set; }
        public long id_parent { get; set; }
        public long id_root { get; set; }
        public int level { get; set; }
        public long id_con { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool on_recycle { get; set; }
        public int sort { get; set; }
        public DateTime timestamp { get; set; }
        public bool on_class { get; set; }
        public bool include_act_class { get; set; }
        public DateTime timestamp_child_change { get; set; }
        public bool in_recycle { get; set; }
        public bool include_child_group { get; set; }
        public string path { get; set; }
    }
}