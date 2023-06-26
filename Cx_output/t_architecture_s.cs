using System.Collections.Generic;
public class Cfg_t_architecture_s_Info
{
	public int id;
	public int a_base_architecture_id;
	public int a_base_architecture_name;
	public int a_base_architecture_tips;
	public int a_base_architecture_type;
	public string a_ints_architecture_attr;
	public string a_arrayints_architecture_unlock;
	public string a_ints_architecture_placeholder;
	public int a_base_move_type;
	public int a_base_architecture_group;
	public string a_ints_open_function;
	public int a_base_rank;
	public string a_base_hint_trigger;
	public string a_base_hint_animation;
	public int a_base_animation_click_effect;
public Cfg_t_architecture_s_Info(int id,int a_base_architecture_id,int a_base_architecture_name,int a_base_architecture_tips,int a_base_architecture_type,string a_ints_architecture_attr,string a_arrayints_architecture_unlock,string a_ints_architecture_placeholder,int a_base_move_type,int a_base_architecture_group,string a_ints_open_function,int a_base_rank,string a_base_hint_trigger,string a_base_hint_animation,int a_base_animation_click_effect)
{
  this.id = id;
  this.a_base_architecture_id = a_base_architecture_id;
  this.a_base_architecture_name = a_base_architecture_name;
  this.a_base_architecture_tips = a_base_architecture_tips;
  this.a_base_architecture_type = a_base_architecture_type;
  this.a_ints_architecture_attr = a_ints_architecture_attr;
  this.a_arrayints_architecture_unlock = a_arrayints_architecture_unlock;
  this.a_ints_architecture_placeholder = a_ints_architecture_placeholder;
  this.a_base_move_type = a_base_move_type;
  this.a_base_architecture_group = a_base_architecture_group;
  this.a_ints_open_function = a_ints_open_function;
  this.a_base_rank = a_base_rank;
  this.a_base_hint_trigger = a_base_hint_trigger;
  this.a_base_hint_animation = a_base_hint_animation;
  this.a_base_animation_click_effect = a_base_animation_click_effect;
}
}
public class Cfg_t_architecture_s
{
public static List<Cfg_t_architecture_s_Info> list = new List<Cfg_t_architecture_s_Info>()
{
	[0] = new Cfg_t_architecture_s_Info(1,1,200001,210001,2,"1","","10,10",0,1,"",1,"1","",""),
	[1] = new Cfg_t_architecture_s_Info(2,2,200002,210002,0,"","2,7,1,1","8,8",0,2,"24",3,"1","",""),
	[2] = new Cfg_t_architecture_s_Info(3,3,200003,210003,0,"","2,1,2,1","8,8",0,3,"25",7,"","",""),
	[3] = new Cfg_t_architecture_s_Info(4,4,200004,210004,0,"","2,1,2,1","8,8",0,4,"26",5,"","",""),
	[4] = new Cfg_t_architecture_s_Info(5,5,200005,210005,0,"","2,1,3,1","6,6",0,5,"17,18,27",11,"","",""),
	[5] = new Cfg_t_architecture_s_Info(6,6,200006,210006,0,"","2,1,3,1","8,8",0,6,"19,20,28",13,"","",""),
	[6] = new Cfg_t_architecture_s_Info(7,7,200007,210007,0,"","2,1,1,1;2,1,3,1;2,1,6,1;2,1,8,1;2,1,11,1;2,1,13,1;2,1,16,1;2,1,18,1;2,1,21,1;2,1,23,1","6,6",0,7,"",2,"","",""),
	[7] = new Cfg_t_architecture_s_Info(8,8,200008,210008,0,"","2,1,2,1;2,1,3,1;2,1,6,1;2,1,8,1;2,1,11,1;2,1,13,1;2,1,16,1;2,1,18,1;2,1,21,1;2,1,23,1","6,6",0,8,"",4,"","",""),
	[8] = new Cfg_t_architecture_s_Info(9,9,200009,210009,0,"","2,1,2,1;2,1,3,1;2,1,6,1;2,1,8,1;2,1,11,1;2,1,13,1;2,1,16,1;2,1,18,1;2,1,21,1;2,1,23,1","6,6",0,9,"",6,"","",""),
	[9] = new Cfg_t_architecture_s_Info(10,10,200010,210010,0,"","2,1,3,2;2,1,6,1;2,1,8,1;2,1,11,1;2,1,13,1;2,1,16,1;2,1,18,1;2,1,21,1;2,1,23,1","6,6",0,10,"",12,"","",""),
	[10] = new Cfg_t_architecture_s_Info(11,11,200011,210011,0,"","2,1,3,2;2,1,6,1;2,1,8,1;2,1,11,1;2,1,13,1;2,1,16,1;2,1,18,1;2,1,21,1;2,1,23,1","6,6",0,11,"",10,"","",""),
	[11] = new Cfg_t_architecture_s_Info(12,12,200012,210012,2,"","2,1,1,1","8,8",0,12,"21",21,"","",""),
	[12] = new Cfg_t_architecture_s_Info(13,13,200013,210013,0,"1","2,1,1,1;2,1,3,1;2,1,6,1;2,1,8,1;2,1,11,1;2,1,13,1;2,1,16,1;2,1,18,1;2,1,21,1;2,1,23,1","8,8",0,13,"",8,"","",""),
	[13] = new Cfg_t_architecture_s_Info(14,14,200014,210014,2,"","2,1,6,1","3,3",0,14,"",22,"","",""),
	[14] = new Cfg_t_architecture_s_Info(15,15,200015,210015,2,"","2,1,4,1","2,2",0,15,"",23,"","",""),
	[15] = new Cfg_t_architecture_s_Info(16,16,200016,210016,2,"","2,1,1,1","2,3",0,16,"10,36",20,"","",""),
	[16] = new Cfg_t_architecture_s_Info(17,17,200017,210017,0,"","2,1,3,1","7,7",0,17,"",9,"","",""),
	[17] = new Cfg_t_architecture_s_Info(18,18,200018,210018,2,"","2,1,1,1","3,3",0,18,"34,35",15,"","",""),
	[18] = new Cfg_t_architecture_s_Info(19,19,200019,210019,0,"","2,17,1,1","6,6",0,19,"31,45",14,"","",""),
	[19] = new Cfg_t_architecture_s_Info(20,20,200020,210020,1,"","","1,1",0,,"",16,"","",""),
	[20] = new Cfg_t_architecture_s_Info(21,21,200021,210021,1,"","","2,2",0,,"",17,"","",""),
	[21] = new Cfg_t_architecture_s_Info(22,22,200022,210022,2,"","2,1,1,1","5,5",1,,"47",19,"","",""),
	[22] = new Cfg_t_architecture_s_Info(23,23,200023,210023,2,"","2,1,1,1","5,5",1,,"46",18,"","",""),
};
}
