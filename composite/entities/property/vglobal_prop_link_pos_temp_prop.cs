namespace ManDI.composite.entities.property
{
    /// <summary>
    /// Композитный тип ссылки глобального свойства на свойство шаблона позиций
    /// </summary>
    public class vglobal_prop_link_pos_temp_prop
    {
        public long id_conception { get; set; }
        public long id_global_prop { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_prop { get; set; }
        public int id_prop_type { get; set; }
        public int id_data_type { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string name_link { get; set; }
    }
}