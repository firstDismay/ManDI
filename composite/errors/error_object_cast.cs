namespace ManDI.composite.errors
{
    /// <summary>
    /// Композитный тип ошибки приведения объектов
    /// </summary>
    public class error_object_cast
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public error_object_cast()
        {
        }
        /// <summary>
        /// Полный конструктор класса для возврата данных существующих записей через строку таблицы 
        /// </summary>
        public error_object_cast(System.Data.DataRow row) : this()
        {
            if (row.Table.TableName == "errarg_cast")
            {
                err_id = (Int32)row["err_id"];
                errdesc = (String)row["errdesc"];
                entity_id = (Int32)row["entity_id"];
                entity_instance_id = (Int64)row["entity_instance_id"];
                entity_instance_name = (String)row["entity_instance_name"];
                action_id = (Int32)row["action_id"];
                action_desc = (String)row["action_desc"];
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Format("Наименование входной таблицы '{0}' не соответствует ограничениям конструктора!", row.Table.TableName));
            }
        }

        public int err_id { get; set; }
        public string errdesc { get; set; }
        public int entity_id { get; set; }
        public long entity_instance_id { get; set; }
        public string entity_instance_name { get; set; }
        public int action_id { get; set; }
        public string action_desc { get; set; }
    }
}