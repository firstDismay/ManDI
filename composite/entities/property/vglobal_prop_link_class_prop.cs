using System;

namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип ссылки глобального свойства на свойство класса
    /// </summary>
    public class vglobal_prop_link_class_prop
    {
        public long id_conception { get; set; }
        public long id_global_prop { get; set; }
        public long id_class { get; set; }
        public long id_class_prop_definition { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string name_link { get; set; }

    }
}