using System.Collections.Generic;
public class Cfg_t_triggerlogic_s_Info
{
	public int id;
	public int a_base_trigger_id;
	public int a_base_selfeolr_id;
	public int a_base_trigger_frequency;
	public int a_base_trigger_time_interval;
	public string a_ints_releaseloc_type;
	public string a_arrayints_release_pos;
	public int a_base_location_type;
	public int a_base_location_date;
public Cfg_t_triggerlogic_s_Info(int id,int a_base_trigger_id,int a_base_selfeolr_id,int a_base_trigger_frequency,int a_base_trigger_time_interval,string a_ints_releaseloc_type,string a_arrayints_release_pos,int a_base_location_type,int a_base_location_date)
{
  this.id = id;
  this.a_base_trigger_id = a_base_trigger_id;
  this.a_base_selfeolr_id = a_base_selfeolr_id;
  this.a_base_trigger_frequency = a_base_trigger_frequency;
  this.a_base_trigger_time_interval = a_base_trigger_time_interval;
  this.a_ints_releaseloc_type = a_ints_releaseloc_type;
  this.a_arrayints_release_pos = a_arrayints_release_pos;
  this.a_base_location_type = a_base_location_type;
  this.a_base_location_date = a_base_location_date;
}
}
public class Cfg_t_triggerlogic_s
{
public static List<Cfg_t_triggerlogic_s_Info> list = new List<Cfg_t_triggerlogic_s_Info>()
{
	[0] = new Cfg_t_triggerlogic_s_Info(1,100,,0,15000,"1,-1,-1","1,-1,-1",,),
	[1] = new Cfg_t_triggerlogic_s_Info(2,101,,0,25000,"1,1,2;1,3,2;1,5,2;1,7,2","1,5,2;1,3,2;1,7,2;1,1,2;1,9,2",,),
	[2] = new Cfg_t_triggerlogic_s_Info(3,102,,0,25000,"1,19,2;1,17,2;1,15,2;1,13,2","1,15,2;1,17,2;1,13,2;1,19,2;1,11,2",,),
	[3] = new Cfg_t_triggerlogic_s_Info(4,103,,0,25000,"1,7,2;1,9,2;1,11,2;1,13,2","1,10,2;1,12,2;1,8,2;1,14,2;1,6,2",,),
	[4] = new Cfg_t_triggerlogic_s_Info(5,241,,3,8000,"1,1,2;1,3,2;1,5,2;1,7,2","1,3,2;1,17,2;1,5,2;1,15,2;1,1,2;1,19,2;1,7,2;1,13,2;1,9,2;1,11,2",,),
	[5] = new Cfg_t_triggerlogic_s_Info(6,242,,3,8000,"1,19,2;1,17,2;1,15,2;1,13,2","1,17,2;1,3,2;1,15,2;1,5,2;1,19,2;1,1,2;1,13,2;1,7,2;1,9,2;1,11,2",,),
	[6] = new Cfg_t_triggerlogic_s_Info(7,243,,3,8000,"1,7,2;1,9,2;1,11,2;1,13,2","1,10,2;1,12,2;1,8,2;1,14,2;1,6,2;1,16,2;1,4,2;1,18,2;1,2,2",,),
	[7] = new Cfg_t_triggerlogic_s_Info(8,251,,6,4000,"1,1,2;1,3,2;1,5,2;1,7,2","1,-1,-1",,),
	[8] = new Cfg_t_triggerlogic_s_Info(9,252,,6,4000,"1,19,2;1,17,2;1,15,2;1,13,2","1,-1,-1",,),
	[9] = new Cfg_t_triggerlogic_s_Info(10,253,,6,4000,"1,7,2;1,9,2;1,11,2;1,13,2","1,-1,-1",,),
	[10] = new Cfg_t_triggerlogic_s_Info(11,254,,6,4000,"1,1,2;1,3,2;1,5,2;1,7,2","1,-1,-1",,),
	[11] = new Cfg_t_triggerlogic_s_Info(12,255,,1,4000,"1,19,2;1,17,2;1,15,2;1,13,2","1,17,2;1,3,2;1,15,2;1,5,2;1,19,2;1,1,2;1,13,2;1,7,2;1,9,2;1,11,2",,),
	[12] = new Cfg_t_triggerlogic_s_Info(13,256,,6,4000,"1,1,2;1,3,2;1,5,2;1,7,2","1,8,1;1,6,1;1,10,1;1,4,1;1,12,1;1,2,1;1,14,1;1,0,1;1,16,1",,),
	[13] = new Cfg_t_triggerlogic_s_Info(14,257,,6,4000,"1,19,2;1,17,2;1,15,2;1,13,2","1,2,1;1,14,1;1,4,1;1,12,1;1,0,1;1,16,1;1,6,1;1,10,1;1,8,1",,),
	[14] = new Cfg_t_triggerlogic_s_Info(15,258,,6,4000,"1,7,2;1,9,2;1,11,2;1,13,2","1,14,1;1,2,1;1,12,1;1,4,1;1,16,1;1,0,1;1,10,1;1,6,1;1,8,1",,),
	[15] = new Cfg_t_triggerlogic_s_Info(16,259,,6,4000,"1,1,2;1,3,2;1,5,2;1,7,2","1,2,1;1,14,1;1,4,1;1,12,1;1,0,1;1,16,1;1,6,1;1,10,1;1,8,1",,),
	[16] = new Cfg_t_triggerlogic_s_Info(17,100001,,1,0,"1,-1,-1","1,-1,-1",,),
	[17] = new Cfg_t_triggerlogic_s_Info(18,100002,,2,1000,"1,-1,-1","1,-1,-1",,),
	[18] = new Cfg_t_triggerlogic_s_Info(19,200001,,1,0,"3,-1,-1","3,-1,-1",,),
	[19] = new Cfg_t_triggerlogic_s_Info(20,200002,,1,0,"1,-1,-1","1,-1,-1",,),
	[20] = new Cfg_t_triggerlogic_s_Info(21,200003,,1,0,"1,10,9","1,10,9;1,14,9;1,6,9",,),
	[21] = new Cfg_t_triggerlogic_s_Info(22,300001,,0,51000,"0,0,0","0,0,0",,),
	[22] = new Cfg_t_triggerlogic_s_Info(23,300002,,0,81500,"0,0,0","0,0,0",,),
	[23] = new Cfg_t_triggerlogic_s_Info(24,300003,,0,120600,"0,0,0","0,0,0",,),
	[24] = new Cfg_t_triggerlogic_s_Info(25,300004,,0,162000,"0,0,0","0,0,0",,),
	[25] = new Cfg_t_triggerlogic_s_Info(26,300005,,0,81000,"0,0,0","0,0,0",,),
	[26] = new Cfg_t_triggerlogic_s_Info(27,1000001,,2,1000,"1,7,2;1,9,2;1,11,2;1,13,2","1,10,2;1,12,2;1,8,2;1,14,2;1,6,2;1,16,2;1,4,2;1,18,2;1,2,2",,),
	[27] = new Cfg_t_triggerlogic_s_Info(28,1000002,,10,1000,"1,7,2;1,9,2;1,11,2;1,13,2","1,10,2;1,12,2;1,8,2;1,14,2;1,6,2;1,16,2;1,4,2;1,18,2;1,2,2",,),
};
}
