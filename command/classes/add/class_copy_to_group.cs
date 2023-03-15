using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.classes.add
{
    /// <summary>
    /// Команда копирует класс в новое указанное расположение группы
    /// </summary>
    public class class_copy_to_group : IParametersFunction
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
        /// Признак копирования вложенных классов
        /// </summary>
        public bool on_nested { get; set; }
        
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

                Parameter = new NpgsqlParameter("on_nested", NpgsqlDbType.Boolean);
                Parameter.Value = on_nested;
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
                return "class_copy_to_group";
            }
        }
    }
}
