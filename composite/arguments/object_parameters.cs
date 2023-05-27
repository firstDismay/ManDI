using Newtonsoft.Json;

namespace ManDI.composite.arguments
{
    /// <summary>
    /// Класс параметров создания объекта со свойствами
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class object_parameters
    {
        /// <summary>
        /// Идентификатор позиции объекта 
        /// </summary>
        [JsonProperty]
        public Int64 IdPosition { get; set; }

        /// <summary>
        /// Идентификатор объекта используется для обновления данных об объекте
        /// </summary>
        [JsonProperty]
        public Int64 IdObject { get; set; }

        /// <summary>
        /// Идентификатор класса объекта используется для создания новых объектов
        /// </summary>
        [JsonProperty]
        public Int64 IdClass { get; set; }

        /// <summary>
        /// Идентификатор правила пересчета объекта
        /// </summary>
        [JsonProperty]
        public Int32 IdUnitConversionRule { get; set; }

        /// <summary>
        /// Количество объекта в единицах пересчета текущего правила
        /// </summary>
        [JsonProperty]
        public Decimal СQuantity { get; set; }

        /// <summary>
        /// Лист свойств объекта
        /// </summary>
        [JsonProperty]
        public IEnumerable<object_property_parameters> ObjectPropertyList { get; set; }
    }
}