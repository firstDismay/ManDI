using ManDI.composite.entities.vclass.property;

namespace ManDI.composite.entities.vclass
{
    /// <summary>
    /// Композитный тип классов расширенных
    /// </summary>
    public class vclass_ext
    {
        public long id { get; set; }
        public DateTime timestamp { get; set; }
        public bool has_active { get; set; }
        public DateTime timestamp_child_change { get; set; }
        public long id_con { get; set; }
        public long id_group { get; set; }
        public long id_group_root { get; set; }
        public long id_parent { get; set; }
        public DateTime timestamp_parent { get; set; }
        public long id_root { get; set; }
        public DateTime timestamp_root { get; set; }
        public int level { get; set; }
        public bool is_root { get; set; }
        public string tablename { get; set; }
        public string name { get; set; }
        public string name_format { get; set; }
        public bool quantity_show { get; set; }
        public string desc { get; set; }
        public bool on { get; set; }
        public bool on_extensible { get; set; }
        public bool on_abstraction { get; set; }
        public int id_unit { get; set; }
        public int id_unit_conversion_rule { get; set; }
        public long barcode_manufacturer { get; set; }
        public long barcode_local { get; set; }
        public bool include_child_class { get; set; }
        public bool include_child_object { get; set; }
        public bool include_child_real_class { get; set; }
        public bool include_child_abstract_class { get; set; }
        public long child_count { get; set; }
        public bool in_recycle { get; set; }
        public bool on_freeze { get; set; }
        public vclass_prop[] property_list { get; set; }
        public bool ready { get; set; }
        public string path { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}