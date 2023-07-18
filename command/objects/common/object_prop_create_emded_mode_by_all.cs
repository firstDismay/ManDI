using Npgsql;

namespace ManDI.command.objects.common
{
    /// <summary>
    /// Команда возвращает список режимов встраивания объектов-значений объектных свойств при создании объектов-носителей
    /// </summary>
    public class object_prop_create_emded_mode_by_all : IParametersFunction
    {

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                List<NpgsqlParameter> ListParameter = new List<NpgsqlParameter>();
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
                return "object_prop_create_emded_mode_by_all";
            }
        }

        public string? Condition { get; set; }
    }
}
