using System.Collections.Generic;
public class s_depot_tInfo
{
public int id;
public int a_base_depot_id;
public int a_base_depot_type;
public int a_base_dispel_type;
public string c_ints_base_cheese_coordinate;
public int a_base_synthesis_priority;
public s_depot_tInfo(int id,int a_base_depot_id,int a_base_depot_type,int a_base_dispel_type,string c_ints_base_cheese_coordinate,int a_base_synthesis_priority)
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
public static List<s_depot_tInfo> list = new List<s_depot_tInfo>()
{
	[0] = new s_depot_tInfo(1,1,1,1,"0,1,2",1),
	[1] = new s_depot_tInfo(2,2,1,1,"0,100,200",2),
	[2] = new s_depot_tInfo(3,3,1,2,"0,1,100,101",3),
	[3] = new s_depot_tInfo(4,4,1,3,"0,1,2,3",4),
	[4] = new s_depot_tInfo(5,5,1,3,"0,100,200,300",5),
	[5] = new s_depot_tInfo(6,6,1,4,"0,1,2,102,202",6),
	[6] = new s_depot_tInfo(7,7,1,4,"2,102,200,201,202",7),
	[7] = new s_depot_tInfo(8,8,1,4,"0,100,200,201,202",8),
	[8] = new s_depot_tInfo(9,9,1,4,"0,1,2,100,200",9),
	[9] = new s_depot_tInfo(10,10,1,4,"0,1,2,101,201",10),
	[10] = new s_depot_tInfo(11,11,1,4,"1,101,200,201,202",11),
	[11] = new s_depot_tInfo(12,12,1,4,"0,100,101,102,200",12),
	[12] = new s_depot_tInfo(13,13,1,4,"2,100,101,102,202",13),
	[13] = new s_depot_tInfo(14,14,1,4,"1,100,101,102,201",14),
	[14] = new s_depot_tInfo(15,15,1,5,"0,1,2,3,4",15),
	[15] = new s_depot_tInfo(16,16,1,5,"0,100,200,300,400",16),
	[16] = new s_depot_tInfo(17,101,2,,"2,100,101","2,100,101"),
	[17] = new s_depot_tInfo(18,102,2,,"0,1,102","0,1,102"),
	[18] = new s_depot_tInfo(19,103,2,,"1,100,200","1,100,200"),
	[19] = new s_depot_tInfo(20,104,2,,"0,101,201","0,101,201"),
	[20] = new s_depot_tInfo(21,105,2,,"0,100,201","0,100,201"),
	[21] = new s_depot_tInfo(22,106,2,,"1,101,200","1,101,200"),
	[22] = new s_depot_tInfo(23,107,2,,"1,2,100","1,2,100"),
	[23] = new s_depot_tInfo(24,108,2,,"0,101,102","0,101,102"),
	[24] = new s_depot_tInfo(25,109,2,,"0,1,3","0,1,3"),
	[25] = new s_depot_tInfo(26,110,2,,"0,2,3","0,2,3"),
	[26] = new s_depot_tInfo(27,111,2,,"0,2,101","0,2,101"),
	[27] = new s_depot_tInfo(28,112,2,,"1,100,102","1,100,102"),
	[28] = new s_depot_tInfo(29,113,2,,"1,100,201","1,100,201"),
	[29] = new s_depot_tInfo(30,114,2,,"0,101,200","0,101,200"),
	[30] = new s_depot_tInfo(31,115,2,,"0,200,300","0,200,300"),
	[31] = new s_depot_tInfo(32,116,2,,"0,100,300","0,100,300"),
};
}
