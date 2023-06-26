using System.Collections.Generic;
public class t_active_value_sInfo
{
public int id;
public int a_base_active_value_id;
public int a_base_operater_id;
public int a_base_min_lv;
public int a_base_max_lv;
public int a_base_task_type;
public int a_base_active_value;
public int a_base_reward;
public int a_base_reissue;
public int a_base_automatic;
public string c_base_gift_bag;
public t_active_value_sInfo(int id,int a_base_task_id,int a_base_operater_id,int c_base_desc,int a_base_task_type,int a_base_reissue,int a_base_automatic,int a_base_group,int a_base_receive,string a_arrayints_get_task,string a_arrayints_accomplish,string a_base_next_task,int a_base_rank,int a_base_reward,string c_ints_button,string a_arrayints_plotint id,int a_base_active_value_id,int a_base_operater_id,int a_base_min_lv,int a_base_max_lv,int a_base_task_type,int a_base_active_value,int a_base_reward,int a_base_reissue,int a_base_automatic,string c_base_gift_bag)
{
  this.id = id;
  this.a_base_active_value_id = a_base_active_value_id;
  this.a_base_operater_id = a_base_operater_id;
  this.a_base_min_lv = a_base_min_lv;
  this.a_base_max_lv = a_base_max_lv;
  this.a_base_task_type = a_base_task_type;
  this.a_base_active_value = a_base_active_value;
  this.a_base_reward = a_base_reward;
  this.a_base_reissue = a_base_reissue;
  this.a_base_automatic = a_base_automatic;
  this.c_base_gift_bag = c_base_gift_bag;
}
}
public class Cfg_t_active_value_s
{
public static List<t_active_value_sInfo> list = new List<t_active_value_sInfo>()
{
	[0] = new t_active_value_sInfo(1,10001,0,1,6,0,20,2001,0,0,""),
	[1] = new t_active_value_sInfo(2,10002,0,1,6,0,40,2002,0,0,""),
	[2] = new t_active_value_sInfo(3,10003,0,1,6,0,60,2003,0,0,""),
	[3] = new t_active_value_sInfo(4,10004,0,1,6,0,80,2004,0,0,""),
	[4] = new t_active_value_sInfo(5,10005,0,1,6,0,100,2005,0,0,""),
	[5] = new t_active_value_sInfo(6,10011,0,7,12,0,20,2005,0,0,""),
	[6] = new t_active_value_sInfo(7,10012,0,7,12,0,40,2004,0,0,""),
	[7] = new t_active_value_sInfo(8,10013,0,7,12,0,60,2003,0,0,""),
	[8] = new t_active_value_sInfo(9,10014,0,7,12,0,80,2002,0,0,""),
	[9] = new t_active_value_sInfo(10,10015,0,7,12,0,100,2001,0,0,""),
	[10] = new t_active_value_sInfo(11,11001,0,1,6,1,20,2016,0,0,""),
	[11] = new t_active_value_sInfo(12,11002,0,1,6,1,40,2017,0,0,""),
	[12] = new t_active_value_sInfo(13,11003,0,1,6,1,60,2018,0,0,""),
	[13] = new t_active_value_sInfo(14,11004,0,1,6,1,80,2019,0,0,""),
	[14] = new t_active_value_sInfo(15,11005,0,1,6,1,100,2020,0,0,""),
	[15] = new t_active_value_sInfo(16,11011,0,7,12,1,20,2020,0,0,""),
	[16] = new t_active_value_sInfo(17,11012,0,7,12,1,40,2019,0,0,""),
	[17] = new t_active_value_sInfo(18,11013,0,7,12,1,60,2018,0,0,""),
	[18] = new t_active_value_sInfo(19,11014,0,7,12,1,80,2017,0,0,""),
	[19] = new t_active_value_sInfo(20,11015,0,7,12,1,100,2016,0,0,""),
};
}
