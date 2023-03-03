using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vposition.property
{
    /// <summary>
    /// Композитный тип данных значения свойства позиции типа пользовательское большое
    /// </summary>
    public class vposition_prop_user_big_val
    {
        public long id_position { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public int id_data_type { get; set; }
        public bool inheritance { get; set; }
        public bool min_used { get; set; }
        public bool min_on { get; set; }
        public decimal min_val { get; set; }
        public bool max_on { get; set; }
        public decimal max_val { get; set; }
        public bool max_used { get; set; }
        public string val_text { get; set; }
        public Byte[] val_bytea { get; set; }
        public string val_json { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
        public DateTime timestamp_val { get; set; }
    }
}