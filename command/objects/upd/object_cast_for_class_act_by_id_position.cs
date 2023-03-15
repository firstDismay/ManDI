using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects.upd
{
    /// <summary>
    /// Команда приводит объекты к активным состояниям классов  по идентификатору позиции рекурсивно
    /// </summary>
    public class object_cast_for_class_act_by_id_position : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции объектов
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
                return "object_cast_for_class_act_by_id_position";
            }
        }
    }
}
