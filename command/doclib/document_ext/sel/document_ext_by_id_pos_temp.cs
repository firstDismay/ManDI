using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ManDI.command.doclib.document_ext.sel
{
    /// <summary>
    /// Команда возвращает расширенные документы  по идентификатору шаблона позиции
    public class document_ext_by_id_pos_temp : IParametersFunction
    {
        /// <summary>
        /// Идентификатор экземпляра сущности
        /// </summary>
        public long iid_entity_instance { get; set; }

        /// <summary>
        /// Включение позиций
        /// </summary>
        public bool position_on { get; set; }

        /// <summary>
        /// Включение объектов
        /// </summary>
        public bool object_on { get; set; }

        /// <summary>
        /// Включение рекурсии
        /// </summary>
        public bool recursive_on { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity_instance;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("position_on", NpgsqlDbType.Boolean);
                Parameter.Value = position_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("object_on", NpgsqlDbType.Boolean);
                Parameter.Value = object_on;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("recursive_on", NpgsqlDbType.Boolean);
                Parameter.Value = recursive_on;
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
                return "document_ext_by_id_pos_temp";
            }
        }
    }
}