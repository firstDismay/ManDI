using Newtonsoft.Json;

namespace ManDI.composite.arguments
{
    /// <summary>
    /// Класс значений свойств объектов
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class object_property_parameters
    {

        /// <summary>
        /// Идентификатор определяющего свойства класса
        /// </summary>
        [JsonProperty]
        public Int64 IdDefinitionProp { get; set; }

        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        [JsonProperty]
        public Int64 IdClassProp { get; set; }

        /// <summary>
        ///Наименование свойства класса
        /// </summary>
        [JsonProperty]
        public String NameClassProp { get; set; }

        /// <summary>
        ///Значеие свойства объекта
        /// </summary>
        [JsonProperty]
        public String ValueObjectProp { get; set; }

        /// <summary>
        /// Переопределенный метод класса
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0}[1]: {2}", NameClassProp, IdClassProp, ValueObjectProp);
        }
    }
}