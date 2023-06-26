using System.Collections.Generic;
public class Cfg_t_recharge_s_Info
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
public Cfg_t_recharge_s_Info(int id,int c_base_recharge_id,int c_base_name,int a_base_type,int a_base_recharge_gear,string a_arrayints_first_rewards,int a_base_vip_exp,int a_base_limit_num,int c_base_promotion,int c_base_discount,int c_base_slogan_discount)
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
public static List<Cfg_t_recharge_s_Info> list = new List<Cfg_t_recharge_s_Info>()
{
	[%!d(string=1)] = new Cfg_t_recharge_s_Info(1,1001,27001,1,6,"-5,60",60,0,0,,),
	[%!d(string=2)] = new Cfg_t_recharge_s_Info(2,1002,27001,1,30,"-5,300",300,0,0,,),
	[%!d(string=3)] = new Cfg_t_recharge_s_Info(3,1003,27001,1,68,"-5,680",680,0,0,,),
	[%!d(string=4)] = new Cfg_t_recharge_s_Info(4,1004,27001,1,98,"-5,980",980,0,0,,),
	[%!d(string=5)] = new Cfg_t_recharge_s_Info(5,1005,27001,1,128,"-5,1280",1280,0,0,,),
	[%!d(string=6)] = new Cfg_t_recharge_s_Info(6,1006,27001,1,328,"-5,3280",3280,0,0,,),
	[%!d(string=7)] = new Cfg_t_recharge_s_Info(7,1007,27001,1,648,"-5,6480",6480,0,0,,),
	[%!d(string=8)] = new Cfg_t_recharge_s_Info(8,2001,27001,2,98,"",980,1,0,,),
	[%!d(string=9)] = new Cfg_t_recharge_s_Info(9,3001,26045,3,30,"-5,300",300,1,0,,),
	[%!d(string=10)] = new Cfg_t_recharge_s_Info(10,3002,26046,3,68,"-5,680",680,1,0,,),
	[%!d(string=11)] = new Cfg_t_recharge_s_Info(11,4001,27001,4,128,"-5,1280",1280,1,0,,),
	[%!d(string=12)] = new Cfg_t_recharge_s_Info(12,4002,27001,4,128,"-5,1280",1280,1,0,,),
	[%!d(string=13)] = new Cfg_t_recharge_s_Info(13,4003,27001,4,128,"-5,1280",1280,1,0,,),
	[%!d(string=14)] = new Cfg_t_recharge_s_Info(14,4004,27001,4,128,"-5,1280",1280,1,0,,),
	[%!d(string=15)] = new Cfg_t_recharge_s_Info(15,4005,27001,4,128,"-5,1280",1280,1,0,,),
	[%!d(string=16)] = new Cfg_t_recharge_s_Info(16,4006,27001,4,128,"-5,1280",1280,1,0,,),
	[%!d(string=17)] = new Cfg_t_recharge_s_Info(17,5001,27001,5,30,"",300,3,26020,27101,27102),
	[%!d(string=18)] = new Cfg_t_recharge_s_Info(18,5002,27002,5,68,"",680,3,26020,27103,27104),
	[%!d(string=19)] = new Cfg_t_recharge_s_Info(19,5003,27003,5,68,"",680,3,26020,27105,27106),
	[%!d(string=20)] = new Cfg_t_recharge_s_Info(20,5004,27004,5,198,"",1980,1,26020,27107,27108),
	[%!d(string=21)] = new Cfg_t_recharge_s_Info(21,5005,27005,5,98,"",980,3,26020,27109,27110),
	[%!d(string=22)] = new Cfg_t_recharge_s_Info(22,5006,27006,5,30,"",300,2,26020,27111,27112),
	[%!d(string=23)] = new Cfg_t_recharge_s_Info(23,6001,26004,6,30,"",300,1,,,),
	[%!d(string=24)] = new Cfg_t_recharge_s_Info(24,7001,27001,7,12,"",120,1,0,,),
	[%!d(string=25)] = new Cfg_t_recharge_s_Info(25,7002,27001,7,30,"",300,1,0,,),
	[%!d(string=26)] = new Cfg_t_recharge_s_Info(26,7003,27001,7,60,"",600,1,0,,),
	[%!d(string=27)] = new Cfg_t_recharge_s_Info(27,7004,27001,7,98,"",980,1,0,,),
	[%!d(string=28)] = new Cfg_t_recharge_s_Info(28,7005,27001,7,128,"",1280,1,0,,),
	[%!d(string=29)] = new Cfg_t_recharge_s_Info(29,7006,27001,7,168,"",1680,1,0,,),
	[%!d(string=30)] = new Cfg_t_recharge_s_Info(30,7007,27001,7,198,"",1980,1,0,,),
	[%!d(string=31)] = new Cfg_t_recharge_s_Info(31,7008,27001,7,228,"",2280,1,0,,),
	[%!d(string=32)] = new Cfg_t_recharge_s_Info(32,7009,27001,7,298,"",2980,1,0,,),
	[%!d(string=33)] = new Cfg_t_recharge_s_Info(33,7010,27001,7,358,"",3580,1,0,,),
	[%!d(string=34)] = new Cfg_t_recharge_s_Info(34,7011,27001,7,488,"",4880,1,0,,),
	[%!d(string=35)] = new Cfg_t_recharge_s_Info(35,7012,27001,7,688,"",6880,1,0,,),
	[%!d(string=36)] = new Cfg_t_recharge_s_Info(36,7013,27001,7,888,"",8880,1,0,,),
	[%!d(string=37)] = new Cfg_t_recharge_s_Info(37,7014,27001,7,998,"",9980,1,0,,),
	[%!d(string=38)] = new Cfg_t_recharge_s_Info(38,7015,27001,7,1288,"",12880,1,0,,),
	[%!d(string=39)] = new Cfg_t_recharge_s_Info(39,7016,27001,7,1588,"",15880,1,0,,),
};
}
