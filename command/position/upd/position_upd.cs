using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.upd
{
    /// <summary>
    /// Команда обновляет позицию
    /// </summary>
    public class position_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Наименование позиции
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание позиции
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Ключ сортировки
        /// </summary>
        public int isort { get; set; }

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

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("isort", NpgsqlDbType.Integer);
                Parameter.Value = isort;
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
                return "position_upd";
            }
        }
    }
}
