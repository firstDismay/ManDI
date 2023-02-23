﻿using ManDI.command.common;
using Npgsql;
using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.position.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставлямой сущности
    /// </summary>
    public class class_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  класса
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Штамп времени
        /// </summary>
        public DateTime itimestamp { get; set; }

        /// <summary>
        /// Штамп времени сопоставляемой сущности
        /// </summary>
        public DateTime itimestamp_child_change { get; set; }

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

                Parameter = new NpgsqlParameter("itimestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_child_change", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_child_change;
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
                return "class_is_actual";
            }
        }
    }
}