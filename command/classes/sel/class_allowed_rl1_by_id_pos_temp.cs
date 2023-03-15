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
    /// Команда возвращает список разрешенных активных классов на основе разрешения уровня L1 типа группа/класс на шаблон по идентификатору шаблона 
    /// </summary>
    public class class_allowed_rl1_by_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор шаблона позиции
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
                return "class_allowed_rl1_by_id_pos_temp";
            }
        }
    }
}