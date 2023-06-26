using System.Collections.Generic;
public class Cfg_t_active_value_s_Info
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
public Cfg_t_active_value_s_Info(int id,int a_base_task_id,int a_base_operater_id,int c_base_desc,int a_base_task_type,int a_base_reissue,int a_base_automatic,int a_base_group,int a_base_receive,string a_arrayints_get_task,string a_arrayints_accomplish,string a_base_next_task,int a_base_rank,int a_base_reward,string c_ints_button,string a_arrayints_plotint id,int a_base_active_value_id,int a_base_operater_id,int a_base_min_lv,int a_base_max_lv,int a_base_task_type,int a_base_active_value,int a_base_reward,int a_base_reissue,int a_base_automatic,string c_base_gift_bag)
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
public static List<Cfg_t_active_value_s_Info> list = new List<Cfg_t_active_value_s_Info>()
{
	[0] = new Cfg_t_active_value_s_Info(1,10001,0,1,6,0,20,2001,0,0,""),
	[1] = new Cfg_t_active_value_s_Info(2,10002,0,1,6,0,40,2002,0,0,""),
	[2] = new Cfg_t_active_value_s_Info(3,10003,0,1,6,0,60,2003,0,0,""),
	[3] = new Cfg_t_active_value_s_Info(4,10004,0,1,6,0,80,2004,0,0,""),
	[4] = new Cfg_t_active_value_s_Info(5,10005,0,1,6,0,100,2005,0,0,""),
	[5] = new Cfg_t_active_value_s_Info(6,10011,0,7,12,0,20,2005,0,0,""),
	[6] = new Cfg_t_active_value_s_Info(7,10012,0,7,12,0,40,2004,0,0,""),
	[7] = new Cfg_t_active_value_s_Info(8,10013,0,7,12,0,60,2003,0,0,""),
	[8] = new Cfg_t_active_value_s_Info(9,10014,0,7,12,0,80,2002,0,0,""),
	[9] = new Cfg_t_active_value_s_Info(10,10015,0,7,12,0,100,2001,0,0,""),
	[10] = new Cfg_t_active_value_s_Info(11,11001,0,1,6,1,20,2016,0,0,""),
	[11] = new Cfg_t_active_value_s_Info(12,11002,0,1,6,1,40,2017,0,0,""),
	[12] = new Cfg_t_active_value_s_Info(13,11003,0,1,6,1,60,2018,0,0,""),
	[13] = new Cfg_t_active_value_s_Info(14,11004,0,1,6,1,80,2019,0,0,""),
	[14] = new Cfg_t_active_value_s_Info(15,11005,0,1,6,1,100,2020,0,0,""),
	[15] = new Cfg_t_active_value_s_Info(16,11011,0,7,12,1,20,2020,0,0,""),
	[16] = new Cfg_t_active_value_s_Info(17,11012,0,7,12,1,40,2019,0,0,""),
	[17] = new Cfg_t_active_value_s_Info(18,11013,0,7,12,1,60,2018,0,0,""),
	[18] = new Cfg_t_active_value_s_Info(19,11014,0,7,12,1,80,2017,0,0,""),
	[19] = new Cfg_t_active_value_s_Info(20,11015,0,7,12,1,100,2016,0,0,""),
};
}
