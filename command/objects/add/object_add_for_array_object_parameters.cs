using ManDI.composite.arguments;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.add
{
    /// <summary>
    /// Команда добавляет список объектов по массиву параметров объектов
    /// </summary>
    public class object_add_for_array_object_parameters : IParametersFunction
    {
        /// <summary>
        /// Массив параметров объектов и значений их свойств
        /// </summary>
        public object_parameters[] object_parameters { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("object_parameters", NpgsqlDbType.Array | NpgsqlDbType.Jsonb);
                string[] sarray_object_parameter = new string[object_parameters.Length];
                for (int i = 0; i < object_parameters.Length; i++)
                {
                    sarray_object_parameter[i] = JsonConvert.SerializeObject(object_parameters[i], Formatting.Indented);
                }
                Parameter.Value = sarray_object_parameter;
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
                return "object_add_for_array_object_parameters";
            }
        }
    }
}
