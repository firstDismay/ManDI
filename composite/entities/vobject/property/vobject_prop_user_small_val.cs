namespace ManDI.composite.entities.vobject.property
{
    /// <summary>
    /// Композитный тип данных значения свойства объекта типа  пользовательское маленькое
    /// </summary>
    public class vobject_prop_user_small_val
    {
        public long id_object { get; set; }
        public long id_class { get; set; }
        public DateTime timestamp_class { get; set; }
        public long id_class_prop { get; set; }
        public int id_data_type { get; set; }
        public bool inheritance { get; set; }
        public decimal min_val { get; set; }
        public bool min_on { get; set; }
        public decimal max_val { get; set; }
        public bool max_on { get; set; }
        public int round { get; set; }
        public bool round_on { get; set; }
        public string val_varchar { get; set; }
        public int val_int { get; set; }
        public decimal val_numeric { get; set; }
        public float val_real { get; set; }
        public double val_double { get; set; }
        public decimal val_money { get; set; }
        public bool val_boolean { get; set; }
        public DateTime val_date { get; set; }
        public DateTime val_time { get; set; }
        public TimeSpan val_interval { get; set; }
        public DateTime val_timestamp { get; set; }
        public long val_bigint { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
        public DateTime timestamp_val { get; set; }
        public bool max_used { get; set; }
        public bool min_used { get; set; }
        public bool round_used { get; set; }
    }
}