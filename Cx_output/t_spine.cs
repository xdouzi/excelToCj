using System.Collections.Generic;
public class t_spineInfo
{
public int id;
public int c_base_spine_id;
public string c_base_prefab_path;
public string c_base_spine_path;
public t_spineInfo(int id,int c_base_spine_id,string c_base_prefab_path,string c_base_spine_path)
{
  this.id = id;
  this.c_base_spine_id = c_base_spine_id;
  this.c_base_prefab_path = c_base_prefab_path;
  this.c_base_spine_path = c_base_spine_path;
}
}
public class Cfg_t_spine
{
public static List<t_spineInfo> list = new List<t_spineInfo>()
{
	[0] = new t_spineInfo(1,1,"Role/RoleSpinePrefab/man/man_UISpine",""),
	[1] = new t_spineInfo(2,2,"Role/RoleSpinePrefab/woman/woman_UISpine",""),
	[2] = new t_spineInfo(3,3,"Role/RoleSpinePrefab/wanjianqifa/wanjianqifa_UISpine","Role/Spine/wanjianqifa/skeleton_SkeletonData"),
	[3] = new t_spineInfo(4,4,"Role/RoleSpinePrefab/dianjifashu/dianjifashu_UISpine","Role/Spine/dianjifashu/skeleton_SkeletonData"),
	[4] = new t_spineInfo(5,5,"Role/RoleSpinePrefab/duyaofashu/duyaofashu_UISpine","Role/Spine/duyaofashu/skeleton_SkeletonData"),
	[5] = new t_spineInfo(6,6,"Role/RoleSpinePrefab/huoqiu/huoqiu_UISpine","Role/Spine/huoqiu/skeleton_SkeletonData"),
	[6] = new t_spineInfo(7,7,"Role/RoleSpinePrefab/gunmu/gunmu_UISpine","Role/Spine/gunmu/skeleton_SkeletonData"),
	[7] = new t_spineInfo(8,8,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[8] = new t_spineInfo(9,9,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[9] = new t_spineInfo(10,10,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[10] = new t_spineInfo(11,11,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[11] = new t_spineInfo(12,12,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[12] = new t_spineInfo(13,13,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[13] = new t_spineInfo(14,14,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[14] = new t_spineInfo(15,15,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[15] = new t_spineInfo(16,16,"Role/RoleSpinePrefab/linshiyeniuyongshi/yeniuyongshi_UISpine","Role/Spine/yeniuyongshi/yeniuyongshi2_SkeletonData"),
	[16] = new t_spineInfo(17,17,"Role/RoleSpinePrefab/linshisongshutoushou/songshutoushou_UISpine","Role/Spine/songshutouishou/songshutouishou_SkeletonData"),
	[17] = new t_spineInfo(18,18,"Role/RoleSpinePrefab/linshilangqibing/langqibing_UISpine","Role/Spine/langqibing/langqibing_SkeletonData"),
	[18] = new t_spineInfo(19,19,"Role/RoleSpinePrefab/linshixiaojingling/xiaojingling_UISpine","Role/Spine/xiaojingling/xiaojingling_SkeletonData"),
	[19] = new t_spineInfo(20,20,"Role/RoleSpinePrefab/linshiwuya/wuya_UISpine","Role/Spine/wuya/wuya_SkeletonData"),
	[20] = new t_spineInfo(21,21,"Role/RoleSpinePrefab/linshiyeniujianshi/yeniujianshi_UISpine","Role/Spine/yeniujianshi/yeniujianshi_SkeletonData"),
	[21] = new t_spineInfo(22,22,"Role/RoleSpinePrefab/linshichanggongshou/changgongshou_UISpine","Role/Spine/gongjianshou/linshichanggongshou3_SkeletonData"),
	[22] = new t_spineInfo(23,23,"Role/RoleSpinePrefab/linshilangyouqibing/langyouqibing_UISpine","Role/Spine/langyouqibing/langyouqibing_SkeletonData"),
	[23] = new t_spineInfo(24,24,"Role/RoleSpinePrefab/linshidujiaoshou/dujiaoshou_UISpine","Role/Spine/linshidujiaoshou1/linshidujiaoshou1_SkeletonData"),
	[24] = new t_spineInfo(25,25,"Role/RoleSpinePrefab/linshishitourenzhanshi/shitourenzhanshi_UISpine","Role/Spine/shitourenzhanshi/shitouren_SkeletonData"),
	[25] = new t_spineInfo(26,26,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[26] = new t_spineInfo(27,27,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[27] = new t_spineInfo(28,28,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[28] = new t_spineInfo(29,29,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[29] = new t_spineInfo(30,30,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[30] = new t_spineInfo(31,31,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[31] = new t_spineInfo(32,32,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[32] = new t_spineInfo(33,33,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[33] = new t_spineInfo(34,34,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[34] = new t_spineInfo(35,35,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[35] = new t_spineInfo(36,36,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[36] = new t_spineInfo(37,37,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[37] = new t_spineInfo(38,38,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[38] = new t_spineInfo(39,39,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[39] = new t_spineInfo(40,40,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[40] = new t_spineInfo(41,41,"Role/RoleSpinePrefab/linshidishuwajuezhe/dishuwajuezhe_UISpine","Role/Spine/dishuwajuezhe/dishuwajuezhe_SkeletonData"),
	[41] = new t_spineInfo(42,42,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[42] = new t_spineInfo(43,43,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[43] = new t_spineInfo(44,44,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[44] = new t_spineInfo(45,45,"Role/RoleSpinePrefab/linshihaixiangfeifu/haixiangfeifu_UISpine","Role/Spine/haixiangfeifu/haixiangfeifu_SkeletonData"),
	[45] = new t_spineInfo(46,46,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[46] = new t_spineInfo(47,47,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[47] = new t_spineInfo(48,48,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[48] = new t_spineInfo(49,49,"Role/RoleSpinePrefab/linshimengmaxiangqibing/mengmaxiangqibing_UISpine","Role/Spine/mengmaxiangqibing/mengmaxiangqibing_SkeletonData"),
	[49] = new t_spineInfo(50,50,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[50] = new t_spineInfo(51,51,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[51] = new t_spineInfo(52,52,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[52] = new t_spineInfo(53,53,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[53] = new t_spineInfo(54,54,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[54] = new t_spineInfo(55,55,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[55] = new t_spineInfo(56,56,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[56] = new t_spineInfo(57,57,"Role/RoleSpinePrefab/linshimoxiang/moxiang_UISpine","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[57] = new t_spineInfo(58,58,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[58] = new t_spineInfo(59,59,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[59] = new t_spineInfo(60,60,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[60] = new t_spineInfo(61,61,"Role/RoleSpinePrefab/yongshixiaowu/yongshixiaowu_UISpine","Role/Spine/yongshixiaowu/skeleton_SkeletonData"),
	[61] = new t_spineInfo(62,62,"Role/RoleSpinePrefab/changgongshouyingdi/changgongshouyingdi_UISpine","Role/Spine/changgongshouyingdi/skeleton_SkeletonData"),
	[62] = new t_spineInfo(63,63,"Role/RoleSpinePrefab/juma/juma_UISpine","Role/Spine/juma/skeleton_SkeletonData"),
	[63] = new t_spineInfo(64,64,"Role/RoleSpinePrefab/gongjianta/gongjianta_UISpine","Role/Spine/gongjianta/skeleton_SkeletonData"),
	[64] = new t_spineInfo(65,65,"Role/RoleSpinePrefab/luoshita/luoshita_UISpine","Role/Spine/luoshita/skeleton_SkeletonData"),
	[65] = new t_spineInfo(66,66,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[66] = new t_spineInfo(67,67,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[67] = new t_spineInfo(68,68,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[68] = new t_spineInfo(69,69,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[69] = new t_spineInfo(70,70,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[70] = new t_spineInfo(71,71,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
	[71] = new t_spineInfo(72,72,"","Role/Spine/chuanshanjiazhanshi/chuanshanjiazhanshi_SkeletonData"),
};
}
