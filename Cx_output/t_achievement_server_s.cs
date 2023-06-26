using System.Collections.Generic;
public class t_achievement_server_sInfo
{
public int id;
public int a_base_achievement_id;
public int a_base_duration;
public int c_base_name;
public int c_base_explain;
public int c_base_explain_text;
public string c_base_icon;
public string c_base_image;
public string a_arrayints_unlock;
public string a_arrayints_complete;
public int a_base_award;
public string a_arrayints_claim;
public t_achievement_server_sInfo(int id,int a_base_achievement_id,int a_base_receive,int c_base_name,int c_base_border,string c_base_icon,string a_arrayints_unlock,string a_arrayints_complete,string a_base_next_task,int a_base_awardint id,int a_base_achievement_id,int a_base_duration,int c_base_name,int c_base_explain,int c_base_explain_text,string c_base_icon,string c_base_image,string a_arrayints_unlock,string a_arrayints_complete,int a_base_award,string a_arrayints_claim)
{
  this.id = id;
  this.a_base_achievement_id = a_base_achievement_id;
  this.a_base_duration = a_base_duration;
  this.c_base_name = c_base_name;
  this.c_base_explain = c_base_explain;
  this.c_base_explain_text = c_base_explain_text;
  this.c_base_icon = c_base_icon;
  this.c_base_image = c_base_image;
  this.a_arrayints_unlock = a_arrayints_unlock;
  this.a_arrayints_complete = a_arrayints_complete;
  this.a_base_award = a_base_award;
  this.a_arrayints_claim = a_arrayints_claim;
}
}
public class Cfg_t_achievement_server_s
{
public static List<t_achievement_server_sInfo> list = new List<t_achievement_server_sInfo>()
{
	[0] = new t_achievement_server_sInfo(1,1,0,9001,9101,9201,"","","204,0,0","201,2,5",5210,"1,5,0"),
	[1] = new t_achievement_server_sInfo(2,2,432000,9002,9102,9202,"","","204,1,0","202,1,10",5220,"1,8,0"),
	[2] = new t_achievement_server_sInfo(3,3,432000,9003,9103,9203,"","","204,2,0","202,3,10",5210,"1,9,0"),
	[3] = new t_achievement_server_sInfo(4,4,0,9004,9104,9204,"","","204,3,0","203,110,5",5220,"1,10,0"),
};
}
