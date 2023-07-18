using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору корневого класса
    /// </summary>
    public class object_by_id_class_root : IParametersFunction
    {
        /// <summary>
        /// Идентификатор корневого класса объектов
        /// </summary>
        public long iid_class_root { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_root", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_root;
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
                return "object_by_id_class_root";
            }
        }

        public string? Condition { get; set; }
    }
}
