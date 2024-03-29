﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.sel
{
    /// <summary>
    /// Команда изменяет сортировку позиции на один уровень вниз
    /// </summary>
    public class position_sort_up : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
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
                return "position_sort_up";
            }
        }

        public string? Condition { get; set; }
    }
}
