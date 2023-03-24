namespace ManDI.composite.entities.vposition.property
{
    /// <summary>
    /// Композитный тип данных значения свойства позиции типа перечисление
    /// </summary>
    public class vposition_prop_enum_val
    {
        public long id_conception { get; set; }
        public long id_position { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public int id_data_type { get; set; }
        public bool inheritance { get; set; }
        public long id_prop_enum { get; set; }
        public long id_prop_enum_val { get; set; }
        public decimal val_numeric { get; set; }
        public string val_varchar { get; set; }
        public bool is_use { get; set; }
        public long id_object_reference { get; set; }
        public bool has_object_reference { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
        public DateTime timestamp_val { get; set; }
    }
}