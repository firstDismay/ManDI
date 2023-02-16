using Npgsql;
using ManDI.composite.entities.common;
using ManDI.composite.entities.vobject;
using ManDI.composite.entities.vobject.property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ManDI
{
    /// <summary>
    /// Конфигурация используемых композитных типов
    /// </summary>
    public partial class ManDiBuilder
    {
        /// <summary>
        /// Метод сопоставления композитных типов
        /// </summary>
        private void MapComposite(NpgsqlDataSourceBuilder dataSourceBuilder)
        {
            dataSourceBuilder.MapComposite<vconception>("vconception");

            dataSourceBuilder.MapComposite<vobject_prop>("vobject_prop");
            dataSourceBuilder.MapComposite<vobject_general>("vobject_general");
            dataSourceBuilder.MapComposite<vobject_general_ext>("vobject_general_ext");
        }
    }
}
