﻿using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.del
{
    /// <summary>
    /// Команда уничтожает объект по идентификатору объекта
    public class object_destroy : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid { get; set; }

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
                return "object_destroy";
            }
        }

        public string? Condition { get; set; }
    }
}
