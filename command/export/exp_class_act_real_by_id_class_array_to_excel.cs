using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.export
{
    /// <summary>
    /// Команда оболочка для экспорта настраиваемого активных представления вещественных классов по массиву идентификаторов в файл Excel
    public class exp_class_act_real_by_id_class_array_to_excel : IParametersFunction
    {
        /// <summary>
        /// Массив объектов
        /// </summary>
        public long[] iclass_array { get; set; }

        /// <summary>
        /// Режим
        /// </summary>
        public long imode { get; set; }

        /// <summary>
        /// Показать количество
        /// </summary>
        public bool iquantity_show { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iclass_array", NpgsqlDbType.Bigint);
                Parameter.Value = iclass_array;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("imode", NpgsqlDbType.Integer);
                Parameter.Value = imode;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iquantity_show", NpgsqlDbType.Boolean);
                Parameter.Value = iquantity_show;
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
                return "exp_class_act_real_by_id_class_array_to_excel";
            }
        }
    }
}