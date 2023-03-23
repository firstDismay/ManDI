namespace ManDI.composite.entities.role
{
    /// <summary>
    /// Композитный тип базовой роли пользователей
    /// </summary>
    public class vrole_base
    {
        public uint oid { get; set; }
        public bool rolinherit { get; set; }
        public string namesys { get; set; }
        public string description { get; set; }
    }
}