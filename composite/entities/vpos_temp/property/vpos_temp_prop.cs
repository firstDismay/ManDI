using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vpos_temp.property
{
    /// <summary>
    /// Композитный тип свойств шаблонов позиций
    /// </summary>
    public class vpos_temp_prop
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public long id_pos_temp { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int sort { get; set; }
        public bool on_override { get; set; }
        public bool on_val { get; set; }
        public bool ready { get; set; }
        public bool on_global { get; set; }
        public long id_global_prop { get; set; }
        public DateTime timestamp { get; set; }
        public string string_val { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}