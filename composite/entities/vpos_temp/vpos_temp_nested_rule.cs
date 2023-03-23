namespace ManDI.composite.entities.vpos_temp
{
    /// <summary>
    /// Композитный тип правила вложенности шаблонов позиций
    /// </summary>
    public class vpos_temp_nested_rule
    {
        public long id_con { get; set; }
        public long id_pos_temp { get; set; }
        public long id_pos_temp_nested { get; set; }
        public bool on_limit { get; set; }
        public int limit_max { get; set; }
        public int limit_min { get; set; }
        public bool is_create { get; set; }
        public bool is_use { get; set; }
    }
}