using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.postemp.properties.val
{
    /// <summary>
    /// Команда добавляет значение SMALL пользовательского свойства класса
    /// </summary>
    public class pos_temp_prop_user_small_val_set : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        /// Минимальное значение свойства класса
        /// </summary>
        public decimal imin_val { get; set; }

        /// <summary>
        /// Признак активности контроля минимального значения свойства класса
        /// </summary>
        public bool imin_on { get; set; }

        /// <summary>
        /// Максимальное значение свойства класса
        /// </summary>
        public decimal imax_val { get; set; }

        /// <summary>
        /// Признак активности контроля максимального значения свойства класса
        /// </summary>
        public bool imax_on { get; set; }

        /// <summary>
        /// Точность округления
        /// </summary>
        public int iround { get; set; }

        /// <summary>
        /// Признак активности округления
        /// </summary>
        public bool iround_on { get; set; }

        /// <summary>
        /// Строковое значение свойства класса
        /// </summary>
        public string? ival_varchar { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа integer
        /// </summary>
        public int? ival_int { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа numeric
        /// </summary>
        public decimal? ival_numeric { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа real
        /// </summary>
        public float? ival_real { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа double
        /// </summary>
        public float? ival_double { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа money
        /// </summary>
        public decimal? ival_money { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа boolean
        /// </summary>
        public bool? ival_boolean { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа date
        /// </summary>
        public DateTime? ival_date { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа time
        /// </summary>
        public DateTime? ival_time { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа interval
        /// </summary>
        public TimeSpan? ival_interval { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа timestamp
        /// </summary>
        public DateTime? ival_timestamp { get; set; } = null;

        /// <summary>
        /// Значение свойства класса типа bigint
        /// </summary>
        public long? ival_bigint { get; set; } = null;

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imin_val", NpgsqlDbType.Numeric);
                Parameter.Value = imin_val;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imin_on", NpgsqlDbType.Boolean);
                Parameter.Value = imin_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imax_val", NpgsqlDbType.Numeric);
                Parameter.Value = imax_val;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imax_on", NpgsqlDbType.Boolean);
                Parameter.Value = imin_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iround", NpgsqlDbType.Integer);
                Parameter.Value = iround;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iround_on", NpgsqlDbType.Boolean);
                Parameter.Value = iround_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_varchar", NpgsqlDbType.Varchar);
                Parameter.Value = ival_varchar != null ? ival_varchar : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_int", NpgsqlDbType.Integer);
                Parameter.Value = ival_int != null ? ival_int : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_numeric", NpgsqlDbType.Numeric);
                Parameter.Value = ival_numeric != null ? ival_numeric : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_real", NpgsqlDbType.Real);
                Parameter.Value = ival_real != null ? ival_real : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_double", NpgsqlDbType.Double);
                Parameter.Value = ival_double != null ? ival_double : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_money", NpgsqlDbType.Money);
                Parameter.Value = ival_money != null ? ival_money : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_boolean", NpgsqlDbType.Boolean);
                Parameter.Value = ival_boolean != null ? ival_boolean : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_date", NpgsqlDbType.Date);
                Parameter.Value = ival_date != null ? ival_date : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_time", NpgsqlDbType.Time);
                Parameter.Value = ival_time != null ? ival_time : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_interval", NpgsqlDbType.Interval);
                Parameter.Value = ival_interval != null ? ival_interval : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_timestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = ival_timestamp != null ? ival_timestamp : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_bigint", NpgsqlDbType.Bigint);
                Parameter.Value = ival_bigint != null ? ival_bigint : DBNull.Value;
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
                return "pos_temp_prop_user_small_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}