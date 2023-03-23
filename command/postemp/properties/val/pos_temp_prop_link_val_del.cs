using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Principal;

namespace ManDI.command.postemp.properties.val
{
    /// <summary>
    /// Команда удаляет значение свойства типа ссылка по идентификатору свойства
    /// </summary>
    public class pos_temp_prop_link_val_del : IParametersFunction
    {
        /// <summary>
        /// Идентификатор свойства шаблона позиции 
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
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
                return "pos_temp_prop_link_val_del";
            }
        }
    }
}