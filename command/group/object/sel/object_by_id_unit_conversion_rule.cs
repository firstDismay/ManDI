using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.@object.sel
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору правил пересчета 
    /// </summary>
    public class object_by_id_unit_conversion_rule : IParametersFunction
    {
        /// <summary>
        /// Идентификатор правила пересчета объектов
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
                return "object_by_id_unit_conversion_rule";
            }
        }
    }
}