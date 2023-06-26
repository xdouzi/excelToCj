using System.Collections.Generic;
public class Cfg_t_audio_s_Info
{
public int id;
public int c_base_audio_id;
public string a_base_operater_id;
public string c_e_name;
public int c_base_type;
public string c_base_resource;
public Cfg_t_audio_s_Info(int id,int c_base_audio_id,string a_base_operater_id,string c_e_name,int c_base_type,string c_base_resource)
{
  this.id = id;
  this.c_base_audio_id = c_base_audio_id;
  this.a_base_operater_id = a_base_operater_id;
  this.c_e_name = c_e_name;
  this.c_base_type = c_base_type;
  this.c_base_resource = c_base_resource;
}
}
public class Cfg_t_audio_s
{
public static List<Cfg_t_audio_s_Info> list = new List<Cfg_t_audio_s_Info>()
{
	[0] = new Cfg_t_audio_s_Info(1,101,"","Audio_Bg_Login",1,"Download/Audio/BackGround/Audio_Bg_Login.mp3"),
	[1] = new Cfg_t_audio_s_Info(2,102,"","Audio_Bg_Map",1,"Download/Audio/BackGround/Audio_Bg_Map.mp3"),
	[2] = new Cfg_t_audio_s_Info(3,150,"","Audio_Bg_Battle_01",1,"Download/Audio/BackGround/Audio_Bg_Battle_01.mp3"),
	[3] = new Cfg_t_audio_s_Info(4,151,"","Audio_Bg_Battle_02",1,"Download/Audio/BackGround/Audio_Bg_Battle_02.mp3"),
	[4] = new Cfg_t_audio_s_Info(5,10001,"","UI_Button_01",2,"Download/Audio/UI/UI_Button_01.mp3"),
	[5] = new Cfg_t_audio_s_Info(6,10101,"","UI_Open",2,"Download/Audio/UI/UI_Open.mp3"),
	[6] = new Cfg_t_audio_s_Info(7,10102,"","UI_reward_show",2,"Download/Audio/UI/UI_reward_show.mp3"),
	[7] = new Cfg_t_audio_s_Info(8,10103,"","UI_item_fly",2,"Download/Audio/UI/UI_item_fly.mp3"),
	[8] = new Cfg_t_audio_s_Info(9,10104,"","Audio_Building_Up_01",2,"Download/Audio/UI/Audio_Building_Up_01.mp3"),
	[9] = new Cfg_t_audio_s_Info(10,10105,"","Audio_Building_Up_02",2,"Download/Audio/UI/Audio_Building_Up_02.mp3"),
	[10] = new Cfg_t_audio_s_Info(11,10106,"","UI_congratulations",2,"Download/Audio/UI/UI_congratulations.mp3"),
	[11] = new Cfg_t_audio_s_Info(12,10107,"","UI_tab_button",2,"Download/Audio/UI/UI_tab_button.mp3"),
	[12] = new Cfg_t_audio_s_Info(13,10108,"","UI_player_level_up",2,"Download/Audio/UI/UI_player_level_up.mp3"),
	[13] = new Cfg_t_audio_s_Info(14,10109,"","UI_cg_animation",2,"Download/Audio/UI/UI_cg_animation.mp3"),
	[14] = new Cfg_t_audio_s_Info(15,20001,"","Chess_Eliminate_01",2,"Download/Audio/Fight/Chess_Eliminate_01.mp3"),
	[15] = new Cfg_t_audio_s_Info(16,20002,"","Hero_Death",2,"Download/Audio/Fight/Hero_Death.mp3"),
	[16] = new Cfg_t_audio_s_Info(17,20003,"","Hero_Hit",2,"Download/Audio/Fight/Hero_Hit.mp3"),
	[17] = new Cfg_t_audio_s_Info(18,20004,"","Skill_role_clean",2,"Download/Audio/Skill/Skill_role_clean.mp3"),
	[18] = new Cfg_t_audio_s_Info(19,20101,"","Skill_10201",2,"Download/Audio/Skill/Skill_10201.mp3"),
	[19] = new Cfg_t_audio_s_Info(20,20102,"","Skill_Gongjian",2,"Download/Audio/Skill/Skill_Gongjian.mp3"),
	[20] = new Cfg_t_audio_s_Info(21,20103,"","Skill_10203_1",2,"Download/Audio/Skill/Skill_10203_1.mp3"),
	[21] = new Cfg_t_audio_s_Info(22,20104,"","Skill_10203_2",2,"Download/Audio/Skill/Skill_10203_2.mp3"),
	[22] = new Cfg_t_audio_s_Info(23,20105,"","Skill_Jinzhan",2,"Download/Audio/Skill/Skill_Jinzhan.mp3"),
	[23] = new Cfg_t_audio_s_Info(24,20106,"","Fight_start",2,"Download/Audio/Fight/Fight_start.mp3"),
	[24] = new Cfg_t_audio_s_Info(25,20107,"","chess_change",2,"Download/Audio/Fight/CK_skill1.mp3"),
	[25] = new Cfg_t_audio_s_Info(26,20108,"","Fight_victory",2,"Download/Audio/Fight/Fight_victory.mp3"),
	[26] = new Cfg_t_audio_s_Info(27,20109,"","Fight_defeat",2,"Download/Audio/Fight/Fight_defeat.mp3"),
	[27] = new Cfg_t_audio_s_Info(28,20110,"","Fight_build_destroy",2,"Download/Audio/Fight/Fight_build_destroy.mp3"),
	[28] = new Cfg_t_audio_s_Info(29,20111,"","Fight_hero_landing",2,"Download/Audio/Fight/Fight_hero_landing.mp3"),
	[29] = new Cfg_t_audio_s_Info(30,20112,"","Skill_magic_yellow",2,"Download/Audio/Skill/Skill_magic_yellow.mp3"),
	[30] = new Cfg_t_audio_s_Info(31,20113,"","Skill_magic_blue",2,"Download/Audio/Skill/Skill_magic_blue.mp3"),
	[31] = new Cfg_t_audio_s_Info(32,20114,"","Skill_magic_green",2,"Download/Audio/Skill/Skill_magic_green.mp3"),
	[32] = new Cfg_t_audio_s_Info(33,20115,"","Skill_magic_red",2,"Download/Audio/Skill/Skill_magic_red.mp3"),
	[33] = new Cfg_t_audio_s_Info(34,20117,"","Fight_chess_synthesis",2,"Download/Audio/Fight/Fight_chess_synthesis.mp3"),
	[34] = new Cfg_t_audio_s_Info(35,20118,"","Fight_chess_move",2,"Download/Audio/Fight/Fight_chess_move.mp3"),
	[35] = new Cfg_t_audio_s_Info(36,20119,"","Fight_chess_falling",2,"Download/Audio/Fight/Fight_chess_falling.mp3"),
	[36] = new Cfg_t_audio_s_Info(37,20201,"","Skill_qibing_01",2,"Download/Audio/Skill/Skill_qibing_01.mp3"),
	[37] = new Cfg_t_audio_s_Info(38,20202,"","Skill_gongjianta_01",2,"Download/Audio/Skill/Skill_gongjianta_01.mp3"),
	[38] = new Cfg_t_audio_s_Info(39,20203,"","Skill_shuren_01",2,"Download/Audio/Skill/Skill_shuren_01.mp3"),
	[39] = new Cfg_t_audio_s_Info(40,20204,"","Skill_shenbing_01",2,"Download/Audio/Skill/Skill_shenbing_01.mp3"),
	[40] = new Cfg_t_audio_s_Info(41,20205,"","Skill_hanbingta_01",2,"Download/Audio/Skill/Skill_hanbingta_01.mp3"),
	[41] = new Cfg_t_audio_s_Info(42,20206,"","Skill_guanglingta_01",2,"Download/Audio/Skill/Skill_guanglingta_01.mp3"),
	[42] = new Cfg_t_audio_s_Info(43,30001,"","Map_selected",2,"Download/Audio/UI/Map_selected.mp3"),
	[43] = new Cfg_t_audio_s_Info(44,30002,"","Map_move",2,"Download/Audio/UI/Map_move.mp3"),
	[44] = new Cfg_t_audio_s_Info(45,30003,"","Map_landing",2,"Download/Audio/UI/Map_landing.mp3"),
	[45] = new Cfg_t_audio_s_Info(46,30004,"","Map_clean",2,"Download/Audio/UI/Map_clean.mp3"),
	[46] = new Cfg_t_audio_s_Info(47,30005,"","Map_open_box",2,"Download/Audio/UI/Map_open_box.mp3"),
	[47] = new Cfg_t_audio_s_Info(48,30006,"","Map_bubble",2,"Download/Audio/UI/Map_bubble.mp3"),
	[48] = new Cfg_t_audio_s_Info(49,30007,"","Map_build_complete",2,"Download/Audio/UI/Map_build_complete.mp3"),
	[49] = new Cfg_t_audio_s_Info(50,30008,"","Map_building",2,"Download/Audio/UI/Map_building.mp3"),
	[50] = new Cfg_t_audio_s_Info(51,30009,"","Map_fog",2,"Download/Audio/UI/Map_fog.mp3"),
};
}
