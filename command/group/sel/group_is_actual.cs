using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставляемой сущности
    /// 1 - Не найдена
    /// 2 - Не актуальна
    /// 3 - Актуальна
    /// </summary>
    public class group_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Штамп времени объекта
        /// </summary>
        public long itimestamp { get; set; }

        /// <summary>
        /// Штамп времени объекта
        /// </summary>
        public long itimestamp_child_change { get; set; }

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

                Parameter = new NpgsqlParameter("itimestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_child_change", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_child_change;
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
                return "group_is_actual";
            }
        }
    }
}
