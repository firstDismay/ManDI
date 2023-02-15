using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vobject
{
    /// <summary>
    /// Композитный тип объектов
    /// </summary>
    public class vobject_general
    {
        public long id { get; set; }
        public string name { get; set; }
        public long id_conception { get; set; }
        public long id_position { get; set; }
        public long id_position_root { get; set; }
        public long id_group { get; set; }
        public long id_group_root { get; set; }
        public long id_class { get; set; }
        public long id_class_root { get; set; }
        public DateTime timestamp_class { get; set; }
        public long barcode_unit { get; set; }
        public int id_unit_conversion_rule { get; set; }
        public decimal bquantity { get; set; }
        public string bunit { get; set; }
        public decimal mc { get; set; }
        public decimal cquantity { get; set; }
        public string cunit { get; set; }
        public bool on_technical { get; set; }
        public bool on_commercial { get; set; }
        public bool on_accounting { get; set; }
        public DateTime timestamp { get; set; }
        public bool on_freeze { get; set; }
        public long id_object_carrier { get; set; }
        public bool is_inside { get; set; }
        public string desc { get; set; }
        public long id_class_prop_object_carrier { get; set; }
        public int id_unit { get; set; }
        public bool has_user_property { get; set; }
        public bool has_enum_property { get; set; }
        public bool has_object_property { get; set; }
        public bool has_link_property { get; set; }
        public bool in_recycle { get; set; }
        public bool quantity_show { get; set; }
        public string name_format { get; set; }
        public long id_pos_temp_prop { get; set; }
        public string path { get; set; }
        public int round { get; set; }
        public string tablename { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}


