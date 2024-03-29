﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.val
{
    /// <summary>
    /// Команда изменяет сортировку списка элементов перечисления на сортировку по имени
    /// </summary>
    public class prop_enum_val_sort_by_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор перечисления
        /// </summary>
        public long iid_prop_enum { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prop_enum", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum;
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
                return "prop_enum_val_sort_by_name";
            }
        }

        public string? Condition { get; set; }
    }
}