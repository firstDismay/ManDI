using Npgsql;

namespace ManDI.command.properties.vprop_enum.sel
{
    /// <summary>
    /// Команда возвращает список областей применения перечислений
    /// </summary>
    public class prop_enum_use_area_by_all : IParametersFunction
    {

        /// <summary>
        /// Список параметров функции
        /// </summary>
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                NpgsqlParameter Parameter;
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
                return "prop_enum_use_area_by_all";
            }
        }

        public string? Condition { get; set; }
    }
}