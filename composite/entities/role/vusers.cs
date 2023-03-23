
namespace ManDI.composite.entities.role
{
    /// <summary>
    /// Композитный тип пользователей
    /// </summary>
    public class vusers
    {
        public long id { get; set; }
        public uint oid { get; set; }
        public string name { get; set; }
        public string otchestvo { get; set; }
        public string familiya { get; set; }
        public string rolname { get; set; }
        public bool rolsuper { get; set; }
        public bool rolinherit { get; set; }
        public bool rolcreaterole { get; set; }
        public bool rolcreatedb { get; set; }
        public bool rolcanlogin { get; set; }
        public bool rolbypassrls { get; set; }
        public DateTime timestamp { get; set; }
        public bool iscurrent { get; set; }
        public string fio { get; set; }
        public bool rolcanweblogin { get; set; }
    }
}