using ManDI.composite.arguments;
using Npgsql;
using NpgsqlTypes;
using Newtonsoft.Json;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов по соответствующих набору значений глобальных/определяющих свойств (подбор по критериям)
    /// </summary>
    public class object_by_array_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public search_condition[] array_prop { get; set; }

        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("array_prop", NpgsqlDbType.Array | NpgsqlDbType.Jsonb);
                string[] sarray_prop = new string[array_prop.Length];
                for (int i = 0; i < array_prop.Length; i++)
                {
                    sarray_prop[i] = JsonConvert.SerializeObject(array_prop[i], Formatting.Indented);
                }
                Parameter.Value = array_prop;
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
                return "object_by_array_prop";
            }
        }
    }
}