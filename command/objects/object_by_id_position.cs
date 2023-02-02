using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects
{
    /// <summary>
    /// Команда возвращает таблицу объектов по идентификатору позиции
    /// </summary>
    public class object_by_id_position
    {
        /// <summary>
        /// Наименование функции
        /// </summary>
        public String proname() { return "object_by_id_position"; } 
        
        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public Int64 iid_position { get; set; }
    }
}
