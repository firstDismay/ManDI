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
    /// Команда копирует класс в новое указанное расположение с последующим удалением класса паттерна
    /// </summary>
    public class class_move_to_class : IParametersFunction
    {
        /// <summary>
        /// Идентификатор копируемого класса
        /// </summary>
        public long iid_pattern { get; set; }

        /// <summary>
        /// Идентификатор целевого класса
        /// </summary>
        public long iid_target { get; set; }
        
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

                Parameter = new NpgsqlParameter("iid_target", NpgsqlDbType.Bigint);
                Parameter.Value = iid_target;
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
                return "class_move_to_class";
            }
        }
    }
}
