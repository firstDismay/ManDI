﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.properties.sel
{
    /// <summary>
    /// Команда возвращает список свойств шаблона позиции по идентификатору шаблона позиции
    /// </summary>
    public class pos_temp_prop_by_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции
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
                return "pos_temp_prop_by_id_pos_temp";
            }
        }

        public string? Condition { get; set; }
    }
}