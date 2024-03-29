﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel_ext
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по идентификатору концепции и маске имени 
    /// </summary>
    public class class_act_ext_by_id_conception_msk_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Маска имени класса
        /// </summary>
        public long name_mask { get; set; }

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

                Parameter = new NpgsqlParameter("name_mask", NpgsqlDbType.Varchar);
                Parameter.Value = name_mask;
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
                return "class_act_ext_by_id_conception_msk_name";
            }
        }

        /// <summary>
        /// Дополнительные параметры вызова функции добавляемые к основному запросу
        /// </summary>
        public string? Condition { get; set; }
    }
}
