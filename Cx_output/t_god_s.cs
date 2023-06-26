using System.Collections.Generic;
public class Cfg_t_god_s_Info
{
public int id;
public int a_base_god_id;
public int a_base_god_type;
public int a_base_god_name;
public int c_base_godprefab_id;
public int c_base_first_skill;
public int c_base_second_skill;
public int c_base_third_skill;
public int c_base_fourth_skill;
public string c_base_god_skillicon;
public string c_arrayints_skill_type;
public string a_arrayints_god_unlock;
public string c_arrayints_god_skillname;
public string c_arrayints_god_attr;
public string c_vector3_position;
public string c_vector3_scale;
public Cfg_t_god_s_Info(int id,int a_base_god_id,int a_base_god_type,int a_base_god_name,int c_base_godprefab_id,int c_base_first_skill,int c_base_second_skill,int c_base_third_skill,int c_base_fourth_skill,string c_base_god_skillicon,string c_arrayints_skill_type,string a_arrayints_god_unlock,string c_arrayints_god_skillname,string c_arrayints_god_attr,string c_vector3_position,string c_vector3_scale)
{
  this.id = id;
  this.a_base_god_id = a_base_god_id;
  this.a_base_god_type = a_base_god_type;
  this.a_base_god_name = a_base_god_name;
  this.c_base_godprefab_id = c_base_godprefab_id;
  this.c_base_first_skill = c_base_first_skill;
  this.c_base_second_skill = c_base_second_skill;
  this.c_base_third_skill = c_base_third_skill;
  this.c_base_fourth_skill = c_base_fourth_skill;
  this.c_base_god_skillicon = c_base_god_skillicon;
  this.c_arrayints_skill_type = c_arrayints_skill_type;
  this.a_arrayints_god_unlock = a_arrayints_god_unlock;
  this.c_arrayints_god_skillname = c_arrayints_god_skillname;
  this.c_arrayints_god_attr = c_arrayints_god_attr;
  this.c_vector3_position = c_vector3_position;
  this.c_vector3_scale = c_vector3_scale;
}
}
public class Cfg_t_god_s
{
public static List<Cfg_t_god_s_Info> list = new List<Cfg_t_god_s_Info>()
{
	[0] = new Cfg_t_god_s_Info(1,1,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,1","7001;7002;7003;7004","1,2400;3,100","0.86,-0.44,7.35","2,2,2"),
	[1] = new Cfg_t_god_s_Info(2,2,5,54,46000003,10801,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,2","7001;7002;7003;7004","1,2880;3,120","0.86,-0.44,7.35","2,2,2"),
	[2] = new Cfg_t_god_s_Info(3,3,5,54,46000003,,10807,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,3","7001;7002;7003;7004","1,3456;3,144","0.86,-0.44,7.35","2,2,2"),
	[3] = new Cfg_t_god_s_Info(4,4,5,54,46000003,,,10813,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,4","7001;7002;7003;7004","1,4148;3,173","0.86,-0.44,7.35","2,2,2"),
	[4] = new Cfg_t_god_s_Info(5,5,5,54,46000003,,,,10819,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,5","7001;7002;7003;7004","1,4977;3,208","0.86,-0.44,7.35","2,2,2"),
	[5] = new Cfg_t_god_s_Info(6,6,5,54,46000003,10802,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,6","7001;7002;7003;7004","1,5972;3,249","0.86,-0.44,7.35","2,2,2"),
	[6] = new Cfg_t_god_s_Info(7,7,5,54,46000003,,10808,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,7","7001;7002;7003;7004","1,7167;3,299","0.86,-0.44,7.35","2,2,2"),
	[7] = new Cfg_t_god_s_Info(8,8,5,54,46000003,,,10814,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,8","7001;7002;7003;7004","1,8600;3,359","0.86,-0.44,7.35","2,2,2"),
	[8] = new Cfg_t_god_s_Info(9,9,5,54,46000003,,,,10820,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,9","7001;7002;7003;7004","1,10320;3,430","0.86,-0.44,7.35","2,2,2"),
	[9] = new Cfg_t_god_s_Info(10,10,5,54,46000003,10803,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,10","7001;7002;7003;7004","1,12384;3,516","0.86,-0.44,7.35","2,2,2"),
	[10] = new Cfg_t_god_s_Info(11,11,5,54,46000003,,10809,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,11","7001;7002;7003;7004","1,14861;3,620","0.86,-0.44,7.35","2,2,2"),
	[11] = new Cfg_t_god_s_Info(12,12,5,54,46000003,,,10815,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,12","7001;7002;7003;7004","1,17833;3,744","0.86,-0.44,7.35","2,2,2"),
	[12] = new Cfg_t_god_s_Info(13,13,5,54,46000003,,,,10821,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,13","7001;7002;7003;7004","1,21399;3,892","0.86,-0.44,7.35","2,2,2"),
	[13] = new Cfg_t_god_s_Info(14,14,5,54,46000003,10804,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,14","7001;7002;7003;7004","1,25679;3,1070","0.86,-0.44,7.35","2,2,2"),
	[14] = new Cfg_t_god_s_Info(15,15,5,54,46000003,,10810,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,15","7001;7002;7003;7004","1,30815;3,1284","0.86,-0.44,7.35","2,2,2"),
	[15] = new Cfg_t_god_s_Info(16,16,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,16","7001;7002;7003;7004","1,36977;3,1541","0.86,-0.44,7.35","2,2,2"),
	[16] = new Cfg_t_god_s_Info(17,17,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,17","7001;7002;7003;7004","1,44373;3,1849","0.86,-0.44,7.35","2,2,2"),
	[17] = new Cfg_t_god_s_Info(18,18,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,18","7001;7002;7003;7004","1,53247;3,2219","0.86,-0.44,7.35","2,2,2"),
	[18] = new Cfg_t_god_s_Info(19,19,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,19","7001;7002;7003;7004","1,63896;3,2663","0.86,-0.44,7.35","2,2,2"),
	[19] = new Cfg_t_god_s_Info(20,20,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,20","7001;7002;7003;7004","1,76676;3,3195","0.86,-0.44,7.35","2,2,2"),
	[20] = new Cfg_t_god_s_Info(21,21,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,21","7001;7002;7003;7004","1,92011;3,3834","0.86,-0.44,7.35","2,2,2"),
	[21] = new Cfg_t_god_s_Info(22,22,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,22","7001;7002;7003;7004","1,110413;3,4601","0.86,-0.44,7.35","2,2,2"),
	[22] = new Cfg_t_god_s_Info(23,23,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,23","7001;7002;7003;7004","1,132495;3,5521","0.86,-0.44,7.35","2,2,2"),
	[23] = new Cfg_t_god_s_Info(24,24,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,24","7001;7002;7003;7004","1,158994;3,6625","0.86,-0.44,7.35","2,2,2"),
	[24] = new Cfg_t_god_s_Info(25,25,5,54,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","5,25","7001;7002;7003;7004","1,190793;3,7950","0.86,-0.44,7.35","2,2,2"),
	[25] = new Cfg_t_god_s_Info(26,26,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,1","7005;7006;7007;7008","1,2400;3,100","0.86,-0.44,7.35","2,2,2"),
	[26] = new Cfg_t_god_s_Info(27,27,6,55,46000003,10825,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,2","7005;7006;7007;7008","1,2880;3,120","0.86,-0.44,7.35","2,2,2"),
	[27] = new Cfg_t_god_s_Info(28,28,6,55,46000003,,10831,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,3","7005;7006;7007;7008","1,3456;3,144","0.86,-0.44,7.35","2,2,2"),
	[28] = new Cfg_t_god_s_Info(29,29,6,55,46000003,,,10837,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,4","7005;7006;7007;7008","1,4148;3,173","0.86,-0.44,7.35","2,2,2"),
	[29] = new Cfg_t_god_s_Info(30,30,6,55,46000003,,,,10843,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,5","7005;7006;7007;7008","1,4977;3,208","0.86,-0.44,7.35","2,2,2"),
	[30] = new Cfg_t_god_s_Info(31,31,6,55,46000003,10826,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,6","7005;7006;7007;7008","1,5972;3,249","0.86,-0.44,7.35","2,2,2"),
	[31] = new Cfg_t_god_s_Info(32,32,6,55,46000003,,10832,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,7","7005;7006;7007;7008","1,7167;3,299","0.86,-0.44,7.35","2,2,2"),
	[32] = new Cfg_t_god_s_Info(33,33,6,55,46000003,,,10838,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,8","7005;7006;7007;7008","1,8600;3,359","0.86,-0.44,7.35","2,2,2"),
	[33] = new Cfg_t_god_s_Info(34,34,6,55,46000003,,,,10844,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,9","7005;7006;7007;7008","1,10320;3,430","0.86,-0.44,7.35","2,2,2"),
	[34] = new Cfg_t_god_s_Info(35,35,6,55,46000003,10827,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,10","7005;7006;7007;7008","1,12384;3,516","0.86,-0.44,7.35","2,2,2"),
	[35] = new Cfg_t_god_s_Info(36,36,6,55,46000003,,10833,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,11","7005;7006;7007;7008","1,14861;3,620","0.86,-0.44,7.35","2,2,2"),
	[36] = new Cfg_t_god_s_Info(37,37,6,55,46000003,,,10839,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,12","7005;7006;7007;7008","1,17833;3,744","0.86,-0.44,7.35","2,2,2"),
	[37] = new Cfg_t_god_s_Info(38,38,6,55,46000003,,,,10845,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,13","7005;7006;7007;7008","1,21399;3,892","0.86,-0.44,7.35","2,2,2"),
	[38] = new Cfg_t_god_s_Info(39,39,6,55,46000003,10828,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,14","7005;7006;7007;7008","1,25679;3,1070","0.86,-0.44,7.35","2,2,2"),
	[39] = new Cfg_t_god_s_Info(40,40,6,55,46000003,,10834,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,15","7005;7006;7007;7008","1,30815;3,1284","0.86,-0.44,7.35","2,2,2"),
	[40] = new Cfg_t_god_s_Info(41,41,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,16","7005;7006;7007;7008","1,36977;3,1541","0.86,-0.44,7.35","2,2,2"),
	[41] = new Cfg_t_god_s_Info(42,42,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,17","7005;7006;7007;7008","1,44373;3,1849","0.86,-0.44,7.35","2,2,2"),
	[42] = new Cfg_t_god_s_Info(43,43,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,18","7005;7006;7007;7008","1,53247;3,2219","0.86,-0.44,7.35","2,2,2"),
	[43] = new Cfg_t_god_s_Info(44,44,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,19","7005;7006;7007;7008","1,63896;3,2663","0.86,-0.44,7.35","2,2,2"),
	[44] = new Cfg_t_god_s_Info(45,45,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,20","7005;7006;7007;7008","1,76676;3,3195","0.86,-0.44,7.35","2,2,2"),
	[45] = new Cfg_t_god_s_Info(46,46,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,21","7005;7006;7007;7008","1,92011;3,3834","0.86,-0.44,7.35","2,2,2"),
	[46] = new Cfg_t_god_s_Info(47,47,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,22","7005;7006;7007;7008","1,110413;3,4601","0.86,-0.44,7.35","2,2,2"),
	[47] = new Cfg_t_god_s_Info(48,48,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,23","7005;7006;7007;7008","1,132495;3,5521","0.86,-0.44,7.35","2,2,2"),
	[48] = new Cfg_t_god_s_Info(49,49,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,24","7005;7006;7007;7008","1,158994;3,6625","0.86,-0.44,7.35","2,2,2"),
	[49] = new Cfg_t_god_s_Info(50,50,6,55,46000003,,,,,"jineng1;jineng2;jineng3;jineng1","1;2;1;2","6,25","7005;7006;7007;7008","1,190793;3,7950","0.86,-0.44,7.35","2,2,2"),
};
}
