using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает полный список объектов по идентификатору позиции рекурсивно
    /// </summary>
    public class object_by_id_position_recursive : IParametersFunction
    {
        //object_by_id_position_full
        /// <summary>
        /// Идентификатор позиции объекта
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
                return "object_by_id_position_recursive";
            }
        }
    }
}
