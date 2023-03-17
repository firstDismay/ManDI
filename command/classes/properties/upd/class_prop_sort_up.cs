﻿using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ManDI.command.classes.properties.upd
{
    /// <summary>
    /// Команда изменяет сортировку указанного свойства активного класса на один уровень вверх
    /// </summary>
    public class class_prop_sort_up : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
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
                return "class_prop_sort_up";
            }
        }
    }
}