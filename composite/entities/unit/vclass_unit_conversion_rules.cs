using ManDI.composite.entities.vclass.property;

namespace ManDI.composite.entities.unit
{
    /// <summary>
    /// Композитный тип правил пересчета классов
    /// </summary>
    public class vclass_unit_conversion_rules
    {
        public long id_class { get; set; }
        public long id_conception { get; set; }
        public int id_unit { get; set; }
        public int id_unit_conversion_rule { get; set; }
        public bool is_create { get; set; }
        public bool is_use { get; set; }
        public bool on_base { get; set; }
    }
}


