﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставляемой сущности
    /// </summary>
    public class class_prop_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  класса
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Штамп времени
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

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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
                return "class_prop_is_actual";
            }
        }
    }
}