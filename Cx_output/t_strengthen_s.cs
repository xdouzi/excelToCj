using System.Collections.Generic;
public class t_strengthen_sInfo
{
public int id;
public int a_base_strengthen_id;
public int a_base_strengthen_name;
public int a_base_strengthen_text;
public string a_base_strengthen_icon;
public string a_ints_strengthen_attr;
public t_strengthen_sInfo(int id,int a_base_strengthen_id,int a_base_strengthen_name,int a_base_strengthen_text,string a_base_strengthen_icon,string a_ints_strengthen_attr)
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
public static List<t_strengthen_sInfo> list = new List<t_strengthen_sInfo>()
{
	[0] = new t_strengthen_sInfo(1,1,10601,10701,"jineng1","1,1,200"),
	[1] = new t_strengthen_sInfo(2,2,10602,10702,"jineng2","2,7,200"),
	[2] = new t_strengthen_sInfo(3,3,10603,10703,"jineng3","1,7,200"),
	[3] = new t_strengthen_sInfo(4,4,10604,10704,"jineng1","2,8,200"),
	[4] = new t_strengthen_sInfo(5,5,10605,10705,"jineng2","1,8,200"),
	[5] = new t_strengthen_sInfo(6,6,10606,10706,"jineng3","2,9,200"),
	[6] = new t_strengthen_sInfo(7,7,10607,10707,"jineng1","1,9,200"),
	[7] = new t_strengthen_sInfo(8,8,10608,10708,"jineng2","2,10,200"),
	[8] = new t_strengthen_sInfo(9,9,10609,10709,"jineng3","1,10,200"),
	[9] = new t_strengthen_sInfo(10,10,10610,10710,"jineng1","1,2,200"),
	[10] = new t_strengthen_sInfo(11,11,10611,10711,"jineng2","1,3,200"),
	[11] = new t_strengthen_sInfo(12,12,10612,10712,"jineng3","1,4,200"),
	[12] = new t_strengthen_sInfo(13,13,10613,10713,"jineng1","1,5,200"),
	[13] = new t_strengthen_sInfo(14,14,10614,10714,"jineng2","1,6,200"),
	[14] = new t_strengthen_sInfo(15,15,10615,10715,"jineng3","1,1,300"),
	[15] = new t_strengthen_sInfo(16,16,10616,10716,"jineng1","2,7,300"),
	[16] = new t_strengthen_sInfo(17,17,10617,10717,"jineng2","1,7,300"),
	[17] = new t_strengthen_sInfo(18,18,10618,10718,"jineng3","2,8,300"),
	[18] = new t_strengthen_sInfo(19,19,10619,10719,"jineng1","1,8,300"),
	[19] = new t_strengthen_sInfo(20,20,10620,10720,"jineng2","2,9,300"),
	[20] = new t_strengthen_sInfo(21,21,10621,10721,"jineng3","1,9,300"),
	[21] = new t_strengthen_sInfo(22,22,10622,10722,"jineng1","2,10,300"),
	[22] = new t_strengthen_sInfo(23,23,10623,10723,"jineng2","1,10,300"),
	[23] = new t_strengthen_sInfo(24,24,10624,10724,"jineng3","2,0,400"),
	[24] = new t_strengthen_sInfo(25,25,10625,10725,"jineng1","1,0,400"),
};
}
