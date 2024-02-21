using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.position.properties.upd
{
    /// <summary>
    /// Команда добавляет значение BIG пользовательского свойства позиции
    /// </summary>
    public class position_prop_user_big_val_set : IParametersFunction
    {

        /// <summary>
        /// Идентификатор позиции
        /// </summary>
        public long iid_position { get; set; }

        /// <summary>
        /// Идентификатор свойства шаблона позиции
        /// </summary>
        public long iid_pos_temp_prop { get; set; }

        /// <summary>
        ///  Идентификатор значения типа text
        /// </summary>
        public string? ival_text { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа bytea
        /// </summary>
        public byte[]? ival_bytea { get; set; } = null;

        /// <summary>
        ///  Идентификатор значения типа json
        /// </summary>
        public string ival_json { get; set; }

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();

                Parameter = new NpgsqlParameter("iid_position", NpgsqlDbType.Bigint);
                Parameter.Value = iid_position;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_pos_temp_prop", NpgsqlDbType.Bigint);
                Parameter.Value = iid_pos_temp_prop;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_text", NpgsqlDbType.Text);
                Parameter.Value = ival_text != null ? ival_text : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_bytea", NpgsqlDbType.Bytea);
                Parameter.Value = ival_bytea != null ? ival_bytea : DBNull.Value;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ival_json", NpgsqlDbType.Json);
                Parameter.Value = ival_json != null ? ival_json : DBNull.Value;
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
                return "position_prop_user_big_val_set";
            }
        }

        public string? Condition { get; set; }
    }
}
