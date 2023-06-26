using System.Collections.Generic;
public class t_award_sInfo
{
public int id;
public int a_base_award_id;
public string a_arrayints_type;
public string a_arrayints_award;
public string a_arrayints_random_award;
public string a_arrayints_choose_award;
public string c_arrayints_show_award;
public string c_arrayints_fixed_award;
public t_award_sInfo(int id,int a_base_award_id,string a_arrayints_type,string a_arrayints_award,string a_arrayints_random_award,string a_arrayints_choose_award,string c_arrayints_show_award,string c_arrayints_fixed_award)
{
  this.id = id;
  this.a_base_award_id = a_base_award_id;
  this.a_arrayints_type = a_arrayints_type;
  this.a_arrayints_award = a_arrayints_award;
  this.a_arrayints_random_award = a_arrayints_random_award;
  this.a_arrayints_choose_award = a_arrayints_choose_award;
  this.c_arrayints_show_award = c_arrayints_show_award;
  this.c_arrayints_fixed_award = c_arrayints_fixed_award;
}
}
public class Cfg_t_award_s
{
public static List<t_award_sInfo> list = new List<t_award_sInfo>()
{
	[0] = new t_award_sInfo(1,1,"1,10000","-2,500-550,0,0,0;1002,10000,0,0,0","","","-2,1,500,550;1002,0,1",""),
	[1] = new t_award_sInfo(2,2,"1,10000","","-1,500-800,0,0,0,7000;1002,10000,0,0,0,3000","","1001,1,500,800;1002,0,1",""),
	[2] = new t_award_sInfo(3,3,"1,10000","","","1001,1,0,0,0;1002,1,0,0,0","1001,0,1;1002,0,1",""),
	[3] = new t_award_sInfo(4,4,"1,10000","2101,500,0,0,0;2001,1,0,0,0","","","2101,0,5000;2001,0,10",""),
	[4] = new t_award_sInfo(5,5,"1,10000","10200,1,0,0,0;10203,1,0,0,0;34210,1,0,0,0;36210,5,0,0,0;47210,20,0,0,0,","-2,1000-1025,0,0,0,10000;-1,12-18,0,0,0,10000;1008,1,0,0,0,5000;1010,1,0,0,0,2000;1012,1,0,0,0,500","","-2,1,1000,1025;-1,1,12,18;1008,0,1;1010,0,1;1012,0,1","10200,1;10203,1;34210,1;36210,5;47210,20"),
	[5] = new t_award_sInfo(6,6,"1,10000","-1,1000000,0,0,0;-2,1000000,0,0,0;-3,10000,0,0,0;-101,1000000,0,0,0;-102,1000000,0,0,0;-103,1000000,0,0,0;-104,1000000,0,0,0;-300,10000,0,0,0;21120,100,0,0,0;21130,100,0,0,0;21140,100,0,0,0","","","-1,0,1000000;-2,0,1000000;-3,0,10000;-101,0,1000000;-102,0,1000000;-103,0,1000000;-104,0,1000000;-300,0,10000;21120,0,100;21130,0,100;21140,0,100",""),
	[6] = new t_award_sInfo(7,7,"1,10000","10200,70,0,0,0;10202,20,0,0,0;10204,5,0,0,0;33210,5,0,0,0;34210,2,0,0,0","","","-1,0,200;3101,0,2;3102,0,5;3103,0,20;3104,0,70",""),
	[7] = new t_award_sInfo(8,101,"1,10000","-103,2500,0,0,0","","","-103,0,2500",""),
	[8] = new t_award_sInfo(9,201,"1,10000","-3,60,0,0,0","","","-3,0,60",""),
	[9] = new t_award_sInfo(10,202,"1,10000","-3,60,0,0,0","","","-3,0,60",""),
	[10] = new t_award_sInfo(11,1001,"1,10000","-2,500-550,0,0,0","","","-2,0,500",""),
	[11] = new t_award_sInfo(12,1002,"1,10000","-2,2500,0,0,0","","","-2,0,2500",""),
	[12] = new t_award_sInfo(13,1003,"1,10000","-101,2500,0,0,0","","","-101,0,2500",""),
	[13] = new t_award_sInfo(14,1004,"1,10000","-102,2500,0,0,0","","","-102,0,2500",""),
	[14] = new t_award_sInfo(15,1005,"1,10000","-103,2500,0,0,0","","","-103,0,2500",""),
	[15] = new t_award_sInfo(16,1006,"1,10000","-104,2500,0,0,0","","","-104,0,2500",""),
};
}
