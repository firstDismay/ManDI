using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.@object.sel_ext
{
    /// <summary>
    /// Команда ввозвращает список объектов по идентификатору группы рекурсивно
    /// </summary>
    public class object_ext_by_id_group_root : IParametersFunction
    {
        /// <summary>
        /// Идентификатор корневой группы классов объектов
        /// </summary>
        public long iid_group_root { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_group_root", NpgsqlDbType.Bigint);
                Parameter.Value = iid_group_root;
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
                return "object_ext_by_id_group_root";
            }
        }
    }
}