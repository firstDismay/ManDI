using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.position.sel
{
    /// <summary>
    /// Команда определяет возможность вложения в указанную позицию указанного шаблона
    /// </summary>
    public class position_nested_limit_control : IParametersFunction
    {
        /// <summary>
        /// Идентификатор родительской позиции
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Идентификатор  шаблона позиции
        /// </summary>
        public long iid_pos_temp { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp;
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
                return "position_nested_limit_control";
            }
        }
    }
}
