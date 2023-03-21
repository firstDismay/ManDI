﻿using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// добавляет значение в виде элемента перечисления для свойства типа 
    /// перечисление объектов снимка класса в указанной позиции
    /// </summary>
    public class object_prop_enum_val_objects_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Штамп времени класса
        /// </summary>
        public DateTime itimestamp_class { get; set; }

        /// <summary>
        /// Выполнить включая встроенные объекты
        /// </summary>
        public bool on_internal { get; set; }

        /// <summary>
        /// Идентификатор элемента перечисления
        /// </summary>
        public long iid_prop_enum_val { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("on_internal", NpgsqlDbType.Boolean);
                Parameter.Value = on_internal;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_prop_enum_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum_val;
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
                return "object_prop_enum_val_objects_upd";
            }
        }
    }
}