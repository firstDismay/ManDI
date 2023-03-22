namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип глобального свойства
    /// </summary>
    public class vglobal_prop
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool is_use { get; set; }
        public DateTime timestamp { get; set; }
        public long id_area_val { get; set; }
        public DateTime timestamp_area_val { get; set; }
        public bool on_val { get; set; }
        public bool ready { get; set; }
        public bool visible { get; set; }
    }
}