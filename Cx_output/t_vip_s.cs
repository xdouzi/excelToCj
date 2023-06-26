using System.Collections.Generic;
public class Cfg_t_vip_s_Info
{
	public int id;
	public int a_base_vip_level;
	public int a_base_deplete_exp;
	public string a_arrayints_vip_privilege;
	public string a_arrayints_battle_buff;
	public string a_ints_vip_freeaward;
	public string a_ints_vip_limitaward;
	public string a_ints_vip_limitaward_price;
public Cfg_t_vip_s_Info(int id,int a_base_vip_level,int a_base_deplete_exp,string a_arrayints_vip_privilege,string a_arrayints_battle_buff,string a_ints_vip_freeaward,string a_ints_vip_limitaward,string a_ints_vip_limitaward_price)
{
  this.id = id;
  this.a_base_vip_level = a_base_vip_level;
  this.a_base_deplete_exp = a_base_deplete_exp;
  this.a_arrayints_vip_privilege = a_arrayints_vip_privilege;
  this.a_arrayints_battle_buff = a_arrayints_battle_buff;
  this.a_ints_vip_freeaward = a_ints_vip_freeaward;
  this.a_ints_vip_limitaward = a_ints_vip_limitaward;
  this.a_ints_vip_limitaward_price = a_ints_vip_limitaward_price;
}
}
public class Cfg_t_vip_s
{
public static List<Cfg_t_vip_s_Info> list = new List<Cfg_t_vip_s_Info>()
{
	[0] = new Cfg_t_vip_s_Info(1,0,60,"2002,300;2003,300","","201000,1","202000,1","7001"),
	[1] = new Cfg_t_vip_s_Info(2,1,360,"2002,300;2003,300;2004,300;2005,300;4013,0","","201001,1","202001,1","7002"),
	[2] = new Cfg_t_vip_s_Info(3,2,1200,"2002,500;2003,500;2004,500;2005,500;2001,500;4013,0;4001,10;4015,1","","201002,1","202002,1","7003"),
	[3] = new Cfg_t_vip_s_Info(4,3,1800,"2002,700;2003,700;2004,700;2005,700;2001,700;4013,0;4001,10;4015,1;4002,500","","201003,1","202003,1","7004"),
	[4] = new Cfg_t_vip_s_Info(5,4,3600,"2002,900;2003,900;2004,900;2005,900;2001,900;4013,0;4001,10;4015,2;4002,500;4014,0","","201004,1","202004,1","7005"),
	[5] = new Cfg_t_vip_s_Info(6,5,5450,"2002,1200;2003,1200;2004,1200;2005,1200;2001,1200;4013,0;4001,20;4015,2;4002,500;4014,0;4006,1;4010,5","","201005,1","202005,1","7006"),
	[6] = new Cfg_t_vip_s_Info(7,6,10500,"2002,1500;2003,1500;2004,1500;2005,1500;2001,1500;4013,0;4001,20;4015,3;4002,1000;4014,0;4006,1;4010,5;4003,0","","201006,1","202006,1","7007"),
	[7] = new Cfg_t_vip_s_Info(8,7,22500,"2002,1800;2003,1800;2004,1800;2005,1800;2001,1800;4013,0;4001,20;4015,3;4002,1000;4014,0;4006,1;4010,5;4003,0;4007,10000","","201007,1","202007,1","7008"),
	[8] = new Cfg_t_vip_s_Info(9,8,45000,"2002,2100;2003,2100;2004,2100;2005,2100;2001,2100;4013,0;4001,20;4015,4;4002,1000;4014,0;4006,1;4010,5;4003,0;4007,10000;4009,2","","201008,1","202008,1","7009"),
	[9] = new Cfg_t_vip_s_Info(10,9,75000,"2002,2500;2003,2500;2004,2500;2005,2500;2001,2500;4013,0;4001,20;4015,4;4002,1000;4014,0;4006,2;4010,5;4003,0;4007,30000;4009,2;4008,200","","201009,1","202009,1","7010"),
	[10] = new Cfg_t_vip_s_Info(11,10,105000,"2002,2900;2003,2900;2004,2900;2005,2900;2001,2900;4013,0;4001,30;4015,5;4002,1500;4014,0;4006,2;4010,10;4003,0;4007,30000;4009,2;4008,200","","201010,1","202010,1","7011"),
	[11] = new Cfg_t_vip_s_Info(12,11,225000,"2002,3300;2003,3300;2004,3300;2005,3300;2001,3300;4013,0;4001,30;4015,5;4002,1500;4014,0;4006,2;4010,10;4003,0;4007,50000;4009,2;4008,200;4004,500","501,128","201011,1","202011,1","7012"),
	[12] = new Cfg_t_vip_s_Info(13,12,300000,"2002,3800;2003,3800;2004,3800;2005,3800;2001,3800;4013,0;4001,30;4015,6;4002,1500;4014,0;4006,2;4010,10;4003,0;4007,50000;4009,4;4008,200;4004,500;4005,500","501,128;502,128","201012,1","202012,1","7013"),
	[13] = new Cfg_t_vip_s_Info(14,13,450000,"2002,4200;2003,4200;2004,4200;2005,4200;2001,4200;4013,0;4001,30;4015,6;4002,1500;4014,0;4006,3;4010,10;4003,0;4007,70000;4009,4;4008,500;4004,500;4005,500;4012,500","501,128;502,128;501,8192","201013,1","202013,1","7014"),
	[14] = new Cfg_t_vip_s_Info(15,14,750000,"2002,4600;2003,4600;2004,4600;2005,4600;2001,4600;4013,0;4001,30;4015,7;4002,1500;4014,0;4006,3;4010,10;4003,0;4007,70000;4009,4;4008,500;4004,500;4005,500;4012,500;4011,500","501,128;502,128;501,8192;502,8192","201014,1","202014,1","7015"),
	[15] = new Cfg_t_vip_s_Info(16,15,,"2002,5000;2003,5000;2004,5000;2005,5000;2001,5000;4013,0;4001,50;4015,7;4002,2000;4014,0;4006,4;4010,15;4003,0;4007,100000;4009,8;4008,700;4004,500;4005,500;4012,500;4011,500","501,128;502,128;501,8192;502,8192","201015,1","202015,1","7016"),
};
}
