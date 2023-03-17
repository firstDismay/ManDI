﻿using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ManDI.command.classes.properties.sel
{
    /// <summary>
    /// Команда возвращает свойство исторического представления класса по идентификатору свойства класса
    /// </summary>
    public class class_prop_snapshot_by_id_class_snapshot : IParametersFunction
    {
        /// <summary>
        /// Идентификатор снимка класса
        /// </summary>
        public long iid_class_snapshot { get; set; }

        /// <summary>
        /// Штамп времени снимка класса
        /// </summary>
        public DateTime itimestamp_class_snapshot { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_snapshot", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_snapshot;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class_snapshot", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class_snapshot;
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
                return "class_prop_snapshot_by_id_class_snapshot";
            }
        }
    }
}