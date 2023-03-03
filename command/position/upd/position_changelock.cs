using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.position.upd
{
    /// <summary>
    /// Команда изменяет параметры блокировки удаления/переноса позиции, каскадный метод
    /// </summary>
    public class position_changelock : IParametersFunction
    {
        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid { get; set; }
        
        /// <summary>
        /// Ключ блокировки
        /// </summary>
        public bool onlock { get; set; }

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

                Parameter = new NpgsqlParameter("onlock", NpgsqlDbType.Boolean);
                Parameter.Value = onlock;
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
                return "position_changelock";
            }
        }
    }
}
