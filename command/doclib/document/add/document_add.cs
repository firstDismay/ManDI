using Npgsql;
using NpgsqlTypes;

namespace ManDI.command.doclib.document.add
{
    /// <summary>
    /// Команда добавляет документ в библиотеку документов
    public class document_add : IParametersFunction
    {
        /// <summary>
        /// Идентификатор категории документа
        /// </summary>
        public long iid_category { get; set; }

        /// <summary>
        /// Идентификатор родителя
        /// </summary>
        public long iid_parent { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string iname { get; set; }

        /// <summary>
        /// Описание группы
        /// </summary>
        public string idesc { get; set; }

        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string iregnum { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime iregdate { get; set; }

        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public long iid_entity { get; set; }

        /// <summary>
        /// Идентификатор экземпляра сущности
        /// </summary>
        public long iid_entity_instance { get; set; }

        /// <summary>
        ///  Идентификатор экземпляра дочерней сущности
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

                Parameter = new NpgsqlParameter("iid_category", NpgsqlDbType.Bigint);
                Parameter.Value = iid_category;
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

                Parameter = new NpgsqlParameter("iregnum", NpgsqlDbType.Varchar);
                Parameter.Value = iregnum;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iregdate", NpgsqlDbType.Timestamp);
                Parameter.Value = iregdate;
                ListParameter.Add(Parameter);

                Parameter = new NpgsqlParameter("iid_entity", NpgsqlDbType.Bigint);
                Parameter.Value = iid_entity;
                ListParameter.Add(Parameter);

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
                return "document_add";
            }
        }
    }
}