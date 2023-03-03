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
    /// Команда возвращает список объектов по массиву идентификаторов объектов
    /// </summary>
    public class object_by_id_array : IParametersFunction
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
                return "object_by_id_array";
            }
        }
    }
}
