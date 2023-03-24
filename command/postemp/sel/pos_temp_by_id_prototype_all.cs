using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.sel
{
    /// <summary>
    /// Команда возвращает полный список шаблонов прототипа в конструкторе концепций
    /// </summary>
    public class pos_temp_by_id_prototype_all : IParametersFunction
    {
        /// <summary>
        /// Идентификатор прототипа
        /// </summary>
        public long iid_prototype { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prototype", NpgsqlDbType.Integer);
                Parameter.Value = iid_prototype;
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
                return "pos_temp_by_id_prototype_all";
            }
        }
    }
}
