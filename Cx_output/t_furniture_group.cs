using System.Collections.Generic;
public class Cfg_t_furniture_group_Info
{
	public int id;
	public int a_base_furniture_group_id;
	public int a_base_group_name;
	public string a_base_group_icon;
	public int c_base_groupprefab_id;
	public string a_arrayints_furnituregroup_unlock;
	public string a_pairints_furniture_unlockcost;
	public int a_base_unlock_effect_complete;
	public int a_base_unlock_animation_complete;
	public int a_base_furnitur_group;
	public int a_base_furniture_enableunlockplot;
	public int a_base_furniture_unlockplot;
	public int a_base_group_unlockffect;
	public int a_base_group_clickeffect;
	public int a_base_group_choseeffect;
	public int a_base_grouptips;
	public int c_base_relation_id;
public Cfg_t_furniture_group_Info(int id,int a_base_furniture_group_id,int a_base_group_name,string a_base_group_icon,int c_base_groupprefab_id,string a_arrayints_furnituregroup_unlock,string a_pairints_furniture_unlockcost,int a_base_unlock_effect_complete,int a_base_unlock_animation_complete,int a_base_furnitur_group,int a_base_furniture_enableunlockplot,int a_base_furniture_unlockplot,int a_base_group_unlockffect,int a_base_group_clickeffect,int a_base_group_choseeffect,int a_base_grouptips,int c_base_relation_id)
{
  this.id = id;
  this.a_base_furniture_group_id = a_base_furniture_group_id;
  this.a_base_group_name = a_base_group_name;
  this.a_base_group_icon = a_base_group_icon;
  this.c_base_groupprefab_id = c_base_groupprefab_id;
  this.a_arrayints_furnituregroup_unlock = a_arrayints_furnituregroup_unlock;
  this.a_pairints_furniture_unlockcost = a_pairints_furniture_unlockcost;
  this.a_base_unlock_effect_complete = a_base_unlock_effect_complete;
  this.a_base_unlock_animation_complete = a_base_unlock_animation_complete;
  this.a_base_furnitur_group = a_base_furnitur_group;
  this.a_base_furniture_enableunlockplot = a_base_furniture_enableunlockplot;
  this.a_base_furniture_unlockplot = a_base_furniture_unlockplot;
  this.a_base_group_unlockffect = a_base_group_unlockffect;
  this.a_base_group_clickeffect = a_base_group_clickeffect;
  this.a_base_group_choseeffect = a_base_group_choseeffect;
  this.a_base_grouptips = a_base_grouptips;
  this.c_base_relation_id = c_base_relation_id;
}
}
public class Cfg_t_furniture_group
{
public static List<Cfg_t_furniture_group_Info> list = new List<Cfg_t_furniture_group_Info>()
{
	[%!d(string=1)] = new Cfg_t_furniture_group_Info(1,1,100001,"UI/UIRes/UICommon/Sprite_Icon_Rank1.png",20001,"4,1,0","-101,10",,,1,,2,,,,20005,1),
	[%!d(string=2)] = new Cfg_t_furniture_group_Info(2,2,100007,"UI/UIRes/UICommon/Icon_Rank_1.png",20007,"4,1,0","-102,10",,,1,,,,,,20005,6),
	[%!d(string=3)] = new Cfg_t_furniture_group_Info(3,3,100013,"UI/UIRes/UICommon/Sprite_Rank_1.png",20013,"4,1,0","-103,10",,,,,,,,,20005,11),
	[%!d(string=4)] = new Cfg_t_furniture_group_Info(4,4,100019,"UI/UIRes/UICommon/Sprite_Icon_Rank1.png",20019,"4,1,0","4001,110;4002,120",,,,,,,,,20005,16),
	[%!d(string=5)] = new Cfg_t_furniture_group_Info(5,5,100025,"UI/UIRes/UICommon/Icon_Rank_1.png",20025,"4,1,0","4002,110;4003,120",,,,,,,,,20005,21),
	[%!d(string=6)] = new Cfg_t_furniture_group_Info(6,6,100031,"UI/UIRes/UICommon/Sprite_Rank_1.png",20031,"4,1,0","4003,110;4004,120",,,,,,,,,20005,26),
};
}
