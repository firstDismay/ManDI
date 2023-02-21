using ManDI.composite.entities.vclass.property;
using System;

namespace ManDI.composite.errors
{
    /// <summary>
    /// Композитный тип ошибки приведения объектов
    /// </summary>
    public class errarg_cast
    {
        public int err_id { get; set; }
        public string errdesc { get; set; }
        public int entity_id { get; set; }
        public long entity_instance_id { get; set; }
        public string entity_instance_name { get; set; }
        public int action_id { get; set; }
        public string action_desc { get; set; }
    }
}