﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает историческое представление класса по идентификатору класса и Штампу времени
    /// </summary>
    public class class_snapshot_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Штамп времени класса
        /// </summary>
        public DateTime timestamp_class { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("timestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = timestamp_class;
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
                return "class_snapshot_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}