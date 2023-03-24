using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel_ext
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору позиции и маске имени
    /// </summary>
    public class object_ext_by_name_id_pos : IParametersFunction
    {
        /// <summary>
        /// Маска имени объекта
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Признак необходимости поиска встроенных объектов
        /// </summary>
        public bool on_inside { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("on_inside", NpgsqlDbType.Boolean);
                Parameter.Value = on_inside;
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
                return "object_ext_by_name_id_pos";
            }
        }
    }
}