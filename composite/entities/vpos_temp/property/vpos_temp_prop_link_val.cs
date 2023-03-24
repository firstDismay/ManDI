namespace ManDI.composite.entities.vpos_temp.property
{
    /// <summary>
    /// Композитный тип данных значения свойства шаблона позиции типа ссылка
    /// </summary>
    public class vpos_temp_prop_link_val
    {
        public long id_conception { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public int id_data_type { get; set; }
        public int id_entity { get; set; }
        public long id_entity_instance { get; set; }
        public string tablename { get; set; }
        public bool on_val { get; set; }
        public long id_sub_entity_instance { get; set; }
        public DateTime timestamp { get; set; }
    }
}