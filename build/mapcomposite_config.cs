using ManDI.composite.entities.common;
using ManDI.composite.entities.conception;
using ManDI.composite.entities.document;
using ManDI.composite.entities.group;
using ManDI.composite.entities.property;
using ManDI.composite.entities.role;
using ManDI.composite.entities.rule;
using ManDI.composite.entities.unit;
using ManDI.composite.entities.vclass;
using ManDI.composite.entities.vclass.property;
using ManDI.composite.entities.vlog;
using ManDI.composite.entities.vobject;
using ManDI.composite.entities.vobject.property;
using ManDI.composite.entities.vpos_temp;
using ManDI.composite.entities.vpos_temp.property;
using ManDI.composite.entities.vposition;
using ManDI.composite.entities.vposition.property;
using ManDI.composite.errors;
using Npgsql;

namespace ManDI.build
{
    /// <summary>
    /// Конфигурация используемых композитных типов
    /// </summary>
    public partial class ManDiDataService
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
            dataSourceBuilder.MapComposite<ventity>("ventity");
            dataSourceBuilder.MapComposite<vpattern_string>("vpattern_string");

            dataSourceBuilder.MapComposite<vunits>("vunits");
            dataSourceBuilder.MapComposite<vunit_conversion_rules>("vunit_conversion_rules");
            dataSourceBuilder.MapComposite<vclass_unit_conversion_rules>("vclass_unit_conversion_rules");

            dataSourceBuilder.MapComposite<vcfg_prop_spec_limit2>("vcfg_prop_spec_limit2");
            dataSourceBuilder.MapComposite<vcon_prop_data_type>("vcon_prop_data_type");

            dataSourceBuilder.MapComposite<vglobal_prop>("vglobal_prop");
            dataSourceBuilder.MapComposite<vglobal_prop_area_val>("vglobal_prop_area_val");
            dataSourceBuilder.MapComposite<vglobal_prop_link_class_prop>("vglobal_prop_link_class_prop");
            dataSourceBuilder.MapComposite<vglobal_prop_link_pos_temp_prop>("vglobal_prop_link_pos_temp_prop");

            dataSourceBuilder.MapComposite<vprop_data_type>("vprop_data_type");
            dataSourceBuilder.MapComposite<vprop_enum>("vprop_enum");
            dataSourceBuilder.MapComposite<vprop_enum_use_area>("vprop_enum_use_area");
            dataSourceBuilder.MapComposite<vprop_enum_val>("vprop_enum_val");
            dataSourceBuilder.MapComposite<vprop_search_method>("vprop_search_method");
            dataSourceBuilder.MapComposite<vprop_type>("vprop_type");

            dataSourceBuilder.MapComposite<vrulel1_class_on_pos_temp>("vrulel1_class_on_pos_temp");
            dataSourceBuilder.MapComposite<vrulel1_class_on_pos_temp_tbl_access>("vrulel1_class_on_pos_temp_tbl_access");
            dataSourceBuilder.MapComposite<vrulel1_group_on_pos_temp>("vrulel1_group_on_pos_temp");
            dataSourceBuilder.MapComposite<vrulel1_group_on_pos_temp_tbl_access>("vrulel1_group_on_pos_temp_tbl_access");
            dataSourceBuilder.MapComposite<vrulel2_class_on_position>("vrulel2_class_on_position");
            dataSourceBuilder.MapComposite<vrulel2_class_snapshot_on_position>("vrulel2_class_snapshot_on_position");

            dataSourceBuilder.MapComposite<vusers>("vusers");
            dataSourceBuilder.MapComposite<vrole_base>("vrole_base");
            dataSourceBuilder.MapComposite<vrole_user>("vrole_user");
            dataSourceBuilder.MapComposite<vuser_role_mapping>("vuser_role_mapping");

            dataSourceBuilder.MapComposite<vgroup>("vgroup");
            dataSourceBuilder.MapComposite<vclass>("vclass");
            dataSourceBuilder.MapComposite<vclass_ext>("vclass_ext");
            dataSourceBuilder.MapComposite<vclass_prop>("vclass_prop");
            dataSourceBuilder.MapComposite<vclass_prop_enum_val>("vclass_prop_enum_val");
            dataSourceBuilder.MapComposite<vclass_prop_link_val>("vclass_prop_link_val");
            dataSourceBuilder.MapComposite<vclass_prop_object_val>("vclass_prop_object_val");
            dataSourceBuilder.MapComposite<vclass_prop_user_big_val>("vclass_prop_user_big_val");
            dataSourceBuilder.MapComposite<vclass_prop_user_small_val>("vclass_prop_user_small_val");

            dataSourceBuilder.MapComposite<vpos_prototype>("vpos_prototype");
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
            dataSourceBuilder.MapComposite<vobject_prop_create_emded_mode>("dataSourceBuilder.MapComposite<");

            dataSourceBuilder.MapComposite<vdoc_category>("vdoc_category");
            dataSourceBuilder.MapComposite<vdoc_link>("vdoc_link");
            dataSourceBuilder.MapComposite<vdoc_file>("vdoc_file");
            dataSourceBuilder.MapComposite<vdocument>("vdocument");
            dataSourceBuilder.MapComposite<vdocument_ext>("vdocument_ext");

            dataSourceBuilder.MapComposite<vlog>("vlog");
            dataSourceBuilder.MapComposite<vlog_category>("vlog_category");
            dataSourceBuilder.MapComposite<vlog_link>("vlog_link");
            
            dataSourceBuilder.MapComposite<error_message>("error_message");
        }
    }
}