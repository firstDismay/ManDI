
namespace ManDI.composite.errors
{
    /// <summary>
    /// Квантовый класс для возврата результатов групповых операций приведения объектов
    /// </summary>
    public class error_object_add
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public error_object_add() { }

        /// <summary>
        /// Полный конструктор класса для возврата данных существующих записей через строку таблицы 
        /// </summary>
        public error_object_add(System.Data.DataRow row) : this()
        {
            if (row.Table.TableName == "errarg_object_add")
            {
                err_id = (Int32)row["err_id"];
                errdesc = (String)row["errdesc"];

                class_id = (Int64)row["class_id"];
                class_name = (String)row["class_name"];

                object_id = (Int64)row["object_id"];
                object_name = (String)row["object_name"];

                action_id = (Int32)row["action_id"];
                action_desc = (String)row["action_desc"];
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Format("Наименование входной таблицы '{0}' не соответствует ограничениям конструктора!", row.Table.TableName));
            }
        }

        /// <summary>
        /// Идентификатор ошибки
        /// </summary>
        public Int32 err_id { get; set; }

        /// <summary>
        /// Описание ошибки
        /// </summary>
        public String errdesc { get; set; }

        /// <summary>
        /// Идентификатор класса
        /// </summary>
        public Int64 class_id { get; set; }

        /// <summary>
        /// Наименование класса
        /// </summary>
        public String class_name { get; set; }

        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        public Int64 object_id { get; set; }

        /// <summary>
        /// Наименование объекта
        /// </summary>
        public String object_name { get; set; }


        /// <summary>
        /// Идентификатор действия
        /// </summary>
        public Int32 action_id { get; set; }

        /// <summary>
        /// Описание дейсвтвия
        /// </summary>
        public String action_desc { get; set; }
    }
}
