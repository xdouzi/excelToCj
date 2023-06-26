using System.Collections.Generic;
public class Cfg_t_towerdefense_s_Info
{
	public int id;
	public int a_base_unit_id;
	public int a_base_unitgroup_id;
	public int a_base_unit_kind;
	public string a_ints_unit_type;
	public int a_base_build_date;
	public string a_ints_land_type;
	public int a_base_color_type;
	public string a_ints_unlock_config;
	public int a_base_star;
	public string a_base_star_id_num;
	public string a_ints_star_recovery;
	public int a_base_basedamage;
	public int a_base_blood_num;
	public int a_base_blood_recovery;
	public int a_base_buff_id;
	public int a_base_buff_time;
public Cfg_t_towerdefense_s_Info(int id,int a_base_unit_id,int a_base_unitgroup_id,int a_base_unit_kind,string a_ints_unit_type,int a_base_build_date,string a_ints_land_type,int a_base_color_type,string a_ints_unlock_config,int a_base_star,string a_base_star_id_num,string a_ints_star_recovery,int a_base_basedamage,int a_base_blood_num,int a_base_blood_recovery,int a_base_buff_id,int a_base_buff_time)
{
  this.id = id;
  this.a_base_unit_id = a_base_unit_id;
  this.a_base_unitgroup_id = a_base_unitgroup_id;
  this.a_base_unit_kind = a_base_unit_kind;
  this.a_ints_unit_type = a_ints_unit_type;
  this.a_base_build_date = a_base_build_date;
  this.a_ints_land_type = a_ints_land_type;
  this.a_base_color_type = a_base_color_type;
  this.a_ints_unlock_config = a_ints_unlock_config;
  this.a_base_star = a_base_star;
  this.a_base_star_id_num = a_base_star_id_num;
  this.a_ints_star_recovery = a_ints_star_recovery;
  this.a_base_basedamage = a_base_basedamage;
  this.a_base_blood_num = a_base_blood_num;
  this.a_base_blood_recovery = a_base_blood_recovery;
  this.a_base_buff_id = a_base_buff_id;
  this.a_base_buff_time = a_base_buff_time;
}
}
public class Cfg_t_towerdefense_s
{
public static List<Cfg_t_towerdefense_s_Info> list = new List<Cfg_t_towerdefense_s_Info>()
{
	[0] = new Cfg_t_towerdefense_s_Info(1,1,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[1] = new Cfg_t_towerdefense_s_Info(2,2,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[2] = new Cfg_t_towerdefense_s_Info(3,3,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[3] = new Cfg_t_towerdefense_s_Info(4,4,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[4] = new Cfg_t_towerdefense_s_Info(5,5,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[5] = new Cfg_t_towerdefense_s_Info(6,6,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[6] = new Cfg_t_towerdefense_s_Info(7,7,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[7] = new Cfg_t_towerdefense_s_Info(8,8,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[8] = new Cfg_t_towerdefense_s_Info(9,11,,3,"4",1,"4",10,"3,1",0,"","","","","","",""),
	[9] = new Cfg_t_towerdefense_s_Info(10,12,,3,"4",1,"4",10,"3,3",0,"","","","","","",""),
	[10] = new Cfg_t_towerdefense_s_Info(11,13,,3,"4",1,"4",10,"3,5",0,"","","","","","",""),
	[11] = new Cfg_t_towerdefense_s_Info(12,14,,3,"1,2,3,5",1,"4",10,"3,7",0,"","","","","","",""),
	[12] = new Cfg_t_towerdefense_s_Info(13,21,,3,"4",1,"4",10,"3,1",0,"","","","","","",""),
	[13] = new Cfg_t_towerdefense_s_Info(14,22,,3,"4",1,"4",10,"3,3",0,"","","","","","",""),
	[14] = new Cfg_t_towerdefense_s_Info(15,23,,3,"4",1,"4",10,"3,5",0,"","","","","","",""),
	[15] = new Cfg_t_towerdefense_s_Info(16,24,,3,"5",1,"4",10,"3,7",0,"","","","","","",""),
	[16] = new Cfg_t_towerdefense_s_Info(17,11101,1,1,"2",0,"",1,"",1,"","1,0",10000,1,2000,2000,2000),
	[17] = new Cfg_t_towerdefense_s_Info(18,12101,2,1,"2",0,"",1,"",2,"11101,3","1,1",15000,2,,1001,0),
	[18] = new Cfg_t_towerdefense_s_Info(19,13101,,1,"2",0,"",1,"",3,"12101,3","1,2",20000,5,,1002,0),
	[19] = new Cfg_t_towerdefense_s_Info(20,11201,,1,"1",0,"",2,"",1,"","1,3",10000,1,2000,2000,2000),
	[20] = new Cfg_t_towerdefense_s_Info(21,12201,,1,"1",0,"",2,"",2,"11201,3","1,4",15000,2,,2001,0),
	[21] = new Cfg_t_towerdefense_s_Info(22,13201,,1,"1",0,"",2,"",3,"12201,3","1,5",20000,5,,2002,0),
	[22] = new Cfg_t_towerdefense_s_Info(23,11301,,1,"2",0,"",3,"",1,"","1,6",10000,1,2000,2000,2000),
	[23] = new Cfg_t_towerdefense_s_Info(24,12301,,1,"2",0,"",3,"",2,"11301,3","1,7",15000,2,,3001,0),
	[24] = new Cfg_t_towerdefense_s_Info(25,13301,,1,"2",0,"",3,"",3,"12301,3","1,8",20000,5,,3002,0),
	[25] = new Cfg_t_towerdefense_s_Info(26,11401,,1,"3",0,"",4,"",1,"","1,9",10000,1,2000,2000,2000),
	[26] = new Cfg_t_towerdefense_s_Info(27,12401,,1,"3",0,"",4,"",2,"11401,3","1,10",15000,2,,4001,0),
	[27] = new Cfg_t_towerdefense_s_Info(28,13401,,1,"3",0,"",4,"",3,"12401,3","1,11",20000,5,,4002,0),
	[28] = new Cfg_t_towerdefense_s_Info(29,11501,,1,"2",0,"",5,"",1,"","1,12",10000,1,2000,2000,2000),
	[29] = new Cfg_t_towerdefense_s_Info(30,12501,,1,"2",0,"",5,"",2,"11501,3","1,13",15000,2,,5001,0),
	[30] = new Cfg_t_towerdefense_s_Info(31,13501,,1,"2",0,"",5,"",3,"12501,3","1,14",20000,5,,5002,0),
	[31] = new Cfg_t_towerdefense_s_Info(32,10000001,,2,"4",0,"",1,"",,"","1,15","1,15","1,15","1,15","1,15","1,15"),
	[32] = new Cfg_t_towerdefense_s_Info(33,10000002,,2,"4",0,"",1,"",,"","1,16","1,16","1,16","1,16","1,16","1,16"),
	[33] = new Cfg_t_towerdefense_s_Info(34,10000003,,2,"4",0,"",1,"",,"","1,17","1,17","1,17","1,17","1,17","1,17"),
	[34] = new Cfg_t_towerdefense_s_Info(35,10000004,,2,"4",0,"",2,"",,"","1,18","1,18","1,18","1,18","1,18","1,18"),
	[35] = new Cfg_t_towerdefense_s_Info(36,10000005,,2,"4",0,"",2,"",,"","1,19","1,19","1,19","1,19","1,19","1,19"),
	[36] = new Cfg_t_towerdefense_s_Info(37,10000006,,2,"4",0,"",2,"",,"","1,20","1,20","1,20","1,20","1,20","1,20"),
	[37] = new Cfg_t_towerdefense_s_Info(38,10000007,,2,"4",0,"",3,"",,"","1,21","1,21","1,21","1,21","1,21","1,21"),
	[38] = new Cfg_t_towerdefense_s_Info(39,10000008,,2,"4",0,"",3,"",,"","1,22","1,22","1,22","1,22","1,22","1,22"),
	[39] = new Cfg_t_towerdefense_s_Info(40,10000009,,2,"4",0,"",3,"",,"","1,23","1,23","1,23","1,23","1,23","1,23"),
	[40] = new Cfg_t_towerdefense_s_Info(41,10000010,,2,"4",0,"",4,"",,"","1,24","1,24","1,24","1,24","1,24","1,24"),
	[41] = new Cfg_t_towerdefense_s_Info(42,10000011,,2,"4",0,"",4,"",,"","1,25","1,25","1,25","1,25","1,25","1,25"),
	[42] = new Cfg_t_towerdefense_s_Info(43,10000012,,2,"4",0,"",4,"",,"","1,26","1,26","1,26","1,26","1,26","1,26"),
	[43] = new Cfg_t_towerdefense_s_Info(44,10000013,,2,"4",0,"",5,"",,"","1,27","1,27","1,27","1,27","1,27","1,27"),
	[44] = new Cfg_t_towerdefense_s_Info(45,10000014,,2,"4",0,"",5,"",,"","1,28","1,28","1,28","1,28","1,28","1,28"),
	[45] = new Cfg_t_towerdefense_s_Info(46,10000015,,2,"4",0,"",5,"",,"","1,29","1,29","1,29","1,29","1,29","1,29"),
	[46] = new Cfg_t_towerdefense_s_Info(47,10000016,,1,"3",0,"",1,"",,"","1,30","1,30","1,30","1,30","1,30","1,30"),
	[47] = new Cfg_t_towerdefense_s_Info(48,10000017,,1,"3",0,"",1,"",,"","1,31","1,31","1,31","1,31","1,31","1,31"),
	[48] = new Cfg_t_towerdefense_s_Info(49,10000018,,1,"3",0,"",2,"",,"","1,32","1,32","1,32","1,32","1,32","1,32"),
	[49] = new Cfg_t_towerdefense_s_Info(50,10000019,,1,"3",0,"",2,"",,"","1,33","1,33","1,33","1,33","1,33","1,33"),
	[50] = new Cfg_t_towerdefense_s_Info(51,10000020,,1,"3",0,"",3,"",,"","1,34","1,34","1,34","1,34","1,34","1,34"),
	[51] = new Cfg_t_towerdefense_s_Info(52,10000021,,1,"3",0,"",3,"",,"","1,35","1,35","1,35","1,35","1,35","1,35"),
	[52] = new Cfg_t_towerdefense_s_Info(53,10000022,,1,"3",0,"",4,"",,"","1,36","1,36","1,36","1,36","1,36","1,36"),
	[53] = new Cfg_t_towerdefense_s_Info(54,10000023,,1,"3",0,"",4,"",,"","1,37","1,37","1,37","1,37","1,37","1,37"),
	[54] = new Cfg_t_towerdefense_s_Info(55,10000024,,1,"3",0,"",5,"",,"","1,38","1,38","1,38","1,38","1,38","1,38"),
	[55] = new Cfg_t_towerdefense_s_Info(56,10000025,,1,"3",0,"",5,"",,"","1,39","1,39","1,39","1,39","1,39","1,39"),
	[56] = new Cfg_t_towerdefense_s_Info(57,10000026,,2,"4",1,"1,2,3",1,"",,"","1,40","1,40","1,40","1,40","1,40","1,40"),
	[57] = new Cfg_t_towerdefense_s_Info(58,10000027,,2,"4",1,"1,2,3",1,"",,"","1,41","1,41","1,41","1,41","1,41","1,41"),
	[58] = new Cfg_t_towerdefense_s_Info(59,10000028,,2,"4",1,"1,2,3",2,"",,"","1,42","1,42","1,42","1,42","1,42","1,42"),
	[59] = new Cfg_t_towerdefense_s_Info(60,10000029,,2,"4",1,"1,2,3",2,"",,"","1,43","1,43","1,43","1,43","1,43","1,43"),
	[60] = new Cfg_t_towerdefense_s_Info(61,10000030,,2,"4",1,"1,2,3",3,"",,"","1,44","1,44","1,44","1,44","1,44","1,44"),
	[61] = new Cfg_t_towerdefense_s_Info(62,10000031,,2,"4",1,"1,2,3",3,"",,"","1,45","1,45","1,45","1,45","1,45","1,45"),
	[62] = new Cfg_t_towerdefense_s_Info(63,10000032,,2,"4",1,"1,2,3",4,"",,"","1,46","1,46","1,46","1,46","1,46","1,46"),
	[63] = new Cfg_t_towerdefense_s_Info(64,10000033,,2,"4",1,"1,2,3",4,"",,"","1,47","1,47","1,47","1,47","1,47","1,47"),
	[64] = new Cfg_t_towerdefense_s_Info(65,10000034,,2,"4",1,"1,2,3",5,"",,"","1,48","1,48","1,48","1,48","1,48","1,48"),
	[65] = new Cfg_t_towerdefense_s_Info(66,10000035,,2,"4",1,"1,2,3",5,"",,"","1,49","1,49","1,49","1,49","1,49","1,49"),
};
}
