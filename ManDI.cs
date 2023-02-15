using ManDI.composite.entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManDI
{
    /// <summary>
    /// Базовый конфигуратор источника данных ManDI
    /// </summary>
    public partial class ManDiBuilder
    {
        NpgsqlConnectionStringBuilder _csb;
        public ManDiBuilder(NpgsqlConnectionStringBuilder ConnectionStringBuilder)
        {
            if (ConnectionStringBuilder == null) throw new ArgumentNullException("ConnectionStringBuilder");
            _csb = ConnectionStringBuilder;
        }
        /// <summary>
        /// Сборка источника данных ManDI
        /// </summary>
        public NpgsqlDataSource Build()
        {
            ConnectionStringConfiguration(_csb);
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(_csb.ConnectionString);
            MapComposite(dataSourceBuilder);
            MapEnum(dataSourceBuilder);
            return dataSourceBuilder.Build();
        }
    }
}
