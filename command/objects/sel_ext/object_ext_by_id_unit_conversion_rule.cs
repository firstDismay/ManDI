﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel_ext
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору правил пересчета 
    /// </summary>
    public class object_ext_by_id_unit_conversion_rule : IParametersFunction
    {
        /// <summary>
        /// Идентификатор правила пересчета объектов
        /// </summary>
        public int iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit_conversion_rule;
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
                return "object_ext_by_id_unit_conversion_rule";
            }
        }

        public string? Condition { get; set; }
    }
}