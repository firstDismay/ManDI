namespace ManDI.composite.entities.unit
{
    /// <summary>
    /// Композитный тип правил пересчета
    /// </summary>
    public class vunit_conversion_rules
    {
        public int id { get; set; }
        public long id_conception { get; set; }
        public decimal mc { get; set; }
        public string bunit { get; set; }
        public string cunit { get; set; }
        public string desc { get; set; }
        public int id_unit { get; set; }
        public bool is_entity { get; set; }
        public bool is_use { get; set; }
        public bool not_fractional { get; set; }
        public bool on { get; set; }
        public bool on_base { get; set; }
        public bool on_single { get; set; }
        public int round { get; set; }
        public DateTime timestamp { get; set; }
    }
}


