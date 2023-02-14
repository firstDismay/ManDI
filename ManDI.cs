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
    public class ManDiBuilder
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
            _csb.SearchPath = "bpd";
            _csb.LoadTableComposites = true;
            
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(_csb.ConnectionString);
            MapComposite(dataSourceBuilder);
            MapEnum(dataSourceBuilder);
            return dataSourceBuilder.Build();
        }
        
        /// <summary>
        /// Метод сопоставления композитных типов
        /// </summary>
        private void MapComposite(NpgsqlDataSourceBuilder dataSourceBuilder)
        {
            dataSourceBuilder.MapComposite<pg_vobject_prop>("vobject_prop");
            dataSourceBuilder.MapComposite<pg_vobject_general_ext>("vobject_general_ext");
        }

        /// <summary>
        /// Метод сопоставления перечислений
        /// </summary>
        private void MapEnum(NpgsqlDataSourceBuilder dataSourceBuilder)
        {
            //dataSourceBuilder.MapEnum<pg_vobject_prop>("bpd.vobject_prop");
        }
    }
}
