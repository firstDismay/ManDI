using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.upd
{
    /// <summary>
    /// Команда объединяет массив объектов в расположении первого объекта
    /// </summary>
    public class object_merging : IParametersFunction
    {
        /// <summary>
        /// Массив идентификатор объекта
        /// </summary>
        public long[] object_merging_array { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("object_merging_array", NpgsqlDbType.Array | NpgsqlDbType.Bigint);
                Parameter.Value = object_merging_array;
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
                return "object_merging";
            }
        }
    }
}