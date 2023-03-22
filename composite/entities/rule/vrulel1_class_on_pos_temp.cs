namespace ManDI.composite.entities.rule
{
    /// <summary>
    /// Композитный тип правила вложенности уровня 1 класс на шаблон
    /// </summary>
    public class vrulel1_class_on_pos_temp
    {
        public long id_group { get; set; }
        public long id_class { get; set; }
        public long id_pos_temp { get; set; }
        public string name_rule { get; set; }
        public bool is_create { get; set; }
        public bool is_use { get; set; }
    }
}