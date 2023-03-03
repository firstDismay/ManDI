using Npgsql;
using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.user_role.sel
{
    /// <summary>
    /// Команда возвращает данные по актуальности сопоставлямой сущности
    /// </summary>
    public class user_role_user_is_actual : IParametersFunction
    {
        /// <summary>
        /// Идентификатор  позиции
        /// </summary>
        public string irole_user { get; set; }

        /// <summary>
        /// Штамп времени
        /// </summary>
        public DateTime itimestamp { get; set; }

        

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("irole_user", NpgsqlDbType.Varchar);
                Parameter.Value = irole_user;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("itimestamp", NpgsqlDbType.Timestamp);
                Parameter.Value = itimestamp;
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
                return "user_role_user_is_actual";
            }
        }
    }
}
