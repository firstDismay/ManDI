using static System.Net.Mime.MediaTypeNames;
using System;
namespace ManDI.composite.entities.vlog
{
    /// <summary>
    /// Композитный тип записи журнала
    /// </summary>
    public class vlog
    {
        public long id { get; set; }
        public long id_conception { get; set; }
        public string user_current { get; set; }
        public DateTime timestamp { get; set; }
        public long id_category { get; set; }
        public string name_category { get; set; }
        public int level_category { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string class_body { get; set; }
        public string body { get; set; }
        public string user_author { get; set; }
        public DateTime datetime { get; set; }
    }
}