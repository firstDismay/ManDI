namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип определения метода поиска
    /// </summary>
    public class vprop_search_method
    {
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public bool more { get; set; }
        public bool less { get; set; }
        public bool interval { get; set; }
        public bool equality { get; set; }
        public bool contains { get; set; }
        public int sort { get; set; }
    }
}