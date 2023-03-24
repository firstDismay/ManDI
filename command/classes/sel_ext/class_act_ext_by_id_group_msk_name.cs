using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.sel_ext
{
    /// <summary>
    /// Команда возвращает список активных представлений классов по идентификатору группы и маске имени 
    /// </summary>
    public class class_act_ext_by_id_group_msk_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  группы
        /// </summary>
        public long iid_group { get; set; }

        /// <summary>
        /// Маска имени класса
        /// </summary>
        public long name_mask { get; set; }

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

                Parameter = new NpgsqlParameter("name_mask", NpgsqlDbType.Varchar);
                Parameter.Value = name_mask;
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
                return "class_act_ext_by_id_group_msk_name";
            }
        }
    }
}
