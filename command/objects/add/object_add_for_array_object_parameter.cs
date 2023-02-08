using ManDI.command.common;
using ManDI.composite.arguments;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.add
{
    /// <summary>
    /// Команда добавляет список объектов по массиву параметров объектов
    /// </summary>
    public class object_add_for_array_object_parameter : IParametersFunction
    {
        /// <summary>
        /// Массив параметров объектов и значений их свойств
        /// </summary>
        public object_parameters[] array_object_parameter { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("array_object_parameters", NpgsqlDbType.Array | NpgsqlDbType.Jsonb);
                String[] sarray_object_parameter = new String[array_object_parameter.Length];
                for (Int32 i = 0; i < array_object_parameter.Length; i++)
                {
                    sarray_object_parameter[i] = JsonConvert.SerializeObject(array_object_parameter[i], Formatting.Indented);
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
                return "object_add_for_array_object_parameter";
            }
        }
    }
}
