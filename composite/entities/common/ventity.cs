namespace ManDI.composite.entities.common
{
    /// <summary>
    /// Композитный тип обобщенной сущности
    /// </summary>
    public class ventity
    {
        public int id { get; set; }
        public string entity { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int errid { get; set; }
        public bool can_link { get; set; }
        public bool on_export { get; set; }
        public bool sec_point { get; set; }
    }
}