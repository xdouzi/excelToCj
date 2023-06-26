using System.Collections.Generic;
public class Cfg_t_sys_scene_detail_Info
{
public int id;
public int c_base_scene_detail_id;
public string c_base_name;
public string c_base_scene_path;
public int c_base_scene_grade;
public Cfg_t_sys_scene_detail_Info(int id,int c_base_scene_id,string c_e_name,int c_base_bgmid,int c_base_scene_typeint id,int c_base_scene_detail_id,string c_base_name,string c_base_scene_path,int c_base_scene_grade)
{
  this.id = id;
  this.c_base_scene_detail_id = c_base_scene_detail_id;
  this.c_base_name = c_base_name;
  this.c_base_scene_path = c_base_scene_path;
  this.c_base_scene_grade = c_base_scene_grade;
}
}
public class Cfg_t_sys_scene_detail
{
public static List<Cfg_t_sys_scene_detail_Info> list = new List<Cfg_t_sys_scene_detail_Info>()
{
	[0] = new Cfg_t_sys_scene_detail_Info(1,1011,"InitScene","Download/Scenes/InitScenes/InitScene01",0),
	[1] = new Cfg_t_sys_scene_detail_Info(2,1003,"BattleScene03","Download/Scenes/CardBattle/CardBattle_03/CardBattle_03",0),
	[2] = new Cfg_t_sys_scene_detail_Info(3,1004,"BattleScene04","Download/Scenes/CardBattle/CardBattle_04/CardBattle_04",0),
	[3] = new Cfg_t_sys_scene_detail_Info(4,1005,"BattleScene05","Download/Scenes/CardBattle/CardBattle_05/CardBattle_05",0),
	[4] = new Cfg_t_sys_scene_detail_Info(5,1015,"BattleScene06","Download/Scenes/CardBattle/CardBattle_06/CardBattle_06",0),
	[5] = new Cfg_t_sys_scene_detail_Info(6,1016,"FurnitureScene","Download/Scenes/HomeView/Furniture_Scene",0),
	[6] = new Cfg_t_sys_scene_detail_Info(7,1017,"BattleScene07","Download/Scenes/CardBattle/CardBattle_07/CardBattle_07",0),
	[7] = new Cfg_t_sys_scene_detail_Info(8,10001,"StoneAge_Level_01","Download/Scenes/CardBattle/StoneAge_Level_01/StoneAge_Level_01",0),
	[8] = new Cfg_t_sys_scene_detail_Info(9,10002,"StoneAge_Level_02","Download/Scenes/CardBattle/StoneAge_Level_01/StoneAge_Level_02",0),
	[9] = new Cfg_t_sys_scene_detail_Info(10,30001,"StoneAge_Tower_01","Download/Scenes/CardBattle/StoneAge_Level_01/StoneAge_Tower_01",0),
	[10] = new Cfg_t_sys_scene_detail_Info(11,50001,"StoneAge_PVP_01","Download/Scenes/CardBattle/StoneAge_PVP_01/StoneAge_PVP_01",0),
	[11] = new Cfg_t_sys_scene_detail_Info(12,70001,"StoneAge_PVP_6V6","Download/Scenes/CardBattle/StoneAge_Level_01/StoneAge_PVP_6V6",0),
};
}
