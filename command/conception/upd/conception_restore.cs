using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.conception.upd
{
    /// <summary>
    /// Команда восстанавливает параметры концепции, корзины, базовые правила пересчета и правила пересчета в вещественных классах
    /// <summary>
    public class conception_restore : IParametersFunction
    {
        /// <summary>
        /// Идентификатор концепции
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
                return "conception_restore";
            }
        }

        public string? Condition { get; set; }
    }
}