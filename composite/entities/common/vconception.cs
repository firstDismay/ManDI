using ManDI.composite.entities.vclass.property;

namespace ManDI.composite.entities.common
{
    /// <summary>
    /// Композитный тип измеряемых величин
    /// </summary>
    public class vconception
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool on { get; set; }
        public bool on_root_create { get; set; }
        public bool @default { get; set; }
        public long pos_recycle { get; set; }
        public long group_recycle { get; set; }
        public long pos_temp_recycle { get; set; }
        public int actcatalog { get; set; }
        public DateTime timestamp { get; set; }
    }
}


