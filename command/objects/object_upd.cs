using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects
{
    /// <summary>
    /// Команда изменяет указанный объект
    /// </summary>
    public class object_upd
    {
        /// <summary>
        /// Наименование функции
        /// </summary>
        public String proname() { return "object_upd"; } 
        
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public Int64 iid { get; set; }
        
        /// <summary>
        /// Идентификатор правила пересчета количества объектов
        /// </summary>
        public Int32 iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Количество объектов в текущем правиле пересчета
        /// </summary>
        public Decimal icquantity { get; set; }
    }
}
