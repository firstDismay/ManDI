using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список исторических представлений класса (снимков) по идентификатору класса родителя
    /// </summary>
    public class class_snapshot_by_id_parent_snapshot : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_parent_snapshot { get; set; }

        /// <summary>
        /// Штамп времени класса
        /// </summary>
        public DateTime itimestamp_parent_snapshot { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_parent_snapshot", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent_snapshot;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_parent_snapshot", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_parent_snapshot;
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
                return "class_snapshot_by_id_parent_snapshot";
            }
        }
    }
}