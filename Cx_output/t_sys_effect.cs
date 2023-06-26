using System.Collections.Generic;
public class t_sys_effectInfo
{
public int id;
public int c_base_effects_id;
public string c_e_name;
public int a_base_prefab_id;
public string c_base_effect_res;
public int c_base_effects_time;
public string c_base_effects_node;
public int c_base_delay;
public int c_base_sound_delay;
public int c_base_saund_id;
public string c_float_scale_size;
public int c_base_effect_height;
public t_sys_effectInfo(int id,int c_base_effects_id,string c_e_name,int a_base_prefab_id,string c_base_effect_res,int c_base_effects_time,string c_base_effects_node,int c_base_delay,int c_base_sound_delay,int c_base_saund_id,string c_float_scale_size,int c_base_effect_height)
{
  this.id = id;
  this.c_base_effects_id = c_base_effects_id;
  this.c_e_name = c_e_name;
  this.a_base_prefab_id = a_base_prefab_id;
  this.c_base_effect_res = c_base_effect_res;
  this.c_base_effects_time = c_base_effects_time;
  this.c_base_effects_node = c_base_effects_node;
  this.c_base_delay = c_base_delay;
  this.c_base_sound_delay = c_base_sound_delay;
  this.c_base_saund_id = c_base_saund_id;
  this.c_float_scale_size = c_float_scale_size;
  this.c_base_effect_height = c_base_effect_height;
}
}
public class Cfg_t_sys_effect
{
public static List<t_sys_effectInfo> list = new List<t_sys_effectInfo>()
{
	[0] = new t_sys_effectInfo(1,1,"1",1000001,"Effect/Skill_Eff/Prefab/Eff_Skill_ArcherPutten.prefab",5000,"",,,20102,"",),
	[1] = new t_sys_effectInfo(2,2,"2",1000002,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet.prefab",5000,"",,,,"",),
	[2] = new t_sys_effectInfo(3,3,"3",1000003,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet.prefab",5000,"",,,,"",),
	[3] = new t_sys_effectInfo(4,4,"4",1000004,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet.prefab",5000,"",,,,"",),
	[4] = new t_sys_effectInfo(5,5,"5",1000005,"Effect/Skill_Eff/Prefab/Eff_Skill_WerwolfRoar.prefab",750,"",,,,"",),
	[5] = new t_sys_effectInfo(6,6,"6",1000006,"Effect/Scene_Eff/Prefab/Eff_Scene_10200_Arrow_Hit.prefab",5000,"",,,,"",),
	[6] = new t_sys_effectInfo(7,7,"7",1000007,"Effect/Scene_Eff/Prefab/Eff_Scene_10200_Arrow_Bullet.prefab",5000,"",,,,"",),
	[7] = new t_sys_effectInfo(8,8,"8",1000008,"Effect/Scene_Eff/Prefab/Eff_Scene_10201_Lightning.prefab",3000,"",,,20101,"",),
	[8] = new t_sys_effectInfo(9,9,"9",1000009,"Effect/Scene_Eff/Prefab/Eff_Scene_10203_FireBall_Bullet.prefab",5000,"",,,20103,"",),
	[9] = new t_sys_effectInfo(10,10,"10",1000010,"Effect/Scene_Eff/Prefab/Eff_Scene_10203_FireBall_Hit.prefab",5000,"",,,20104,"",),
	[10] = new t_sys_effectInfo(11,11,"11",1000011,"Effect/Scene_Eff/Prefab/Eff_Scene_10204_Wood_Root.prefab",5000,"",,,,"",),
	[11] = new t_sys_effectInfo(12,12,"12",1000012,"Effect/Scene_Eff/Prefab/Eff_Scene_10204_Wood_Hit.prefab",5000,"",,,,"",),
	[12] = new t_sys_effectInfo(13,17,"17",1000017,"Effect/Skill_Eff/Prefab/Eff_Skill_Boss_1004.prefab",5000,"",,,,"",),
	[13] = new t_sys_effectInfo(14,18,"18",1000018,"Effect/Scene_Eff/Prefab/Eff_Scene_47250_RockFallTower_Hit.prefab",5000,"",,,,"",),
	[14] = new t_sys_effectInfo(15,19,"19",1000019,"Effect/Scene_Eff/Prefab/Eff_Scene_32210_Diglett_Root.prefab",0,"",,,,"",),
	[15] = new t_sys_effectInfo(16,20,"20",1000020,"Effect/Scene_Eff/Prefab/Eff_Scene_32210_Diglett_Hit.prefab",5000,"",,,,"",),
	[16] = new t_sys_effectInfo(17,21,"21",1000021,"Effect/Scene_Eff/Prefab/Eff_Scene_33210_Axe.prefab",3000,"",,,,"",),
	[17] = new t_sys_effectInfo(18,22,"22",1000022,"Effect/Scene_Eff/Prefab/Eff_Scene_34210_Mammoth_Wind.prefab",3000,"",,,,"",),
	[18] = new t_sys_effectInfo(19,23,"23",1000023,"Effect/Scene_Eff/Prefab/Eff_Scene_34210_Mammoth_Attack.prefab",10000,"",,,,"",),
	[19] = new t_sys_effectInfo(20,24,"24",1000024,"Effect/Scene_Eff/Prefab/Eff_Scene_10202_Gas.prefab",10000,"",,,,"",),
	[20] = new t_sys_effectInfo(21,25,"25",1000025,"Effect/Scene_Eff/Prefab/Eff_10200_Indicator_Gunmu.prefab",4000,"","","","","",""),
	[21] = new t_sys_effectInfo(22,26,"26",1000026,"Effect/Scene_Eff/Prefab/Effe_Scene_Dragon_Skilll.prefab",8000,"","","","","",""),
	[22] = new t_sys_effectInfo(23,27,"27",1000027,"Effect/Scene_Eff/Prefab/Eff_Red_Cube.prefab",0,"","","","","",""),
	[23] = new t_sys_effectInfo(24,28,"28",1000028,"Effect/Scene_Eff/Prefab/Eff_LightningChain.prefab",0,"","","","","",""),
	[24] = new t_sys_effectInfo(25,101,"101",1000101,"Effect/Scene_Eff/Prefab/Eff_10200_Indicator.prefab",3000,"",,,,"",),
	[25] = new t_sys_effectInfo(26,102,"102",1000102,"Effect/Scene_Eff/Prefab/Eff_10200_Indicator_Gunmu.prefab",3000,"",,,,"",),
	[26] = new t_sys_effectInfo(27,103,"103",1000103,"Effect/Scene_Eff/Prefab/Eff_10200_Indicator_Square.prefab","Effect/Scene_Eff/Prefab/Eff_10200_Indicator_Square.prefab","","","","","",""),
	[27] = new t_sys_effectInfo(28,201,"201",1000201,"Effect/Skill_Eff/Prefab/Eff_skill_leidianzhaohuan.prefab",10000,"","","","","",""),
	[28] = new t_sys_effectInfo(29,202,"202",1000202,"Effect/Skill_Eff/Prefab/Eff_skill_tiantangzhimen.prefab",10000,"","","","","",""),
	[29] = new t_sys_effectInfo(30,203,"203",1000203,"Effect/Skill_Eff/Prefab/Eff_skill_shengguangpuzhao_01.prefab",10000,"","","","","",""),
	[30] = new t_sys_effectInfo(31,204,"204",1000204,"Effect/Skill_Eff/Prefab/Eff_skill_shengguangpuzhao_02.prefab",10000,"","","","","",""),
	[31] = new t_sys_effectInfo(32,205,"205",1000205,"Effect/Skill_Eff/Prefab/Eff_skill_yunshishu.prefab",10000,"","","","","",""),
	[32] = new t_sys_effectInfo(33,207,"207",1000207,"Effect/Skill_Eff/Prefab/Eff_skill_diyuzhimen.prefab",10000,"","","","","",""),
	[33] = new t_sys_effectInfo(34,208,"208",1000208,"Effect/Skill_Eff/Prefab/Eff_skill_diyuhuo.prefab",10000,"","","","","",""),
	[34] = new t_sys_effectInfo(35,210,"210",1000210,"Effect/Skill_Eff/Prefab/Eff_skill_huoyanzhiyu.prefab",10000,"","","","","",""),
	[35] = new t_sys_effectInfo(36,401,"401",1000401,"Effect/Skill_Eff/Prefab/Eff_tafang_gongjianta/Eff_Skill_gongjianta_01_bullet.prefab",10000,"","","","","",""),
	[36] = new t_sys_effectInfo(37,402,"402",1000402,"Effect/Skill_Eff/Prefab/Eff_tafang_gongjianta/Eff_Skill_gongjianta_01_bullet.prefab",10000,"","","","","",""),
	[37] = new t_sys_effectInfo(38,403,"403",1000403,"Effect/Skill_Eff/Prefab/Eff_tafang_gongjianta/Eff_Skill_gongjianta_01_bullet.prefab",10000,"","","","","",""),
	[38] = new t_sys_effectInfo(39,404,"404",1000404,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_bullet.prefab",10000,"","","","","",""),
	[39] = new t_sys_effectInfo(40,405,"405",1000405,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_hit.prefab",10000,"",,,20104,"",""),
	[40] = new t_sys_effectInfo(41,406,"406",1000406,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_bullet.prefab",10000,"","","","","",""),
	[41] = new t_sys_effectInfo(42,407,"407",1000407,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_hit.prefab",10000,"","","","","",""),
	[42] = new t_sys_effectInfo(43,408,"408",1000408,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_bullet.prefab",10000,"","","","","",""),
	[43] = new t_sys_effectInfo(44,409,"409",1000409,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_hit.prefab",10000,"","","","","",""),
	[44] = new t_sys_effectInfo(45,410,"410",1000410,"Effect/Skill_Eff/Prefab/Eff_Skill_boom.prefab",10000,"","","","","",""),
	[45] = new t_sys_effectInfo(46,411,"411",1000411,"Effect/Skill_Eff/Prefab/Eff_tafang_hanbingta/Eff_Skill_hanbingta_bullet.prefab",10000,"",,,20204,"",""),
	[46] = new t_sys_effectInfo(47,412,"412",1000412,"Effect/Skill_Eff/Prefab/Eff_tafang_hanbingta/Eff_Skill_hanbingta_bullet.prefab",10000,"","","","","",""),
	[47] = new t_sys_effectInfo(48,413,"413",1000413,"Effect/Skill_Eff/Prefab/Eff_tafang_hanbingta/Eff_Skill_hanbingta_01_hit.prefab",10000,"","","","","",""),
	[48] = new t_sys_effectInfo(49,414,"414",1000414,"Effect/Skill_Eff/Prefab/Eff_tafang_hanbingta/Eff_Skill_hanbingta_bullet.prefab",10000,"","","","","",""),
	[49] = new t_sys_effectInfo(50,415,"415",1000415,"Effect/Skill_Eff/Prefab/Eff_Skill_ice_burst.prefab",10000,"","","","","",""),
	[50] = new t_sys_effectInfo(51,416,"416",1000416,"Effect/Skill_Eff/Prefab/Eff_tafang_shurenta/Eff_Skill_shurenta_01_bullet.prefab",10000,"",,,20203,"",""),
	[51] = new t_sys_effectInfo(52,417,"417",1000417,"Effect/Skill_Eff/Prefab/Eff_tafang_shurenta/Eff_Skill_shurenta_01_bullet.prefab",10000,"","","","","",""),
	[52] = new t_sys_effectInfo(53,418,"418",1000418,"Effect/Skill_Eff/Prefab/Eff_tafang_guangzhita/Eff_Skill_guangzhita_01_bullet.prefab",0,"","","","","",""),
	[53] = new t_sys_effectInfo(54,419,"419",1000419,"Effect/Skill_Eff/Prefab/Eff_tafang_guangzhita/Eff_Skill_guangzhita_01_hit.prefab",100,"","","","","",""),
	[54] = new t_sys_effectInfo(55,420,"420",1000420,"Effect/Skill_Eff/Prefab/Eff_Skill_self_explode.prefab",10000,"","","","","",""),
	[55] = new t_sys_effectInfo(56,421,"421",1000421,"Effect/Skill_Eff/Prefab/Eff_Skill_bubing_02.prefab",10000,"","","","","",""),
	[56] = new t_sys_effectInfo(57,422,"422",1000422,"Effect/Skill_Eff/Prefab/Eff_Skill_qibing_01.prefab",10000,"",,,20201,"",""),
	[57] = new t_sys_effectInfo(58,423,"423",1000423,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_bullet.prefab",10000,"","","","","",""),
	[58] = new t_sys_effectInfo(59,424,"424",1000424,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_hit.prefab",10000,"","","","","",""),
	[59] = new t_sys_effectInfo(60,425,"425",1000425,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_bullet.prefab",10000,"","","","","",""),
	[60] = new t_sys_effectInfo(61,426,"426",1000426,"Effect/Skill_Eff/Prefab/Eff_Skill_mobing_01.prefab",10000,"","","","","",""),
	[61] = new t_sys_effectInfo(62,427,"427",1000427,"Effect/Skill_Eff/Prefab/Eff_Skill_mobing_01_2.prefab",10000,"","","","","",""),
	[62] = new t_sys_effectInfo(63,428,"428",1000428,"Effect/Skill_Eff/Prefab/Eff_Skill_shenbing_01.prefab",10000,"",,,20204,"",""),
	[63] = new t_sys_effectInfo(64,429,"429",1000429,"Effect/Skill_Eff/Prefab/Eff_Skill_shenbing_02.prefab",10000,"","","","","",""),
	[64] = new t_sys_effectInfo(65,430,"430",1000430,"Effect/Skill_Eff/Prefab/Eff_Skill_shenbing_02_fumes.prefab",10000,"","","","","",""),
	[65] = new t_sys_effectInfo(66,431,"431",1000431,"Effect/Skill_Eff/Prefab/Eff_Skill_mark.prefab",10000,"","","","","",""),
	[66] = new t_sys_effectInfo(67,432,"432",1000432,"Effect/Skill_Eff/Prefab/Eff_Skill_poisoning.prefab",10000,"","","","","",""),
	[67] = new t_sys_effectInfo(68,433,"433",1000433,"Effect/Skill_Eff/Prefab/Eff_Skill_vertigo.prefab",10000,"","","","","",""),
	[68] = new t_sys_effectInfo(69,434,"434",1000434,"Effect/Skill_Eff/Prefab/Eff_tafang_gongjianta/Eff_Skill_gongjianta_01_hit.prefab",10000,"","","","","",""),
	[69] = new t_sys_effectInfo(70,435,"435",1000435,"Effect/Skill_Eff/Prefab/Eff_tafang_guangzhita/Eff_Skill_guangzhita_01_xuli.prefab",0,"","","","","",""),
	[70] = new t_sys_effectInfo(71,436,"436",1000436,"Effect/Skill_Eff/Prefab/Eff_tafang_zhadanta/Eff_Skill_zhadanta_01_xuli.prefab",500,"","","","","",""),
	[71] = new t_sys_effectInfo(72,437,"437",1000437,"Effect/Skill_Eff/Prefab/Eff_tafang_shurenta/Eff_Skill_shurenta_01_xuli.prefab",500,"","","","","",""),
	[72] = new t_sys_effectInfo(73,438,"438",1000438,"Effect/Skill_Eff/Prefab/Eff_tafang_shurenta/Eff_Skill_shurenta_01_hit.prefab",500,"","","","","",""),
	[73] = new t_sys_effectInfo(74,439,"439",1000439,"Effect/Skill_Eff/Prefab/Eff_tafang_hanbingta/Eff_Skill_hanbingta_01_hit.prefab",500,"","","","","",""),
	[74] = new t_sys_effectInfo(75,440,"440",1000440,"Effect/Skill_Eff/Prefab/Eff_tafang_hanbingta/Eff_Skill_hanbingta_01_xuli.prefab",500,"","","","","",""),
	[75] = new t_sys_effectInfo(76,601,"601",1000601,"Effect/Skill_Eff/Prefab/Eff_Skill_magic_Blue.prefab",10000,"","","","","",""),
	[76] = new t_sys_effectInfo(77,602,"602",1000602,"Effect/Skill_Eff/Prefab/Eff_Skill_magic_green.prefab",10000,"",,,20114,"",""),
	[77] = new t_sys_effectInfo(78,603,"603",1000604,"Effect/Skill_Eff/Prefab/Eff_Skill_magic_yellow.prefab",10000,"",,,20112,"",""),
	[78] = new t_sys_effectInfo(79,604,"604",1002010,"Effect/Scene_Eff/Prefab/Eff_Scene_34210_Mammoth_Wind.prefab",0,"","","","","",""),
	[79] = new t_sys_effectInfo(80,605,"605",1000603,"Effect/Skill_Eff/Prefab/Eff_Skill_magic_purple.prefab",0,"","","","","",""),
	[80] = new t_sys_effectInfo(81,606,"606",1000605,"Effect/Skill_Eff/Prefab/Eff_Skill_magic_red/Eff_Skill_magic_red_Bip001_Head.prefab",0,"","","","","",""),
	[81] = new t_sys_effectInfo(82,607,"607",1000606,"Effect/Skill_Eff/Prefab/Eff_Skill_magic_Blue/Eff_Skill_magic_hit.prefab",0,"","","","","",""),
	[82] = new t_sys_effectInfo(83,2004,"2004",1004003,"Effect/Scene_Eff/Prefab/Eff_Battle1011_Disapeare.prefab",500,"",,,50001,"",""),
	[83] = new t_sys_effectInfo(84,23101,"23101",1003220,"Effect/Scene_Eff/Prefab/Eff_Battle1011_Energy.prefab",,"",,,,"",10000),
	[84] = new t_sys_effectInfo(85,25001,"25001",1005001,"Effect/UI_Eff/Prefab/Eff_UI_Quan_XunHuan.prefab",500,"","","","","",""),
	[85] = new t_sys_effectInfo(86,25002,"25002",1005002,"Effect/UI_Eff/Prefab/Eff_UI_StepEmpty.prefab",500,"","","","","",""),
	[86] = new t_sys_effectInfo(87,25003,"25003",1005003,"Scenes/CardBattle/Common/Prefab/empty.prefab",500,"","","","","",""),
	[87] = new t_sys_effectInfo(88,25004,"25004",1005004,"Effect/UI_Eff/Prefab/Eff_UI_EnergyStep1.prefab",500,"","","","","",""),
	[88] = new t_sys_effectInfo(89,25005,"25005",1005005,"Effect/UI_Eff/Prefab/Eff_UI_EnergyStep2.prefab",500,"","","","","",""),
	[89] = new t_sys_effectInfo(90,25006,"25006",1005006,"Effect/UI_Eff/Prefab/Eff_UI_EnergyStep3.prefab",500,"","","","","",""),
	[90] = new t_sys_effectInfo(91,25101,"25101",1006001,"Effect/UI_Eff/Prefab/Eff_UI_EnergyIncrease.prefab",10000,"","","","","",""),
	[91] = new t_sys_effectInfo(92,30001,"30001",80001,"Effect/Scene_Eff/Prefab/Eff_ji_show_oneself.prefab",10000,"","","","","",""),
	[92] = new t_sys_effectInfo(93,30002,"30002",80002,"Effect/Scene_Eff/Prefab/Eff_ji_show_rest01.prefab",10000,"","","","","",""),
	[93] = new t_sys_effectInfo(94,30003,"30003",1020001,"Effect/Scene_Eff/Prefab/Eff_Scene_SA_card_beijing/Eff_Scene_SA_card_Cardbeijing2.prefab",10000,"","","","","",""),
	[94] = new t_sys_effectInfo(95,100001,"100001",1001001,"Effect/Scene_Eff/Prefab/Eff_elminate_movetril.prefab",0,"",,,20001,"",""),
	[95] = new t_sys_effectInfo(96,100002,"100002",1001001,"Effect/Scene_Eff/Prefab/Eff_elminate_movetril.prefab",0,"",,,20001,"",""),
	[96] = new t_sys_effectInfo(97,110001,"110001",1001101,"Effect/Scene_Eff/Prefab/Eff_elminate_gow_blue.prefab",10000,"",,,20001,"",""),
	[97] = new t_sys_effectInfo(98,110002,"110002",1001102,"Effect/Scene_Eff/Prefab/Eff_elminate_gow_green.prefab",10000,"",,,20001,"",0),
	[98] = new t_sys_effectInfo(99,110003,"110003",1001103,"Effect/Scene_Eff/Prefab/Eff_elminate_gow_red.prefab",10000,"",,,20001,"",0),
	[99] = new t_sys_effectInfo(100,110004,"110004",1001104,"Effect/Scene_Eff/Prefab/Eff_elminate_gow_gold.prefab",10000,"",,,20001,"",0),
	[100] = new t_sys_effectInfo(101,110005,"110005",1001105,"Effect/Scene_Eff/Prefab/Eff_elminate_gow_purple.prefab",10000,"",,,20001,"",0),
	[101] = new t_sys_effectInfo(102,110006,"110006",1003301,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_lan_bullet.prefab",500,"","","","","",""),
	[102] = new t_sys_effectInfo(103,110007,"110007",1003302,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_lv_bullet.prefab",500,"","","","","",""),
	[103] = new t_sys_effectInfo(104,110008,"110008",1003303,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_hong_bullet.prefab",500,"","","","","",""),
	[104] = new t_sys_effectInfo(105,110009,"110009",1003304,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_jin_bullet.prefab",500,"","","","","",""),
	[105] = new t_sys_effectInfo(106,110010,"110010",1003305,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_zi_bullet.prefab",500,"","","","","",""),
	[106] = new t_sys_effectInfo(107,110101,"110101",1003401,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_lan_xuli.prefab",500,"","","","","",""),
	[107] = new t_sys_effectInfo(108,110102,"110102",1003402,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_lv_xuli.prefab",500,"","","","","",""),
	[108] = new t_sys_effectInfo(109,110103,"110103",1003403,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_hong_xuli.prefab",500,"","","","","",""),
	[109] = new t_sys_effectInfo(110,110104,"110104",1003404,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_jin_xuli.prefab",500,"","","","","",""),
	[110] = new t_sys_effectInfo(111,110105,"110105",1003405,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_zi_xuli.prefab",500,"","","","","",""),
	[111] = new t_sys_effectInfo(112,110201,"110201",1003501,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_lan_baozha.prefab",500,"","","","","",""),
	[112] = new t_sys_effectInfo(113,110202,"110202",1003502,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_lv_baozha.prefab",500,"","","","","",""),
	[113] = new t_sys_effectInfo(114,110203,"110203",1003503,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_hong_baozha.prefab",500,"","","","","",""),
	[114] = new t_sys_effectInfo(115,110204,"110204",1003504,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_jin_baozha.prefab",500,"","","","","",""),
	[115] = new t_sys_effectInfo(116,110205,"110205",1003505,"Effect/Scene_Eff/Prefab/Eff_elminate_SQ_xiaofeiji/Eff_elminate_SQ_xiaofeiji_zi_baozha.prefab",500,"","","","","",""),
	[116] = new t_sys_effectInfo(117,120001,"120001",1002001,"",,"",,,20001,"",0),
	[117] = new t_sys_effectInfo(118,120002,"120002",1002002,"","","","","","","",""),
	[118] = new t_sys_effectInfo(119,120003,"120003",1002003,"Effect/Scene_Eff/Prefab/Eff_elminate_circularsynthesis.prefab",5000,"",,,20117,"",""),
	[119] = new t_sys_effectInfo(120,120004,"120004",1002004,"Effect/Scene_Eff/Prefab/Eff_elminate_rectanglesynthesis.prefab",5000,"",,,20117,"",""),
	[120] = new t_sys_effectInfo(121,120005,"120005",1002005,"Effect/Scene_Eff/Prefab/Eff_elminate_rectanglesynthesis_y.prefab",5000,"","","","","",""),
	[121] = new t_sys_effectInfo(122,120006,"120006",1002006,"Effect/Scene_Eff/Prefab/Eff_elminate_chess_choosen.prefab",0,"","","","","",""),
	[122] = new t_sys_effectInfo(123,120007,"120007",1002007,"","","","","","","",""),
	[123] = new t_sys_effectInfo(124,120008,"120008",1002008,"Effect/Scene_Eff/Prefab/Eff_elminate_jihuopaidui.prefab",0,"","","","","",""),
	[124] = new t_sys_effectInfo(125,130001,"130001",1002101,"Effect/Scene_Eff/Prefab/Eff_elminate_guangzhu_blue.prefab",10000,"",,,20001,"",""),
	[125] = new t_sys_effectInfo(126,130002,"130002",1002102,"Effect/Scene_Eff/Prefab/Eff_elminate_guangzhu_green.prefab",10000,"",,,20001,"",""),
	[126] = new t_sys_effectInfo(127,130003,"130003",1002103,"Effect/Scene_Eff/Prefab/Eff_elminate_guangzhu_red.prefab",10000,"",,,20001,"",""),
	[127] = new t_sys_effectInfo(128,130004,"130004",1002104,"Effect/Scene_Eff/Prefab/Eff_elminate_guangzhu_gold.prefab",10000,"",,,20001,"",""),
	[128] = new t_sys_effectInfo(129,130005,"130005",1002105,"Effect/Scene_Eff/Prefab/Eff_elminate_guangzhu_purple.prefab",10000,"",,,20001,"",""),
	[129] = new t_sys_effectInfo(130,140001,"140001",1003101,"Effect/Scene_Eff/Prefab/Eff_elminate_juese_blue.prefab",10000,"","","","","",""),
	[130] = new t_sys_effectInfo(131,140002,"140002",1003102,"Effect/Scene_Eff/Prefab/Eff_elminate_juese_green.prefab",10000,"","","","","",""),
	[131] = new t_sys_effectInfo(132,140003,"140003",1003103,"Effect/Scene_Eff/Prefab/Eff_elminate_juese_red.prefab",10000,"","","","","",""),
	[132] = new t_sys_effectInfo(133,140004,"140004",1003104,"Effect/Scene_Eff/Prefab/Eff_elminate_juese_gold.prefab",10000,"","","","","",""),
	[133] = new t_sys_effectInfo(134,140005,"140005",1003105,"Effect/Scene_Eff/Prefab/Eff_elminate_juese_purple.prefab",10000,"","","","","",""),
	[134] = new t_sys_effectInfo(135,150001,"150001",1003201,"Effect/Scene_Eff/Prefab/Eff_elminate_qipan_gow_XunHuan.prefab",10000,"","","","","",""),
	[135] = new t_sys_effectInfo(136,150002,"150002",1003202,"Effect/Scene_Eff/Prefab/Eff_elminate_nuchexuli.prefab",10000,"","","","","",""),
	[136] = new t_sys_effectInfo(137,150003,"150003",1003203,"","","","","","","",""),
	[137] = new t_sys_effectInfo(138,150004,"150004",1003204,"","","","","","","",""),
	[138] = new t_sys_effectInfo(139,150005,"150005",1003205,"Effect/Scene_Eff/Prefab/Eff_elminate_shuijingactive.prefab",10000,"","","","","",""),
	[139] = new t_sys_effectInfo(140,150006,"150006",1003206,"Effect/Scene_Eff/Prefab/Eff_elminate_teshuqizi_bullet.prefab","Effect/Scene_Eff/Prefab/Eff_elminate_teshuqizi_bullet.prefab","","","","","",""),
	[140] = new t_sys_effectInfo(141,150007,"150007",1003207,"Effect/Scene_Eff/Prefab/Eff_elminate_strightline.prefab",10000,"","","","","",""),
	[141] = new t_sys_effectInfo(142,150008,"150008",1003208,"Effect/Scene_Eff/Prefab/Eff_elminate_shizibaozha.prefab",10000,"","","","","",""),
	[142] = new t_sys_effectInfo(143,150009,"150009",1003209,"Effect/Scene_Eff/Prefab/Eff_elminate_zhadanbaozha.prefab",10000,"","","","","",""),
	[143] = new t_sys_effectInfo(144,150010,"150010",1003210,"","","","","","","",""),
	[144] = new t_sys_effectInfo(145,150011,"150011",1003211,"","","","","","","",""),
	[145] = new t_sys_effectInfo(146,150012,"150012",1003212,"","","","","","","",""),
	[146] = new t_sys_effectInfo(147,150013,"150013",1003213,"","","","","","","",""),
	[147] = new t_sys_effectInfo(148,150015,"150015",1003215,"Effect/Scene_Eff/Prefab/Eff_elminate_bullet_traill.prefab",10000,"","","","","",""),
	[148] = new t_sys_effectInfo(149,150016,"150016",1003216,"Effect/Scene_Eff/Prefab/Eff_elminate_zhadanyinxian.prefab",10000,"","","","","",""),
	[149] = new t_sys_effectInfo(150,150018,"150018",1003218,"Effect/Scene_Eff/Prefab/Eff_elminate_zuhexiaochutishi.prefab",10000,"","","","","",""),
	[150] = new t_sys_effectInfo(151,150019,"150019",1003219,"Effect/Scene_Eff/Prefab/Eff_elminate_zuhexiaochuactive.prefab",10000,"","","","","",""),
	[151] = new t_sys_effectInfo(152,150020,"150020",1003220,"Effect/Scene_Eff/Prefab/Eff_elminate_energyball.prefab",10000,"","","","","",""),
	[152] = new t_sys_effectInfo(153,150021,"150021",1003221,"Effect/Scene_Eff/Prefab/Eff_elminate_nuche_bullet.prefab",10000,"","","","","",""),
	[153] = new t_sys_effectInfo(154,150022,"150022",1003222,"Effect/Scene_Eff/Prefab/Eff_elminate_nuchexuli.prefab",300,"","","","","",""),
	[154] = new t_sys_effectInfo(155,150023,"150023",1003201,"Effect/Scene_Eff/Prefab/Eff_elminate_chess_choosen.prefab","Effect/Scene_Eff/Prefab/Eff_elminate_chess_choosen.prefab","","","","","",""),
	[155] = new t_sys_effectInfo(156,200001,"200001",1004001,"Effect/Scene_Eff/Prefab/Eff_Scene_47250_RockFallTower_Hit.prefab",10000,"","","","","",""),
	[156] = new t_sys_effectInfo(157,200002,"200002",1004002,"Effect/Scene_Eff/Prefab/Eff_Battle1010_Appear.prefab",10000,"","","","","",""),
	[157] = new t_sys_effectInfo(158,200003,"200003",1004003,"Effect/Scene_Eff/Prefab/Eff_Battle1011_Disapeare.prefab",10000,"","","","","",""),
	[158] = new t_sys_effectInfo(159,200004,"200004",1004004,"Effect/Scene_Eff/Prefab/Eff_Battle1014_BigBuildingShow.prefab",10000,"","","","","",""),
	[159] = new t_sys_effectInfo(160,200005,"200005",1004005,"Effect/Scene_Eff/Prefab/Eff_Battle1014_SmallBuildingShow.prefab",10000,"","","","","",""),
	[160] = new t_sys_effectInfo(161,200006,"200006",1004006,"Effect/Scene_Eff/Prefab/Eff_Battle1016_SoldierShow.prefab",10000,"","","","","",""),
	[161] = new t_sys_effectInfo(162,200007,"200007",1004007,"Effect/Scene_Eff/Prefab/Eff_scence_die.prefab",10000,"","","","","",""),
	[162] = new t_sys_effectInfo(163,200008,"200008",1004008,"Effect/RoleEffectPrefab/shaolin_xp_loop_001.prefab",10000,"","","","","",""),
	[163] = new t_sys_effectInfo(164,200009,"200009",1004009,"Effect/Scene_Eff/Prefab/Eff_Scene_34210_Mammoth_Wind.prefab",0,"",,,20002,"",""),
	[164] = new t_sys_effectInfo(165,200010,"200010",1004010,"Effect/Skill_Eff/Prefab/Eff_Skill_Bull_HitGround.prefab",10000,"","","","","",""),
	[165] = new t_sys_effectInfo(166,200011,"200011",1004011,"Effect/Scene_Eff/Prefab/Eff_tower_birth.prefab",10000,"",,,30003,"",""),
	[166] = new t_sys_effectInfo(167,230001,"230001",1007001,"Effect/UI_Eff/Prefab/Eff_UI_Battle1005_Empty.prefab",10000,"","","","","",""),
	[167] = new t_sys_effectInfo(168,230002,"230002",1007002,"Effect/Scene_Eff/Prefab/Eff_Battle1016_SoldierShow.prefab",10000,"","","","","",""),
	[168] = new t_sys_effectInfo(169,240001,"240001",1008001,"Effect/UI_Eff/Prefab/Eff_UI_Watch.prefab",0,"","","","","",""),
	[169] = new t_sys_effectInfo(170,240002,"240002",1008002,"Effect/UI_Eff/Prefab/Eff_UI_EnergyBall.prefab",5000,"","","","","",""),
	[170] = new t_sys_effectInfo(171,240003,"240003",1008003,"Effect/UI_Eff/Prefab/Eff_UI_EnergyBall.prefab",5000,"","","","","",""),
	[171] = new t_sys_effectInfo(172,250001,"250001",1009001,"Effect/Skill_Eff/Prefab/Eff_Skill_EnergyFull_Green.prefab",0,"","","","","",""),
	[172] = new t_sys_effectInfo(173,250002,"250002",1009002,"Effect/Skill_Eff/Prefab/Eff_Skill_EnergyFull_Blue.prefab",0,"","","","","",""),
	[173] = new t_sys_effectInfo(174,250003,"250003",1009003,"Effect/Skill_Eff/Prefab/Eff_Skill_EnergyFull_Purple.prefab",0,"","","","","",""),
	[174] = new t_sys_effectInfo(175,250004,"250004",1009004,"Effect/Skill_Eff/Prefab/Eff_Skill_EnergyFull_Yellow.prefab",0,"","","","","",""),
	[175] = new t_sys_effectInfo(176,250005,"250005",1009005,"Effect/UI_Eff/Prefab/Eff_UI_Battle1013.prefab",10000,"","","","","",""),
	[176] = new t_sys_effectInfo(177,260001,"260001",1010001,"Scenes/CardBattle/Common/Prefab/empty.prefab",5000,"","","","","",""),
	[177] = new t_sys_effectInfo(178,260002,"260002",1011001,"Effect/Scene_Eff/Prefab/Effect_Nvshen_skill1.prefab",10000,"","","","","",""),
	[178] = new t_sys_effectInfo(179,260003,"260003",1011002,"Effect/Scene_Eff/Prefab/Effect_Nvshen_skill2.prefab",10000,"","","","","",""),
	[179] = new t_sys_effectInfo(180,260004,"260004",1011003,"Effect/Scene_Eff/Prefab/Effect_Nvshen_skill3.prefab",10000,"","","","","",""),
	[180] = new t_sys_effectInfo(181,260005,"260005",1011004,"Effect/Scene_Eff/Prefab/Effect_Nvshen_skill4.prefab",10000,"","","","","",""),
	[181] = new t_sys_effectInfo(182,260006,"260006",1011005,"Effect/Scene_Eff/Prefab/Effect_Nvshen_skill5.prefab",10000,"","","","","",""),
	[182] = new t_sys_effectInfo(183,270001,"270001",1012001,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet_Blue.prefab",10000,"","","","","",""),
	[183] = new t_sys_effectInfo(184,270002,"270002",1012002,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet_Green.prefab",10000,"","","","","",""),
	[184] = new t_sys_effectInfo(185,270003,"270003",1012003,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet_Red.prefab",10000,"","","","","",""),
	[185] = new t_sys_effectInfo(186,270004,"270004",1012004,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet_Gold.prefab",10000,"","","","","",""),
	[186] = new t_sys_effectInfo(187,270005,"270005",1012005,"Effect/Skill_Eff/Prefab/Eff_Skill_Dragon_Bullet_Purple.prefab",10000,"","","","","",""),
	[187] = new t_sys_effectInfo(188,270006,"270006",1012006,"Effect/Skill_Eff/Prefab/Eff_Boom.prefab",500,"","","","","",""),
	[188] = new t_sys_effectInfo(189,280001,"280001",1013001,"Effect/Scene_Eff/Prefab/Eff_Battle_level_up.prefab",10000,"",,,10105,"",""),
	[189] = new t_sys_effectInfo(190,280002,"280002",1030011,"Effect/Scene_Eff/Prefab/Eff_buildings_levelup_tips.prefab",0,"","","","","",""),
	[190] = new t_sys_effectInfo(191,300001,"300001",1013002,"Effect/Scene_Eff/Prefab/Eff_buildings_level_up.prefab",3000,"","","","","",""),
	[191] = new t_sys_effectInfo(192,300002,"300002",1013003,"Effect/Scene_Eff/Prefab/Eff_Scene_zhucheng_smoke02.prefab",10000,"","","","","",""),
	[192] = new t_sys_effectInfo(193,300003,"300003",1013004,"Effect/Scene_Eff/Prefab/Eff_Scene_zhucheng_smoke03.prefab",10000,"","","","","",""),
	[193] = new t_sys_effectInfo(194,300004,"300004",1013005,"Effect/Scene_Eff/Prefab/Eff_Scene_stone_fangwu_01.prefab",10000,"","","","","",""),
	[194] = new t_sys_effectInfo(195,300005,"300005",1013006,"Effect/Scene_Eff/Prefab/Eff_Scene_stone_moxiang_02.prefab",10000,"","","","","",""),
	[195] = new t_sys_effectInfo(196,300006,"300006",1013007,"Effect/Scene_Eff/Prefab/Eff_Scene_stone_moxiang_03.prefab",10000,"","","","","",""),
	[196] = new t_sys_effectInfo(197,300007,"300007",1013008,"Effect/Scene_Eff/Prefab/Eff_Scene_shenxiang_tuteng02.prefab",10000,"","","","","",""),
	[197] = new t_sys_effectInfo(198,300008,"300008",1013009,"Effect/Scene_Eff/Prefab/Eff_Scene_stone_moxiang_01.prefab",10000,"","","","","",""),
	[198] = new t_sys_effectInfo(199,300009,"300009",1013010,"Effect/Scene_Eff/Prefab/Eff_Scene_shenxiang_tuteng01.prefab",10000,"","","","","",""),
	[199] = new t_sys_effectInfo(200,300010,"300010",1013011,"Effect/Scene_Eff/Prefab/Eff_Map_stone_guaiwuyingdiLv1_01.prefab",10000,"","","","","",""),
	[200] = new t_sys_effectInfo(201,300011,"300011",1013012,"Effect/Scene_Eff/Prefab/Eff_Map_stone_guaiwuyingdiLv2_01.prefab",10000,"","","","","",""),
	[201] = new t_sys_effectInfo(202,300012,"300012",1013013,"Effect/Scene_Eff/Prefab/Eff_Map_stone_jiuguan_01.prefab",10000,"","","","","",""),
	[202] = new t_sys_effectInfo(203,300013,"300013",1013014,"Effect/Scene_Eff/Prefab/Eff_Map_stone_cangku_01.prefab",10000,"","","","","",""),
	[203] = new t_sys_effectInfo(204,300014,"300014",1013015,"Effect/Scene_Eff/Prefab/Eff_Map_stone_feixu.prefab",10000,"","","","","",""),
	[204] = new t_sys_effectInfo(205,400001,"400001",1900001,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_attack.prefab",1000,"","","","","",""),
	[205] = new t_sys_effectInfo(206,400002,"400002",1900002,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_bullet.prefab",0,"","","","","",""),
	[206] = new t_sys_effectInfo(207,400003,"400003",1900003,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_hit.prefab",2000,"","","","","",""),
	[207] = new t_sys_effectInfo(208,400004,"400004",1900004,"Effect/Skill_Eff/Prefab/Eff_skill_gongjianshou/Eff_skill_gongjianshou_skill.prefab",2000,"","","","","",""),
};
}