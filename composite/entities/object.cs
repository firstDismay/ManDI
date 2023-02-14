using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace ManDI.composite.entities
{
    /// <summary>
    /// Класс обобщенного представления объектов
    /// </summary>
    public partial class object_general 
    {
        #region КОНСТРУКТОРЫ КЛАССА

        /// <summary>
        /// Закрытый конструктор по умолчанию
        /// </summary>
        protected object_general()
        {
            on_change = false;
        }
        /// <summary>
        /// Полный конструктор класса для возврата данных существующих записей через строку таблицы 
        /// </summary>
        public object_general(System.Data.DataRow row) : this()
        {
            switch (row.Table.TableName)
            {
                case "vobject_general":
                    viewname = row.Table.TableName;
                    id = (Int64)row["id"];
                    name = (String)row["name"];
                    name_len = row.Table.Columns["name"].MaxLength;
                    id_conception = (Int64)row["id_conception"];
                    id_position = (Int64)row["id_position"];
                    id_position_root = (Int64)row["id_position_root"];
                    id_group = (Int64)row["id_group"];
                    id_group_root = (Int64)row["id_group_root"];
                    id_class = (Int64)row["id_class"];
                    id_class_root = (Int64)row["id_class_root"];
                    timestamp_class = Convert.ToDateTime(row["timestamp_class"]);
                    barcode_unit = (Int64)row["barcode_unit"];
                    id_unit_conversion_rule = (Int32)row["id_unit_conversion_rule"];
                    bquantity = (Decimal)row["bquantity"];
                    bunit = (String)row["bunit"];
                    mc = (Decimal)row["mc"];
                    cquantity = (Decimal)row["cquantity"];
                    cunit = (String)row["cunit"];
                    on_technical = (Boolean)row["on_technical"];
                    on_commercial = (Boolean)row["on_commercial"];
                    on_accounting = (Boolean)row["on_accounting"];
                    timestamp = Convert.ToDateTime(row["timestamp"]);
                    on_freeze = (Boolean)row["on_freeze"];
                    id_object_carrier = (Int64)row["id_object_carrier"];
                    is_inside = (Boolean)row["is_inside"];
                    desc = (String)row["desc"];
                    id_class_prop_object_carrier = (Int64)row["id_class_prop_object_carrier"];
                    id_unit = (Int32)row["id_unit"];

                    has_user_property = (Boolean)row["has_user_property"];
                    has_enum_property = (Boolean)row["has_enum_property"];
                    has_object_property = (Boolean)row["has_object_property"];
                    has_link_property = (Boolean)row["has_link_property"];

                    in_recycle = (Boolean)row["in_recycle"];

                    name_format = (String)row["name_format"];
                    quantity_show = (Boolean)row["quantity_show"];

                    id_pos_temp_prop = (Int64)row["id_pos_temp_prop"];
                    path = (String)row["path"];
                    round = (Int32)row["round"];
                    break;
                
                case "vobject_general_ext":
                    viewname = row.Table.TableName;
                    id = (Int64)row["id"];
                    name = (String)row["name"];
                    name_len = row.Table.Columns["name"].MaxLength;
                    id_conception = (Int64)row["id_conception"];
                    id_position = (Int64)row["id_position"];
                    id_position_root = (Int64)row["id_position_root"];
                    id_group = (Int64)row["id_group"];
                    id_group_root = (Int64)row["id_group_root"];
                    id_class = (Int64)row["id_class"];
                    id_class_root = (Int64)row["id_class_root"];
                    timestamp_class = Convert.ToDateTime(row["timestamp_class"]);
                    barcode_unit = (Int64)row["barcode_unit"];
                    id_unit_conversion_rule = (Int32)row["id_unit_conversion_rule"];
                    bquantity = (Decimal)row["bquantity"];
                    bunit = (String)row["bunit"];
                    mc = (Decimal)row["mc"];
                    cquantity = (Decimal)row["cquantity"];
                    cunit = (String)row["cunit"];
                    on_technical = (Boolean)row["on_technical"];
                    on_commercial = (Boolean)row["on_commercial"];
                    on_accounting = (Boolean)row["on_accounting"];
                    timestamp = Convert.ToDateTime(row["timestamp"]);
                    on_freeze = (Boolean)row["on_freeze"];
                    id_object_carrier = (Int64)row["id_object_carrier"];
                    is_inside = (Boolean)row["is_inside"];
                    desc = (String)row["desc"];
                    id_class_prop_object_carrier = (Int64)row["id_class_prop_object_carrier"];
                    id_unit = (Int32)row["id_unit"];

                    has_user_property = (Boolean)row["has_user_property"];
                    has_enum_property = (Boolean)row["has_enum_property"];
                    has_object_property = (Boolean)row["has_object_property"];
                    has_link_property = (Boolean)row["has_link_property"];

                    in_recycle = (Boolean)row["in_recycle"];

                    name_format = (String)row["name_format"];
                    quantity_show = (Boolean)row["quantity_show"];

                    id_pos_temp_prop = (Int64)row["id_pos_temp_prop"];
                    path = (String)row["path"];
                    round = (Int32)row["round"];

                    if (!DBNull.Value.Equals(row["property_list"]))
                    {
                        property_list = (IEnumerable<pg_vobject_prop>)row["property_list"];
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(String.Format("Наименование входной таблицы '{0}' не соответствует ограничениям конструктора!", row.Table.TableName));
            }
        }
        #endregion

        #region СВОЙСТВА КЛАССА

        private Int64 id = 0;
        private String name;
        private Int32 name_len;
        private Int64 id_conception;
        private Int64 id_position;
        private Int64 id_position_root;
        private Int64 id_group;
        private Int64 id_group_root;
        private Int64 id_class;
        private Int64 id_class_root;
        private DateTime timestamp_class;
        private Int64 barcode_unit;
        private Int32 id_unit;
        private Int32 id_unit_conversion_rule;
        private Decimal bquantity;
        private String bunit;
        private Decimal mc;
        private Decimal cquantity;
        private String cunit;
        private Boolean on_technical;
        private Boolean on_commercial;
        private Boolean on_accounting;
        private DateTime timestamp;
        private Boolean on_freeze;
        private Int64 id_object_carrier;
        private Int64 id_class_prop_object_carrier;
        private Int64 id_pos_temp_prop;
        private Boolean is_inside;
        private String desc;
        private String path;
        private Int32 round;

        private Boolean has_user_property;
        private Boolean has_enum_property;
        private Boolean has_object_property;
        private Boolean has_link_property;

        private String name_format;
        private Boolean quantity_show;
        private Boolean in_recycle;

        IEnumerable<pg_vobject_prop> property_list;

        private String viewname;
        /// <summary>
        /// Имя представления базы ассистента, содержащей запись об объекте
        /// </summary>
        public String Viewname { get => viewname; }


        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public Int64 Id { get => id; }

        /// <summary>
        /// Идентификатор концепции объекта
        /// </summary>
        public Int64 Id_conception { get => id_conception; }

        /// <summary>
        /// Идентификатор позиции объекта
        /// </summary>
        public Int64 Id_position { get => id_position; }

        /// <summary>
        /// Идентификатор корневой позиции объекта
        /// </summary>
        public Int64 Id_position_root { get => id_position_root; }

        /// <summary>
        /// Идентификатор группы класса объекта
        /// </summary>
        public Int64 Id_group { get => id_group; }

        /// <summary>
        /// Идентификатор корневой группы класса объекта
        /// </summary>
        public Int64 Id_group_root { get => id_group_root; }

        /// <summary>
        /// Идентификатор класса объекта
        /// </summary>
        public Int64 Id_class { get => id_class; }

        /// <summary>
        /// Идентификатор корневого класса объекта
        /// </summary>
        public Int64 Id_class_root { get => id_class_root;}

       
        /// <summary>
        /// Уникальный штрих-код объекта
        /// </summary>
        public Int64 Barcode_unit { get => barcode_unit; }

        /// <summary>
        /// Признак встроенного объекта
        /// </summary>
        public Boolean Is_inside { get => is_inside; }
        
        
        /// <summary>
        /// Признак установленного технического расширения объекта
        /// </summary>
        public Boolean Оn_technical { get => on_technical; }

        /// <summary>
        /// Признак установленного коммерчесого расширения объекта
        /// </summary>
        public Boolean On_commercial { get => on_commercial; }

        /// <summary>
        /// Признак установленного бухгалтерского расширения объекта
        /// </summary>
        public Boolean Оn_accounting { get => on_accounting; }

        /// <summary>
        /// Признак заблокированного объекта
        /// </summary>
        public Boolean Оn_freeze { get => on_freeze; }

        /// <summary>
        /// Штамп времени объекта
        /// </summary>
        public DateTime Timestamp { get => timestamp; }

        /// <summary>
        /// Штамп времени класса объекта
        /// </summary>
        public DateTime Timestamp_class { get => timestamp_class; }

        /// <summary>
        /// Наименование класса объекта
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

        }

        /// <summary>
        /// Описание класса объекта
        /// </summary>
        public string Desc
        {
            get
            {
                return desc;
            }
        }

        /// <summary>
        /// Признак наличия у объекта пользовательских свойств
        /// </summary>
        public Boolean Has_User_property { get => has_user_property; }
        /// <summary>
        /// Признак наличия у объекта свойств перечислений
        /// </summary>
        public Boolean Has_Enum_property { get => has_enum_property; }

        /// <summary>
        /// Признак наличия у объекта объектных свойств
        /// </summary>
        public Boolean Has_Object_property { get => has_object_property; }

        /// <summary>
        /// Признак наличия у объекта свойств-ссылок
        /// </summary>
        public Boolean Has_link_property { get => has_link_property; }

        
        /// <summary>
        /// Признак удаленной сущности
        /// </summary>
        public Boolean In_recycle { get => in_recycle; }


        /// <summary>
        /// Формат наименования объектов класса
        /// none имя объекта равно имени класса
        /// </summary>
        public String Name_format { get => name_format; }


        /// <summary>
        /// Признак необходимости отобажения колличества в имени объекта
        /// </summary>
        public Boolean Quantity_show { get => quantity_show; }

        
        private Boolean on_change;
        /// <summary>
        /// Свойство определяющее потребность в обновлении данных БД
        /// </summary>
        public Boolean On_change
        {
            get
            {
                return on_change;
            }
        }
        
        /// <summary>
        /// Ключ объекта
        /// </summary>
        public string ImageKey
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("object_us");
                return sb.ToString();
            }
        }


        /// <summary>
        /// Ключ выделенного объекта
        /// </summary>
        public string SelectedImageKey
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("object_s");
                return sb.ToString();
            }
        }

        /// <summary>
        /// Лист свойств объекта
        /// </summary>
        public IEnumerable<pg_vobject_prop> PropertyList
        {
            get
            {
                return property_list;
            }
        }

        #endregion
    }
}
