using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.classes.add
{
    /// <summary>
    /// Команда копирует класс в новое указанное расположение группы
    /// </summary>
    public class class_move_to_group : IParametersFunction
    {
        /// <summary>
        /// Идентификатор копируемого класса
        /// </summary>
        public long iid_class { get; set; }

        /// <summary>
        /// Идентификатор целевого класса
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

                Parameter = new NpgsqlParameter("iid_class", NpgsqlDbType.Bigint);
                Parameter.Value = iid_class;
                ListParameter.Add(Parameter);

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
                return "class_move_to_group";
            }
        }
    }
}
