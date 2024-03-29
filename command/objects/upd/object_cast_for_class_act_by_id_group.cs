﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.upd
{
    /// <summary>
    /// Команда приводит объекты к активным состояниям классов  по идентификатору группы
    /// </summary>
    public class object_cast_for_class_act_by_id_group : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы классов
        /// </summary>
        public long iid_group { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_group", NpgsqlDbType.Bigint);
                Parameter.Value = iid_group;
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
                return "object_cast_for_class_act_by_id_group";
            }
        }

        public string? Condition { get; set; }
    }
}
