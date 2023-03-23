using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace ManDI.command.doclib.document_ext
        {
    /// <summary>
    /// Команда возвращает расширенные документы  по идентификатору свойства шаблона позиции
    public class document_ext_by_id_pos_temp_prop : IParametersFunction
    {
        /// <summary>
        /// Идентификатор экземпляра сущности
        /// </summary>
        public long iid_entity_instance { get; set; }


        /// <summary>
        /// Идентификатор экземпляра дочерней сущности
        /// </summary>
        public long iid_sub_entity_instance { get; set; }

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

                Parameter = new NpgsqlParameter("iid_sub_entity_instance", NpgsqlDbType.Bigint);
                Parameter.Value = iid_sub_entity_instance;
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
                return "document_ext_by_id_pos_temp_prop";
            }
        }
    }
}