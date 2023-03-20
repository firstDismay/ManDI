using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда добавляет значение в виде элемента перечисления для свойства объекта типа перечисление
    /// </summary>
    public class object_prop_enum_val_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

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

                Parameter = new NpgsqlParameter("iid_object", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
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
                return "object_prop_enum_val_upd";
            }
        }
    }
}