﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.properties.val
{
    /// <summary>
    /// Команда возвращает данные значение объектного свойства шаблона позиции по идентификатору свойства
    /// </summary>
    public class pos_temp_prop_object_val_by_id_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

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
                return "pos_temp_prop_object_val_by_id_prop";
            }
        }

        public string? Condition { get; set; }
    }
}