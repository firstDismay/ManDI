namespace ManDI.composite.entities.vpos_temp
{
    /// <summary>
    /// Композитный тип прототипа шаблона позиции
    /// </summary>
    public class vpos_prototype
    {
        public int id { get; set; }
        public bool on_root { get; set; }
        public bool on_this { get; set; }
        public bool on_pos { get; set; }
        public bool on_obj { get; set; }
        public string desc { get; set; }
        public int sort { get; set; }
        public bool on_service { get; set; }
    }
}