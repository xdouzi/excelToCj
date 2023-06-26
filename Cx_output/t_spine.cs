using System.Collections.Generic;
public class Cfg_t_spine_Info
{
public int id;
public int c_base_spine_id;
public string c_base_prefab_path;
public string c_base_spine_path;
public Cfg_t_spine_Info(int id,int c_base_spine_id,string c_base_prefab_path,string c_base_spine_path)
{
  this.id = id;
  this.c_base_spine_id = c_base_spine_id;
  this.c_base_prefab_path = c_base_prefab_path;
  this.c_base_spine_path = c_base_spine_path;
}
}
public class Cfg_t_spine
{
public static List<Cfg_t_spine_Info> list = new List<Cfg_t_spine_Info>()
{
	[0] = new Cfg_t_spine_Info(1,1,"Role/RoleSpinePrefab/man/man_UISpine",""),
	[1] = new Cfg_t_spine_Info(2,2,"Role/RoleSpinePrefab/woman/woman_UISpine",""),
	[2] = new Cfg_t_spine_Info(3,3,"Role/RoleSpinePrefab/wanjianqifa/wanjianqifa_UISpine","Role/Spine/wanjianqifa/skeleton_SkeletonData"),
	[3] = new Cfg_t_spine_Info(4,4,"Role/RoleSpinePrefab/dianjifashu/dianjifashu_UISpine","Role/Spine/dianjifashu/skeleton_SkeletonData"),
	[4] = new Cfg_t_spine_Info(5,5,"Role/RoleSpinePrefab/duyaofashu/duyaofashu_UISpine","Role/Spine/duyaofashu/skeleton_SkeletonData"),
	[5] = new Cfg_t_spine_Info(6,6,"Role/RoleSpinePrefab/huoqiu/huoqiu_UISpine","Role/Spine/huoqiu/skeleton_SkeletonData"),
	[6] = new Cfg_t_spine_Info(7,7,"Role/RoleSpinePrefab/gunmu/gunmu_UISpine","Role/Spine/gunmu/skeleton_SkeletonData"),
	[7] = new Cfg_t_spine_Info(8,8,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[8] = new Cfg_t_spine_Info(9,9,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[9] = new Cfg_t_spine_Info(10,10,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[10] = new Cfg_t_spine_Info(11,11,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[11] = new Cfg_t_spine_Info(12,12,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[12] = new Cfg_t_spine_Info(13,13,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[13] = new Cfg_t_spine_Info(14,14,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[14] = new Cfg_t_spine_Info(15,15,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[15] = new Cfg_t_spine_Info(16,16,"Role/RoleSpinePrefab/linshiyeniuyongshi/yeniuyongshi_UISpine","Role/Spine/yeniuyongshi/yeniuyongshi2_SkeletonData"),
	[16] = new Cfg_t_spine_Info(17,17,"Role/RoleSpinePrefab/linshisongshutoushou/songshutoushou_UISpine","Role/Spine/songshutouishou/songshutouishou_SkeletonData"),
	[17] = new Cfg_t_spine_Info(18,18,"Role/RoleSpinePrefab/linshilangqibing/langqibing_UISpine","Role/Spine/langqibing/langqibing_SkeletonData"),
	[18] = new Cfg_t_spine_Info(19,19,"Role/RoleSpinePrefab/linshixiaojingling/xiaojingling_UISpine","Role/Spine/xiaojingling/xiaojingling_SkeletonData"),
	[19] = new Cfg_t_spine_Info(20,20,"Role/RoleSpinePrefab/linshiwuya/wuya_UISpine","Role/Spine/wuya/wuya_SkeletonData"),
	[20] = new Cfg_t_spine_Info(21,21,"Role/RoleSpinePrefab/linshiyeniujianshi/yeniujianshi_UISpine","Role/Spine/yeniujianshi/yeniujianshi_SkeletonData"),
	[21] = new Cfg_t_spine_Info(22,22,"Role/RoleSpinePrefab/linshichanggongshou/changgongshou_UISpine","Role/Spine/gongjianshou/linshichanggongshou3_SkeletonData"),
	[22] = new Cfg_t_spine_Info(23,23,"Role/RoleSpinePrefab/linshilangyouqibing/langyouqibing_UISpine","Role/Spine/langyouqibing/langyouqibing_SkeletonData"),
	[23] = new Cfg_t_spine_Info(24,24,"Role/RoleSpinePrefab/linshidujiaoshou/dujiaoshou_UISpine","Role/Spine/linshidujiaoshou1/linshidujiaoshou1_SkeletonData"),
	[24] = new Cfg_t_spine_Info(25,25,"Role/RoleSpinePrefab/linshishitourenzhanshi/shitourenzhanshi_UISpine","Role/Spine/shitourenzhanshi/shitouren_SkeletonData"),
	[25] = new Cfg_t_spine_Info(26,26,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[26] = new Cfg_t_spine_Info(27,27,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[27] = new Cfg_t_spine_Info(28,28,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[28] = new Cfg_t_spine_Info(29,29,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[29] = new Cfg_t_spine_Info(30,30,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[30] = new Cfg_t_spine_Info(31,31,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[31] = new Cfg_t_spine_Info(32,32,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[32] = new Cfg_t_spine_Info(33,33,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[33] = new Cfg_t_spine_Info(34,34,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[34] = new Cfg_t_spine_Info(35,35,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[35] = new Cfg_t_spine_Info(36,36,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[36] = new Cfg_t_spine_Info(37,37,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[37] = new Cfg_t_spine_Info(38,38,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[38] = new Cfg_t_spine_Info(39,39,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[39] = new Cfg_t_spine_Info(40,40,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[40] = new Cfg_t_spine_Info(41,41,"Role/RoleSpinePrefab/linshidishuwajuezhe/dishuwajuezhe_UISpine","Role/Spine/dishuwajuezhe/dishuwajuezhe_SkeletonData"),
	[41] = new Cfg_t_spine_Info(42,42,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[42] = new Cfg_t_spine_Info(43,43,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[43] = new Cfg_t_spine_Info(44,44,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[44] = new Cfg_t_spine_Info(45,45,"Role/RoleSpinePrefab/linshihaixiangfeifu/haixiangfeifu_UISpine","Role/Spine/haixiangfeifu/haixiangfeifu_SkeletonData"),
	[45] = new Cfg_t_spine_Info(46,46,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[46] = new Cfg_t_spine_Info(47,47,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[47] = new Cfg_t_spine_Info(48,48,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[48] = new Cfg_t_spine_Info(49,49,"Role/RoleSpinePrefab/linshimengmaxiangqibing/mengmaxiangqibing_UISpine","Role/Spine/mengmaxiangqibing/mengmaxiangqibing_SkeletonData"),
	[49] = new Cfg_t_spine_Info(50,50,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[50] = new Cfg_t_spine_Info(51,51,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[51] = new Cfg_t_spine_Info(52,52,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[52] = new Cfg_t_spine_Info(53,53,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[53] = new Cfg_t_spine_Info(54,54,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[54] = new Cfg_t_spine_Info(55,55,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[55] = new Cfg_t_spine_Info(56,56,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[56] = new Cfg_t_spine_Info(57,57,"Role/RoleSpinePrefab/linshimoxiang/moxiang_UISpine","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[57] = new Cfg_t_spine_Info(58,58,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[58] = new Cfg_t_spine_Info(59,59,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[59] = new Cfg_t_spine_Info(60,60,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[60] = new Cfg_t_spine_Info(61,61,"Role/RoleSpinePrefab/yongshixiaowu/yongshixiaowu_UISpine","Role/Spine/yongshixiaowu/skeleton_SkeletonData"),
	[61] = new Cfg_t_spine_Info(62,62,"Role/RoleSpinePrefab/changgongshouyingdi/changgongshouyingdi_UISpine","Role/Spine/changgongshouyingdi/skeleton_SkeletonData"),
	[62] = new Cfg_t_spine_Info(63,63,"Role/RoleSpinePrefab/juma/juma_UISpine","Role/Spine/juma/skeleton_SkeletonData"),
	[63] = new Cfg_t_spine_Info(64,64,"Role/RoleSpinePrefab/gongjianta/gongjianta_UISpine","Role/Spine/gongjianta/skeleton_SkeletonData"),
	[64] = new Cfg_t_spine_Info(65,65,"Role/RoleSpinePrefab/luoshita/luoshita_UISpine","Role/Spine/luoshita/skeleton_SkeletonData"),
	[65] = new Cfg_t_spine_Info(66,66,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[66] = new Cfg_t_spine_Info(67,67,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[67] = new Cfg_t_spine_Info(68,68,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[68] = new Cfg_t_spine_Info(69,69,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[69] = new Cfg_t_spine_Info(70,70,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[70] = new Cfg_t_spine_Info(71,71,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[71] = new Cfg_t_spine_Info(72,72,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
};
}
