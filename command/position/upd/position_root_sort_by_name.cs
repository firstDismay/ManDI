using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.upd
{
    /// <summary>
    /// Команда изменяет сортировку корневых позиций концепций на сортировку по алфавиту
    /// </summary>
    public class position_root_sort_by_name : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  концепции
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
                return "position_root_sort_by_name";
            }
        }
    }
}
