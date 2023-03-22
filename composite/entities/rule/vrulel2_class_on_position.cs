using static System.Net.Mime.MediaTypeNames;

namespace ManDI.composite.entities.rule
{
    /// <summary>
    /// Композитный тип правила вложенности уровня 2 класс на позицию
    /// </summary>
    public class vrulel2_class_on_position
    {
        public long id_class { get; set; }
        public long id_position { get; set; }
        public string name_rule { get; set; }
        public bool is_create { get; set; }
        public bool is_use { get; set; }
    }
}