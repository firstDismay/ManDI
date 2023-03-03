using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vclass.property
{
    /// <summary>
    /// Композитный тип данных значения свойства класса типа перечисление
    /// </summary>
    public class vclass_prop_enum_val
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public long id_class { get; set; }
        public DateTime timestamp_class { get; set; }
        public long id_class_prop { get; set; }
        public int id_data_type { get; set; }
        public long id_class_definition { get; set; }
        public long id_prop_definition { get; set; }
        public DateTime timestamp_class_definition { get; set; }
        public bool inheritance { get; set; }
        public long id_prop_enum { get; set; }
        public long id_prop_enum_val { get; set; }
        public decimal val_numeric { get; set; }
        public string val_varchar { get; set; }
        public bool is_use { get; set; }
        public long id_object_reference { get; set; }
        public bool has_object_reference { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
    }
}


