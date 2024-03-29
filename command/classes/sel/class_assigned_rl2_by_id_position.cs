﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список назначенных активных классов с учетом разрешения уровня 2 класс на позицию по идентификатору позиции
    /// </summary>
    public class class_assigned_rl2_by_id_position : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
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
                return "class_assigned_rl2_by_id_position";
            }
        }

        public string? Condition { get; set; }
    }
}