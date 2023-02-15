using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vclass.property
{
    /// <summary>
    /// Композитный тип свойств классов
    /// </summary>
    public class vclass_prop
    {
        public long id { get; set; }
        public long id_class { get; set; }
        public DateTime timestamp_class { get; set; }
        public bool on_inherit { get; set; }
        public bool inheritance { get; set; }
        public long id_prop_inherit { get; set; }
        public DateTime timestamp_class_inherit { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int sort { get; set; }
        public bool on_override { get; set; }
        public bool on_val { get; set; }
        public string string_val { get; set; }
        public string tablename { get; set; }
        public bool ready { get; set; }
        public long id_conception { get; set; }
        public long id_class_definition { get; set; }
        public DateTime timestamp_class_definition { get; set; }
        public long id_prop_definition { get; set; }
        public bool on_override_prop_inherit { get; set; }
        public bool on_global { get; set; }
        public long id_global_prop { get; set; }
        public string tag { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}


