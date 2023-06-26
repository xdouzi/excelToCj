using System.Collections.Generic;
public class Cfg_t_tower_reward_s_Info
{
public int id;
public int a_base_award_id;
public int a_base_level_id;
public int a_base_level_reward;
public Cfg_t_tower_reward_s_Info(int id,int a_base_award_id,int a_base_level_id,int a_base_level_reward)
{
  this.id = id;
  this.a_base_award_id = a_base_award_id;
  this.a_base_level_id = a_base_level_id;
  this.a_base_level_reward = a_base_level_reward;
}
}
public class Cfg_t_tower_reward_s
{
public static List<Cfg_t_tower_reward_s_Info> list = new List<Cfg_t_tower_reward_s_Info>()
{
	[0] = new Cfg_t_tower_reward_s_Info(1,1,3000005,20001),
	[1] = new Cfg_t_tower_reward_s_Info(2,2,3000010,20001),
	[2] = new Cfg_t_tower_reward_s_Info(3,3,3000015,20001),
	[3] = new Cfg_t_tower_reward_s_Info(4,4,3000020,20001),
	[4] = new Cfg_t_tower_reward_s_Info(5,5,3000025,20002),
	[5] = new Cfg_t_tower_reward_s_Info(6,6,3000030,20002),
	[6] = new Cfg_t_tower_reward_s_Info(7,7,3000035,20002),
	[7] = new Cfg_t_tower_reward_s_Info(8,8,3000040,20002),
	[8] = new Cfg_t_tower_reward_s_Info(9,9,3000045,20003),
	[9] = new Cfg_t_tower_reward_s_Info(10,10,3000050,20003),
	[10] = new Cfg_t_tower_reward_s_Info(11,11,3000055,20003),
	[11] = new Cfg_t_tower_reward_s_Info(12,12,3000060,20003),
	[12] = new Cfg_t_tower_reward_s_Info(13,13,3000065,20004),
	[13] = new Cfg_t_tower_reward_s_Info(14,14,3000070,20004),
	[14] = new Cfg_t_tower_reward_s_Info(15,15,3000075,20004),
	[15] = new Cfg_t_tower_reward_s_Info(16,16,3000080,20004),
	[16] = new Cfg_t_tower_reward_s_Info(17,17,3000085,20005),
	[17] = new Cfg_t_tower_reward_s_Info(18,18,3000090,20005),
	[18] = new Cfg_t_tower_reward_s_Info(19,19,3000095,20005),
	[19] = new Cfg_t_tower_reward_s_Info(20,20,3000100,20005),
};
}
