using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects.upd
{
    /// <summary>
    /// Команда перемещает объект полностью или частично с разделением
    /// </summary>
    public class object_move : IParametersFunction
    {

        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Идентификатор целевой позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Количество перемещаемых объектов в текущем правиле пересчета
        /// </summary>
        public decimal icquantity { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_object", NpgsqlDbType.Bigint);
                Parameter.Value = iid_object;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
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
        public string NameFunction
        {
            get
            {
                return "object_move";
            }
        }
    }
}
