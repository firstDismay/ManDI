using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.position.add
{
    /// <summary>
    /// Команда выполняет копирование позиции их свойств и объектов
    /// </summary>
    public class position_copy : IParametersFunction
    {
        
        /// <summary>
        /// Идентификатор паттерна
        /// </summary>
        public long iid_pattern { get; set; }

        /// <summary>
        /// Идентификатор родительской позиции
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Ключ рекурсивного копирования
        /// </summary>
        public bool recursivecall { get; set; }

        /// <summary>
        /// Ключ копирования объектов
        /// </summary>
        public bool on_object { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pattern", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pattern;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("recursivecall", NpgsqlDbType.Boolean);
                Parameter.Value = recursivecall;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("on_object", NpgsqlDbType.Boolean);
                Parameter.Value = on_object;
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
                return "position_copy";
            }
        }
    }
}
