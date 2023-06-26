using System.Collections.Generic;
public class t_cardreleaseai_sInfo
{
public int id;
public int a_base_cardrelease;
public string a_arrayints_target_weight;
public t_cardreleaseai_sInfo(int id,int a_base_card_id,string a_base_operater_id,int a_base_group,int a_base_level,int a_base_next_lv_id,int c_base_cardborn_effect,int a_base_setarea,int a_base_auto_ai,string c_arrayints_release_position,int a_base_skill_id,string c_ints_release_parameter,string c_ints_indicator,string c_arrayints_backpack_show_position,string c_base_backpack_show_parameter,string c_base_ui_show_position,string c_base_ui_show_parameter,string c_base_scene_show_position,int c_base_show_model_id,string c_base_scene_show_parameter,int a_base_cost_card,string a_base_cost_item,int a_base_energy_type,int a_base_energy_number,string c_base_showcase_properties,string c_base_videoint id,int a_base_group,string a_base_operater_id,int c_base_name,int c_base_is_show,int a_base_type,int a_base_quality,int a_base_initial_level,int c_base_star_number,int c_base_era,int c_base_class,int c_base_prefabid,int c_base_prefabid_battle,int c_base_cardmodel_size,int c_base_chessbordmodel_size,int a_base_trade,string a_ints_lowest_price,string c_ints_special_effect,string c_vector3s_effect_location,string c_vector3s_effect_revolve,string c_ints_effect_zoom,string c_ints_effect_delay,string c_base_effect_node,int c_base_backstory,string a_vector3_position,string a_vector3_scale,string a_vector3_formation,string a_base_spineData,int a_base_card_landing_soundint id,int a_base_cardrelease,string a_arrayints_target_weight)
{
  this.id = id;
  this.a_base_cardrelease = a_base_cardrelease;
  this.a_arrayints_target_weight = a_arrayints_target_weight;
}
}
public class Cfg_t_cardreleaseai_s
{
public static List<t_cardreleaseai_sInfo> list = new List<t_cardreleaseai_sInfo>()
{
	[0] = new t_cardreleaseai_sInfo(1,1,"1,5000"),
	[1] = new t_cardreleaseai_sInfo(2,2,"2,5000"),
	[2] = new t_cardreleaseai_sInfo(3,3,"3,5000"),
	[3] = new t_cardreleaseai_sInfo(4,4,"4,7000;3,3000"),
	[4] = new t_cardreleaseai_sInfo(5,5,"1,3000;2,7000"),
	[5] = new t_cardreleaseai_sInfo(6,6,"1,5000;3,5000"),
	[6] = new t_cardreleaseai_sInfo(7,7,"2,5000;3,5000"),
	[7] = new t_cardreleaseai_sInfo(8,8,"1,5000;2,5000;3,5000"),
	[8] = new t_cardreleaseai_sInfo(9,9,"4,5000;2,5000"),
	[9] = new t_cardreleaseai_sInfo(10,10,"5,1000"),
};
}
