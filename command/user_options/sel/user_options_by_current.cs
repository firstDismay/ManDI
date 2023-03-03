using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.user_options.sel
{
    /// <summary>
    /// Команда возвращает индивидуальные предпочтения пользователя, хранимые в БД
    /// </summary>
    public class user_options_by_current : IParametersFunction
    {
        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

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
                return "user_options_by_current";
            }
        }
    }
}
