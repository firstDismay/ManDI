using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vposition.property
{
    /// <summary>
    /// Композитный тип данных значения свойства позиции типа ссылка
    /// </summary>
    public class vposition_prop_link_val
    {
        public long id_conception { get; set; }
        public long id_position { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public int id_data_type { get; set; }
        public bool inheritance { get; set; }
        public int id_entity { get; set; }
        public long id_entity_instance { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
        public DateTime timestamp_val { get; set; }
        public long id_sub_entity_instance { get; set; }
    }
}