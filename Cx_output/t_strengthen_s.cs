using System.Collections.Generic;
public class Cfg_t_strengthen_s_Info
{
	public int id;
	public int a_base_strengthen_id;
	public int a_base_strengthen_name;
	public int a_base_strengthen_text;
	public string a_base_strengthen_icon;
	public string a_ints_strengthen_attr;
public Cfg_t_strengthen_s_Info(int id,int a_base_strengthen_id,int a_base_strengthen_name,int a_base_strengthen_text,string a_base_strengthen_icon,string a_ints_strengthen_attr)
{
  this.id = id;
  this.a_base_strengthen_id = a_base_strengthen_id;
  this.a_base_strengthen_name = a_base_strengthen_name;
  this.a_base_strengthen_text = a_base_strengthen_text;
  this.a_base_strengthen_icon = a_base_strengthen_icon;
  this.a_ints_strengthen_attr = a_ints_strengthen_attr;
}
}
public class Cfg_t_strengthen_s
{
public static List<Cfg_t_strengthen_s_Info> list = new List<Cfg_t_strengthen_s_Info>()
{
	[%!d(string=1)] = new Cfg_t_strengthen_s_Info(1,1,10601,10701,"jineng1","1,1,200"),
	[%!d(string=2)] = new Cfg_t_strengthen_s_Info(2,2,10602,10702,"jineng2","2,7,200"),
	[%!d(string=3)] = new Cfg_t_strengthen_s_Info(3,3,10603,10703,"jineng3","1,7,200"),
	[%!d(string=4)] = new Cfg_t_strengthen_s_Info(4,4,10604,10704,"jineng1","2,8,200"),
	[%!d(string=5)] = new Cfg_t_strengthen_s_Info(5,5,10605,10705,"jineng2","1,8,200"),
	[%!d(string=6)] = new Cfg_t_strengthen_s_Info(6,6,10606,10706,"jineng3","2,9,200"),
	[%!d(string=7)] = new Cfg_t_strengthen_s_Info(7,7,10607,10707,"jineng1","1,9,200"),
	[%!d(string=8)] = new Cfg_t_strengthen_s_Info(8,8,10608,10708,"jineng2","2,10,200"),
	[%!d(string=9)] = new Cfg_t_strengthen_s_Info(9,9,10609,10709,"jineng3","1,10,200"),
	[%!d(string=10)] = new Cfg_t_strengthen_s_Info(10,10,10610,10710,"jineng1","1,2,200"),
	[%!d(string=11)] = new Cfg_t_strengthen_s_Info(11,11,10611,10711,"jineng2","1,3,200"),
	[%!d(string=12)] = new Cfg_t_strengthen_s_Info(12,12,10612,10712,"jineng3","1,4,200"),
	[%!d(string=13)] = new Cfg_t_strengthen_s_Info(13,13,10613,10713,"jineng1","1,5,200"),
	[%!d(string=14)] = new Cfg_t_strengthen_s_Info(14,14,10614,10714,"jineng2","1,6,200"),
	[%!d(string=15)] = new Cfg_t_strengthen_s_Info(15,15,10615,10715,"jineng3","1,1,300"),
	[%!d(string=16)] = new Cfg_t_strengthen_s_Info(16,16,10616,10716,"jineng1","2,7,300"),
	[%!d(string=17)] = new Cfg_t_strengthen_s_Info(17,17,10617,10717,"jineng2","1,7,300"),
	[%!d(string=18)] = new Cfg_t_strengthen_s_Info(18,18,10618,10718,"jineng3","2,8,300"),
	[%!d(string=19)] = new Cfg_t_strengthen_s_Info(19,19,10619,10719,"jineng1","1,8,300"),
	[%!d(string=20)] = new Cfg_t_strengthen_s_Info(20,20,10620,10720,"jineng2","2,9,300"),
	[%!d(string=21)] = new Cfg_t_strengthen_s_Info(21,21,10621,10721,"jineng3","1,9,300"),
	[%!d(string=22)] = new Cfg_t_strengthen_s_Info(22,22,10622,10722,"jineng1","2,10,300"),
	[%!d(string=23)] = new Cfg_t_strengthen_s_Info(23,23,10623,10723,"jineng2","1,10,300"),
	[%!d(string=24)] = new Cfg_t_strengthen_s_Info(24,24,10624,10724,"jineng3","2,0,400"),
	[%!d(string=25)] = new Cfg_t_strengthen_s_Info(25,25,10625,10725,"jineng1","1,0,400"),
};
}
