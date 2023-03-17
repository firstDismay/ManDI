using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда добавляет большое значение пользовательского свойства класса
    /// </summary>
    public class class_prop_user_small_val_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

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
        public string ival_varchar { get; set; }

        /// <summary>
        /// Значение свойства класса типа integer
        /// </summary>
        public int ival_int { get; set; }

        /// <summary>
        /// Значение свойства класса типа numeric
        /// </summary>
        public decimal ival_numeric { get; set; }

        /// <summary>
        /// Значение свойства класса типа real
        /// </summary>
        public float ival_real { get; set; }

        /// <summary>
        /// Значение свойства класса типа double
        /// </summary>
        public float ival_double { get; set; }

        /// <summary>
        /// Значение свойства класса типа money
        /// </summary>
        public decimal ival_money { get; set; }

        /// <summary>
        /// Значение свойства класса типа boolean
        /// </summary>
        public bool ival_boolean { get; set; }

        /// <summary>
        /// Значение свойства класса типа date
        /// </summary>
        public DateTime ival_date { get; set; }

        /// <summary>
        /// Значение свойства класса типа time
        /// </summary>
        public DateTime ival_time { get; set; }

        /// <summary>
        /// Значение свойства класса типа interval
        /// </summary>
        public TimeSpan ival_interval { get; set; }

        /// <summary>
        /// Значение свойства класса типа timestamp
        /// </summary>
        public DateTime ival_timestamp { get; set; }

        /// <summary>
        /// Значение свойства класса типа bigint
        /// </summary>
        public long ival_bigint { get; set; }
        
        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
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
                Parameter.Value = ival_varchar;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_int", NpgsqlDbType.Integer);
                Parameter.Value = ival_int;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_numeric", NpgsqlDbType.Numeric);
                Parameter.Value = ival_numeric;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_real", NpgsqlDbType.Real);
                Parameter.Value = ival_real;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_double", NpgsqlDbType.Double);
                Parameter.Value = ival_double;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_money", NpgsqlDbType.Money);
                Parameter.Value = ival_money;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_boolean", NpgsqlDbType.Boolean);
                Parameter.Value = ival_boolean;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_date", NpgsqlDbType.Date);
                Parameter.Value = ival_date;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_time", NpgsqlDbType.Time);
                Parameter.Value = ival_time;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_interval", NpgsqlDbType.Interval);
                Parameter.Value = ival_interval;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_bigint", NpgsqlDbType.Bigint);
                Parameter.Value = ival_bigint;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_timestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = ival_timestamp;
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
                return "class_prop_user_small_val_add";
            }
        }
    }
}