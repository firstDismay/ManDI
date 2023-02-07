using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.common
{
    public class UserContextSQL 
    {
        /// <summary>
        /// Условие выборки
        /// </summary>
        public string Where { get; set; }

        /// <summary>
        /// Ограничение выборки
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public string OrderBy { get; set; }
    }
}
