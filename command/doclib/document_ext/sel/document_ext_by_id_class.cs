using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.document_ext.sel
{
    /// <summary>
    /// Команда возвращает расширенные документы  по идентификатору класса
    public class document_ext_by_id_class : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Включение объектов
        /// </summary>
        public bool object_on { get; set; }

        /// <summary>
        /// Включение рекурсии
        /// </summary>
        public bool recursive_on { get; set; }

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

                Parameter = new NpgsqlParameter("object_on", NpgsqlDbType.Boolean);
                Parameter.Value = object_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("recursive_on", NpgsqlDbType.Boolean);
                Parameter.Value = recursive_on;
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
                return "document_ext_by_id_class";
            }
        }

        public string? Condition { get; set; }
    }
}