using ManDI.enums;
using Newtonsoft.Json;

namespace ManDI.composite.arguments
{
    /// <summary>
    /// Класс условие поиска типа подбор пр критериям преобразования в JSONB
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class search_condition
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public search_condition()
        {
            IdGlobalProp = -1;
            IdDefinitionProp = -1;
        }

        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        [JsonProperty]
        public Int64 IdGlobalProp { get; set; }

        /// <summary>
        /// Идентификатор определяющего свойства, может быть задан при отсуствии глобального свойства
        /// </summary>
        [JsonProperty]
        public Int64 IdDefinitionProp { get; set; }

        private eSearchMethods _SearchMethods;
        /// <summary>
        ///Метод поиска
        /// </summary>
        [JsonProperty]
        public eSearchMethods SearchMethods { get; set; }

        /// <summary>
        ///Метод поиска строковое представление
        /// </summary>
        [JsonProperty]
        public String SearchMethodsToString
        {
            get
            {
                return _SearchMethods.ToString();
            }
        }

        /// <summary>
        /// Верхня граница условия поиска
        /// </summary>
        [JsonProperty]
        public String ValMax { get; set; }

        /// <summary>
        /// Нижняя граница условия поиска
        /// </summary>
        [JsonProperty]
        public String ValMin { get; set; }

        /// <summary>
        /// Запрашиваемое единичное значение или маска
        /// </summary>
        [JsonProperty]
        public String ValReq { get; set; }

        /// <summary>
        /// Запрашиваемый массив значений
        /// </summary>
        [JsonProperty]
        public String[] ValReqArray { get; set; }
    }
}


