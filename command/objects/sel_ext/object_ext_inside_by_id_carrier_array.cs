﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel_ext
{
    /// <summary>
    /// Команда возвращает список встроенных расширенных объектов по массиву идентификаторов объектов носителей
    /// </summary>
    public class object_ext_inside_by_id_carrier_array : IParametersFunction
    {
        /// <summary>
        /// Массив идентификаторов объекта
        /// </summary>
        public long[] object_array { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("object_array", NpgsqlDbType.Array | NpgsqlDbType.Bigint);
                Parameter.Value = object_array;
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
                return "object_ext_inside_by_id_carrier_array";
            }
        }

        public string? Condition { get; set; }
    }
}
