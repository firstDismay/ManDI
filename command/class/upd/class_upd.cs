using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.classes.upd
{
    /// <summary>
    /// Команда изменяет активное представление класса
    /// </summary>
    public class class_upd : IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public long iid { get; set; }
                
        /// <summary>
        /// Наименование класса
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание класса
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Признак включенного класса
        /// </summary>
        public bool ion { get; set; }

        /// <summary>
        /// Признак расширяемого класса
        /// </summary>
        public bool ion_extensible { get; set; }

        /// <summary>
        /// Признак абстрактного класса
        /// </summary>
        public bool ion_abstraction { get; set; }

        /// <summary>
        /// Идентификатор измеряемой величины
        /// </summary>
        public int iid_unit { get; set; }

        /// <summary>
        /// Идентификатор правила пересчета измеряемой величины
        /// </summary>
        public int iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Штрих-код производителя
        /// </summary>
        public int ibarcode_manufacturer { get; set; }

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

                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_extensible", NpgsqlDbType.Boolean);
                Parameter.Value = ion_extensible;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_abstraction", NpgsqlDbType.Boolean);
                Parameter.Value = ion_abstraction;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit_conversion_rule;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ibarcode_manufacturer", NpgsqlDbType.Bigint);
                Parameter.Value = ibarcode_manufacturer;
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
                return "class_upd";
            }
        }
    }
}