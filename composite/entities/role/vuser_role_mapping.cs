namespace ManDI.composite.entities.role
{
    /// <summary>
    /// Композитный тип подключаемых ролей пользователя
    /// </summary>
    public class vuser_role_mapping
    {
        public long id_conception { get; set; }
        public uint oid_role { get; set; }
        public string rolname { get; set; }
    }
}