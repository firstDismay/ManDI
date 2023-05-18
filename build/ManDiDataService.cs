using Npgsql;

namespace ManDI.build
{
    /// <summary>
    /// Базовый конфигуратор источника данных ManDI
    /// </summary>
    public partial class ManDiDataService : IDataService
    {
        NpgsqlConnectionStringBuilder csb;
        NpgsqlDataSource data_source;
        public ManDiDataService(NpgsqlConnectionStringBuilder ConnectionStringBuilder)
        {
            if (ConnectionStringBuilder == null) throw new ArgumentNullException("ConnectionStringBuilder");
            csb = ConnectionStringBuilder;
        }
        /// <summary>
        /// Сборка источника данных ManDI
        /// </summary>
        public NpgsqlDataSource Build()
        {
            ConnectionStringConfiguration(csb);
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(csb.ConnectionString);
            MapComposite(dataSourceBuilder);
            MapEnum(dataSourceBuilder);
            return dataSourceBuilder.Build();
        }

        public NpgsqlDataSource GetDataSource()
        {
            if (data_source == null)
            {
                data_source = Build();
            }
            return data_source;
        }
    }
}
