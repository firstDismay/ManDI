namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип перечисления
    /// </summary>
    public class vprop_enum
    {
        public long id_conception { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool has_items { get; set; }
        public int id_data_type { get; set; }
        public long id_prop_enum { get; set; }
        public int id_prop_enum_use_area { get; set; }
        public bool is_use { get; set; }
        public DateTime timestamp { get; set; }
    }
}