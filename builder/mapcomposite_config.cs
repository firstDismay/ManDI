using Npgsql;
using ManDI.composite.entities.common;
using ManDI.composite.entities.conception;
using ManDI.composite.entities.vclass;
using ManDI.composite.entities.vclass.property;
using ManDI.composite.entities.vpos_temp;
using ManDI.composite.entities.vpos_temp.property;
using ManDI.composite.entities.vposition;
using ManDI.composite.entities.vposition.property;
using ManDI.composite.entities.vobject;
using ManDI.composite.entities.vobject.property;
using System;


namespace ManDI
{
    /// <summary>
    /// Конфигурация используемых композитных типов
    /// </summary>
    public partial class ManDiBuilder
    {
        /// <summary>
        /// Метод сопоставления композитных типов
        /// </summary>
        private void MapComposite(NpgsqlDataSourceBuilder dataSourceBuilder)
        {
            dataSourceBuilder.MapComposite<vconception>("vconception");

            dataSourceBuilder.MapComposite<path>("bpd.path");
            dataSourceBuilder.MapComposite<path2>("bpd.path2");
            dataSourceBuilder.MapComposite<path3>("bpd.path3");
            dataSourceBuilder.MapComposite<path4>("bpd.path4");

            dataSourceBuilder.MapComposite<vgroup>("vgroup");
            dataSourceBuilder.MapComposite<vclass>("vclass");
            dataSourceBuilder.MapComposite<vclass_ext>("vclass_ext");
            dataSourceBuilder.MapComposite<vclass_prop>("vclass_prop");
            dataSourceBuilder.MapComposite<vclass_prop_enum_val>("vclass_prop_enum_val");
            dataSourceBuilder.MapComposite<vclass_prop_link_val>("vclass_prop_link_val");
            dataSourceBuilder.MapComposite<vclass_prop_object_val>("vclass_prop_object_val");
            dataSourceBuilder.MapComposite<vclass_prop_user_big_val>("vclass_prop_user_big_val");
            dataSourceBuilder.MapComposite<vclass_prop_user_small_val>("vclass_prop_user_small_val");

            dataSourceBuilder.MapComposite<vpos_temp>("vpos_temp");
            dataSourceBuilder.MapComposite<vpos_temp_prop>("vpos_temp_prop");
            dataSourceBuilder.MapComposite<vpos_temp_prop_enum_val>("vpos_temp_prop_enum_val");
            dataSourceBuilder.MapComposite<vpos_temp_prop_link_val>("vpos_temp_prop_link_val");
            dataSourceBuilder.MapComposite<vpos_temp_prop_object_val>("vpos_temp_prop_object_val");
            dataSourceBuilder.MapComposite<vpos_temp_prop_user_big_val>("vpos_temp_prop_user_big_val");
            dataSourceBuilder.MapComposite<vpos_temp_prop_user_small_val>("vpos_temp_prop_user_small_val");

            dataSourceBuilder.MapComposite<vposition>("vposition");
            dataSourceBuilder.MapComposite<vposition_prop>("vposition_prop");
            dataSourceBuilder.MapComposite<vposition_prop_enum_val>("vposition_prop_enum_val");
            dataSourceBuilder.MapComposite<vposition_prop_link_val>("vposition_prop_link_val");
            dataSourceBuilder.MapComposite<vposition_prop_object_val>("vposition_prop_object_val");
            dataSourceBuilder.MapComposite<vposition_prop_user_big_val>("vposition_prop_user_big_val");
            dataSourceBuilder.MapComposite<vposition_prop_user_small_val>("vposition_prop_user_small_val");

            dataSourceBuilder.MapComposite<vobject_general>("vobject_general");
            dataSourceBuilder.MapComposite<vobject_general_ext>("vobject_general_ext");
            dataSourceBuilder.MapComposite<vobject_prop>("vobject_prop");
            dataSourceBuilder.MapComposite<vobject_prop_enum_val>("vobject_prop_enum_val");
            dataSourceBuilder.MapComposite<vobject_prop_link_val>("vobject_prop_link_val");
            dataSourceBuilder.MapComposite<vobject_prop_object_val>("vobject_prop_object_val");
            dataSourceBuilder.MapComposite<vobject_prop_user_big_val>("vobject_prop_user_big_val");
            dataSourceBuilder.MapComposite<vobject_prop_user_small_val>("vobject_prop_user_small_val");
        }
    }
}