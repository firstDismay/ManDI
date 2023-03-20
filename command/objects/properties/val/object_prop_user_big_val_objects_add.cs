using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда добавляет данные большого значения пользовательского свойства объектам снимка класса в указанной позиции
    /// </summary>
    public class object_prop_user_big_val_objects_add : IParametersFunction
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
        /// Текстовое значение свойства класса
        /// </summary>
        public string ival_text { get; set; }

        /// <summary>
        /// Байтовое значение свойства класса
        /// </summary>
        public Byte[] ival_bytea { get; set; }

        /// <summary>
        /// Текстовое значение свойства класса в формате JSON
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

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("on_internal", NpgsqlDbType.Boolean);
                Parameter.Value = on_internal;
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
                return "object_prop_user_big_val_objects_add";
            }
        }
    }
}