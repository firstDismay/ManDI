﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору свойства перечисления
    /// </summary>
    public class object_by_id_prop_enum : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства перечисления
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
                return "object_by_id_prop_enum";
            }
        }

        public string? Condition { get; set; }
    }
}