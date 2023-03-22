namespace ManDI.composite.entities.common
{
    /// <summary>
    /// Композитный тип объектов пути
    /// </summary>
    public class path3
    {
        public long id_position { get; set; }
        public long id_object { get; set; }
        public string name_object { get; set; }
        public long id_object_carrier { get; set; }
        public string name_oject_carrier { get; set; }
        public long id_class_prop_object_carrier { get; set; }
        public string name_class_prop_object_carrier { get; set; }
        public int level { get; set; }
    }
}