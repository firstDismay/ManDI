
using System;

namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип таблицы спецификаторов пределов значений для используемых типов данных
    /// </summary>
    public class vcfg_prop_spec_limit2
    {
        public int id_prop_data_type { get; set; }
        public string max_name { get; set; }
        public bool max_used { get; set; }
        public bool max_limit_on { get; set; }
        public decimal max_upper { get; set; }
        public decimal max_lower { get; set; }
        public decimal max_default { get; set; }
        public string min_name { get; set; }
        public bool min_used { get; set; }
        public bool min_limit_on { get; set; }
        public decimal min_upper { get; set; }
        public decimal min_lower { get; set; }
        public decimal min_default { get; set; }
        public string round_name { get; set; }
        public bool round_used { get; set; }
        public bool round_limit_on { get; set; }
        public int round_upper { get; set; }
        public int round_lower { get; set; }
        public int round_default { get; set; }
    }
}