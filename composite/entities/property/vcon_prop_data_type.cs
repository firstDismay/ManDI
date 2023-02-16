using System;

namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип типов данных свойств концепции
    /// </summary>
    public class vcon_prop_data_type
    {
        public int id { get; set; }
        public long id_conception { get; set; }
        public string alias { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string usrdesc { get; set; }
        public bool is_create { get; set; }
        public bool is_use { get; set; }
        public int sort { get; set; }
    }
}