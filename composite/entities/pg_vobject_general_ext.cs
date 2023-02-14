using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities
{
    /// <summary>
    /// Композитный тип данных столбца таблицы
    /// </summary>
    public class pg_vobject_general_ext
    {
        public Int64 id { get; set; }
        public String name { get; set; }
        public Int64 id_conception { get; set; }
        public Int64 id_position { get; set; }
        public Int64 id_position_root { get; set; }
        public Int64 id_group { get; set; }
        public Int64 id_group_root { get; set; }
        public Int64 id_class { get; set; }
        public Int64 id_class_root { get; set; }
        public DateTime timestamp_class { get; set; }
        public Int64 barcode_unit { get; set; }
        public Int32 id_unit_conversion_rule { get; set; }
        public Decimal bquantity { get; set; }
        public String bunit { get; set; }
        public Decimal mc { get; set; }
        public Decimal cquantity { get; set; }
        public String cunit { get; set; }
        public Boolean on_technical { get; set; }
        public Boolean on_commercial { get; set; }
        public Boolean on_accounting { get; set; }
        public DateTime timestamp { get; set; }
        public Boolean on_freeze { get; set; }
        public Int64 id_object_carrier { get; set; }
        public Boolean is_inside { get; set; }
        public String desc { get; set; }
        public Int64 id_class_prop_object_carrier { get; set; }
        public Int32 id_unit { get; set; }
        public Boolean has_user_property { get; set; }
        public Boolean has_enum_property { get; set; }
        public Boolean has_object_property { get; set; }
        public Boolean has_link_property { get; set; }
        public Boolean in_recycle { get; set; }
        public Boolean quantity_show { get; set; }
        public String name_format { get; set; }
        public Int64 id_pos_temp_prop { get; set; }
        public pg_vobject_prop[] property_list { get; set; }
        public String path { get; set; }
        public Int32 round { get; set; }
        public String tablename { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}


