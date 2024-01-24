﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.common
{
    /// <summary>
    /// Команда возвращает правило назначение типа данных для указанной концепции по идентификаторам правила и концепции
    /// </summary>
    public class con_prop_data_type_by_id : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Идентификатор типа данных свойства
        /// </summary>
        public int iid_prop_data_type { get; set; }


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

                Parameter = new NpgsqlParameter("iid_prop_data_type", NpgsqlDbType.Integer);
                Parameter.Value = iid_prop_data_type;
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
                return "con_prop_data_type_by_id";
            }
        }

        public string? Condition { get; set; }
    }
}
