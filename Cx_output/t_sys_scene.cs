using System.Collections.Generic;
public class t_sys_sceneInfo
{
public int id;
public int c_base_scene_id;
public string c_e_name;
public int c_base_bgmid;
public int c_base_scene_type;
public t_sys_sceneInfo(int id,int c_base_scene_id,string c_e_name,int c_base_bgmid,int c_base_scene_type)
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
public static List<t_sys_sceneInfo> list = new List<t_sys_sceneInfo>()
{
	[0] = new t_sys_sceneInfo(1,1,"InitScene",10001,2),
	[1] = new t_sys_sceneInfo(2,3,"BattleScene03",10001,2),
	[2] = new t_sys_sceneInfo(3,4,"BattleScene04",10001,2),
	[3] = new t_sys_sceneInfo(4,5,"BattleScene05",10001,2),
	[4] = new t_sys_sceneInfo(5,6,"BattleScene06",10001,2),
	[5] = new t_sys_sceneInfo(6,7,"FurnitureScene",10001,2),
	[6] = new t_sys_sceneInfo(7,8,"BattleScene07",10001,2),
	[7] = new t_sys_sceneInfo(8,10001,"StoneAge_Level_01",10001,2),
	[8] = new t_sys_sceneInfo(9,10002,"StoneAge_Level_02",10001,2),
	[9] = new t_sys_sceneInfo(10,30001,"StoneAge_Tower_01",10001,2),
	[10] = new t_sys_sceneInfo(11,50001,"StoneAge_PVP_01",10001,2),
	[11] = new t_sys_sceneInfo(12,70001,"StoneAge_PVP_6V6",10001,2),
};
}
