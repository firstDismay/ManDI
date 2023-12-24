namespace ManDI.composite.entities.group
{
    /// <summary>
    /// Композитный тип ссылки записи журнала
    /// </summary>
    public class vlog_link
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public long id_log { get; set; }
        public long id_category { get; set; }
        public string message { get; set; }
        public DateTime datetime { get; set; }
        public int id_entity { get; set; }
        public long id_entity_instance { get; set; }
        public long id_sub_entity_instance { get; set; }
        public string path { get; set; }
        public bool is_main_link { get; set; }
    }
}