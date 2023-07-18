using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel_ext
{
    /// <summary>
    /// Команда возвращает активное представление класса по идентификатору класса родителя и строгому соотвествию имени
    /// </summary>
    public class class_act_ext_by_id_parent_strict_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор родителького класса
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Маска имени класса
        /// </summary>
        public long iname { get; set; }

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

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
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
                return "class_act_ext_by_id_parent_strict_name";
            }
        }

        public string? Condition { get; set; }
    }
}
