using ManDI.enums;
using Newtonsoft.Json;

namespace ManDI.composite.arguments
{
    /// <summary>
    /// Класс метода поиска
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class search_method
    {
        /// <summary>
        /// Основной конструктор класса
        /// </summary>
        public search_method(eSearchMethods iSearchMethod)
        {
            SearchMethod = iSearchMethod;
        }

        /// <summary>
        ///Метод поиска
        /// </summary>
        [JsonProperty]
        public eSearchMethods SearchMethod { get; set; }
    }
}