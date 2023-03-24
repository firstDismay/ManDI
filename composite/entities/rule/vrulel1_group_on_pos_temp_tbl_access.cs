namespace ManDI.composite.entities.rule
{
    /// <summary>
    /// Композитный тип разрешений правила вложенности уровня 1 группа на шаблон
    /// </summary>
    public class vrulel1_group_on_pos_temp_tbl_access
    {
        public long id_con { get; set; }
        public long id_pos_temp { get; set; }
        public long id_group { get; set; }
        public bool on_assigned { get; set; }
        public long id_group_assigned { get; set; }
        public int group_level { get; set; }
        public string name_rule { get; set; }
    }
}