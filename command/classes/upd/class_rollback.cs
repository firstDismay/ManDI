﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.upd
{
    /// <summary>
    /// Команда возвращает текущее представление класса по идентификатору снимка и Штампу времени 
    /// </summary>
    public class class_rollback : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_snapshot { get; set; }

        /// <summary>
        /// Штамп времени класса
        /// </summary>
        public DateTime timestamp_snapshot { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_snapshot", NpgsqlDbType.Bigint);
                Parameter.Value = iid_snapshot;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("timestamp_snapshot", NpgsqlDbType.Timestamp);
                Parameter.Value = timestamp_snapshot;
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
                return "class_rollback";
            }
        }

        public string? Condition { get; set; }
    }
}
