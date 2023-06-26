using System.Collections.Generic;
public class t_towerdevelop_sInfo
{
public int id;
public int a_base_technology_id;
public int a_base_group_id;
public int a_base_object_id;
public int a_base_build_type;
public int a_base_build_level;
public int a_base_unlock_level;
public int a_base_object_blood;
public int a_base_power;
public int a_base_attack_range;
public int a_base_attack_speed;
public t_towerdevelop_sInfo(int id,int a_base_unit_id,int a_base_unitgroup_id,int a_base_unit_kind,string a_ints_unit_type,int a_base_build_date,string a_ints_land_type,int a_base_color_type,string a_ints_unlock_config,int a_base_star,string a_base_star_id_num,string a_ints_star_recovery,int a_base_basedamage,int a_base_blood_num,int a_base_blood_recovery,int a_base_buff_id,int a_base_buff_timeint id,int a_base_technology_id,int a_base_group_id,int a_base_object_id,int a_base_build_type,int a_base_build_level,int a_base_unlock_level,int a_base_object_blood,int a_base_power,int a_base_attack_range,int a_base_attack_speed)
{
  this.id = id;
  this.a_base_technology_id = a_base_technology_id;
  this.a_base_group_id = a_base_group_id;
  this.a_base_object_id = a_base_object_id;
  this.a_base_build_type = a_base_build_type;
  this.a_base_build_level = a_base_build_level;
  this.a_base_unlock_level = a_base_unlock_level;
  this.a_base_object_blood = a_base_object_blood;
  this.a_base_power = a_base_power;
  this.a_base_attack_range = a_base_attack_range;
  this.a_base_attack_speed = a_base_attack_speed;
}
}
public class Cfg_t_towerdevelop_s
{
public static List<t_towerdevelop_sInfo> list = new List<t_towerdevelop_sInfo>()
{
	[0] = new t_towerdevelop_sInfo(1,1,0,1,6,,0,0,0,0,0),
	[1] = new t_towerdevelop_sInfo(2,2,0,2,6,,0,0,0,0,0),
	[2] = new t_towerdevelop_sInfo(3,3,0,3,6,,0,0,0,0,0),
	[3] = new t_towerdevelop_sInfo(4,4,0,4,6,,0,0,0,0,0),
	[4] = new t_towerdevelop_sInfo(5,5,0,5,6,,0,0,0,0,0),
	[5] = new t_towerdevelop_sInfo(6,6,0,6,6,,0,0,0,0,0),
	[6] = new t_towerdevelop_sInfo(7,7,0,7,6,,0,0,0,0,0),
	[7] = new t_towerdevelop_sInfo(8,8,0,8,6,,0,0,0,0,0),
	[8] = new t_towerdevelop_sInfo(9,9,0,11,6,,1,1,1,1,1),
	[9] = new t_towerdevelop_sInfo(10,10,0,12,6,,2,2,2,2,2),
	[10] = new t_towerdevelop_sInfo(11,11,0,13,6,,3,3,3,3,3),
	[11] = new t_towerdevelop_sInfo(12,12,0,14,6,,4,4,4,4,4),
	[12] = new t_towerdevelop_sInfo(13,13,0,21,6,,1,1,1,1,1),
	[13] = new t_towerdevelop_sInfo(14,14,0,22,6,,2,2,2,2,2),
	[14] = new t_towerdevelop_sInfo(15,15,0,23,6,,3,3,3,3,3),
	[15] = new t_towerdevelop_sInfo(16,16,0,24,6,,4,4,4,4,4),
	[16] = new t_towerdevelop_sInfo(17,101,1,11101,1,1,1,1,1,1,1),
	[17] = new t_towerdevelop_sInfo(18,102,1,11102,1,1,1,1,1,1,1),
	[18] = new t_towerdevelop_sInfo(19,103,1,11103,1,1,1,1,1,1,1),
	[19] = new t_towerdevelop_sInfo(20,104,1,11104,1,1,1,1,1,1,1),
	[20] = new t_towerdevelop_sInfo(21,105,1,11105,1,1,1,1,1,1,1),
	[21] = new t_towerdevelop_sInfo(22,106,1,11106,1,1,1,1,1,1,1),
	[22] = new t_towerdevelop_sInfo(23,107,1,11107,1,1,1,1,1,1,1),
	[23] = new t_towerdevelop_sInfo(24,108,1,11108,1,1,1,1,1,1,1),
	[24] = new t_towerdevelop_sInfo(25,109,1,11109,1,1,1,1,1,1,1),
	[25] = new t_towerdevelop_sInfo(26,110,1,11110,1,1,1,1,1,1,1),
	[26] = new t_towerdevelop_sInfo(27,111,1,11111,1,1,1,1,1,1,1),
	[27] = new t_towerdevelop_sInfo(28,112,1,11112,1,1,1,1,1,1,1),
	[28] = new t_towerdevelop_sInfo(29,113,1,11113,1,1,1,1,1,1,1),
	[29] = new t_towerdevelop_sInfo(30,114,1,11114,1,1,1,1,1,1,1),
	[30] = new t_towerdevelop_sInfo(31,115,1,11115,1,1,1,1,1,1,1),
	[31] = new t_towerdevelop_sInfo(32,201,2,12101,2,2,2,2,2,2,2),
	[32] = new t_towerdevelop_sInfo(33,202,2,12102,2,2,2,2,2,2,2),
	[33] = new t_towerdevelop_sInfo(34,203,2,12103,2,2,2,2,2,2,2),
	[34] = new t_towerdevelop_sInfo(35,204,2,12104,2,2,2,2,2,2,2),
	[35] = new t_towerdevelop_sInfo(36,205,2,12105,2,2,2,2,2,2,2),
	[36] = new t_towerdevelop_sInfo(37,206,2,12106,2,2,2,2,2,2,2),
	[37] = new t_towerdevelop_sInfo(38,207,2,12107,2,2,2,2,2,2,2),
	[38] = new t_towerdevelop_sInfo(39,208,2,12108,2,2,2,2,2,2,2),
	[39] = new t_towerdevelop_sInfo(40,209,2,12109,2,2,2,2,2,2,2),
	[40] = new t_towerdevelop_sInfo(41,210,2,12110,2,2,2,2,2,2,2),
	[41] = new t_towerdevelop_sInfo(42,211,2,12111,2,2,2,2,2,2,2),
	[42] = new t_towerdevelop_sInfo(43,212,2,12112,2,2,2,2,2,2,2),
	[43] = new t_towerdevelop_sInfo(44,213,2,12113,2,2,2,2,2,2,2),
	[44] = new t_towerdevelop_sInfo(45,214,2,12114,2,2,2,2,2,2,2),
	[45] = new t_towerdevelop_sInfo(46,215,2,12115,2,2,2,2,2,2,2),
};
}
