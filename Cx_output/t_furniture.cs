using System.Collections.Generic;
public class Cfg_t_furniture_Info
{
public int id;
public int a_base_furniture_id;
public int a_base_furniture_name;
public string a_base_furniture_icon;
public int a_base_group_id;
public int c_base_furnitureprefab_id;
public int a_base_furniture_tips;
public string a_ints_upgradeway;
public string a_ints_refitgroup;
public int a_base_furniture_lv;
public string a_arrayints_upgrade_condition;
public string a_pairints_upgrade_expend;
public string a_pairints_refi_expend;
public int a_base_upgrade_time;
public int a_base_upgrade_effect_building;
public int a_base_upgrade_animation_building;
public int a_base_upgrade_effect_complete;
public int a_base_upgrade_animation_complete;
public int a_base_furniture_prompteffect;
public int a_base_rank;
public int a_base_furniture_clickeffect;
public int a_base_furniture_choseeffect;
public int a_base_furnitureplot;
public int a_base_furnituretips;
public string a_base_interactive;
public string a_arrayints_coordinate;
public string a_arrayints_role_animation;
public string a_arrayints_role_language;
public Cfg_t_furniture_Info(int id,int a_base_furniture_group_id,int a_base_group_name,string a_base_group_icon,int c_base_groupprefab_id,string a_arrayints_furnituregroup_unlock,string a_pairints_furniture_unlockcost,int a_base_unlock_effect_complete,int a_base_unlock_animation_complete,int a_base_furnitur_group,int a_base_furniture_enableunlockplot,int a_base_furniture_unlockplot,int a_base_group_unlockffect,int a_base_group_clickeffect,int a_base_group_choseeffect,int a_base_grouptips,int c_base_relation_idint id,int a_base_furniture_id,int a_base_furniture_name,string a_base_furniture_icon,int a_base_group_id,int c_base_furnitureprefab_id,int a_base_furniture_tips,string a_ints_upgradeway,string a_ints_refitgroup,int a_base_furniture_lv,string a_arrayints_upgrade_condition,string a_pairints_upgrade_expend,string a_pairints_refi_expend,int a_base_upgrade_time,int a_base_upgrade_effect_building,int a_base_upgrade_animation_building,int a_base_upgrade_effect_complete,int a_base_upgrade_animation_complete,int a_base_furniture_prompteffect,int a_base_rank,int a_base_furniture_clickeffect,int a_base_furniture_choseeffect,int a_base_furnitureplot,int a_base_furnituretips,string a_base_interactive,string a_arrayints_coordinate,string a_arrayints_role_animation,string a_arrayints_role_language)
{
  this.id = id;
  this.a_base_furniture_id = a_base_furniture_id;
  this.a_base_furniture_name = a_base_furniture_name;
  this.a_base_furniture_icon = a_base_furniture_icon;
  this.a_base_group_id = a_base_group_id;
  this.c_base_furnitureprefab_id = c_base_furnitureprefab_id;
  this.a_base_furniture_tips = a_base_furniture_tips;
  this.a_ints_upgradeway = a_ints_upgradeway;
  this.a_ints_refitgroup = a_ints_refitgroup;
  this.a_base_furniture_lv = a_base_furniture_lv;
  this.a_arrayints_upgrade_condition = a_arrayints_upgrade_condition;
  this.a_pairints_upgrade_expend = a_pairints_upgrade_expend;
  this.a_pairints_refi_expend = a_pairints_refi_expend;
  this.a_base_upgrade_time = a_base_upgrade_time;
  this.a_base_upgrade_effect_building = a_base_upgrade_effect_building;
  this.a_base_upgrade_animation_building = a_base_upgrade_animation_building;
  this.a_base_upgrade_effect_complete = a_base_upgrade_effect_complete;
  this.a_base_upgrade_animation_complete = a_base_upgrade_animation_complete;
  this.a_base_furniture_prompteffect = a_base_furniture_prompteffect;
  this.a_base_rank = a_base_rank;
  this.a_base_furniture_clickeffect = a_base_furniture_clickeffect;
  this.a_base_furniture_choseeffect = a_base_furniture_choseeffect;
  this.a_base_furnitureplot = a_base_furnitureplot;
  this.a_base_furnituretips = a_base_furnituretips;
  this.a_base_interactive = a_base_interactive;
  this.a_arrayints_coordinate = a_arrayints_coordinate;
  this.a_arrayints_role_animation = a_arrayints_role_animation;
  this.a_arrayints_role_language = a_arrayints_role_language;
}
}
public class Cfg_t_furniture
{
public static List<Cfg_t_furniture_Info> list = new List<Cfg_t_furniture_Info>()
{
	[0] = new Cfg_t_furniture_Info(1,1,100002,"UI/UIRes/UICommon/Sprite_Icon_Rank2.png",1,20002,,"2","",1,"1,0,1","-2,1","-102,100",0,0,0,0,0,0,1,0,0,1,20005,"0","","",""),
	[1] = new Cfg_t_furniture_Info(2,2,100003,"UI/UIRes/UICommon/Sprite_Icon_Rank3.png",1,20003,,"3","",2,"1,0,1","-2,2","-102,101",0,0,0,0,0,0,2,0,0,2,20005,"0","","",""),
	[2] = new Cfg_t_furniture_Info(3,3,100004,"UI/UIRes/UICommon/Sprite_Icon_Rank2.png",1,20004,,"4,5","",3,"1,0,1","-2,3","-102,102",0,0,0,0,0,0,3,0,0,1,20005,"0","","",""),
	[3] = new Cfg_t_furniture_Info(4,4,100005,"UI/UIRes/UICommon/Sprite_Icon_Rank3.png",1,20005,,"","4,5",4,"1,0,1","-2,4","-102,103",0,0,0,0,0,0,4,0,0,2,20005,"0","","",""),
	[4] = new Cfg_t_furniture_Info(5,5,100006,"UI/UIRes/UICommon/Sprite_Icon_Rank2.png",1,20006,,"","4,5",4,"1,0,1","-2,5","-102,104",0,0,0,0,0,0,5,0,0,0,20005,"0","","",""),
	[5] = new Cfg_t_furniture_Info(6,6,100008,"UI/UIRes/UICommon/Icon_Rank_2.png",2,20008,,"7","",1,"1,0,1","-2,6","-102,105",0,0,0,0,0,0,6,0,0,0,20005,"0","","",""),
	[6] = new Cfg_t_furniture_Info(7,7,100009,"UI/UIRes/UICommon/Icon_Rank_3.png",2,20009,,"8","",2,"1,0,1","-2,7","-102,106",0,0,0,0,0,0,7,0,0,0,20005,"0","","",""),
	[7] = new Cfg_t_furniture_Info(8,8,100010,"UI/UIRes/UICommon/Icon_Rank_2.png",2,20010,,"9,10","",3,"1,0,1","-2,8","-102,107",0,0,0,0,0,0,8,0,0,0,20005,"0","","",""),
	[8] = new Cfg_t_furniture_Info(9,9,100011,"UI/UIRes/UICommon/Icon_Rank_3.png",2,20011,,"","9,10",4,"1,0,1","-2,9","-102,108",0,0,0,0,0,0,9,0,0,0,20005,"0","","",""),
	[9] = new Cfg_t_furniture_Info(10,10,100012,"UI/UIRes/UICommon/Icon_Rank_2.png",2,20012,,"","9,10",4,"1,0,1","-2,10","-102,109",0,0,0,0,0,0,10,0,0,0,20005,"0","","",""),
	[10] = new Cfg_t_furniture_Info(11,11,100014,"UI/UIRes/UICommon/Sprite_Rank_2.png",3,20014,,"12","",1,"1,0,1","-2,11","-102,110",0,0,0,0,0,0,11,0,0,0,20005,"0","","",""),
	[11] = new Cfg_t_furniture_Info(12,12,100015,"UI/UIRes/UICommon/Sprite_Rank_3.png",3,20015,,"13","",2,"1,0,1","-2,12","-102,111",0,0,0,0,0,0,12,0,0,0,20005,"0","","",""),
	[12] = new Cfg_t_furniture_Info(13,13,100016,"UI/UIRes/UICommon/Sprite_Rank_2.png",3,20016,,"14,15","",3,"1,0,1","-2,13","-102,112",0,0,0,0,0,0,13,0,0,0,20005,"0","","",""),
	[13] = new Cfg_t_furniture_Info(14,14,100017,"UI/UIRes/UICommon/Sprite_Rank_3.png",3,20017,,"","14,15",4,"1,0,1","-2,14","-102,113",0,0,0,0,0,0,14,0,0,0,20005,"0","","",""),
	[14] = new Cfg_t_furniture_Info(15,15,100018,"UI/UIRes/UICommon/Sprite_Rank_2.png",3,20018,,"","14,15",4,"1,0,1","-2,15","-102,114",0,0,0,0,0,0,15,0,0,0,20005,"0","","",""),
	[15] = new Cfg_t_furniture_Info(16,16,100020,"UI/UIRes/UICommon/Sprite_Icon_Rank2.png",4,20020,,"17","",1,"1,0,1","-2,16","-102,115",0,0,0,0,0,0,16,0,0,0,20005,"0","","",""),
	[16] = new Cfg_t_furniture_Info(17,17,100021,"UI/UIRes/UICommon/Sprite_Icon_Rank3.png",4,20021,,"18","",2,"1,0,1","-2,17","-102,116",0,0,0,0,0,0,17,0,0,0,20005,"0","","",""),
	[17] = new Cfg_t_furniture_Info(18,18,100022,"UI/UIRes/UICommon/Sprite_Icon_Rank2.png",4,20022,,"19,20","",3,"1,0,1","-2,18","-102,117",0,0,0,0,0,0,18,0,0,0,20005,"0","","",""),
	[18] = new Cfg_t_furniture_Info(19,19,100023,"UI/UIRes/UICommon/Sprite_Icon_Rank3.png",4,20023,,"","19,20",4,"1,0,1","-2,19","-102,118",0,0,0,0,0,0,19,0,0,0,20005,"0","","",""),
	[19] = new Cfg_t_furniture_Info(20,20,100024,"UI/UIRes/UICommon/Sprite_Icon_Rank2.png",4,20024,,"","19,20",4,"1,0,1","-2,20","-102,119",0,0,0,0,0,0,20,0,0,0,20005,"0","","",""),
	[20] = new Cfg_t_furniture_Info(21,21,100026,"UI/UIRes/UICommon/Icon_Rank_2.png",5,20026,,"22","",1,"1,0,1","-2,21","-102,120",0,0,0,0,0,0,21,0,0,0,20005,"0","","",""),
	[21] = new Cfg_t_furniture_Info(22,22,100027,"UI/UIRes/UICommon/Icon_Rank_3.png",5,20027,,"23","",2,"1,0,1","-2,22","-102,121",0,0,0,0,0,0,22,0,0,0,20005,"0","","",""),
	[22] = new Cfg_t_furniture_Info(23,23,100028,"UI/UIRes/UICommon/Icon_Rank_2.png",5,20028,,"24,25","",3,"1,0,1","-2,23","-102,122",0,0,0,0,0,0,23,0,0,0,20005,"0","","",""),
	[23] = new Cfg_t_furniture_Info(24,24,100029,"UI/UIRes/UICommon/Icon_Rank_3.png",5,20029,,"","24,25",4,"1,0,1","-2,24","-102,123",0,0,0,0,0,0,24,0,0,0,20005,"0","","",""),
	[24] = new Cfg_t_furniture_Info(25,25,100030,"UI/UIRes/UICommon/Icon_Rank_2.png",5,20030,,"","24,25",4,"1,0,1","-2,25","-102,124",0,0,0,0,0,0,25,0,0,0,20005,"0","","",""),
	[25] = new Cfg_t_furniture_Info(26,26,100032,"UI/UIRes/UICommon/Sprite_Rank_2.png",6,20032,,"27","",1,"1,0,1","-2,26","-102,125",0,0,0,0,0,0,26,0,0,0,20005,"0","","",""),
	[26] = new Cfg_t_furniture_Info(27,27,100033,"UI/UIRes/UICommon/Sprite_Rank_3.png",6,20033,,"28","",2,"1,0,1","-2,27","-102,126",0,0,0,0,0,0,27,0,0,0,20005,"0","","",""),
	[27] = new Cfg_t_furniture_Info(28,28,100034,"UI/UIRes/UICommon/Sprite_Rank_2.png",6,20034,,"29,30","",3,"1,0,1","-2,28","-102,127",0,0,0,0,0,0,28,0,0,0,20005,"0","","",""),
	[28] = new Cfg_t_furniture_Info(29,29,100035,"UI/UIRes/UICommon/Sprite_Rank_3.png",6,20035,,"","29,30",4,"1,0,1","-2,29","-102,128",0,0,0,0,0,0,29,0,0,0,20005,"0","","",""),
	[29] = new Cfg_t_furniture_Info(30,30,100036,"UI/UIRes/UICommon/Sprite_Rank_2.png",6,20036,,"","29,30",4,"1,0,1","-2,30","-102,129",0,0,0,0,0,0,30,0,0,0,20005,"0","","",""),
};
}
