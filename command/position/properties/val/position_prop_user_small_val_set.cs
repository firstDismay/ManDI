﻿using Npgsql;
using NpgsqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManDI.command.position.properties.upd
{
    /// <summary>
    /// Команда добавляет значение BIG пользовательского свойства позиции
    /// </summary>
    public class position_prop_user_small_val_set : IParametersFunction
    {

        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        ///  Идентификатор значения типа text
        /// </summary>
        public string? ival_varchar { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа bytea
        /// </summary>
        public Int32? ival_int { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public Decimal? ival_numeric { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public float? ival_real { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public Double? ival_double { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public Decimal? ival_money { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public bool? ival_boolean { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public DateOnly? ival_date { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public DateTime? ival_time { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public TimeOnly? ival_interval { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public Date? ival_timestamp { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
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

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
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
                return "position_prop_user_small_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}
