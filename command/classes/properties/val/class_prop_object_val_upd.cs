using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда обновляет данные значения объектного свойства
    /// </summary>
    public class class_prop_object_val_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

        /// <summary>
        /// Идентификатор класса значения свойства
        /// </summary>
        public long iid_class_val { get; set; }

        /// <summary>
        /// Минимальное количество объектов класса в базовых единицах измерения
        /// </summary>
        public decimal ibquantity_min { get; set; }

        /// <summary>
        /// Максимальное количество объектов класса в базовых единицах измерения
        /// </summary>
        public decimal ibquantity_max { get; set; }

        /// <summary>
        /// Режим встраивания
        /// </summary>
        public int iembed_mode { get; set; }

        /// <summary>
        /// Признак встраивания единичных объектов, количеством в одну базовую единицу
        /// </summary>
        public int iembed_single { get; set; }

        /// <summary>
        /// Идентификатор вещественного класса встраиваемых объектов
        /// </summary>
        public long iembed_class_real_id { get; set; }

        /// <summary>
        /// Идентификатор правила пересчета
        /// </summary>
        public int iid_unit_conversion_rule { get; set; }

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

                Parameter = new NpgsqlParameter("iid_class_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_val;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ibquantity_min", NpgsqlDbType.Numeric);
                Parameter.Value = ibquantity_min;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ibquantity_max", NpgsqlDbType.Numeric);
                Parameter.Value = ibquantity_max;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iembed_mode", NpgsqlDbType.Integer);
                Parameter.Value = iembed_mode;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iembed_single", NpgsqlDbType.Boolean);
                Parameter.Value = iembed_single;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iembed_class_real_id", NpgsqlDbType.Bigint);
                Parameter.Value = iembed_class_real_id;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit_conversion_rule;
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
                return "class_prop_object_val_upd";
            }
        }
    }
}