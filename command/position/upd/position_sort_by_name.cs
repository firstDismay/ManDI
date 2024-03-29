﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.sel
{
    /// <summary>
    /// Команда изменяет сортировку дочерних позиций на сортировку по алфавиту
    /// </summary>
    public class position_sort_by_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
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
                return "position_sort_by_name";
            }
        }

        public string? Condition { get; set; }
    }
}
