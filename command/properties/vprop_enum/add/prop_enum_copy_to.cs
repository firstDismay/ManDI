using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.properties.vprop_enum.add
{
    /// <summary>
    /// Команда добавляет перечисление в указанную концепцию
    /// </summary>
    public class prop_enum_copy_to : IParametersFunction
    {
        /// <summary>
        /// Идентификатор перечисления
        /// </summary>
        public long iid_prop_enum { get; set; }

        /// <summary>
        /// Идентификатор концепции
        /// </summary>
        public long iid_conception { get; set; }



        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prop_enum", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
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
                return "prop_enum_copy_to";
            }
        }
    }
}