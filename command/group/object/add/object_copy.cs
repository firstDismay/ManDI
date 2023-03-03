using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects.add
{
    /// <summary>
    /// Команда копирует объект в указанное расположение, рукурсивно включая вложенные объекты-значения объектных свойств
    /// </summary>
    public class object_copy : IParametersFunction
    {
        /// <summary>
        /// Идентификатор копируемого объекта
        /// </summary>
        public long iid_object_pattern { get; set; }

        /// <summary>
        /// Идентификатор целевой сущности
        /// </summary>
        public int iid_entity_target { get; set; }

        /// <summary>
        /// Идентификатор экземпляра целевой сущности
        /// </summary>
        public long iid_entity_instance_target { get; set; }

        /// <summary>
        /// Дополнительный идентификатор экземпляра целевой сущности
        /// </summary>
        public long iid_sub_entity_instance_target { get; set; }

        /// <summary>
        /// Признак необходимости проверки правил вложенности объектов
        /// </summary>
        public bool on_check_nested_rule { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object_pattern", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object_pattern;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity_target", NpgsqlDbType.Integer);
                Parameter.Value = iid_entity_target;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity_instance_target", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity_instance_target;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_sub_entity_instance_target", NpgsqlDbType.Bigint);
                Parameter.Value = iid_sub_entity_instance_target;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("on_check_nested_rule", NpgsqlDbType.Boolean);
                Parameter.Value = on_check_nested_rule;
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
                return "object_copy";
            }
        }
    }
}
