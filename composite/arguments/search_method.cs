using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManDI.enums;
using ManDI.function;
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

        /// <summary>
        /// Описание метода поиска
        /// </summary>
        public  String Description()
        {
            return global_dictionary.SearchMethodsToDescription(SearchMethod);
        }

        /// <summary>
        /// Переопределение метода ToString
        /// </summary>
        public override String ToString()
        {
            return global_dictionary.SearchMethodsToString(SearchMethod);
        }
    }
}