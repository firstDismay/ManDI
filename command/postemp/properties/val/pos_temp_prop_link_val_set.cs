using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.properties.val
{
    /// <summary>
    /// Команда добавляет данные значения типа ссылка
    /// </summary>
    public class pos_temp_prop_link_val_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции 
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

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
        public long iid_sub_entity_instance { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity_instance;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_sub_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_sub_entity_instance;
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
                return "pos_temp_prop_link_val_set";
            }
        }
    }
}