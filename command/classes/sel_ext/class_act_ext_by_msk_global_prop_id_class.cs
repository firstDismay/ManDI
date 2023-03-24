using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel_ext
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по идентификатору класса и маске значения глобального свойства 
    /// </summary>
    public class class_act_ext_by_msk_global_prop_id_class : IParametersFunction
    {
        /// <summary>
        /// Идентификатор глобального свойства
        /// </summary>
        public long iid_global_prop { get; set; }

        /// <summary>
        /// Идентификатор  класса
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Маска имени класса
        /// </summary>
        public string find_mask { get; set; }

        /// <summary>
        /// Признак выбора вещественных классов
        /// </summary>
        public bool class_real_only { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_global_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_global_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("find_mask", NpgsqlDbType.Varchar);
                Parameter.Value = find_mask;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("class_real_only", NpgsqlDbType.Boolean);
                Parameter.Value = class_real_only;
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
                return "class_act_ext_by_msk_global_prop_id_class";
            }
        }
    }
}
