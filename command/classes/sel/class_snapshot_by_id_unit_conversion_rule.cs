using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.classes.sel
{
    /// <summary>
    /// Команда возвращает список снимков классов по идентификатору правила пересчета
    /// </summary>
    public class class_snapshot_by_id_unit_conversion_rule : IParametersFunction
    {
        /// <summary>
        /// Идентификатор правила пересчета
        /// </summary>
        public long iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Bigint);
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
                return "class_snapshot_by_id_unit_conversion_rule";
            }
        }
    }
}