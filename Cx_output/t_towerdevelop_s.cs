using System.Collections.Generic;
public class Cfg_t_towerdevelop_s_Info
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
public Cfg_t_towerdevelop_s_Info(int id,int a_base_unit_id,int a_base_unitgroup_id,int a_base_unit_kind,string a_ints_unit_type,int a_base_build_date,string a_ints_land_type,int a_base_color_type,string a_ints_unlock_config,int a_base_star,string a_base_star_id_num,string a_ints_star_recovery,int a_base_basedamage,int a_base_blood_num,int a_base_blood_recovery,int a_base_buff_id,int a_base_buff_timeint id,int a_base_technology_id,int a_base_group_id,int a_base_object_id,int a_base_build_type,int a_base_build_level,int a_base_unlock_level,int a_base_object_blood,int a_base_power,int a_base_attack_range,int a_base_attack_speed)
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
public static List<Cfg_t_towerdevelop_s_Info> list = new List<Cfg_t_towerdevelop_s_Info>()
{
	[0] = new Cfg_t_towerdevelop_s_Info(1,1,0,1,6,,0,0,0,0,0),
	[1] = new Cfg_t_towerdevelop_s_Info(2,2,0,2,6,,0,0,0,0,0),
	[2] = new Cfg_t_towerdevelop_s_Info(3,3,0,3,6,,0,0,0,0,0),
	[3] = new Cfg_t_towerdevelop_s_Info(4,4,0,4,6,,0,0,0,0,0),
	[4] = new Cfg_t_towerdevelop_s_Info(5,5,0,5,6,,0,0,0,0,0),
	[5] = new Cfg_t_towerdevelop_s_Info(6,6,0,6,6,,0,0,0,0,0),
	[6] = new Cfg_t_towerdevelop_s_Info(7,7,0,7,6,,0,0,0,0,0),
	[7] = new Cfg_t_towerdevelop_s_Info(8,8,0,8,6,,0,0,0,0,0),
	[8] = new Cfg_t_towerdevelop_s_Info(9,9,0,11,6,,1,1,1,1,1),
	[9] = new Cfg_t_towerdevelop_s_Info(10,10,0,12,6,,2,2,2,2,2),
	[10] = new Cfg_t_towerdevelop_s_Info(11,11,0,13,6,,3,3,3,3,3),
	[11] = new Cfg_t_towerdevelop_s_Info(12,12,0,14,6,,4,4,4,4,4),
	[12] = new Cfg_t_towerdevelop_s_Info(13,13,0,21,6,,1,1,1,1,1),
	[13] = new Cfg_t_towerdevelop_s_Info(14,14,0,22,6,,2,2,2,2,2),
	[14] = new Cfg_t_towerdevelop_s_Info(15,15,0,23,6,,3,3,3,3,3),
	[15] = new Cfg_t_towerdevelop_s_Info(16,16,0,24,6,,4,4,4,4,4),
	[16] = new Cfg_t_towerdevelop_s_Info(17,101,1,11101,1,1,1,1,1,1,1),
	[17] = new Cfg_t_towerdevelop_s_Info(18,102,1,11102,1,1,1,1,1,1,1),
	[18] = new Cfg_t_towerdevelop_s_Info(19,103,1,11103,1,1,1,1,1,1,1),
	[19] = new Cfg_t_towerdevelop_s_Info(20,104,1,11104,1,1,1,1,1,1,1),
	[20] = new Cfg_t_towerdevelop_s_Info(21,105,1,11105,1,1,1,1,1,1,1),
	[21] = new Cfg_t_towerdevelop_s_Info(22,106,1,11106,1,1,1,1,1,1,1),
	[22] = new Cfg_t_towerdevelop_s_Info(23,107,1,11107,1,1,1,1,1,1,1),
	[23] = new Cfg_t_towerdevelop_s_Info(24,108,1,11108,1,1,1,1,1,1,1),
	[24] = new Cfg_t_towerdevelop_s_Info(25,109,1,11109,1,1,1,1,1,1,1),
	[25] = new Cfg_t_towerdevelop_s_Info(26,110,1,11110,1,1,1,1,1,1,1),
	[26] = new Cfg_t_towerdevelop_s_Info(27,111,1,11111,1,1,1,1,1,1,1),
	[27] = new Cfg_t_towerdevelop_s_Info(28,112,1,11112,1,1,1,1,1,1,1),
	[28] = new Cfg_t_towerdevelop_s_Info(29,113,1,11113,1,1,1,1,1,1,1),
	[29] = new Cfg_t_towerdevelop_s_Info(30,114,1,11114,1,1,1,1,1,1,1),
	[30] = new Cfg_t_towerdevelop_s_Info(31,115,1,11115,1,1,1,1,1,1,1),
	[31] = new Cfg_t_towerdevelop_s_Info(32,201,2,12101,2,2,2,2,2,2,2),
	[32] = new Cfg_t_towerdevelop_s_Info(33,202,2,12102,2,2,2,2,2,2,2),
	[33] = new Cfg_t_towerdevelop_s_Info(34,203,2,12103,2,2,2,2,2,2,2),
	[34] = new Cfg_t_towerdevelop_s_Info(35,204,2,12104,2,2,2,2,2,2,2),
	[35] = new Cfg_t_towerdevelop_s_Info(36,205,2,12105,2,2,2,2,2,2,2),
	[36] = new Cfg_t_towerdevelop_s_Info(37,206,2,12106,2,2,2,2,2,2,2),
	[37] = new Cfg_t_towerdevelop_s_Info(38,207,2,12107,2,2,2,2,2,2,2),
	[38] = new Cfg_t_towerdevelop_s_Info(39,208,2,12108,2,2,2,2,2,2,2),
	[39] = new Cfg_t_towerdevelop_s_Info(40,209,2,12109,2,2,2,2,2,2,2),
	[40] = new Cfg_t_towerdevelop_s_Info(41,210,2,12110,2,2,2,2,2,2,2),
	[41] = new Cfg_t_towerdevelop_s_Info(42,211,2,12111,2,2,2,2,2,2,2),
	[42] = new Cfg_t_towerdevelop_s_Info(43,212,2,12112,2,2,2,2,2,2,2),
	[43] = new Cfg_t_towerdevelop_s_Info(44,213,2,12113,2,2,2,2,2,2,2),
	[44] = new Cfg_t_towerdevelop_s_Info(45,214,2,12114,2,2,2,2,2,2,2),
	[45] = new Cfg_t_towerdevelop_s_Info(46,215,2,12115,2,2,2,2,2,2,2),
};
}
