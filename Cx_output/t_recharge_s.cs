using System.Collections.Generic;
public class t_recharge_sInfo
{
public int id;
public int c_base_recharge_id;
public int c_base_name;
public int a_base_type;
public int a_base_recharge_gear;
public string a_arrayints_first_rewards;
public int a_base_vip_exp;
public int a_base_limit_num;
public int c_base_promotion;
public int c_base_discount;
public int c_base_slogan_discount;
public t_recharge_sInfo(int id,int c_base_recharge_id,int c_base_name,int a_base_type,int a_base_recharge_gear,string a_arrayints_first_rewards,int a_base_vip_exp,int a_base_limit_num,int c_base_promotion,int c_base_discount,int c_base_slogan_discount)
{
  this.id = id;
  this.c_base_recharge_id = c_base_recharge_id;
  this.c_base_name = c_base_name;
  this.a_base_type = a_base_type;
  this.a_base_recharge_gear = a_base_recharge_gear;
  this.a_arrayints_first_rewards = a_arrayints_first_rewards;
  this.a_base_vip_exp = a_base_vip_exp;
  this.a_base_limit_num = a_base_limit_num;
  this.c_base_promotion = c_base_promotion;
  this.c_base_discount = c_base_discount;
  this.c_base_slogan_discount = c_base_slogan_discount;
}
}
public class Cfg_t_recharge_s
{
public static List<t_recharge_sInfo> list = new List<t_recharge_sInfo>()
{
	[0] = new t_recharge_sInfo(1,1001,27001,1,6,"-5,60",60,0,0,0,0),
	[1] = new t_recharge_sInfo(2,1002,27001,1,30,"-5,300",300,0,0,0,0),
	[2] = new t_recharge_sInfo(3,1003,27001,1,68,"-5,680",680,0,0,0,0),
	[3] = new t_recharge_sInfo(4,1004,27001,1,98,"-5,980",980,0,0,0,0),
	[4] = new t_recharge_sInfo(5,1005,27001,1,128,"-5,1280",1280,0,0,0,0),
	[5] = new t_recharge_sInfo(6,1006,27001,1,328,"-5,3280",3280,0,0,0,0),
	[6] = new t_recharge_sInfo(7,1007,27001,1,648,"-5,6480",6480,0,0,0,0),
	[7] = new t_recharge_sInfo(8,2001,27001,2,98,"",980,1,0,0,0),
	[8] = new t_recharge_sInfo(9,3001,26045,3,30,"-5,300",300,1,0,0,0),
	[9] = new t_recharge_sInfo(10,3002,26046,3,68,"-5,680",680,1,0,0,0),
	[10] = new t_recharge_sInfo(11,4001,27001,4,128,"-5,1280",1280,1,0,0,0),
	[11] = new t_recharge_sInfo(12,4002,27001,4,128,"-5,1280",1280,1,0,0,0),
	[12] = new t_recharge_sInfo(13,4003,27001,4,128,"-5,1280",1280,1,0,0,0),
	[13] = new t_recharge_sInfo(14,4004,27001,4,128,"-5,1280",1280,1,0,0,0),
	[14] = new t_recharge_sInfo(15,4005,27001,4,128,"-5,1280",1280,1,0,0,0),
	[15] = new t_recharge_sInfo(16,4006,27001,4,128,"-5,1280",1280,1,0,0,0),
	[16] = new t_recharge_sInfo(17,5001,27001,5,30,"",300,3,26020,27101,27102),
	[17] = new t_recharge_sInfo(18,5002,27002,5,68,"",680,3,26020,27103,27104),
	[18] = new t_recharge_sInfo(19,5003,27003,5,68,"",680,3,26020,27105,27106),
	[19] = new t_recharge_sInfo(20,5004,27004,5,198,"",1980,1,26020,27107,27108),
	[20] = new t_recharge_sInfo(21,5005,27005,5,98,"",980,3,26020,27109,27110),
	[21] = new t_recharge_sInfo(22,5006,27006,5,30,"",300,2,26020,27111,27112),
	[22] = new t_recharge_sInfo(23,6001,26004,6,30,"",300,1,1,1,1),
	[23] = new t_recharge_sInfo(24,7001,27001,7,12,"",120,1,0,0,0),
	[24] = new t_recharge_sInfo(25,7002,27001,7,30,"",300,1,0,0,0),
	[25] = new t_recharge_sInfo(26,7003,27001,7,60,"",600,1,0,0,0),
	[26] = new t_recharge_sInfo(27,7004,27001,7,98,"",980,1,0,0,0),
	[27] = new t_recharge_sInfo(28,7005,27001,7,128,"",1280,1,0,0,0),
	[28] = new t_recharge_sInfo(29,7006,27001,7,168,"",1680,1,0,0,0),
	[29] = new t_recharge_sInfo(30,7007,27001,7,198,"",1980,1,0,0,0),
	[30] = new t_recharge_sInfo(31,7008,27001,7,228,"",2280,1,0,0,0),
	[31] = new t_recharge_sInfo(32,7009,27001,7,298,"",2980,1,0,0,0),
	[32] = new t_recharge_sInfo(33,7010,27001,7,358,"",3580,1,0,0,0),
	[33] = new t_recharge_sInfo(34,7011,27001,7,488,"",4880,1,0,0,0),
	[34] = new t_recharge_sInfo(35,7012,27001,7,688,"",6880,1,0,0,0),
	[35] = new t_recharge_sInfo(36,7013,27001,7,888,"",8880,1,0,0,0),
	[36] = new t_recharge_sInfo(37,7014,27001,7,998,"",9980,1,0,0,0),
	[37] = new t_recharge_sInfo(38,7015,27001,7,1288,"",12880,1,0,0,0),
	[38] = new t_recharge_sInfo(39,7016,27001,7,1588,"",15880,1,0,0,0),
};
}
