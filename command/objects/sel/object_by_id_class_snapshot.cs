using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору активного представления класса
    /// </summary>
    public class object_by_id_class_snapshot : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса объектов
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Шатамп времени наследуемого класса
        /// </summary>
        public DateTime itimestamp_class { get; set; }


        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp_class", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp_class;
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
                return "object_by_id_class_snapshot";
            }
        }

        public string? Condition { get; set; }
    }
}