using Npgsql;

namespace ManDI.build
{
    /// <summary>
    /// Конфигурация используемых типов перечислений
    /// </summary>
    public partial class ManDiDataService
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
