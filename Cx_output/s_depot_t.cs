using System.Collections.Generic;
public class Cfg_s_depot_t_Info
{
	public int id;
	public int a_base_depot_id;
	public int a_base_depot_type;
	public int a_base_dispel_type;
	public string c_ints_base_cheese_coordinate;
	public int a_base_synthesis_priority;
public Cfg_s_depot_t_Info(int id,int a_base_depot_id,int a_base_depot_type,int a_base_dispel_type,string c_ints_base_cheese_coordinate,int a_base_synthesis_priority)
{
  this.id = id;
  this.a_base_depot_id = a_base_depot_id;
  this.a_base_depot_type = a_base_depot_type;
  this.a_base_dispel_type = a_base_dispel_type;
  this.c_ints_base_cheese_coordinate = c_ints_base_cheese_coordinate;
  this.a_base_synthesis_priority = a_base_synthesis_priority;
}
}
public class Cfg_s_depot_t
{
public static List<Cfg_s_depot_t_Info> list = new List<Cfg_s_depot_t_Info>()
{
	[0] = new Cfg_s_depot_t_Info(1,1,1,1,"0,1,2",1),
	[1] = new Cfg_s_depot_t_Info(2,2,1,1,"0,100,200",2),
	[2] = new Cfg_s_depot_t_Info(3,3,1,2,"0,1,100,101",3),
	[3] = new Cfg_s_depot_t_Info(4,4,1,3,"0,1,2,3",4),
	[4] = new Cfg_s_depot_t_Info(5,5,1,3,"0,100,200,300",5),
	[5] = new Cfg_s_depot_t_Info(6,6,1,4,"0,1,2,102,202",6),
	[6] = new Cfg_s_depot_t_Info(7,7,1,4,"2,102,200,201,202",7),
	[7] = new Cfg_s_depot_t_Info(8,8,1,4,"0,100,200,201,202",8),
	[8] = new Cfg_s_depot_t_Info(9,9,1,4,"0,1,2,100,200",9),
	[9] = new Cfg_s_depot_t_Info(10,10,1,4,"0,1,2,101,201",10),
	[10] = new Cfg_s_depot_t_Info(11,11,1,4,"1,101,200,201,202",11),
	[11] = new Cfg_s_depot_t_Info(12,12,1,4,"0,100,101,102,200",12),
	[12] = new Cfg_s_depot_t_Info(13,13,1,4,"2,100,101,102,202",13),
	[13] = new Cfg_s_depot_t_Info(14,14,1,4,"1,100,101,102,201",14),
	[14] = new Cfg_s_depot_t_Info(15,15,1,5,"0,1,2,3,4",15),
	[15] = new Cfg_s_depot_t_Info(16,16,1,5,"0,100,200,300,400",16),
	[16] = new Cfg_s_depot_t_Info(17,101,2,,"2,100,101",),
	[17] = new Cfg_s_depot_t_Info(18,102,2,,"0,1,102",),
	[18] = new Cfg_s_depot_t_Info(19,103,2,,"1,100,200",),
	[19] = new Cfg_s_depot_t_Info(20,104,2,,"0,101,201",),
	[20] = new Cfg_s_depot_t_Info(21,105,2,,"0,100,201",),
	[21] = new Cfg_s_depot_t_Info(22,106,2,,"1,101,200",),
	[22] = new Cfg_s_depot_t_Info(23,107,2,,"1,2,100",),
	[23] = new Cfg_s_depot_t_Info(24,108,2,,"0,101,102",),
	[24] = new Cfg_s_depot_t_Info(25,109,2,,"0,1,3",),
	[25] = new Cfg_s_depot_t_Info(26,110,2,,"0,2,3",),
	[26] = new Cfg_s_depot_t_Info(27,111,2,,"0,2,101",),
	[27] = new Cfg_s_depot_t_Info(28,112,2,,"1,100,102",),
	[28] = new Cfg_s_depot_t_Info(29,113,2,,"1,100,201",),
	[29] = new Cfg_s_depot_t_Info(30,114,2,,"0,101,200",),
	[30] = new Cfg_s_depot_t_Info(31,115,2,,"0,200,300",),
	[31] = new Cfg_s_depot_t_Info(32,116,2,,"0,100,300",),
};
}
