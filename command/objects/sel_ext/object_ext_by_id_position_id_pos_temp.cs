﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel_ext
{
    /// <summary>
    /// Команда возвращает список расширенных объектов позиций указанного шаблона рекурсивно начиная с указанной позиции
    /// </summary>
    public class object_ext_by_id_position_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор стартовой позиции
        /// </summary>
        public long iid_position { get; set; }

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

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp", NpgsqlDbType.Bigint);
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
                return "object_ext_by_id_position_id_pos_temp";
            }
        }

        public string? Condition { get; set; }
    }
}
