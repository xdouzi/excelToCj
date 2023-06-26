using System.Collections.Generic;
public class Cfg_t_sys_scene_Info
{
	public int id;
	public int c_base_scene_id;
	public string c_e_name;
	public int c_base_bgmid;
	public int c_base_scene_type;
public Cfg_t_sys_scene_Info(int id,int c_base_scene_id,string c_e_name,int c_base_bgmid,int c_base_scene_type)
{
  this.id = id;
  this.c_base_scene_id = c_base_scene_id;
  this.c_e_name = c_e_name;
  this.c_base_bgmid = c_base_bgmid;
  this.c_base_scene_type = c_base_scene_type;
}
}
public class Cfg_t_sys_scene
{
public static List<Cfg_t_sys_scene_Info> list = new List<Cfg_t_sys_scene_Info>()
{
	[%!d(string=1)] = new Cfg_t_sys_scene_Info(1,1,"InitScene",10001,2),
	[%!d(string=2)] = new Cfg_t_sys_scene_Info(2,3,"BattleScene03",10001,2),
	[%!d(string=3)] = new Cfg_t_sys_scene_Info(3,4,"BattleScene04",10001,2),
	[%!d(string=4)] = new Cfg_t_sys_scene_Info(4,5,"BattleScene05",10001,2),
	[%!d(string=5)] = new Cfg_t_sys_scene_Info(5,6,"BattleScene06",10001,2),
	[%!d(string=6)] = new Cfg_t_sys_scene_Info(6,7,"FurnitureScene",10001,2),
	[%!d(string=7)] = new Cfg_t_sys_scene_Info(7,8,"BattleScene07",10001,2),
	[%!d(string=8)] = new Cfg_t_sys_scene_Info(8,10001,"StoneAge_Level_01",10001,2),
	[%!d(string=9)] = new Cfg_t_sys_scene_Info(9,10002,"StoneAge_Level_02",10001,2),
	[%!d(string=10)] = new Cfg_t_sys_scene_Info(10,30001,"StoneAge_Tower_01",10001,2),
	[%!d(string=11)] = new Cfg_t_sys_scene_Info(11,50001,"StoneAge_PVP_01",10001,2),
	[%!d(string=12)] = new Cfg_t_sys_scene_Info(12,70001,"StoneAge_PVP_6V6",10001,2),
};
}
