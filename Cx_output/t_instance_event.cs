using System.Collections.Generic;
public class t_instance_eventInfo
{
public int id;
public int a_base_dungeon_event_id;
public int a_base_trigger_type;
public string a_ints_trigger_information;
public string a_ints_screen_shake;
public string a_ints_talk;
public int c_base_mask;
public string c_base_mask_information;
public int c_base_mask_pellucidity;
public int c_base_mask_time;
public string c_arrayints_scene_color_change;
public t_instance_eventInfo(int id,int a_base_level_id,int a_base_chapter_id,int a_base_chapter_name,int a_base_levelchapter,int a_base_level_name,int c_base_condition_text,int a_base_next_level_id,int a_base_mode_type,int a_base_mode_subtype,int a_base_pvptype,int a_base_combat_cost,int a_base_era_limits,int a_base_amount,int c_base_era_progress,int a_base_isshow_energy,string c_arrayints_show_boss_res_id,string c_base_effect_display,int c_base_bgpng_id,string a_ints_segment_id,int a_base_level_reward,string a_arrayints_inbreak_rewardint id,int a_base_segment_id,int a_base_mode_type,int a_base_pvptype,int c_base_map_id,int c_base_bgm_id,string a_ints_battlefield_size,string a_ints_enter_page_split,int c_base_lens_performance,int a_base_control_camera,int a_base_is_rechallenge,int a_base_timeover,int a_base_next_card_cd,string a_arrayints_reserve,string a_base_troops_location,string a_arrayints_birth_area,string a_arrayints_peace_area,string a_arrayints_battlefield_occupation,string a_ints_coordinates_id,string a_arrayints_deity_coordinates,string a_arrayints_monster_deity_coordinates,string a_arrayints_main_building,int c_base_camera_movement,string a_arrayints_initial_soldier,string a_ints_card_use,int a_base_soldier_busy_can_use,string a_arrayints_barrier,string a_arrayints_barrierprefab,string a_arrayints_barrierfence,string a_arrayints_start_plot_id,string a_ints_segment_events,string a_ints_end_plot_id,int a_base_windescription,string a_ints_winning_condition,string a_arrayints_end_condition04,int a_base_wave_cd,string a_base_monster_config,string a_ints_waves_trigger,string a_ints_wave_buff,string a_arrayints_displayboss_nodes,int a_base_monster_trigger_time,string a_ints_towerunit_type,string a_ints_toweropen,int a_base_enmination_addtime,string a_ints_chess,string a_ints_reserved_chess,string a_ints_chess_reset,string a_pairweights_cheese_weights,int a_base_chessboard_height,int a_base_chessboard_width,int c_base_chessboard_res,string a_arrayints_tower_feature,string a_ints_feature_desc,string a_ints_buff_pool_id,string a_arrayints_buff_probability,int a_base_td_skilllv,int a_base_initialenergyvalue,int a_base_closeup_switch,string a_base_mapoffsrt,string c_base_picture_id,string c_ints_tower_start,int c_base_juma_idint id,int a_base_dungeon_event_id,int a_base_trigger_type,string a_ints_trigger_information,string a_ints_screen_shake,string a_ints_talk,int c_base_mask,string c_base_mask_information,int c_base_mask_pellucidity,int c_base_mask_time,string c_arrayints_scene_color_change)
{
  this.id = id;
  this.a_base_dungeon_event_id = a_base_dungeon_event_id;
  this.a_base_trigger_type = a_base_trigger_type;
  this.a_ints_trigger_information = a_ints_trigger_information;
  this.a_ints_screen_shake = a_ints_screen_shake;
  this.a_ints_talk = a_ints_talk;
  this.c_base_mask = c_base_mask;
  this.c_base_mask_information = c_base_mask_information;
  this.c_base_mask_pellucidity = c_base_mask_pellucidity;
  this.c_base_mask_time = c_base_mask_time;
  this.c_arrayints_scene_color_change = c_arrayints_scene_color_change;
}
}
public class Cfg_t_instance_event
{
public static List<t_instance_eventInfo> list = new List<t_instance_eventInfo>()
{
	[0] = new t_instance_eventInfo(1,1,1,"2,5000","3,100,200,4","","","","","",""),
	[1] = new t_instance_eventInfo(2,2,1,"2,3000","","","","","","",""),
	[2] = new t_instance_eventInfo(3,3,1,"501,1000","","",0,"00FF00",5000,10000,""),
	[3] = new t_instance_eventInfo(4,4,1,"5006,3000","3,100,200,4","",0,"00FF00",5000,30000,""),
	[4] = new t_instance_eventInfo(5,5,4,"230043","2,200,40,3","",,"",,,"101,120"),
	[5] = new t_instance_eventInfo(6,6,4,"60402","2,200,40,3","",,"",,,"100,120"),
	[6] = new t_instance_eventInfo(7,7,4,"60803","1,200,40,2","","","","","",""),
	[7] = new t_instance_eventInfo(8,8,4,"61104","2,100,80,4","",,"",,,"100,320"),
	[8] = new t_instance_eventInfo(9,9,4,"62501","2,200,40,3","",,"",,,"100,120"),
	[9] = new t_instance_eventInfo(10,10,4,"230036","3,200,40,2","","","","","",""),
	[10] = new t_instance_eventInfo(11,11,4,"61501","2,200,40,2","","","","","",""),
	[11] = new t_instance_eventInfo(12,12,4,"62201","3,200,40,2","",,"",,,"103,75"),
	[12] = new t_instance_eventInfo(13,13,4,"62801","1,200,40,2","",,"",,,"103,75"),
	[13] = new t_instance_eventInfo(14,14,4,"63101","2,200,40,2","","","","","",""),
	[14] = new t_instance_eventInfo(15,15,4,"63401","3,200,40,2","",,"",,,"103,90"),
	[15] = new t_instance_eventInfo(16,16,4,"63701","1,200,40,2","","","","","",""),
	[16] = new t_instance_eventInfo(17,17,4,"64001","3,200,40,4","",,"",,,"15,200"),
	[17] = new t_instance_eventInfo(18,18,4,"65801","2,200,40,2","",,"",,,"103,90"),
	[18] = new t_instance_eventInfo(19,19,4,"66701","3,200,40,3","",,"",,,"104,100"),
	[19] = new t_instance_eventInfo(20,20,4,"69401","3,200,40,2","",,"",,,"100,80"),
	[20] = new t_instance_eventInfo(21,21,4,"150003","2,200,40,3","","","","","",""),
	[21] = new t_instance_eventInfo(22,22,4,"150004","2,200,40,3","",,"",,,"101,120"),
	[22] = new t_instance_eventInfo(23,23,4,"150010","2,250,30,4","",,"",,,"102,120"),
	[23] = new t_instance_eventInfo(24,24,4,"150007","2,300,25,3","",,"",,,"105,80"),
	[24] = new t_instance_eventInfo(25,25,4,"480005","2,200,40,3","",,"",,,"101,120"),
	[25] = new t_instance_eventInfo(26,26,4,"480004","2,200,40,3","","","","","",""),
	[26] = new t_instance_eventInfo(27,27,4,"480008","2,250,30,4","",,"",,,"102,120"),
	[27] = new t_instance_eventInfo(28,28,4,"480009","2,300,25,3","",,"",,,"105,80"),
	[28] = new t_instance_eventInfo(29,29,4,"570005","2,200,40,3","",,"",,,"101,120"),
	[29] = new t_instance_eventInfo(30,30,4,"570004","2,200,40,3","","","","","",""),
	[30] = new t_instance_eventInfo(31,31,4,"570008","2,250,30,4","",,"",,,"102,120"),
	[31] = new t_instance_eventInfo(32,32,4,"570009","2,300,25,3","",,"",,,"105,80"),
	[32] = new t_instance_eventInfo(33,33,4,"230058","2,200,40,4","",,"",,,"100,190"),
};
}
