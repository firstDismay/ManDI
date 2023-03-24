namespace ManDI.composite.entities.vposition
{
    /// <summary>
    /// Композитный тип позиции
    /// </summary>
    public class vposition
    {
        public long id { get; set; }
        public long id_parent { get; set; }
        public long id_root { get; set; }
        public int level { get; set; }
        public long id_con { get; set; }
        public long id_pos_temp { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool lockdel { get; set; }
        public bool on_service { get; set; }
        public bool on_recycle { get; set; }
        public bool in_recycle { get; set; }
        public int sort { get; set; }
        public DateTime timestamp { get; set; }
        public bool include_object { get; set; }
        public int id_prototype { get; set; }
        public DateTime timestamp_child_change { get; set; }
        public bool is_root { get; set; }
        public bool on_object { get; set; }
        public bool on_rulel2_class_on_position { get; set; }
        public string pos_temp_name { get; set; }
        public string path { get; set; }
        public bool include_position { get; set; }
    }
}