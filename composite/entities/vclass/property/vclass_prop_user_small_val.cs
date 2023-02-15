using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vclass.property
{
    /// <summary>
    /// Композитный тип данных значения свойства класса типа пользовательское маленькое
    /// </summary>
    public class vclass_prop_user_small_val
    {
        
        public long id_class { get; set; }
        public long id_class_definition { get; set; }
        public long id_class_prop { get; set; }
        public int id_data_type { get; set; }
        public long id_prop_definition { get; set; }
        public bool inheritance { get; set; }
        public bool max_on { get; set; }
        public bool max_used { get; set; }
        public decimal max_val { get; set; }
        public bool min_on { get; set; }
        public bool min_used { get; set; }
        public decimal min_val { get; set; }
        public bool on_val { get; set; }
        public int round { get; set; }
        public bool round_on { get; set; }
        public bool round_used { get; set; }
        public string tablename { get; set; }
        public DateTime timestamp_class { get; set; }
        public DateTime timestamp_class_definition { get; set; }
        public long val_bigint { get; set; }
        public bool val_boolean { get; set; }
        public DateTime val_date { get; set; }
        public double val_double { get; set; }
        public int val_int { get; set; }
        public TimeSpan val_interval { get; set; }
        public decimal val_money { get; set; }
        public decimal val_numeric { get; set; }
        public float val_real { get; set; }
        public TimeSpan val_time { get; set; }
        public DateTime val_timestamp { get; set; }
        public string val_varchar { get; set; }
    }
}