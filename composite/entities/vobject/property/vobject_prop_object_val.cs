using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vobject.property
{
    /// <summary>
    /// Композитный тип данных значения свойства объекта типа объектное
    /// </summary>
    public class vobject_prop_object_val {
        public long id_object_carrier { get; set; }
        public long id_class_object_carrier { get; set; }
        public DateTime timestamp_class_object_carrier { get; set; }
        public long id_class_prop_object_carrier { get; set; }
        public bool on_val { get; set; }
        public decimal bquantity { get; set; }
        public decimal bquantity_max { get; set; }
        public decimal bquantity_min { get; set; }
        public long id_class_val { get; set; }
        public DateTime timestamp_class_val { get; set; }
        public bool not_set { get; set; }
        public DateTime timestamp_val { get; set; }
        public string tablename { get; set; }
        public int embed_mode { get; set; }
        public bool embed_single { get; set; }
        public long embed_class_real_id { get; set; }
        public int id_unit_conversion_rule { get; set; }
    }
}