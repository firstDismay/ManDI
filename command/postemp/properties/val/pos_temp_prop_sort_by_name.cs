﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.properties.val
{
    /// <summary>
    /// Команда изменяет сортировку свойства на сортировку по имени
    /// </summary>
    public class pos_temp_prop_sort_by_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pos_temp", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp;
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
                return "pos_temp_prop_sort_by_name";
            }
        }

        public string? Condition { get; set; }
    }
}