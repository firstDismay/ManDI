namespace ManDI.composite.entities.vclass.property
{
    /// <summary>
    /// Композитный тип данных значения свойства класса типа пользовательское большое
    /// </summary>
    public class vclass_prop_user_big_val
    {
        public long id_class { get; set; }
        public long id_class_definition { get; set; }
        public long id_class_prop { get; set; }
        public int id_data_type { get; set; }
        public long id_prop_definition { get; set; }
        public bool inheritance { get; set; }
        public bool max_on { get; set; }
        public bool max_used { get; set; }
        public decimal max_val { get; set; }
        public bool min_on { get; set; }
        public bool min_used { get; set; }
        public decimal min_val { get; set; }
        public bool on_val { get; set; }
        public string tablename { get; set; }
        public DateTime timestamp_class { get; set; }
        public DateTime timestamp_class_definition { get; set; }
        public Byte[] val_bytea { get; set; }
        public string val_json { get; set; }
        public string val_text { get; set; }
    }
}