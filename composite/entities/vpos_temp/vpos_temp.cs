namespace ManDI.composite.entities.vpos_temp
{
    /// <summary>
    /// Композитный тип шаблона позиции
    /// </summary>
    public class vpos_temp
    {
        public long id { get; set; }
        public long id_con { get; set; }
        public int id_prototype { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool on_nested_limit { get; set; }
        public bool on { get; set; }
        public bool on_root { get; set; }
        public bool on_this { get; set; }
        public bool on_pos { get; set; }
        public bool on_obj { get; set; }
        public bool on_service { get; set; }
        public DateTime timestamp { get; set; }
    }
}