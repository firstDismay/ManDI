namespace ManDI.composite.entities.vpos_temp.property
{
    /// <summary>
    /// Композитный тип данных значения свойства шаблона позиции типа объектное
    /// </summary>
    public class vpos_temp_prop_object_val
    {
        public long id { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public bool on_val { get; set; }
        public long id_class_val { get; set; }
        public decimal bquantity_max { get; set; }
        public decimal bquantity_min { get; set; }
        public int embed_mode { get; set; }
        public bool embed_single { get; set; }
        public long embed_class_real_id { get; set; }
        public int id_unit_conversion_rule { get; set; }
        public string tablename { get; set; }
        public DateTime timestamp_class_val { get; set; }
        public DateTime timestamp { get; set; }
    }
}