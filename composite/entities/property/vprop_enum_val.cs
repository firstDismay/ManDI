namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип значения перечисления
    /// </summary>
    public class vprop_enum_val
    {
        public long id_conception { get; set; }
        public long id_prop_enum { get; set; }
        public long id_prop_enum_val { get; set; }
        public int id_data_type { get; set; }
        public long id_object_reference { get; set; }
        public int id_prop_enum_use_area { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime timestamp_prop_enum { get; set; }
        public decimal val_numeric { get; set; }
        public string val_varchar { get; set; }
        public bool has_object_reference { get; set; }
        public bool is_use { get; set; }
        public long sort { get; set; }
    }
}