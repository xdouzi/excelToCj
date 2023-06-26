using System.Collections.Generic;
public class t_towerdefense_sInfo
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
public t_towerdefense_sInfo(int id,int a_base_unit_id,int a_base_unitgroup_id,int a_base_unit_kind,string a_ints_unit_type,int a_base_build_date,string a_ints_land_type,int a_base_color_type,string a_ints_unlock_config,int a_base_star,string a_base_star_id_num,string a_ints_star_recovery,int a_base_basedamage,int a_base_blood_num,int a_base_blood_recovery,int a_base_buff_id,int a_base_buff_time)
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
public static List<t_towerdefense_sInfo> list = new List<t_towerdefense_sInfo>()
{
	[0] = new t_towerdefense_sInfo(1,1,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[1] = new t_towerdefense_sInfo(2,2,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[2] = new t_towerdefense_sInfo(3,3,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[3] = new t_towerdefense_sInfo(4,4,,3,"1,2,3,4",1,"1,2,3",10,"0",0,"","","","","","",""),
	[4] = new t_towerdefense_sInfo(5,5,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[5] = new t_towerdefense_sInfo(6,6,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[6] = new t_towerdefense_sInfo(7,7,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[7] = new t_towerdefense_sInfo(8,8,,3,"1,2,3",1,"4",10,"0",0,"","","","","","",""),
	[8] = new t_towerdefense_sInfo(9,11,,3,"4",1,"4",10,"3,1",0,"","","","","","",""),
	[9] = new t_towerdefense_sInfo(10,12,,3,"4",1,"4",10,"3,3",0,"","","","","","",""),
	[10] = new t_towerdefense_sInfo(11,13,,3,"4",1,"4",10,"3,5",0,"","","","","","",""),
	[11] = new t_towerdefense_sInfo(12,14,,3,"1,2,3,5",1,"4",10,"3,7",0,"","","","","","",""),
	[12] = new t_towerdefense_sInfo(13,21,,3,"4",1,"4",10,"3,1",0,"","","","","","",""),
	[13] = new t_towerdefense_sInfo(14,22,,3,"4",1,"4",10,"3,3",0,"","","","","","",""),
	[14] = new t_towerdefense_sInfo(15,23,,3,"4",1,"4",10,"3,5",0,"","","","","","",""),
	[15] = new t_towerdefense_sInfo(16,24,,3,"5",1,"4",10,"3,7",0,"","","","","","",""),
	[16] = new t_towerdefense_sInfo(17,11101,1,1,"2",0,"",1,"",1,"","1,0",10000,1,2000,2000,2000),
	[17] = new t_towerdefense_sInfo(18,12101,2,1,"2",0,"",1,"",2,"11101,3","1,1",15000,2,,1001,0),
	[18] = new t_towerdefense_sInfo(19,13101,,1,"2",0,"",1,"",3,"12101,3","1,2",20000,5,,1002,0),
	[19] = new t_towerdefense_sInfo(20,11201,,1,"1",0,"",2,"",1,"","1,3",10000,1,2000,2000,2000),
	[20] = new t_towerdefense_sInfo(21,12201,,1,"1",0,"",2,"",2,"11201,3","1,4",15000,2,,2001,0),
	[21] = new t_towerdefense_sInfo(22,13201,,1,"1",0,"",2,"",3,"12201,3","1,5",20000,5,,2002,0),
	[22] = new t_towerdefense_sInfo(23,11301,,1,"2",0,"",3,"",1,"","1,6",10000,1,2000,2000,2000),
	[23] = new t_towerdefense_sInfo(24,12301,,1,"2",0,"",3,"",2,"11301,3","1,7",15000,2,,3001,0),
	[24] = new t_towerdefense_sInfo(25,13301,,1,"2",0,"",3,"",3,"12301,3","1,8",20000,5,,3002,0),
	[25] = new t_towerdefense_sInfo(26,11401,,1,"3",0,"",4,"",1,"","1,9",10000,1,2000,2000,2000),
	[26] = new t_towerdefense_sInfo(27,12401,,1,"3",0,"",4,"",2,"11401,3","1,10",15000,2,,4001,0),
	[27] = new t_towerdefense_sInfo(28,13401,,1,"3",0,"",4,"",3,"12401,3","1,11",20000,5,,4002,0),
	[28] = new t_towerdefense_sInfo(29,11501,,1,"2",0,"",5,"",1,"","1,12",10000,1,2000,2000,2000),
	[29] = new t_towerdefense_sInfo(30,12501,,1,"2",0,"",5,"",2,"11501,3","1,13",15000,2,,5001,0),
	[30] = new t_towerdefense_sInfo(31,13501,,1,"2",0,"",5,"",3,"12501,3","1,14",20000,5,,5002,0),
	[31] = new t_towerdefense_sInfo(32,10000001,,2,"4",0,"",1,"",,"","1,15","1,15","1,15","1,15","1,15","1,15"),
	[32] = new t_towerdefense_sInfo(33,10000002,,2,"4",0,"",1,"",,"","1,16","1,16","1,16","1,16","1,16","1,16"),
	[33] = new t_towerdefense_sInfo(34,10000003,,2,"4",0,"",1,"",,"","1,17","1,17","1,17","1,17","1,17","1,17"),
	[34] = new t_towerdefense_sInfo(35,10000004,,2,"4",0,"",2,"",,"","1,18","1,18","1,18","1,18","1,18","1,18"),
	[35] = new t_towerdefense_sInfo(36,10000005,,2,"4",0,"",2,"",,"","1,19","1,19","1,19","1,19","1,19","1,19"),
	[36] = new t_towerdefense_sInfo(37,10000006,,2,"4",0,"",2,"",,"","1,20","1,20","1,20","1,20","1,20","1,20"),
	[37] = new t_towerdefense_sInfo(38,10000007,,2,"4",0,"",3,"",,"","1,21","1,21","1,21","1,21","1,21","1,21"),
	[38] = new t_towerdefense_sInfo(39,10000008,,2,"4",0,"",3,"",,"","1,22","1,22","1,22","1,22","1,22","1,22"),
	[39] = new t_towerdefense_sInfo(40,10000009,,2,"4",0,"",3,"",,"","1,23","1,23","1,23","1,23","1,23","1,23"),
	[40] = new t_towerdefense_sInfo(41,10000010,,2,"4",0,"",4,"",,"","1,24","1,24","1,24","1,24","1,24","1,24"),
	[41] = new t_towerdefense_sInfo(42,10000011,,2,"4",0,"",4,"",,"","1,25","1,25","1,25","1,25","1,25","1,25"),
	[42] = new t_towerdefense_sInfo(43,10000012,,2,"4",0,"",4,"",,"","1,26","1,26","1,26","1,26","1,26","1,26"),
	[43] = new t_towerdefense_sInfo(44,10000013,,2,"4",0,"",5,"",,"","1,27","1,27","1,27","1,27","1,27","1,27"),
	[44] = new t_towerdefense_sInfo(45,10000014,,2,"4",0,"",5,"",,"","1,28","1,28","1,28","1,28","1,28","1,28"),
	[45] = new t_towerdefense_sInfo(46,10000015,,2,"4",0,"",5,"",,"","1,29","1,29","1,29","1,29","1,29","1,29"),
	[46] = new t_towerdefense_sInfo(47,10000016,,1,"3",0,"",1,"",,"","1,30","1,30","1,30","1,30","1,30","1,30"),
	[47] = new t_towerdefense_sInfo(48,10000017,,1,"3",0,"",1,"",,"","1,31","1,31","1,31","1,31","1,31","1,31"),
	[48] = new t_towerdefense_sInfo(49,10000018,,1,"3",0,"",2,"",,"","1,32","1,32","1,32","1,32","1,32","1,32"),
	[49] = new t_towerdefense_sInfo(50,10000019,,1,"3",0,"",2,"",,"","1,33","1,33","1,33","1,33","1,33","1,33"),
	[50] = new t_towerdefense_sInfo(51,10000020,,1,"3",0,"",3,"",,"","1,34","1,34","1,34","1,34","1,34","1,34"),
	[51] = new t_towerdefense_sInfo(52,10000021,,1,"3",0,"",3,"",,"","1,35","1,35","1,35","1,35","1,35","1,35"),
	[52] = new t_towerdefense_sInfo(53,10000022,,1,"3",0,"",4,"",,"","1,36","1,36","1,36","1,36","1,36","1,36"),
	[53] = new t_towerdefense_sInfo(54,10000023,,1,"3",0,"",4,"",,"","1,37","1,37","1,37","1,37","1,37","1,37"),
	[54] = new t_towerdefense_sInfo(55,10000024,,1,"3",0,"",5,"",,"","1,38","1,38","1,38","1,38","1,38","1,38"),
	[55] = new t_towerdefense_sInfo(56,10000025,,1,"3",0,"",5,"",,"","1,39","1,39","1,39","1,39","1,39","1,39"),
	[56] = new t_towerdefense_sInfo(57,10000026,,2,"4",1,"1,2,3",1,"",,"","1,40","1,40","1,40","1,40","1,40","1,40"),
	[57] = new t_towerdefense_sInfo(58,10000027,,2,"4",1,"1,2,3",1,"",,"","1,41","1,41","1,41","1,41","1,41","1,41"),
	[58] = new t_towerdefense_sInfo(59,10000028,,2,"4",1,"1,2,3",2,"",,"","1,42","1,42","1,42","1,42","1,42","1,42"),
	[59] = new t_towerdefense_sInfo(60,10000029,,2,"4",1,"1,2,3",2,"",,"","1,43","1,43","1,43","1,43","1,43","1,43"),
	[60] = new t_towerdefense_sInfo(61,10000030,,2,"4",1,"1,2,3",3,"",,"","1,44","1,44","1,44","1,44","1,44","1,44"),
	[61] = new t_towerdefense_sInfo(62,10000031,,2,"4",1,"1,2,3",3,"",,"","1,45","1,45","1,45","1,45","1,45","1,45"),
	[62] = new t_towerdefense_sInfo(63,10000032,,2,"4",1,"1,2,3",4,"",,"","1,46","1,46","1,46","1,46","1,46","1,46"),
	[63] = new t_towerdefense_sInfo(64,10000033,,2,"4",1,"1,2,3",4,"",,"","1,47","1,47","1,47","1,47","1,47","1,47"),
	[64] = new t_towerdefense_sInfo(65,10000034,,2,"4",1,"1,2,3",5,"",,"","1,48","1,48","1,48","1,48","1,48","1,48"),
	[65] = new t_towerdefense_sInfo(66,10000035,,2,"4",1,"1,2,3",5,"",,"","1,49","1,49","1,49","1,49","1,49","1,49"),
};
}
