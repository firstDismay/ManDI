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
    /// Команда ввозвращает список объектов по идентификатору группы рекурсивно
    /// </summary>
    public class object_by_id_group : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы классов объектов
        /// </summary>
        public long iid_group { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_group", NpgsqlDbType.Bigint);
                Parameter.Value = iid_group;
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
                return "object_by_id_group";
            }
        }
    }
}