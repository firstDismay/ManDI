﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.sel
{
    /// <summary>
    /// Команда возвращает список свойств для формирования формата имени объекта по идентификатору класса
    /// </summary>
    public class class_prop_for_format_by_id_class : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
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
                return "class_prop_for_format_by_id_class";
            }
        }

        public string? Condition { get; set; }
    }
}