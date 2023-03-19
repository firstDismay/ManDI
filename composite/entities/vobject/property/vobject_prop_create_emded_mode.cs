using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.composite.entities.vobject.property
{
    /// <summary>
    /// Композитный тип данных режимов встраивания объектов-значений объектных свойств при создании объектов-носителей
    /// </summary>
    public class vobject_prop_create_emded_mode
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public bool on { get; set; }
        public int sort { get; set; }
    }
}

