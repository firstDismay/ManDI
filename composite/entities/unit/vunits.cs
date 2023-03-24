namespace ManDI.composite.entities.unit
{
    /// <summary>
    /// Композитный тип измеряемых величин
    /// </summary>
    public class vunits
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool is_entity { get; set; }
        public bool not_fractional { get; set; }
    }
}