using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel_ext
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по идентификатору класса родителя
    /// </summary>
    public class class_act_ext_by_id_parent : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  класса
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
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
                return "class_act_ext_by_id_parent";
            }
        }

        public string? Condition { get; set; }
    }
}
