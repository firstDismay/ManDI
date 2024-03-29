﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.export
{
    /// <summary>
    /// Команда оболочка для экспорта объектов в Excel по маске значения глобального свойства
    public class exp_object_by_mask_global_prop_to_excel : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        /// Маска значения
        /// </summary>
        public string find_mask { get; set; }

        /// <summary>
        /// Режим
        /// </summary>
        public long imode { get; set; }

        /// <summary>
        /// Показать количество
        /// </summary>
        public bool iquantity_show { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_global_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_global_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("find_mask", NpgsqlDbType.Varchar);
                Parameter.Value = find_mask;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imode", NpgsqlDbType.Integer);
                Parameter.Value = imode;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iquantity_show", NpgsqlDbType.Boolean);
                Parameter.Value = iquantity_show;
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
                return "exp_object_by_mask_global_prop_to_excel";
            }
        }

        public string? Condition { get; set; }
    }
}