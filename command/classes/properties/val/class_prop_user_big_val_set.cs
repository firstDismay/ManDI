﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда добавляет большое значение пользовательского свойства класса
    /// </summary>
    public class class_prop_user_big_val_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Минимальное значение свойства класса
        /// </summary>
        public decimal imin_val { get; set; }

        /// <summary>
        /// Признак активности контроля минимального значения свойства класса
        /// </summary>
        public bool imin_on { get; set; }

        /// <summary>
        /// Максимальное значение свойства класса
        /// </summary>
        public decimal imax_val { get; set; }

        /// <summary>
        /// Признак активности контроля максимального значения свойства класса
        /// </summary>
        public bool imax_on { get; set; }

        /// <summary>
        /// Текстовое значение свойства класса
        /// </summary>
        public string? ival_text { get; set; } = null;

        /// <summary>
        /// Байтовое значение свойства класса
        /// </summary>
        public Byte[]? ival_bytea { get; set; } = null;

        /// <summary>
        /// Текстовое значение свойства класса в формате JSON
        /// </summary>
        public string? ival_json { get; set; } = null;

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

                Parameter = new NpgsqlParameter("imin_val", NpgsqlDbType.Numeric);
                Parameter.Value = imin_val;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imin_on", NpgsqlDbType.Boolean);
                Parameter.Value = imin_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imax_val", NpgsqlDbType.Numeric);
                Parameter.Value = imax_val;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imax_on", NpgsqlDbType.Boolean);
                Parameter.Value = imin_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_text", NpgsqlDbType.Text);
                Parameter.Value = ival_text != null ? ival_text : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_bytea", NpgsqlDbType.Bytea);
                Parameter.Value = ival_bytea != null ? ival_bytea : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_json", NpgsqlDbType.Json);
                Parameter.Value = ival_json != null ? ival_json : DBNull.Value;
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
                return "class_prop_user_big_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}