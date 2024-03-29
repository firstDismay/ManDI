﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.global.link
{
    /// <summary>
    /// Команда возвращает ссылку глобального свойства на определяющее свойство класса 
    /// по идентификаторам глобального свойства и определяющего свойства класса
    /// </summary>
    public class global_prop_link_class_prop_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор определяющего свойства класса
        /// </summary>
        public long iid_class_prop_definition { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_prop_definition", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop_definition;
                ListParameter.Add(Parameter);

                return ListParameter;
            }
        }

        /// <summary>
        /// Наименование функции API
        /// </summary>
        public string NameFunction
        {
            get
            {
                return "global_prop_link_class_prop_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}