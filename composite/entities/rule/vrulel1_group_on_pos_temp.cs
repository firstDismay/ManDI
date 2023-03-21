using static System.Net.Mime.MediaTypeNames;

namespace ManDI.composite.entities.rule
{
    /// <summary>
    /// Композитный тип правила вложенности уровня 1 группа на шаблон
    /// </summary>
    public class vrulel1_group_on_pos_temp
    {
        public long id_group { get; set; }
        public long id_pos_temp { get; set; }
        public string name_rule { get; set; }
        public bool is_create { get; set; }
        public bool is_use { get; set; }
    }
}