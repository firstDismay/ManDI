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
    /// Конфигурация используемых типов перечислений
    /// </summary>
    public partial class ManDiBuilder
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
