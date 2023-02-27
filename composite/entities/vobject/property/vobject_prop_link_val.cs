using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vobject.property
{
    /// <summary>
    /// Композитный тип данных значения свойства объекта типа ссылка
    /// </summary>
    public class vobject_prop_link_val {
        public long id_conception { get; set; }
        public long id_object { get; set; }
        public long id_class { get; set; }
        public DateTime timestamp_class { get; set; }
        public long id_class_prop { get; set; }
        public int id_data_type { get; set; }
        public long id_class_definition { get; set; }
        public long id_prop_definition { get; set; }
        public DateTime timestamp_class_definition { get; set; }
        public bool inheritance { get; set; }
        public int id_entity { get; set; }
        public long id_entity_instance { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
        public DateTime timestamp_val { get; set; }
        public long id_sub_entity_instance { get; set; }
    }
}

