﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel_ext
{
    /// <summary>
    /// Команда возвращает список расширенных объектов шаблона позиции по идентификатору шаблона позиции
    /// </summary>
    public class object_ext_by_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции объекта
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
                return "object_ext_by_id_pos_temp";
            }
        }
    }
}
