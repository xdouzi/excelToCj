using System.Collections.Generic;
public class Cfg_t_system_open_s_Info
{
	public int id;
	public int a_base_system_id;
	public string c_e_name_id;
	public int a_base_system_icon;
	public int c_base_function_name;
	public string c_base_function_entrance;
	public int c_base_jump_id;
	public int c_base_function_headline;
	public int c_base_subheading;
	public int c_base_describe;
	public string a_arrayints_condition;
public Cfg_t_system_open_s_Info(int id,int a_base_system_id,string c_e_name_id,int a_base_system_icon,int c_base_function_name,string c_base_function_entrance,int c_base_jump_id,int c_base_function_headline,int c_base_subheading,int c_base_describe,string a_arrayints_condition)
{
  this.id = id;
  this.a_base_system_id = a_base_system_id;
  this.c_e_name_id = c_e_name_id;
  this.a_base_system_icon = a_base_system_icon;
  this.c_base_function_name = c_base_function_name;
  this.c_base_function_entrance = c_base_function_entrance;
  this.c_base_jump_id = c_base_jump_id;
  this.c_base_function_headline = c_base_function_headline;
  this.c_base_subheading = c_base_subheading;
  this.c_base_describe = c_base_describe;
  this.a_arrayints_condition = a_arrayints_condition;
}
}
public class Cfg_t_system_open_s
{
public static List<Cfg_t_system_open_s_Info> list = new List<Cfg_t_system_open_s_Info>()
{
	[%!d(string=1)] = new Cfg_t_system_open_s_Info(1,8,"Bag",,8,"",2,,,,""),
	[%!d(string=2)] = new Cfg_t_system_open_s_Info(2,9,"Card_bag",,9,"",3,,,,"3,4000027,1"),
	[%!d(string=3)] = new Cfg_t_system_open_s_Info(3,10,"Mail",,10,"button_mail",22,,,,""),
	[%!d(string=4)] = new Cfg_t_system_open_s_Info(4,11,"Active_task",,11,"",1,,,,""),
	[%!d(string=5)] = new Cfg_t_system_open_s_Info(5,12,"Daily_task",,12,"",17,,,,"4,120,1"),
	[%!d(string=6)] = new Cfg_t_system_open_s_Info(6,13,"Weekly_task",,13,"",18,,,,"4,120,1"),
	[%!d(string=7)] = new Cfg_t_system_open_s_Info(7,14,"Mainline_task",,6006,"",26,,,,"4,101,1"),
	[%!d(string=8)] = new Cfg_t_system_open_s_Info(8,15,"Building",,15,"",,,,,"4,102,1"),
	[%!d(string=9)] = new Cfg_t_system_open_s_Info(9,16,"Side_quest",,6007,"",1,,,,"4,111,1"),
	[%!d(string=10)] = new Cfg_t_system_open_s_Info(10,17,"Idol_skill",,10014,"button_god_skill",6,,,,"2,5,1"),
	[%!d(string=11)] = new Cfg_t_system_open_s_Info(11,18,"Idol_consecrate",,10015,"button_goddess_consecrate",7,,,,"2,5,1"),
	[%!d(string=12)] = new Cfg_t_system_open_s_Info(12,19,"Devil_Sacrifice",,10016,"button_devil_sacrifice",10,,,,"2,6,1"),
	[%!d(string=13)] = new Cfg_t_system_open_s_Info(13,20,"Demon_consecrate",,10017,"button_devil_consecrate",13,,,,"2,6,1"),
	[%!d(string=14)] = new Cfg_t_system_open_s_Info(14,21,"Spring_subsidy",,10018,"button_bodypower",8,,,,"28,12,1"),
	[%!d(string=15)] = new Cfg_t_system_open_s_Info(15,22,"Workshop_compound",,10019,"button_workshop",5,,,,"2,14,1"),
	[%!d(string=16)] = new Cfg_t_system_open_s_Info(16,23,"Mainpanel",,10019,"",1,,,,""),
	[%!d(string=17)] = new Cfg_t_system_open_s_Info(17,24,"InfantryCamp",,101,"button_barracks",9,,,,""),
	[%!d(string=18)] = new Cfg_t_system_open_s_Info(18,25,"BowmanCamp",,102,"button_barracks",9,,,,""),
	[%!d(string=19)] = new Cfg_t_system_open_s_Info(19,26,"KnightCamp",,103,"button_barracks",9,,,,""),
	[%!d(string=20)] = new Cfg_t_system_open_s_Info(20,27,"HolyCamp",,104,"button_barracks",9,,,,""),
	[%!d(string=21)] = new Cfg_t_system_open_s_Info(21,28,"DarkCamp",,105,"button_barracks",9,,,,""),
	[%!d(string=22)] = new Cfg_t_system_open_s_Info(22,29,"Building_dismantle",,10020,"button_dismantle",,,,,""),
	[%!d(string=23)] = new Cfg_t_system_open_s_Info(23,31,"Building_bazaar",,10021,"button_bazaar",11,,,,"2,19,1"),
	[%!d(string=24)] = new Cfg_t_system_open_s_Info(24,32,"Furniture",,10022,"button_furniture",,,,,""),
	[%!d(string=25)] = new Cfg_t_system_open_s_Info(25,33,"Uimall",,10022,"",12,,,,"4,103,1"),
	[%!d(string=26)] = new Cfg_t_system_open_s_Info(26,34,"Achievement_Personal",,24201,"button_achievement_personal",14,,,,"3,4000049,1"),
	[%!d(string=27)] = new Cfg_t_system_open_s_Info(27,35,"Achievement_World",,24107,"button_achievement_world",15,,,,"3,4000049,1"),
	[%!d(string=28)] = new Cfg_t_system_open_s_Info(28,36,"Notice",,10023,"button_notice",19,,,,"1,0"),
	[%!d(string=29)] = new Cfg_t_system_open_s_Info(29,37,"Consume_Spring",,24401,"",16,,,,""),
	[%!d(string=30)] = new Cfg_t_system_open_s_Info(30,38,"Quest_Level",,,"",25,,,,"4,101,1"),
	[%!d(string=31)] = new Cfg_t_system_open_s_Info(31,39,"PVP",,,"",20,,,,"4,140,1"),
	[%!d(string=32)] = new Cfg_t_system_open_s_Info(32,40,"World_Element",,,"",,,,,""),
	[%!d(string=33)] = new Cfg_t_system_open_s_Info(33,41,"Store_Buy",,,"",,,,,""),
	[%!d(string=34)] = new Cfg_t_system_open_s_Info(34,42,"Build_Harvest",,,"",,,,,""),
	[%!d(string=35)] = new Cfg_t_system_open_s_Info(35,43,"Build_Upgrade_Num",,,"",,,,,""),
	[%!d(string=36)] = new Cfg_t_system_open_s_Info(36,44,"Build_Upgrade",,,"",,,,,""),
	[%!d(string=37)] = new Cfg_t_system_open_s_Info(37,45,"Item_Shop",,10024,"button_itemshop",21,,,,"2,19,1"),
	[%!d(string=38)] = new Cfg_t_system_open_s_Info(38,46,"InfinityTower",,28200,"button_InfinityTower",23,,,,""),
	[%!d(string=39)] = new Cfg_t_system_open_s_Info(39,47,"Devildom",,28103,"button_Devildom",24,,,,""),
	[%!d(string=40)] = new Cfg_t_system_open_s_Info(40,48,"AutoBattle",,63,"",,,,,"4,115,1;5,1,0"),
	[%!d(string=41)] = new Cfg_t_system_open_s_Info(41,49,"AutoUse",,64,"",,,,,"4,140,1;5,4,0"),
	[%!d(string=42)] = new Cfg_t_system_open_s_Info(42,50,"Activity",,,"",,,,,"4,105,1"),
	[%!d(string=43)] = new Cfg_t_system_open_s_Info(43,51,"Welfare",,,"",,,,,"4,105,1"),
	[%!d(string=44)] = new Cfg_t_system_open_s_Info(44,52,"First_charge",,,"",,,,,"4,102,1"),
	[%!d(string=45)] = new Cfg_t_system_open_s_Info(45,53,"ArenaResult",,,"",27,,,,""),
	[%!d(string=46)] = new Cfg_t_system_open_s_Info(46,54,"Remove_Debris",,,"",,,,,""),
};
}
