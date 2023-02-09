using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов-значений объектного свойства объекта по идентификатору свойства позиции
    /// </summary>
    public class object_object_prop_by_id_position_carrier : IParametersFunction
    {

        /// <summary>
        /// Идентификатор позиции носителя
        /// </summary>
        public long iid_position_carrier { get; set; }

        /// <summary>
        /// Идентификатор объектного свойства
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position_carrier", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position_carrier;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
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
                return "object_object_prop_by_id_position_carrier";
            }
        }
    }
}