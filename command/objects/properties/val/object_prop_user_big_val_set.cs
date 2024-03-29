﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда добавляет большое значение пользовательского свойства объекта
    /// </summary>
    public class object_prop_user_big_val_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

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
        /// Текстовое значение свойства класса в формате JSON
        /// </summary>
        public Boolean setname { get; set; } = true;

        /// <summary>
        /// Признак опции обновления имени объекта
        /// </summary>

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
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

                Parameter = new NpgsqlParameter("setname", NpgsqlDbType.Boolean);
                Parameter.Value = setname;
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
                return "object_prop_user_big_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}