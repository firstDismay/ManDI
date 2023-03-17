﻿using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;

namespace ManDI.command.classes.properties.del
{
    /// <summary>
    /// Команда добавляет свойство класса
    /// </summary>
    public class class_prop_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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
                return "class_prop_del";
            }
        }
    }
}