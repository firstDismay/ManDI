﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.dell
{
    /// <summary>
    /// Команда удаляет снимки концепции, не содержащие каскадно наследующие объекты и классы значения свойств
    /// </summary>
    public class class_snapshot_clear : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
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
                return "class_snapshot_clear";
            }
        }

        public string? Condition { get; set; }
    }
}
