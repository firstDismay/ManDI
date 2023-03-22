
namespace ManDI.composite.entities.role
{
    /// <summary>
    /// Композитный тип пользовательской роли пользователей
    /// </summary>
    public class vrole_user
    {
        public long id { get; set; }
        public uint oid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string namesys { get; set; }
        public bool rolsuper { get; set; }
        public bool rolinherit { get; set; }
        public bool rolcreaterole { get; set; }
        public bool rolcreatedb { get; set; }
        public bool rolcanlogin { get; set; }
        public bool rolbypassrls { get; set; }
        public DateTime timestamp { get; set; }

    }
}