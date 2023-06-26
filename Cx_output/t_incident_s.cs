using System.Collections.Generic;
public class t_incident_sInfo
{
public int id;
public int a_base_incident_id;
public int a_base_group;
public int a_base_weight;
public string c_ints_resource;
public string a_base_lv_condition;
public string a_ints_incident_type;
public int a_base_incident_type_left;
public string a_arrayints_random_condition;
public int a_base_incident_period;
public int a_base_cd_type;
public int a_base_message;
public string a_ints_incident_interact;
public int a_base_incident_interact_cd;
public int a_base_incident_interact_cdtype;
public int a_base_incident_award;
public string a_ints_incident_area;
public string a_arrayints_repair_expend;
public int a_base_click_incident_cd;
public int a_base_click_incident_cdtype;
public t_incident_sInfo(int id,int a_base_architecture_id,int a_base_architecture_name,int a_base_architecture_tips,int a_base_architecture_type,string a_ints_architecture_attr,string a_arrayints_architecture_unlock,string a_ints_architecture_placeholder,int a_base_move_type,int a_base_architecture_group,string a_ints_open_function,int a_base_rank,string a_base_hint_trigger,string a_base_hint_animation,int a_base_animation_click_effectint id,int a_base_group_id,int a_base_group,int a_base_architecture_lv,string a_arrayints_upgrade_condition,string a_arrayints_upgrade_expend,int a_base_upgrade_time,string a_arrayints_architecture_property,string a_ints_resource,string a_ints_corps_type,string a_ints_corps_id,string a_ints_godrole_id,string a_ints_corps_num,string a_arrayints_towerunit_id,string a_arrayints_passive_skills,int a_base_god_id,string a_base_later_story,string a_base_respath,int c_base_eff_id,string c_vector3_eff_pos,string a_base_show_icon,string a_arrayints_architecture_show,int a_base_building_typeint id,int a_base_city_id,int c_base_condition_text,string a_ints_place_architecture_type,int a_base_place_architecture_type_left,int c_base_order,string c_ints_monster_resource,string a_arrayints_random_area,int a_base_show,string a_arrayints_repair_condition,int a_base_message,int a_base_effects,string a_arrayints_repair_expend,int a_base_time,string a_arrayints_unlock_area,int a_base_award,string a_base_front_story,string a_base_later_story,string a_ints_area,string a_base_respath,int a_base_group_cd,int a_base_group_cdtypeint id,int a_base_incident_id,int a_base_group,int a_base_weight,string c_ints_resource,string a_base_lv_condition,string a_ints_incident_type,int a_base_incident_type_left,string a_arrayints_random_condition,int a_base_incident_period,int a_base_cd_type,int a_base_message,string a_ints_incident_interact,int a_base_incident_interact_cd,int a_base_incident_interact_cdtype,int a_base_incident_award,string a_ints_incident_area,string a_arrayints_repair_expend,int a_base_click_incident_cd,int a_base_click_incident_cdtype)
{
  this.id = id;
  this.a_base_incident_id = a_base_incident_id;
  this.a_base_group = a_base_group;
  this.a_base_weight = a_base_weight;
  this.c_ints_resource = c_ints_resource;
  this.a_base_lv_condition = a_base_lv_condition;
  this.a_ints_incident_type = a_ints_incident_type;
  this.a_base_incident_type_left = a_base_incident_type_left;
  this.a_arrayints_random_condition = a_arrayints_random_condition;
  this.a_base_incident_period = a_base_incident_period;
  this.a_base_cd_type = a_base_cd_type;
  this.a_base_message = a_base_message;
  this.a_ints_incident_interact = a_ints_incident_interact;
  this.a_base_incident_interact_cd = a_base_incident_interact_cd;
  this.a_base_incident_interact_cdtype = a_base_incident_interact_cdtype;
  this.a_base_incident_award = a_base_incident_award;
  this.a_ints_incident_area = a_ints_incident_area;
  this.a_arrayints_repair_expend = a_arrayints_repair_expend;
  this.a_base_click_incident_cd = a_base_click_incident_cd;
  this.a_base_click_incident_cdtype = a_base_click_incident_cdtype;
}
}
public class Cfg_t_incident_s
{
public static List<t_incident_sInfo> list = new List<t_incident_sInfo>()
{
	[0] = new t_incident_sInfo(1,1,1,1,"1,70001","0,0","0,0",0,"2,1,1",30,0,1,"0,0",0,0,1002,"1,1","-3,5",10,0),
	[1] = new t_incident_sInfo(2,2,1,1,"1,70001","0,0","1,0",1,"2,1,2",60,0,1,"1,1",0,0,1004,"1,1","-3,5",1,0),
	[2] = new t_incident_sInfo(3,3,1,1,"1,70001","0,0","4,0",4,"2,1,3",90,0,1,"1,2",10,0,1003,"1,1","-3,10",1,0),
	[3] = new t_incident_sInfo(4,4,1,1,"1,70001","0,0","1,0",1,"2,1,4",120,0,1,"1,3",20,0,1003,"1,1","-3,20",1,0),
	[4] = new t_incident_sInfo(5,5,2,1,"1,70001","0,0","0,0",0,"2,1,1",30,0,1,"1,1",0,0,1004,"1,1","-3,20",1,0),
	[5] = new t_incident_sInfo(6,301,3,1300,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[6] = new t_incident_sInfo(7,302,3,1300,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[7] = new t_incident_sInfo(8,303,3,1300,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[8] = new t_incident_sInfo(9,304,3,1300,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[9] = new t_incident_sInfo(10,305,3,1300,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[10] = new t_incident_sInfo(11,306,3,1300,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[11] = new t_incident_sInfo(12,307,3,1300,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[12] = new t_incident_sInfo(13,308,3,1300,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[13] = new t_incident_sInfo(14,309,3,1300,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[14] = new t_incident_sInfo(15,310,3,1300,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[15] = new t_incident_sInfo(16,311,3,1300,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[16] = new t_incident_sInfo(17,312,3,1300,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[17] = new t_incident_sInfo(18,313,3,1300,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[18] = new t_incident_sInfo(19,314,3,1300,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[19] = new t_incident_sInfo(20,315,3,1300,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[20] = new t_incident_sInfo(21,316,3,1300,"1,70001","0,0","4,0",4,"2,1,16",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[21] = new t_incident_sInfo(22,317,3,1300,"1,70001","0,0","4,0",4,"2,1,17",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[22] = new t_incident_sInfo(23,318,3,1300,"1,70001","0,0","4,0",4,"2,1,18",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[23] = new t_incident_sInfo(24,319,3,1300,"1,70001","0,0","4,0",4,"2,1,19",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[24] = new t_incident_sInfo(25,320,3,1300,"1,70001","0,0","4,0",4,"2,1,20",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[25] = new t_incident_sInfo(26,321,3,1300,"1,70001","0,0","4,0",4,"2,1,21",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[26] = new t_incident_sInfo(27,322,3,1300,"1,70001","0,0","4,0",4,"2,1,22",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[27] = new t_incident_sInfo(28,323,3,1300,"1,70001","0,0","4,0",4,"2,1,23",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[28] = new t_incident_sInfo(29,324,3,1300,"1,70001","0,0","4,0",4,"2,1,24",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[29] = new t_incident_sInfo(30,325,3,1300,"1,70001","0,0","4,0",4,"2,1,25",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[30] = new t_incident_sInfo(31,326,3,800,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[31] = new t_incident_sInfo(32,327,3,800,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[32] = new t_incident_sInfo(33,328,3,800,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[33] = new t_incident_sInfo(34,329,3,800,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[34] = new t_incident_sInfo(35,330,3,800,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[35] = new t_incident_sInfo(36,331,3,800,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[36] = new t_incident_sInfo(37,332,3,800,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[37] = new t_incident_sInfo(38,333,3,800,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[38] = new t_incident_sInfo(39,334,3,800,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[39] = new t_incident_sInfo(40,335,3,800,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[40] = new t_incident_sInfo(41,336,3,800,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[41] = new t_incident_sInfo(42,337,3,800,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[42] = new t_incident_sInfo(43,338,3,800,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[43] = new t_incident_sInfo(44,339,3,800,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[44] = new t_incident_sInfo(45,340,3,800,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[45] = new t_incident_sInfo(46,341,3,800,"1,70001","0,0","4,0",4,"2,1,16",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[46] = new t_incident_sInfo(47,342,3,800,"1,70001","0,0","4,0",4,"2,1,17",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[47] = new t_incident_sInfo(48,343,3,800,"1,70001","0,0","4,0",4,"2,1,18",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[48] = new t_incident_sInfo(49,344,3,800,"1,70001","0,0","4,0",4,"2,1,19",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[49] = new t_incident_sInfo(50,345,3,800,"1,70001","0,0","4,0",4,"2,1,20",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[50] = new t_incident_sInfo(51,346,3,800,"1,70001","0,0","4,0",4,"2,1,21",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[51] = new t_incident_sInfo(52,347,3,800,"1,70001","0,0","4,0",4,"2,1,22",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[52] = new t_incident_sInfo(53,348,3,800,"1,70001","0,0","4,0",4,"2,1,23",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[53] = new t_incident_sInfo(54,349,3,800,"1,70001","0,0","4,0",4,"2,1,24",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[54] = new t_incident_sInfo(55,350,3,800,"1,70001","0,0","4,0",4,"2,1,25",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[55] = new t_incident_sInfo(56,351,3,400,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[56] = new t_incident_sInfo(57,352,3,400,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[57] = new t_incident_sInfo(58,353,3,400,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[58] = new t_incident_sInfo(59,354,3,400,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[59] = new t_incident_sInfo(60,355,3,400,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[60] = new t_incident_sInfo(61,356,3,400,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[61] = new t_incident_sInfo(62,357,3,400,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[62] = new t_incident_sInfo(63,358,3,400,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[63] = new t_incident_sInfo(64,359,3,400,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[64] = new t_incident_sInfo(65,360,3,400,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[65] = new t_incident_sInfo(66,361,3,400,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[66] = new t_incident_sInfo(67,362,3,400,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[67] = new t_incident_sInfo(68,363,3,400,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[68] = new t_incident_sInfo(69,364,3,400,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[69] = new t_incident_sInfo(70,365,3,400,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[70] = new t_incident_sInfo(71,366,3,400,"1,70001","0,0","4,0",4,"2,1,16",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[71] = new t_incident_sInfo(72,367,3,400,"1,70001","0,0","4,0",4,"2,1,17",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[72] = new t_incident_sInfo(73,368,3,400,"1,70001","0,0","4,0",4,"2,1,18",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[73] = new t_incident_sInfo(74,369,3,400,"1,70001","0,0","4,0",4,"2,1,19",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[74] = new t_incident_sInfo(75,370,3,400,"1,70001","0,0","4,0",4,"2,1,20",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[75] = new t_incident_sInfo(76,371,3,400,"1,70001","0,0","4,0",4,"2,1,21",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[76] = new t_incident_sInfo(77,372,3,400,"1,70001","0,0","4,0",4,"2,1,22",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[77] = new t_incident_sInfo(78,373,3,400,"1,70001","0,0","4,0",4,"2,1,23",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[78] = new t_incident_sInfo(79,374,3,400,"1,70001","0,0","4,0",4,"2,1,24",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[79] = new t_incident_sInfo(80,375,3,400,"1,70001","0,0","4,0",4,"2,1,25",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[80] = new t_incident_sInfo(81,376,3,1500,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[81] = new t_incident_sInfo(82,377,3,1500,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[82] = new t_incident_sInfo(83,378,3,1500,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[83] = new t_incident_sInfo(84,379,3,1500,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[84] = new t_incident_sInfo(85,380,3,1500,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[85] = new t_incident_sInfo(86,381,3,1500,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[86] = new t_incident_sInfo(87,382,3,1500,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[87] = new t_incident_sInfo(88,383,3,1500,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[88] = new t_incident_sInfo(89,384,3,1500,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[89] = new t_incident_sInfo(90,385,3,1500,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[90] = new t_incident_sInfo(91,386,3,1500,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[91] = new t_incident_sInfo(92,387,3,1500,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[92] = new t_incident_sInfo(93,388,3,1500,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[93] = new t_incident_sInfo(94,389,3,1500,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[94] = new t_incident_sInfo(95,390,3,1500,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[95] = new t_incident_sInfo(96,391,3,1500,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[96] = new t_incident_sInfo(97,392,3,1500,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[97] = new t_incident_sInfo(98,393,3,1500,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[98] = new t_incident_sInfo(99,394,3,1500,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[99] = new t_incident_sInfo(100,395,3,1500,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[100] = new t_incident_sInfo(101,396,3,1500,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[101] = new t_incident_sInfo(102,397,3,1500,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[102] = new t_incident_sInfo(103,398,3,1500,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[103] = new t_incident_sInfo(104,399,3,1500,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[104] = new t_incident_sInfo(105,400,3,1500,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[105] = new t_incident_sInfo(106,401,3,1500,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[106] = new t_incident_sInfo(107,402,3,1500,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[107] = new t_incident_sInfo(108,403,3,1500,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[108] = new t_incident_sInfo(109,404,3,1500,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[109] = new t_incident_sInfo(110,405,3,1500,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[110] = new t_incident_sInfo(111,406,3,1500,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[111] = new t_incident_sInfo(112,407,3,1500,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[112] = new t_incident_sInfo(113,408,3,1500,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[113] = new t_incident_sInfo(114,409,3,1500,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[114] = new t_incident_sInfo(115,410,3,1500,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[115] = new t_incident_sInfo(116,411,3,1500,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[116] = new t_incident_sInfo(117,412,3,1500,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[117] = new t_incident_sInfo(118,413,3,1500,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[118] = new t_incident_sInfo(119,414,3,1500,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[119] = new t_incident_sInfo(120,415,3,1500,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[120] = new t_incident_sInfo(121,416,3,1500,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[121] = new t_incident_sInfo(122,417,3,1500,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[122] = new t_incident_sInfo(123,418,3,1500,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[123] = new t_incident_sInfo(124,419,3,1500,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[124] = new t_incident_sInfo(125,420,3,1500,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[125] = new t_incident_sInfo(126,421,3,1500,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[126] = new t_incident_sInfo(127,422,3,1500,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[127] = new t_incident_sInfo(128,423,3,1500,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[128] = new t_incident_sInfo(129,424,3,1500,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[129] = new t_incident_sInfo(130,425,3,1500,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[130] = new t_incident_sInfo(131,426,3,1500,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[131] = new t_incident_sInfo(132,427,3,1500,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[132] = new t_incident_sInfo(133,428,3,1500,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[133] = new t_incident_sInfo(134,429,3,1500,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[134] = new t_incident_sInfo(135,430,3,1500,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[135] = new t_incident_sInfo(136,431,3,1500,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[136] = new t_incident_sInfo(137,432,3,1500,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[137] = new t_incident_sInfo(138,433,3,1500,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[138] = new t_incident_sInfo(139,434,3,1500,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[139] = new t_incident_sInfo(140,435,3,1500,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[140] = new t_incident_sInfo(141,436,3,1500,"1,70001","0,0","4,0",4,"2,1,1",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[141] = new t_incident_sInfo(142,437,3,1500,"1,70001","0,0","4,0",4,"2,1,2",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[142] = new t_incident_sInfo(143,438,3,1500,"1,70001","0,0","4,0",4,"2,1,3",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[143] = new t_incident_sInfo(144,439,3,1500,"1,70001","0,0","4,0",4,"2,1,4",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[144] = new t_incident_sInfo(145,440,3,1500,"1,70001","0,0","4,0",4,"2,1,5",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[145] = new t_incident_sInfo(146,441,3,1500,"1,70001","0,0","4,0",4,"2,1,6",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[146] = new t_incident_sInfo(147,442,3,1500,"1,70001","0,0","4,0",4,"2,1,7",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[147] = new t_incident_sInfo(148,443,3,1500,"1,70001","0,0","4,0",4,"2,1,8",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[148] = new t_incident_sInfo(149,444,3,1500,"1,70001","0,0","4,0",4,"2,1,9",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[149] = new t_incident_sInfo(150,445,3,1500,"1,70001","0,0","4,0",4,"2,1,10",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[150] = new t_incident_sInfo(151,446,3,1500,"1,70001","0,0","4,0",4,"2,1,11",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[151] = new t_incident_sInfo(152,447,3,1500,"1,70001","0,0","4,0",4,"2,1,12",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[152] = new t_incident_sInfo(153,448,3,1500,"1,70001","0,0","4,0",4,"2,1,13",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[153] = new t_incident_sInfo(154,449,3,1500,"1,70001","0,0","4,0",4,"2,1,14",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
	[154] = new t_incident_sInfo(155,450,3,1500,"1,70001","0,0","4,0",4,"2,1,15",-1,0,1,"1,1",0,0,1003,"1,1","-3,10",1,0),
};
}