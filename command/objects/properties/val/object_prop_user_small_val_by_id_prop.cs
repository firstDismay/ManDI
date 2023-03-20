using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace ManDI.command.classes.properties.val
{
    /// <summary>
    /// Команда возвращает данные малого значения пользовательского свойства по идентификатору свойства объекта
    /// </summary>
    public class object_prop_user_small_val_by_id_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public long iid_object { get; set; }

        /// <summary>
        /// Идентификатор свойства класса
        /// </summary>
        public long iid_class_prop { get; set; }

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

                Parameter = new NpgsqlParameter("iid_class_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class_prop;
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
                return "object_prop_user_small_val_by_id_prop";
            }
        }
    }
}