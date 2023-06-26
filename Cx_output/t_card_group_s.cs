using System.Collections.Generic;
public class Cfg_t_card_group_s_Info
{
	public int id;
	public int a_base_group;
	public string a_base_operater_id;
	public int c_base_name;
	public int c_base_is_show;
	public int a_base_type;
	public int a_base_quality;
	public int a_base_initial_level;
	public int c_base_star_number;
	public int c_base_era;
	public int c_base_class;
	public int c_base_prefabid;
	public int c_base_prefabid_battle;
	public int c_base_cardmodel_size;
	public int c_base_chessbordmodel_size;
	public int a_base_trade;
	public string a_ints_lowest_price;
	public string c_ints_special_effect;
	public string c_vector3s_effect_location;
	public string c_vector3s_effect_revolve;
	public string c_ints_effect_zoom;
	public string c_ints_effect_delay;
	public string c_base_effect_node;
	public int c_base_backstory;
	public string a_vector3_position;
	public string a_vector3_scale;
	public string a_vector3_formation;
	public string a_base_spineData;
	public int a_base_card_landing_sound;
public Cfg_t_card_group_s_Info(int id,int a_base_card_id,string a_base_operater_id,int a_base_group,int a_base_level,int a_base_next_lv_id,int c_base_cardborn_effect,int a_base_setarea,int a_base_auto_ai,string c_arrayints_release_position,int a_base_skill_id,string c_ints_release_parameter,string c_ints_indicator,string c_arrayints_backpack_show_position,string c_base_backpack_show_parameter,string c_base_ui_show_position,string c_base_ui_show_parameter,string c_base_scene_show_position,int c_base_show_model_id,string c_base_scene_show_parameter,int a_base_cost_card,string a_base_cost_item,int a_base_energy_type,int a_base_energy_number,string c_base_showcase_properties,string c_base_videoint id,int a_base_group,string a_base_operater_id,int c_base_name,int c_base_is_show,int a_base_type,int a_base_quality,int a_base_initial_level,int c_base_star_number,int c_base_era,int c_base_class,int c_base_prefabid,int c_base_prefabid_battle,int c_base_cardmodel_size,int c_base_chessbordmodel_size,int a_base_trade,string a_ints_lowest_price,string c_ints_special_effect,string c_vector3s_effect_location,string c_vector3s_effect_revolve,string c_ints_effect_zoom,string c_ints_effect_delay,string c_base_effect_node,int c_base_backstory,string a_vector3_position,string a_vector3_scale,string a_vector3_formation,string a_base_spineData,int a_base_card_landing_sound)
{
  this.id = id;
  this.a_base_group = a_base_group;
  this.a_base_operater_id = a_base_operater_id;
  this.c_base_name = c_base_name;
  this.c_base_is_show = c_base_is_show;
  this.a_base_type = a_base_type;
  this.a_base_quality = a_base_quality;
  this.a_base_initial_level = a_base_initial_level;
  this.c_base_star_number = c_base_star_number;
  this.c_base_era = c_base_era;
  this.c_base_class = c_base_class;
  this.c_base_prefabid = c_base_prefabid;
  this.c_base_prefabid_battle = c_base_prefabid_battle;
  this.c_base_cardmodel_size = c_base_cardmodel_size;
  this.c_base_chessbordmodel_size = c_base_chessbordmodel_size;
  this.a_base_trade = a_base_trade;
  this.a_ints_lowest_price = a_ints_lowest_price;
  this.c_ints_special_effect = c_ints_special_effect;
  this.c_vector3s_effect_location = c_vector3s_effect_location;
  this.c_vector3s_effect_revolve = c_vector3s_effect_revolve;
  this.c_ints_effect_zoom = c_ints_effect_zoom;
  this.c_ints_effect_delay = c_ints_effect_delay;
  this.c_base_effect_node = c_base_effect_node;
  this.c_base_backstory = c_base_backstory;
  this.a_vector3_position = a_vector3_position;
  this.a_vector3_scale = a_vector3_scale;
  this.a_vector3_formation = a_vector3_formation;
  this.a_base_spineData = a_base_spineData;
  this.a_base_card_landing_sound = a_base_card_landing_sound;
}
}
public class Cfg_t_card_group_s
{
public static List<Cfg_t_card_group_s_Info> list = new List<Cfg_t_card_group_s_Info>()
{
	[0] = new Cfg_t_card_group_s_Info(1,10200,"0",20010200,1,2,1,1,2,1,6,10000009,20000009,15000,8000,0,"-5,50","","","","","","",21010200,"0,-1,10","1,1,1","0.03,-0.02,0","Hero/Spine/wanjianqifa/skeleton_SkeletonData","Hero/Spine/wanjianqifa/skeleton_SkeletonData"),
	[1] = new Cfg_t_card_group_s_Info(2,10201,"0",20010201,1,2,3,1,4,1,6,10000001,20000001,8000,8000,0,"-5,50","","","","","","",21010201,"0,1,12","1,1,1","0,0.18,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[2] = new Cfg_t_card_group_s_Info(3,10202,"0",20010202,0,2,2,1,3,2,6,10000014,20000014,10000,8000,0,"-5,50","","","","","","",21010202,"0,-1.1,6.9","1,1,1","0,0,0","Hero/Spine/duyaofashu/skeleton_SkeletonData","Hero/Spine/duyaofashu/skeleton_SkeletonData"),
	[3] = new Cfg_t_card_group_s_Info(4,10203,"0",20010203,0,2,1,1,2,2,6,10000015,20000015,10000,8000,0,"-5,50","","","","","","",21010203,"0,-1.1,6.9","2.73,2.73,2.73","0,0,0","Hero/Spine/huoqiu/skeleton_SkeletonData","Hero/Spine/huoqiu/skeleton_SkeletonData"),
	[4] = new Cfg_t_card_group_s_Info(5,10204,"0",20010204,1,2,4,1,5,1,6,10000002,20000002,8000,8000,1,"-5,50","","","","","","",21010204,"0,0,12","1,1,1","-0.02,0.12,0","Hero/Spine/gunmu/skeleton_SkeletonData","Hero/Spine/gunmu/skeleton_SkeletonData"),
	[5] = new Cfg_t_card_group_s_Info(6,10300,"0",20010300,0,2,2,1,3,3,6,10000026,20000026,10000,8000,0,"-5,50","","","","","","",21010300,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[6] = new Cfg_t_card_group_s_Info(7,10301,"0",20010301,0,2,3,1,4,3,6,10000027,20000027,10000,8000,0,"-5,50","","","","","","",21010301,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[7] = new Cfg_t_card_group_s_Info(8,10302,"0",20010302,0,2,4,1,5,3,6,10000028,20000028,10000,8000,1,"-5,50","","","","","","",21010302,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[8] = new Cfg_t_card_group_s_Info(9,10400,"0",20010400,0,2,3,1,4,4,6,10000042,20000042,10000,8000,0,"-5,50","","","","","","",21010400,"0,0,10","1,1,1","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[9] = new Cfg_t_card_group_s_Info(10,10401,"0",20010401,0,2,3,1,4,4,6,10000043,20000043,10000,8000,0,"-5,50","","","","","","",21010401,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[10] = new Cfg_t_card_group_s_Info(11,10402,"0",20010402,0,2,2,1,3,4,6,10000044,20000044,10000,8000,0,"-5,50","","","","","","",21010402,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[11] = new Cfg_t_card_group_s_Info(12,10500,"0",20010500,0,2,4,1,5,5,6,10000057,20000057,10000,8000,1,"-5,50","","","","","","",21010500,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[12] = new Cfg_t_card_group_s_Info(13,10501,"0",20010501,0,2,3,1,4,5,6,10000058,20000058,10000,8000,0,"-5,50","","","","","","",21010501,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[13] = new Cfg_t_card_group_s_Info(14,21110,"0",20021110,1,0,1,1,2,1,1,10000012,20000012,10000,8000,0,"-5,50","","","","","","",21021110,"0,-1.1,10","1,1,1","0,-0.2,0","Hero/Spine/yeniuyongshi/yeniuyongshi2_SkeletonData",20111),
	[14] = new Cfg_t_card_group_s_Info(15,21120,"0",20021120,1,0,3,1,4,1,2,10000008,20000008,12000,8000,0,"-5,50","","","","","","",21021120,"0,-1.1,12","1,1,1","-0.04,-0.12,0","Hero/Spine/songshutouishou/songshutouishou_SkeletonData",20111),
	[15] = new Cfg_t_card_group_s_Info(16,21130,"0",20021130,1,0,1,1,2,1,3,10000005,20000005,10000,8000,0,"-5,50","","","","","","",21021130,"0,-1.1,10","1,1,1","-0.01,-0.18,0","Hero/Spine/langqibing/langqibing_SkeletonData",20111),
	[16] = new Cfg_t_card_group_s_Info(17,21140,"0",20021140,1,0,3,1,4,1,4,10000011,20000011,15000,8000,0,"-5,50","","","","","","",21021140,"0,-1,11","1,1,1","-0.03,0,0","Hero/Spine/xiaojingling/xiaojingling_SkeletonData",20111),
	[17] = new Cfg_t_card_group_s_Info(18,21150,"0",20021150,1,0,3,1,4,1,5,10000010,20000010,12000,8000,0,"-5,50","","","","","","",21021150,"0,0.45,10.27","1,1,1","-0.05,0.62,0","Hero/Spine/wuya/wuya_SkeletonData",20111),
	[18] = new Cfg_t_card_group_s_Info(19,21210,"0",20021210,0,0,1,1,2,2,1,10000016,20000016,10000,8000,0,"-5,50","","","","","","",21021210,"0,-1.1,6.9","2.535,2.535,2.535","0,0,0","Hero/Spine/yeniujianshi/yeniujianshi_SkeletonData",20111),
	[19] = new Cfg_t_card_group_s_Info(20,21220,"0",20021220,0,0,1,1,2,2,2,10000017,20000017,10000,8000,0,"-5,50","","","","","","",21021220,"0,-1.1,6.9","2.535,2.535,2.535","0,0,0","Hero/Spine/gongjianshou/linshichanggongshou3_SkeletonData",20111),
	[20] = new Cfg_t_card_group_s_Info(21,21230,"0",20021230,0,0,1,1,2,2,3,10000018,20000018,10000,8000,0,"-5,50","","","","","","",21021230,"0,-1.1,6.9","2.34,2.34,2.34","0,0,0","Hero/Spine/langyouqibing/langyouqibing_SkeletonData",20111),
	[21] = new Cfg_t_card_group_s_Info(22,21240,"0",20021240,0,0,1,1,2,2,4,10000019,20000019,10000,8000,0,"-5,50","","","","","","",21021240,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/linshidujiaoshou1/linshidujiaoshou1_SkeletonData",20111),
	[22] = new Cfg_t_card_group_s_Info(23,21250,"0",20021250,0,0,2,1,3,2,5,10000020,20000020,10000,8000,0,"-5,50","","","","","","",21021250,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/shitourenzhanshi/shitouren_SkeletonData",20111),
	[23] = new Cfg_t_card_group_s_Info(24,21310,"0",20021310,0,0,1,1,2,3,1,10000029,20000029,10000,8000,0,"-5,50","","","","","","",21021310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[24] = new Cfg_t_card_group_s_Info(25,21320,"0",20021320,0,0,1,1,2,3,2,10000030,20000030,10000,8000,0,"-5,50","","","","","","",21021320,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[25] = new Cfg_t_card_group_s_Info(26,21330,"0",20021330,0,0,1,1,2,3,3,10000031,20000031,10000,8000,0,"-5,50","","","","","","",21021330,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[26] = new Cfg_t_card_group_s_Info(27,21340,"0",20021340,0,0,1,1,2,3,4,10000032,20000032,10000,8000,0,"-5,50","","","","","","",21021340,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[27] = new Cfg_t_card_group_s_Info(28,21350,"0",20021350,0,0,1,1,2,3,5,10000033,20000033,10000,8000,0,"-5,50","","","","","","",21021350,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[28] = new Cfg_t_card_group_s_Info(29,21410,"0",20021410,0,0,1,1,2,4,1,10000045,20000045,10000,8000,0,"-5,50","","","","","","",21021410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[29] = new Cfg_t_card_group_s_Info(30,21420,"0",20021420,0,0,1,1,2,4,2,10000046,20000046,10000,8000,0,"-5,50","","","","","","",21021420,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[30] = new Cfg_t_card_group_s_Info(31,21430,"0",20021430,0,0,1,1,2,4,3,10000047,20000047,10000,8000,0,"-5,50","","","","","","",21021430,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[31] = new Cfg_t_card_group_s_Info(32,21440,"0",20021440,0,0,1,1,2,4,4,10000048,20000048,10000,8000,0,"-5,50","","","","","","",21021440,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[32] = new Cfg_t_card_group_s_Info(33,21450,"0",20021450,0,0,2,1,3,4,5,10000049,20000049,10000,8000,0,"-5,50","","","","","","",21021450,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[33] = new Cfg_t_card_group_s_Info(34,21510,"0",20021510,0,0,1,1,2,5,1,10000059,20000059,10000,8000,0,"-5,50","","","","","","",21021510,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[34] = new Cfg_t_card_group_s_Info(35,21520,"0",20021520,0,0,1,1,2,5,2,10000060,20000060,10000,8000,0,"-5,50","","","","","","",21021520,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[35] = new Cfg_t_card_group_s_Info(36,21530,"0",20021530,0,0,1,1,2,5,3,10000061,20000061,10000,8000,0,"-5,50","","","","","","",21021530,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[36] = new Cfg_t_card_group_s_Info(37,21540,"0",20021540,0,0,1,1,2,5,4,10000062,20000062,10000,8000,0,"-5,50","","","","","","",21021540,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[37] = new Cfg_t_card_group_s_Info(38,21550,"0",20021550,0,0,1,1,2,5,5,10000063,20000063,10000,8000,0,"-5,50","","","","","","",21021550,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[38] = new Cfg_t_card_group_s_Info(39,32210,"0",20032210,0,0,2,1,3,2,1,10000021,20000021,10000,8000,0,"-5,50","","","","","","",21032210,"0,-1.1,6.9","2.925,2.925,2.925","0,0,0","Hero/Spine/dishuwajuezhe/dishuwajuezhe_SkeletonData",20111),
	[39] = new Cfg_t_card_group_s_Info(40,32310,"0",20032310,0,0,3,1,4,3,1,10000034,20000034,10000,8000,0,"-5,50","","","","","","",21032310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[40] = new Cfg_t_card_group_s_Info(41,32410,"0",20032410,0,0,2,1,3,4,1,10000050,20000050,10000,8000,0,"-5,50","","","","","","",21032410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[41] = new Cfg_t_card_group_s_Info(42,32510,"0",20032510,0,0,2,1,3,5,1,10000064,20000064,10000,8000,0,"-5,50","","","","","","",21032510,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[42] = new Cfg_t_card_group_s_Info(43,33210,"0",20033210,0,0,3,1,4,2,2,10000022,20000022,10000,8000,0,"-5,50","","","","","","",21033210,"0,-1.1,6.9","2.145,2.145,2.145","0,0,0","Hero/Spine/haixiangfeifu/haixiangfeifu_SkeletonData",20111),
	[43] = new Cfg_t_card_group_s_Info(44,33310,"0",20033310,0,0,4,1,5,3,2,10000035,20000035,10000,8000,1,"-5,50","","","","","","",21033310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[44] = new Cfg_t_card_group_s_Info(45,33410,"0",20033410,0,0,3,1,4,4,2,10000051,20000051,10000,8000,0,"-5,50","","","","","","",21033410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[45] = new Cfg_t_card_group_s_Info(46,33510,"0",20033510,0,0,2,1,3,5,2,10000065,20000065,10000,8000,0,"-5,50","","","","","","",21033510,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[46] = new Cfg_t_card_group_s_Info(47,34210,"0",20034210,1,0,4,1,5,1,3,10000006,20000006,10000,8000,1,"-5,50","","","","","","",21034210,"0,-1.1,11.5","1,1,1","0.02,-0.15,0","Hero/Spine/mengmaxiangqibing/mengmaxiangqibing_SkeletonData",20111),
	[47] = new Cfg_t_card_group_s_Info(48,34310,"0",20034310,0,0,3,1,4,3,3,10000036,20000036,10000,8000,0,"-5,50","","","","","","",21034310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[48] = new Cfg_t_card_group_s_Info(49,34410,"0",20034410,0,0,3,1,4,4,3,10000052,20000052,10000,8000,0,"-5,50","","","","","","",21034410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[49] = new Cfg_t_card_group_s_Info(50,34510,"0",20034510,0,0,4,1,5,5,3,10000066,20000066,10000,8000,1,"-5,50","","","","","","",21034510,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[50] = new Cfg_t_card_group_s_Info(51,35210,"0",20035210,1,0,3,1,4,1,4,10000003,20000003,8000,8000,0,"-5,50","","","","","","",21035210,"0,-1.06,10.47","1.46,1.46,1.46","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[51] = new Cfg_t_card_group_s_Info(52,35310,"0",20035310,0,0,3,1,4,3,4,10000037,20000037,10000,8000,0,"-5,50","","","","","","",21035310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[52] = new Cfg_t_card_group_s_Info(53,35410,"0",20035410,0,0,2,1,3,4,4,10000053,20000053,10000,8000,0,"-5,50","","","","","","",21035410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[53] = new Cfg_t_card_group_s_Info(54,35510,"0",20035510,0,0,4,1,5,5,4,10000067,20000067,10000,8000,1,"-5,50","","","","","","",21035510,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[54] = new Cfg_t_card_group_s_Info(55,36210,"0",20036210,1,0,2,1,3,1,5,10000007,20000007,6000,8000,0,"-5,50","","","","","","",21036210,"0,-1.1,12","1,1,1","0.02,-0.12,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[55] = new Cfg_t_card_group_s_Info(56,36310,"0",20036310,0,0,2,1,3,3,5,10000038,20000038,10000,8000,0,"-5,50","","","","","","",21036310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[56] = new Cfg_t_card_group_s_Info(57,36410,"0",20036410,0,0,3,1,4,4,5,10000054,20000054,10000,8000,0,"-5,50","","","","","","",21036410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[57] = new Cfg_t_card_group_s_Info(58,36510,"0",20036510,0,0,4,1,5,5,5,10000068,20000068,10000,8000,1,"-5,50","","","","","","",21036510,"0,-1.1,10.14","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[58] = new Cfg_t_card_group_s_Info(59,47210,"0",20047210,1,1,1,1,2,1,7,10000013,20000013,6000,8000,0,"-5,50","","","","","","",21047210,"0,-1.1,8.8","1.2,1.2,1.2","0.01,-0.15,0","Hero/Spine/yongshixiaowu/skeleton_SkeletonData",20111),
	[59] = new Cfg_t_card_group_s_Info(60,47220,"0",20047220,0,1,1,1,2,2,7,10000023,20000023,10000,8000,0,"-5,50","","","","","","",21047220,"0,-1.1,6.9","1.56,1.56,1.56","0,0,0","Hero/Spine/changgongshouyingdi/skeleton_SkeletonData",20111),
	[60] = new Cfg_t_card_group_s_Info(61,47230,"0",20047230,1,1,2,1,3,1,7,10000004,20000004,10000,8000,0,"-5,50","","","","","","",21047230,"0,-1.1,10","1.5,1.5,1.5","0.02,-0.18,0","Hero/Spine/juma/skeleton_SkeletonData",20111),
	[61] = new Cfg_t_card_group_s_Info(62,47240,"0",20047240,0,1,1,1,2,2,7,10000024,20000024,10000,8000,0,"-5,50","","","","","","",21047240,"0,-1.1,6.9","1.3,1.3,1.3","0,0,0","Hero/Spine/gongjianta/skeleton_SkeletonData",20111),
	[62] = new Cfg_t_card_group_s_Info(63,47250,"0",20047250,0,1,2,1,3,2,7,10000025,20000025,10000,8000,0,"-5,50","","","","","","",21047250,"0,-1.1,6.9","1.3,1.3,1.3","0,0,0","Hero/Spine/luoshita/skeleton_SkeletonData",20111),
	[63] = new Cfg_t_card_group_s_Info(64,47310,"0",20047310,0,1,2,1,3,3,7,10000039,20000039,10000,8000,0,"-5,50","","","","","","",21047310,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[64] = new Cfg_t_card_group_s_Info(65,47320,"0",20047320,0,1,3,1,4,3,7,10000040,20000040,10000,8000,0,"-5,50","","","","","","",21047320,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[65] = new Cfg_t_card_group_s_Info(66,47330,"0",20047330,0,1,3,1,4,3,7,10000041,20000041,10000,8000,0,"-5,50","","","","","","",21047330,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[66] = new Cfg_t_card_group_s_Info(67,47410,"0",20047410,0,1,3,1,4,4,7,10000055,20000055,10000,8000,0,"-5,50","","","","","","",21047410,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[67] = new Cfg_t_card_group_s_Info(68,47420,"0",20047420,0,1,2,1,3,4,7,10000056,20000056,10000,8000,0,"-5,50","","","","","","",21047420,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[68] = new Cfg_t_card_group_s_Info(69,47510,"0",20047510,0,1,3,1,4,5,7,10000069,20000069,10000,8000,0,"-5,50","","","","","","",21047510,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[69] = new Cfg_t_card_group_s_Info(70,47520,"0",20047520,0,1,2,1,3,5,7,10000070,20000070,10000,8000,0,"-5,50","","","","","","",21047520,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData",20111),
	[70] = new Cfg_t_card_group_s_Info(71,100001,"0",20100001,0,2,1,1,2,1,6,46000021,40000021,10000,8000,0,"-5,50","","","","","","",21100001,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[71] = new Cfg_t_card_group_s_Info(72,100002,"0",20100002,0,2,1,1,2,1,6,46000022,40000022,10000,8000,0,"-5,50","","","","","","",21100002,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[72] = new Cfg_t_card_group_s_Info(73,100003,"0",20100003,0,2,1,1,2,1,6,46000023,40000023,10000,8000,0,"-5,50","","","","","","",21100003,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[73] = new Cfg_t_card_group_s_Info(74,100004,"0",20100004,0,2,1,1,2,1,6,46000024,40000024,10000,8000,0,"-5,50","","","","","","",21100004,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[74] = new Cfg_t_card_group_s_Info(75,100005,"0",20100005,0,2,1,1,2,1,6,46000025,40000025,10000,8000,0,"-5,50","","","","","","",21100005,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[75] = new Cfg_t_card_group_s_Info(76,100006,"0",20100006,0,0,1,1,2,1,6,46000011,40000011,10000,8000,0,"-5,50","","","","","","",21100006,"0,-1.1,6.9","3.12,3.12,3.12","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[76] = new Cfg_t_card_group_s_Info(77,100007,"0",20100007,0,2,1,1,2,1,6,46000013,40000013,10000,8000,0,"-5,50","","","","","","",21100007,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[77] = new Cfg_t_card_group_s_Info(78,100008,"0",20100008,0,0,1,1,2,1,6,46000015,40000015,10000,8000,0,"-5,50","","","","","","",21100008,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[78] = new Cfg_t_card_group_s_Info(79,100009,"0",20100009,0,2,1,1,2,1,6,46000027,40000027,10000,8000,0,"-5,50","","","","","","",21100009,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[79] = new Cfg_t_card_group_s_Info(80,100010,"0",20100010,0,2,1,1,2,1,6,46000028,40000028,10000,8000,0,"-5,50","","","","","","",21100010,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[80] = new Cfg_t_card_group_s_Info(81,100011,"0",20100011,0,2,1,1,2,1,6,46000029,40000029,10000,8000,0,"-5,50","","","","","","",21100011,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[81] = new Cfg_t_card_group_s_Info(82,100012,"0",20100012,0,2,1,1,2,1,6,46000030,40000030,10000,8000,0,"-5,50","","","","","","",21100012,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
	[82] = new Cfg_t_card_group_s_Info(83,100013,"0",20100013,0,2,1,1,2,1,6,46000031,40000031,10000,8000,0,"-5,50","","","","","","",21100013,"0,-1.1,6.9","0.78,0.78,0.78","0,0,0","Hero/Spine/dianjifashu/skeleton_SkeletonData","Hero/Spine/dianjifashu/skeleton_SkeletonData"),
};
}
