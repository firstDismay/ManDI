using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects
{
    /// <summary>
    /// Команда добавляет новый объект в указанное расположение
    /// </summary>
    public class object_add
    {
        /// <summary>
        /// Наименование функции
        /// </summary>
        public String proname() { return "object_add"; } 
        
        /// <summary>
        /// Идентификатор класса объекта
        /// </summary>
        public Int64 iid_class { get; set; }
        
        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public Int64 iid_position { get; set; }
        
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
