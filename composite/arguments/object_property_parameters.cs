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
        /// Идентификатор свойства класса
        /// </summary>
        [JsonProperty]
        public Int64 IdClassProp { get; set; }

        /// <summary>
        ///Значение свойства объекта
        /// </summary>
        [JsonProperty]
        public String ValueObjectProp { get; set; }
    }
}