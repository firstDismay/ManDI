using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.export
{
    /// <summary>
    /// Команда оболочка для экспорта настраиваемого представления объектов по массиву идентификаторов в файл Excel
    public class exp_object_by_id_object_array_to_excel : IParametersFunction
    {

        /// <summary>
        /// Массив объектов
        /// </summary>
        public long[] iobject_array { get; set; }

        /// <summary>
        /// Режим
        /// </summary>
        public long imode { get; set; }

        /// <summary>
        /// Показать количество
        /// </summary>
        public bool iquantity_show { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iobject_array", NpgsqlDbType.Array | NpgsqlDbType.Bigint);
                Parameter.Value = iobject_array;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imode", NpgsqlDbType.Integer);
                Parameter.Value = imode;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iquantity_show", NpgsqlDbType.Boolean);
                Parameter.Value = iquantity_show;
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
                return "exp_object_by_id_object_array_to_excel";
            }
        }

        public string? Condition { get; set; }
    }
}