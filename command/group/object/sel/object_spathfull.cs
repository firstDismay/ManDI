using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.objects.sel
{
    /// <summary>
    /// Команда Функция возвращает строковое представление полного пути объекта
    /// </summary>
    public class object_spathfull : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

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
                return "object_spathfull";
            }
        }
    }
}
