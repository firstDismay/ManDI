using Npgsql;
using NpgsqlTypes;
using ManDI.command;

namespace ManDI.command.classes.add
{
    /// <summary>
    /// Команда добавляет новое активное представление класса
    /// </summary>
    public class class_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор группы класса
        /// </summary>
        public long iid_group { get; set; }

        /// <summary>
        /// Идентификатор родительского класса
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Наименование класса
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание класса
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Признак включенного класса
        /// </summary>
        public bool ion { get; set; }

        /// <summary>
        /// Признак расширяемого класса
        /// </summary>
        public bool ion_extensible { get; set; }

        /// <summary>
        /// Признак абстрактного класса
        /// </summary>
        public bool ion_abstraction { get; set; }

        /// <summary>
        /// Идентификатор измеряемой величины
        /// </summary>
        public int iid_unit { get; set; }

        /// <summary>
        /// Идентификатор правила пересчета измеряемой величины
        /// </summary>
        public int iid_unit_conversion_rule { get; set; }

        /// <summary>
        /// Штрих-код производителя
        /// </summary>
        public int ibarcode_manufacturer { get; set; }

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

                Parameter = new NpgsqlParameter("iid_parent", NpgsqlDbType.Bigint);
                Parameter.Value = iid_parent;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iname", NpgsqlDbType.Varchar);
                Parameter.Value = iname;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("idesc", NpgsqlDbType.Varchar);
                Parameter.Value = idesc;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion", NpgsqlDbType.Boolean);
                Parameter.Value = ion;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_extensible", NpgsqlDbType.Boolean);
                Parameter.Value = ion_extensible;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ion_abstraction", NpgsqlDbType.Boolean);
                Parameter.Value = ion_abstraction;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_unit_conversion_rule", NpgsqlDbType.Integer);
                Parameter.Value = iid_unit_conversion_rule;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("ibarcode_manufacturer", NpgsqlDbType.Bigint);
                Parameter.Value = ibarcode_manufacturer;
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
                return "class_add";
            }
        }
    }
}