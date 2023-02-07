using ManDI.command.common;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects
{
    /// <summary>
    /// Команда добавляет новый объект в указанное расположение
    /// </summary>
    public class object_add: IParametersFunction
    {
        /// <summary>
        /// Идентификатор класса объекта
        /// </summary>
        public Int64 iid_class { get; set; }
        
        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public Int64 iid_position { get; set; }
        
        /// <summary>
        /// Идентификатор правила пересчета количества объектов
        /// </summary>
        public Int32 iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Количество объектов в текущем правиле пересчета
        /// </summary>
        public Decimal icquantity { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit_conversion_rule;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("icquantity", NpgsqlDbType.Numeric);
                Parameter.Value = icquantity;
                ListParameter.Add(Parameter);

                return ListParameter;
            }
        }

        /// <summary>
        /// Наименование функции API
        /// </summary>
        public String NameFunction
        {
            get
            {
                return "object_add";
            }
        }
    }
}
