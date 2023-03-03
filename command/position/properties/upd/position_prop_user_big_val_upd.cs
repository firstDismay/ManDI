﻿using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.position.properties.upd
{
    /// <summary>
    /// Команда обновляет значение BIG пользовательского свойства позиции
    /// </summary>
    public class position_prop_user_big_val_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        ///  Идентификатор значения типа text
        /// </summary>
        public string ival_text { get; set; }

        /// <summary>
        ///  Идентификатор значения типа bytea
        /// </summary>
        public byte ival_bytea { get; set; }

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public string ival_json { get; set; }

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

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_text", NpgsqlDbType.Text);
                Parameter.Value = ival_text;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_bytea", NpgsqlDbType.Bytea);
                Parameter.Value = ival_bytea;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_json", NpgsqlDbType.Json);
                Parameter.Value = ival_json;
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
                return "position_prop_user_big_val_upd";
            }
        }
    }
}
