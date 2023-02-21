using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vposition.property
{
    /// <summary>
    /// Композитный тип свойств позиций
    /// </summary>
    public class vposition_prop
    {
        public long id_conception { get; set; }
        public long id_position_carrier { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int sort { get; set; }
        public bool on_override { get; set; }
        public bool on_val_position { get; set; }
        public bool on_val_pos_temp { get; set; }
        public bool on_global { get; set; }
        public long id_global_prop { get; set; }
        public DateTime timestamp_position_carrier { get; set; }
        public long id_position_root { get; set; }
        public string string_val { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}