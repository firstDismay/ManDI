using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel_ext
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по идентификатору группы
    /// </summary>
    public class class_act_ext_by_id_group : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  класса
        /// </summary>
        public long iid_group { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_group", NpgsqlDbType.Bigint);
                Parameter.Value = iid_group;
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
                return "class_act_ext_by_id_group";
            }
        }
    }
}
