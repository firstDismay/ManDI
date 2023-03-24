using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.group.del
{
    /// <summary>
    /// Команда удаляет группу
    /// </summary>
    public class group_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid", NpgsqlDbType.Bigint);
                Parameter.Value = iid;
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
                return "group_del";
            }
        }
    }
}
