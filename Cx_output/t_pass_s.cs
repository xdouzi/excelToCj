using System.Collections.Generic;
public class t_pass_sInfo
{
public int id;
public int a_base_pass_id;
public int a_base_pass_exp;
public string a_base_jump_level;
public t_pass_sInfo(int id,int c_e_name_id,int a_base_conditional_rewards,int a_base_activity,int a_base_type,int a_base_pass_level,int a_base_task_days,int a_base_attendance_month,string a_arrayints_unlock_conditions,string a_arrayints_claim_conditions,string a_arrayints_award,string c_ints_task_jump,int a_base_special_reward,int a_base_receive,int a_base_packs_type,string a_arrayints_duration,string a_base_open_packs,string a_base_close_packs,int c_base_showint id,int a_base_pass_id,int a_base_pass_exp,string a_base_jump_level)
{
  this.id = id;
  this.a_base_pass_id = a_base_pass_id;
  this.a_base_pass_exp = a_base_pass_exp;
  this.a_base_jump_level = a_base_jump_level;
}
}
public class Cfg_t_pass_s
{
public static List<t_pass_sInfo> list = new List<t_pass_sInfo>()
{
	[0] = new t_pass_sInfo(1,0,50,""),
	[1] = new t_pass_sInfo(2,1,60,"-1,100"),
	[2] = new t_pass_sInfo(3,2,80,"-1,100"),
	[3] = new t_pass_sInfo(4,3,100,"-1,100"),
	[4] = new t_pass_sInfo(5,4,100,"-1,100"),
	[5] = new t_pass_sInfo(6,5,100,"-1,100"),
	[6] = new t_pass_sInfo(7,6,100,"-1,100"),
	[7] = new t_pass_sInfo(8,7,100,"-1,100"),
	[8] = new t_pass_sInfo(9,8,100,"-1,100"),
	[9] = new t_pass_sInfo(10,9,100,"-1,100"),
	[10] = new t_pass_sInfo(11,10,120,"-1,100"),
	[11] = new t_pass_sInfo(12,11,120,"-1,100"),
	[12] = new t_pass_sInfo(13,12,120,"-1,100"),
	[13] = new t_pass_sInfo(14,13,120,"-1,100"),
	[14] = new t_pass_sInfo(15,14,120,"-1,100"),
	[15] = new t_pass_sInfo(16,15,120,"-1,100"),
	[16] = new t_pass_sInfo(17,16,120,"-1,100"),
	[17] = new t_pass_sInfo(18,17,120,"-1,100"),
	[18] = new t_pass_sInfo(19,18,120,"-1,100"),
	[19] = new t_pass_sInfo(20,19,120,"-1,100"),
	[20] = new t_pass_sInfo(21,20,150,"-1,100"),
	[21] = new t_pass_sInfo(22,21,150,"-1,100"),
	[22] = new t_pass_sInfo(23,22,150,"-1,100"),
	[23] = new t_pass_sInfo(24,23,150,"-1,100"),
	[24] = new t_pass_sInfo(25,24,150,"-1,100"),
	[25] = new t_pass_sInfo(26,25,150,"-1,100"),
	[26] = new t_pass_sInfo(27,26,150,"-1,100"),
	[27] = new t_pass_sInfo(28,27,150,"-1,100"),
	[28] = new t_pass_sInfo(29,28,150,"-1,100"),
	[29] = new t_pass_sInfo(30,29,150,"-1,100"),
	[30] = new t_pass_sInfo(31,30,150,"-1,100"),
	[31] = new t_pass_sInfo(32,31,150,"-1,100"),
	[32] = new t_pass_sInfo(33,32,150,"-1,100"),
	[33] = new t_pass_sInfo(34,33,150,"-1,100"),
	[34] = new t_pass_sInfo(35,34,150,"-1,100"),
	[35] = new t_pass_sInfo(36,35,,"-1,100"),
};
}
