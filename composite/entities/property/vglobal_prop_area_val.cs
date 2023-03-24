namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип области видимости глобального свойства
    /// </summary>
    public class vglobal_prop_area_val
    {
        public long id_global_prop { get; set; }
        public DateTime timestamp_global_prop { get; set; }
        public long id_conception { get; set; }
        public bool is_use { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public long id_area_val { get; set; }
        public DateTime timestamp_area_val { get; set; }
        public bool on_val { get; set; }
        public bool ready { get; set; }
    }
}