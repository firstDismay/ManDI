﻿using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда удаляет данные значения пользовательского свойства класса
    /// </summary>
    public class class_prop_user_val_del : IParametersFunction
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
                return "class_prop_user_val_del";
            }
        }
    }
}