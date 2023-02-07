using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects
{
    /// <summary>
    /// Команда возвращает таблицу объектов по идентификатору позиции
    /// </summary>
    public class object_by_id_position: IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public Int64 iid_position { get; set; }

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
        public String NameFunction
        {
            get
            {
                return "object_by_id_position";
            }
        }
    }
}
