using System.Collections.Generic;
public class t_achievement_sInfo
{
public int id;
public int a_base_achievement_id;
public int a_base_receive;
public int c_base_name;
public int c_base_border;
public string c_base_icon;
public string a_arrayints_unlock;
public string a_arrayints_complete;
public string a_base_next_task;
public int a_base_award;
public t_achievement_sInfo(int id,int a_base_achievement_id,int a_base_receive,int c_base_name,int c_base_border,string c_base_icon,string a_arrayints_unlock,string a_arrayints_complete,string a_base_next_task,int a_base_award)
{
  this.id = id;
  this.a_base_achievement_id = a_base_achievement_id;
  this.a_base_receive = a_base_receive;
  this.c_base_name = c_base_name;
  this.c_base_border = c_base_border;
  this.c_base_icon = c_base_icon;
  this.a_arrayints_unlock = a_arrayints_unlock;
  this.a_arrayints_complete = a_arrayints_complete;
  this.a_base_next_task = a_base_next_task;
  this.a_base_award = a_base_award;
}
}
public class Cfg_t_achievement_s
{
public static List<t_achievement_sInfo> list = new List<t_achievement_sInfo>()
{
	[0] = new t_achievement_sInfo(1,101,0,500101,0,"","","2,1,2","102",1002),
	[1] = new t_achievement_sInfo(2,102,1,500102,0,"","","2,1,3","103",1003),
	[2] = new t_achievement_sInfo(3,103,1,500103,0,"","","2,1,4","104",1004),
	[3] = new t_achievement_sInfo(4,104,1,500104,0,"","","2,1,5","105",1005),
	[4] = new t_achievement_sInfo(5,105,1,500105,1,"","","2,1,6","",1006),
	[5] = new t_achievement_sInfo(6,201,0,500201,0,"","6,2","2,2,2","202",1002),
	[6] = new t_achievement_sInfo(7,202,1,500202,0,"","","2,2,3","203",1003),
	[7] = new t_achievement_sInfo(8,203,1,500203,0,"","","2,2,4","204",1004),
	[8] = new t_achievement_sInfo(9,204,1,500204,0,"","","2,2,5","205",1005),
	[9] = new t_achievement_sInfo(10,205,1,500205,1,"","","2,2,6","",1006),
	[10] = new t_achievement_sInfo(11,301,0,500301,0,"","","24,-2,3000","302",1002),
	[11] = new t_achievement_sInfo(12,302,1,500302,0,"","","24,-2,5000","303",1003),
	[12] = new t_achievement_sInfo(13,303,1,500303,0,"","","24,-2,7000","304",1004),
	[13] = new t_achievement_sInfo(14,304,1,500304,0,"","","24,-2,9000","305",1005),
	[14] = new t_achievement_sInfo(15,305,1,500305,1,"","","24,-2,15000","",1006),
	[15] = new t_achievement_sInfo(16,401,0,500401,0,"","","23,-101,500","402",1002),
	[16] = new t_achievement_sInfo(17,402,1,500402,0,"","","23,-101,1000","403",1003),
	[17] = new t_achievement_sInfo(18,403,1,500403,0,"","","23,-101,2000","404",1004),
	[18] = new t_achievement_sInfo(19,404,1,500404,0,"","","23,-101,4000","405",1005),
	[19] = new t_achievement_sInfo(20,405,1,500405,1,"","","23,-101,8000","",1006),
};
}