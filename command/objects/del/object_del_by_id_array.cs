using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.del
{
    /// <summary>
    /// Команда удаляет массив объектов в корзину по идентификатору массива объектов
    public class object_del_by_id_array : IParametersFunction
    {
        /// <summary>
        /// Массив идентификаторов объектов
        /// </summary>
        public long[] object_array { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("object_array", NpgsqlDbType.Array | NpgsqlDbType.Bigint);
                Parameter.Value = object_array;
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
                return "object_del_by_id_array";
            }
        }
    }
}