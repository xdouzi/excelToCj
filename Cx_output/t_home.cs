using System.Collections.Generic;
public class t_homeInfo
{
public int id;
public int a_base_home_id;
public int a_base_culturelevel;
public string a_ints_home_furniture;
public int a_base_show;
public string a_arrayints_home_unlock;
public string a_arrayints_home_unlockarea;
public int a_base_clickmessage;
public string a_pairints_home_unlockcost;
public int a_base_home_effect_unlock;
public int a_base_home_animation_unlock;
public int a_base_home_enableunlockplot;
public int a_base_home_unlockplot;
public string a_vector2_home_center;
public int a_base_hometips;
public string a_arrayints_interactive;
public string a_arrayints_role_interaction_0;
public string a_arrayints_role_interaction_1;
public int a_base_interval;
public t_homeInfo(int id,int a_base_furniture_group_id,int a_base_group_name,string a_base_group_icon,int c_base_groupprefab_id,string a_arrayints_furnituregroup_unlock,string a_pairints_furniture_unlockcost,int a_base_unlock_effect_complete,int a_base_unlock_animation_complete,int a_base_furnitur_group,int a_base_furniture_enableunlockplot,int a_base_furniture_unlockplot,int a_base_group_unlockffect,int a_base_group_clickeffect,int a_base_group_choseeffect,int a_base_grouptips,int c_base_relation_idint id,int a_base_furniture_id,int a_base_furniture_name,string a_base_furniture_icon,int a_base_group_id,int c_base_furnitureprefab_id,int a_base_furniture_tips,string a_ints_upgradeway,string a_ints_refitgroup,int a_base_furniture_lv,string a_arrayints_upgrade_condition,string a_pairints_upgrade_expend,string a_pairints_refi_expend,int a_base_upgrade_time,int a_base_upgrade_effect_building,int a_base_upgrade_animation_building,int a_base_upgrade_effect_complete,int a_base_upgrade_animation_complete,int a_base_furniture_prompteffect,int a_base_rank,int a_base_furniture_clickeffect,int a_base_furniture_choseeffect,int a_base_furnitureplot,int a_base_furnituretips,string a_base_interactive,string a_arrayints_coordinate,string a_arrayints_role_animation,string a_arrayints_role_languageint id,int a_base_home_id,int a_base_culturelevel,string a_ints_home_furniture,int a_base_show,string a_arrayints_home_unlock,string a_arrayints_home_unlockarea,int a_base_clickmessage,string a_pairints_home_unlockcost,int a_base_home_effect_unlock,int a_base_home_animation_unlock,int a_base_home_enableunlockplot,int a_base_home_unlockplot,string a_vector2_home_center,int a_base_hometips,string a_arrayints_interactive,string a_arrayints_role_interaction_0,string a_arrayints_role_interaction_1,int a_base_interval)
{
  this.id = id;
  this.a_base_home_id = a_base_home_id;
  this.a_base_culturelevel = a_base_culturelevel;
  this.a_ints_home_furniture = a_ints_home_furniture;
  this.a_base_show = a_base_show;
  this.a_arrayints_home_unlock = a_arrayints_home_unlock;
  this.a_arrayints_home_unlockarea = a_arrayints_home_unlockarea;
  this.a_base_clickmessage = a_base_clickmessage;
  this.a_pairints_home_unlockcost = a_pairints_home_unlockcost;
  this.a_base_home_effect_unlock = a_base_home_effect_unlock;
  this.a_base_home_animation_unlock = a_base_home_animation_unlock;
  this.a_base_home_enableunlockplot = a_base_home_enableunlockplot;
  this.a_base_home_unlockplot = a_base_home_unlockplot;
  this.a_vector2_home_center = a_vector2_home_center;
  this.a_base_hometips = a_base_hometips;
  this.a_arrayints_interactive = a_arrayints_interactive;
  this.a_arrayints_role_interaction_0 = a_arrayints_role_interaction_0;
  this.a_arrayints_role_interaction_1 = a_arrayints_role_interaction_1;
  this.a_base_interval = a_base_interval;
}
}
public class Cfg_t_home
{
public static List<t_homeInfo> list = new List<t_homeInfo>()
{
	[0] = new t_homeInfo(1,1,1,"1,2,3",0,"","1,1,2,2",20005,"-2,100",,,,1,"7.73,-5.53",20005,"0,10000","","",15000),
	[1] = new t_homeInfo(2,2,2,"4",1,"4,2","1,1,2,2",20005,"-2,101",,,,,"0,0",20005,"0,10000","","",15000),
	[2] = new t_homeInfo(3,3,3,"5",1,"4,3","1,1,2,2",20005,"-2,102",,,,,"0,0",20005,"0,10000","","",15000),
	[3] = new t_homeInfo(4,4,4,"6",1,"4,4","1,1,2,2",20005,"-2,103",,,,,"0,0",20005,"0,10000","","",15000),
	[4] = new t_homeInfo(5,5,5,"6",1,"4,5","1,1,2,2",20005,"-2,104",,,,,"0,0",20005,"0,10000","","",15000),
};
}
