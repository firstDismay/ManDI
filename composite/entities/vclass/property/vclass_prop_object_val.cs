using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vclass.property
{
    /// <summary>
    /// Композитный тип данных значения свойства класса типа объектное
    /// </summary>
    public class vclass_prop_object_val
    {   
        public long id { get; set; }
        public long id_class { get; set; }
        public long id_class_definition { get; set; }
        public long id_class_prop { get; set; }
        public long id_class_val { get; set; }
        public long id_prop_definition { get; set; }
        public int id_unit_conversion_rule { get; set; }
        public decimal bquantity_max { get; set; }
        public decimal bquantity_min { get; set; }
        public long embed_class_real_id { get; set; }
        public int embed_mode { get; set; }
        public bool embed_single { get; set; }
        public bool on_val { get; set; }
        public string tablename { get; set; }
        public DateTime timestamp_class { get; set; }
        public DateTime timestamp_class_definition { get; set; }
        public DateTime timestamp_class_val { get; set; }
    }
}