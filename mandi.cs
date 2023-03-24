using Npgsql;

namespace ManDI
{
    /// <summary>
    /// Базовый конфигуратор источника данных ManDI
    /// </summary>
    public partial class mandi
    {
        NpgsqlConnectionStringBuilder csb;
        NpgsqlDataSource data_source;
        public mandi(NpgsqlConnectionStringBuilder ConnectionStringBuilder)
        {
            if (ConnectionStringBuilder == null) throw new ArgumentNullException("ConnectionStringBuilder");
            this.csb = ConnectionStringBuilder;
        }
        /// <summary>
        /// Сборка источника данных ManDI
        /// </summary>
        public NpgsqlDataSource Build()
        {
            ConnectionStringConfiguration(this.csb);
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(this.csb.ConnectionString);
            MapComposite(dataSourceBuilder);
            MapEnum(dataSourceBuilder);
            return dataSourceBuilder.Build();
        }

        public NpgsqlDataSource GetDataSource()
        {
            if (this.data_source == null)
            {
                this.data_source = this.Build();
            }
            return this.data_source;
        }
    }
}
