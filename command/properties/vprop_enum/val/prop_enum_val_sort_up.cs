using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;

namespace ManDI.command.properties.vprop_enum.val
{
    /// <summary>
    /// Команда перемещает элемент перечисления на одну позицию вверх в списке элементов
    /// </summary>
    public class prop_enum_val_sort_up : IParametersFunction
    {
        /// <summary>
        /// Идентификатор элемента перечисления
        /// </summary>
        public long iid_prop_enum_val { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_prop_enum_val", NpgsqlDbType.Bigint);
                Parameter.Value = iid_prop_enum_val;
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
                return "prop_enum_val_sort_up";
            }
        }
    }
}