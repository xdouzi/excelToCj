using System.Collections.Generic;
public class t_bigmapInfo
{
public int id;
public int a_base_bigmap_id;
public string c_arrayints_bornbuild;
public string c_ints_bornarea;
public int c_base_interactive_cd;
public string a_arrayints_role_interactive;
public string c_arrayints_role_showmyself;
public string c_arrayints_movearea;
public t_bigmapInfo(int id,int a_base_architecture_id,int a_base_architecture_name,int a_base_architecture_tips,int a_base_architecture_type,string a_ints_architecture_attr,string a_arrayints_architecture_unlock,string a_ints_architecture_placeholder,int a_base_move_type,int a_base_architecture_group,string a_ints_open_function,int a_base_rank,string a_base_hint_trigger,string a_base_hint_animation,int a_base_animation_click_effectint id,int a_base_group_id,int a_base_group,int a_base_architecture_lv,string a_arrayints_upgrade_condition,string a_arrayints_upgrade_expend,int a_base_upgrade_time,string a_arrayints_architecture_property,string a_ints_resource,string a_ints_corps_type,string a_ints_corps_id,string a_ints_godrole_id,string a_ints_corps_num,string a_arrayints_towerunit_id,string a_arrayints_passive_skills,int a_base_god_id,string a_base_later_story,string a_base_respath,int c_base_eff_id,string c_vector3_eff_pos,string a_base_show_icon,string a_arrayints_architecture_show,int a_base_building_typeint id,int a_base_city_id,int c_base_condition_text,string a_ints_place_architecture_type,int a_base_place_architecture_type_left,int c_base_order,string c_ints_monster_resource,string a_arrayints_random_area,int a_base_show,string a_arrayints_repair_condition,int a_base_message,int a_base_effects,string a_arrayints_repair_expend,int a_base_time,string a_arrayints_unlock_area,int a_base_award,string a_base_front_story,string a_base_later_story,string a_ints_area,string a_base_respath,int a_base_group_cd,int a_base_group_cdtypeint id,int a_base_incident_id,int a_base_group,int a_base_weight,string c_ints_resource,string a_base_lv_condition,string a_ints_incident_type,int a_base_incident_type_left,string a_arrayints_random_condition,int a_base_incident_period,int a_base_cd_type,int a_base_message,string a_ints_incident_interact,int a_base_incident_interact_cd,int a_base_incident_interact_cdtype,int a_base_incident_award,string a_ints_incident_area,string a_arrayints_repair_expend,int a_base_click_incident_cd,int a_base_click_incident_cdtypeint id,int a_base_bigmap_id,string c_arrayints_bornbuild,string c_ints_bornarea,int c_base_interactive_cd,string a_arrayints_role_interactive,string c_arrayints_role_showmyself,string c_arrayints_movearea)
{
  this.id = id;
  this.a_base_bigmap_id = a_base_bigmap_id;
  this.c_arrayints_bornbuild = c_arrayints_bornbuild;
  this.c_ints_bornarea = c_ints_bornarea;
  this.c_base_interactive_cd = c_base_interactive_cd;
  this.a_arrayints_role_interactive = a_arrayints_role_interactive;
  this.c_arrayints_role_showmyself = c_arrayints_role_showmyself;
  this.c_arrayints_movearea = c_arrayints_movearea;
}
}
public class Cfg_t_bigmap
{
public static List<t_bigmapInfo> list = new List<t_bigmapInfo>()
{
	[0] = new t_bigmapInfo(1,1,"1,5000;7,5000","50,50",10000,"0,0;1,10000","","15,15;50,50"),
};
}
