﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel_ext
{
    /// <summary>
    /// Команда возвращает список объектов по идентификаторам класса и позиции
    /// </summary>
    public class object_ext_by_id_class_id_pos : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса объектов
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Идентификатор позиции объектов
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

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

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
                return "object_ext_by_id_class_id_pos";
            }
        }

        public string? Condition { get; set; }
    }
}
