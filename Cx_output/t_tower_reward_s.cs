using System.Collections.Generic;
public class t_tower_reward_sInfo
{
public int id;
public int a_base_award_id;
public int a_base_level_id;
public int a_base_level_reward;
public t_tower_reward_sInfo(int id,int a_base_award_id,int a_base_level_id,int a_base_level_reward)
{
  this.id = id;
  this.a_base_award_id = a_base_award_id;
  this.a_base_level_id = a_base_level_id;
  this.a_base_level_reward = a_base_level_reward;
}
}
public class Cfg_t_tower_reward_s
{
public static List<t_tower_reward_sInfo> list = new List<t_tower_reward_sInfo>()
{
	[0] = new t_tower_reward_sInfo(1,1,3000005,20001),
	[1] = new t_tower_reward_sInfo(2,2,3000010,20001),
	[2] = new t_tower_reward_sInfo(3,3,3000015,20001),
	[3] = new t_tower_reward_sInfo(4,4,3000020,20001),
	[4] = new t_tower_reward_sInfo(5,5,3000025,20002),
	[5] = new t_tower_reward_sInfo(6,6,3000030,20002),
	[6] = new t_tower_reward_sInfo(7,7,3000035,20002),
	[7] = new t_tower_reward_sInfo(8,8,3000040,20002),
	[8] = new t_tower_reward_sInfo(9,9,3000045,20003),
	[9] = new t_tower_reward_sInfo(10,10,3000050,20003),
	[10] = new t_tower_reward_sInfo(11,11,3000055,20003),
	[11] = new t_tower_reward_sInfo(12,12,3000060,20003),
	[12] = new t_tower_reward_sInfo(13,13,3000065,20004),
	[13] = new t_tower_reward_sInfo(14,14,3000070,20004),
	[14] = new t_tower_reward_sInfo(15,15,3000075,20004),
	[15] = new t_tower_reward_sInfo(16,16,3000080,20004),
	[16] = new t_tower_reward_sInfo(17,17,3000085,20005),
	[17] = new t_tower_reward_sInfo(18,18,3000090,20005),
	[18] = new t_tower_reward_sInfo(19,19,3000095,20005),
	[19] = new t_tower_reward_sInfo(20,20,3000100,20005),
};
}
