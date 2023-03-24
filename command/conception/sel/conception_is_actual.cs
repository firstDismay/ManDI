using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.conception.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставляемой сущности
    /// 1 - Не найдена
    /// 2 - Не актуальна
    /// 3 - Актуальна
    /// </summary>
    public class conception_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid { get; set; }

        /// <summary>
        /// Штамп времени объекта
        /// </summary>
        public long mytimestamp { get; set; }

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

                Parameter = new NpgsqlParameter("mytimestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = mytimestamp;
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
                return "conception_is_actual";
            }
        }
    }
}