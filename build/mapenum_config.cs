using Npgsql;

namespace ManDI
{
    /// <summary>
    /// Конфигурация используемых типов перечислений
    /// </summary>
    public partial class PgsqlDataService
    {
        /// <summary>
        /// Метод сопоставления перечислений
        /// </summary>
        private void MapEnum(NpgsqlDataSourceBuilder dataSourceBuilder)
        {
            //dataSourceBuilder.MapEnum<pg_vobject_prop>("bpd.vobject_prop");
        }
    }
}
