using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда добавляет значение в виде ссылки на сущность для свойства класса типа ссылка
    /// </summary>
    public class class_prop_link_val_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public long iid_entity { get; set; }

        /// <summary>
        /// Идентификатор экземпляра сущности
        /// </summary>
        public long iid_entity_instance { get; set; }

        /// <summary>
        /// Идентификатор экземпляра сущности, дополнительный
        /// </summary>
        public long? iid_sub_entity_instance { get; set; } = null;

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

                Parameter = new NpgsqlParameter("iid_entity", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity_instance;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_sub_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_sub_entity_instance != null ? iid_sub_entity_instance : DBNull.Value;
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
                return "class_prop_link_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}