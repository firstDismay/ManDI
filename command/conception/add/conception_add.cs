using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.conception.add
{
    /// <summary>
    /// Команда добавляет новую концепцию
    public class conception_add : IParametersFunction
    {
        /// <summary>
        /// Наименование концепции
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание концепции
        /// </summary>
        public string idesc { get; set; }


        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Text);
                Parameter.Value = idesc;
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
                return "conception_add";
            }
        }
    }
}
