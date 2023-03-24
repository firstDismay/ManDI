namespace ManDI.composite.entities.rule
{
    /// <summary>
    /// Композитный тип разрешений правила вложенности уровня 1 класс на шаблон
    /// </summary>
    public class vrulel1_class_on_pos_temp_tbl_access
    {
        public long id_con { get; set; }
        public long id_group { get; set; }
        public long id_pos_temp { get; set; }
        public long id_class { get; set; }
        public bool on_assigned { get; set; }
        public long id_class_assigned { get; set; }
        public int class_level { get; set; }
        public string name_rule { get; set; }
    }
}