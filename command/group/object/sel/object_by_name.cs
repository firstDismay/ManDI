using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.group.@object.sel
{
    /// <summary>
    /// Команда возвращает список объектов по идентификатору концепции и маске имени
    /// </summary>
    public class object_by_name : IParametersFunction
    {
        /// <summary>
        /// Маска имени объекта
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Идентификатор концепции объекта
        /// </summary>
        public long iid_conception { get; set; }

        /// <summary>
        /// Признак необходимости поиска встроенных объектов
        /// </summary>
        public bool on_inside { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_conception", NpgsqlDbType.Bigint);
                Parameter.Value = iid_conception;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("on_inside", NpgsqlDbType.Boolean);
                Parameter.Value = on_inside;
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
                return "object_by_name";
            }
        }
    }
}