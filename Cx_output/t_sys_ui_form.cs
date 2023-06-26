using System.Collections.Generic;
public class Cfg_t_sys_ui_form_Info
{
	public int id;
	public int c_base_ui_form_id;
	public string c_base_desc;
	public string c_e_name;
	public int c_base_ui_group_id;
	public int c_base_disable_ui_layer;
	public int c_base_is_lock;
	public int c_base_load_type;
	public string c_base_asset_path;
	public int c_base_can_mulit;
	public int c_base_show_mode;
	public int c_base_freeze_mode;
	public int c_base_reside;
	public int c_base_transfer_ui;
	public int c_base_full_screen;
	public int c_base_hasDimBackGround;
public Cfg_t_sys_ui_form_Info(int id,int c_base_ui_form_id,string c_base_desc,string c_e_name,int c_base_ui_group_id,int c_base_disable_ui_layer,int c_base_is_lock,int c_base_load_type,string c_base_asset_path,int c_base_can_mulit,int c_base_show_mode,int c_base_freeze_mode,int c_base_reside,int c_base_transfer_ui,int c_base_full_screen,int c_base_hasDimBackGround)
{
  this.id = id;
  this.c_base_ui_form_id = c_base_ui_form_id;
  this.c_base_desc = c_base_desc;
  this.c_e_name = c_e_name;
  this.c_base_ui_group_id = c_base_ui_group_id;
  this.c_base_disable_ui_layer = c_base_disable_ui_layer;
  this.c_base_is_lock = c_base_is_lock;
  this.c_base_load_type = c_base_load_type;
  this.c_base_asset_path = c_base_asset_path;
  this.c_base_can_mulit = c_base_can_mulit;
  this.c_base_show_mode = c_base_show_mode;
  this.c_base_freeze_mode = c_base_freeze_mode;
  this.c_base_reside = c_base_reside;
  this.c_base_transfer_ui = c_base_transfer_ui;
  this.c_base_full_screen = c_base_full_screen;
  this.c_base_hasDimBackGround = c_base_hasDimBackGround;
}
}
public class Cfg_t_sys_ui_form
{
public static List<Cfg_t_sys_ui_form_Info> list = new List<Cfg_t_sys_ui_form_Info>()
{
	[0] = new Cfg_t_sys_ui_form_Info(1002,1001,"","UITest",2,0,0,0,"UITest",0,0,0,0,0,0,0),
	[1] = new Cfg_t_sys_ui_form_Info(1003,1002,"","UIMail",2,0,0,0,"Mail/UIMail",0,1,0,0,2,1,0),
	[2] = new Cfg_t_sys_ui_form_Info(1004,1003,"","UIMailContent",2,0,0,0,"Mail/UIMailContent",0,0,0,0,0,0,0),
	[3] = new Cfg_t_sys_ui_form_Info(1005,1004,"","UIDesTipsPop ",4,0,0,0,"Common/PopWindow/UIDesTipsPop ",0,0,0,0,0,0,0),
	[4] = new Cfg_t_sys_ui_form_Info(1006,1005,"","UIBagPanel",2,0,0,2,"Bag/UIBagPanel",0,1,0,0,1,1,0),
	[5] = new Cfg_t_sys_ui_form_Info(1007,1006,"","UIConfirmPop",4,0,0,0,"Common/PopWindow/UIConfirmPop",0,0,0,0,0,0,1),
	[6] = new Cfg_t_sys_ui_form_Info(1008,1007,"","CReceiveAward",2,0,0,0,"Common/UIReceiveAward",0,0,0,0,0,0,0),
	[7] = new Cfg_t_sys_ui_form_Info(1009,1008,"","UISroChangePanel",2,0,0,0,"ScrollChange/UISroChangePanel",0,0,0,0,0,0,0),
	[8] = new Cfg_t_sys_ui_form_Info(1010,1009,"","UITipsPanel",4,0,0,0,"Common/PopWindow/UITipsPanel",0,0,0,1,0,0,0),
	[9] = new Cfg_t_sys_ui_form_Info(1011,1010,"","UIMainPanel",2,0,0,2,"Main/UIMainPanel",0,1,0,1,1,1,0),
	[10] = new Cfg_t_sys_ui_form_Info(1012,1011,"","UIBoxInfoPop",4,0,0,0,"Common/PopWindow/UIBoxInfoPop",0,0,0,0,0,0,1),
	[11] = new Cfg_t_sys_ui_form_Info(1013,1012,"","UIFixedOrRandomBoxPop",4,0,0,0,"Common/PopWindow/UIFixedOrRandomBoxPop",0,0,0,0,0,0,1),
	[12] = new Cfg_t_sys_ui_form_Info(1014,1013,"","UIItemInfoPop",4,0,0,0,"Common/PopWindow/UIItemInfoPop",0,0,0,0,0,0,1),
	[13] = new Cfg_t_sys_ui_form_Info(1015,1014,"","UIItemUsePop",4,0,0,0,"Common/PopWindow/UIItemUsePop",0,0,0,0,0,0,1),
	[14] = new Cfg_t_sys_ui_form_Info(1016,1015,"","UIOptionalBoxPop",4,0,0,0,"Common/PopWindow/UIOptionalBoxPop",0,0,0,0,0,0,1),
	[15] = new Cfg_t_sys_ui_form_Info(1017,1016,"","UIJumpToPop",4,0,0,0,"Common/PopWindow/UIJumpToPop",0,0,0,0,0,0,1),
	[16] = new Cfg_t_sys_ui_form_Info(1018,1017,"","UIRoleInfoWnd",4,0,0,0,"Common/PopWindow/UIRoleInfoWnd",0,0,0,0,0,0,1),
	[17] = new Cfg_t_sys_ui_form_Info(1019,1018,"","UIFurnitureSelect",2,0,0,0,"Home/UIFurnitureSelect",0,0,0,0,0,0,0),
	[18] = new Cfg_t_sys_ui_form_Info(1020,1019,"","UIMainHomePanel",2,0,0,0,"Home/UIMainHomePanel",0,1,0,0,2,1,0),
	[19] = new Cfg_t_sys_ui_form_Info(1021,1020,"","UIHomeDialog",2,0,0,0,"Home/UIHomeDialog",0,0,0,0,0,0,0),
	[20] = new Cfg_t_sys_ui_form_Info(1022,1021,"","UIClickSlider",2,0,0,0,"Common/UIClickSlider",0,0,0,0,0,0,0),
	[21] = new Cfg_t_sys_ui_form_Info(1023,1022,"","UIBattle",2,0,0,2,"UIBattle/UIBattle",0,0,0,0,0,0,0),
	[22] = new Cfg_t_sys_ui_form_Info(1024,1023,"","UIGameLevel",4,0,0,0,"UIGameLevel/UIGameLevel",0,0,0,0,0,0,0),
	[23] = new Cfg_t_sys_ui_form_Info(1025,1024,"","UIGameLevelParticulars",4,0,0,2,"UIGameLevel/UIGameLevelParticulars",0,0,0,0,0,0,0),
	[24] = new Cfg_t_sys_ui_form_Info(1026,1025,"","UICardBag",2,0,0,2,"UICard/UICardBag",0,1,0,0,1,1,0),
	[25] = new Cfg_t_sys_ui_form_Info(1027,1026,"","UICardDetail",2,0,0,0,"UICard/UICardDetail",0,1,0,0,2,1,0),
	[26] = new Cfg_t_sys_ui_form_Info(1028,1027,"","UICardInfo",2,0,0,0,"UICard/UICardInfo",0,0,0,0,0,0,0),
	[27] = new Cfg_t_sys_ui_form_Info(1029,1028,"","UICardLvUp",2,0,0,0,"UICard/UICardLvUp",0,0,0,0,0,0,0),
	[28] = new Cfg_t_sys_ui_form_Info(1030,1029,"","UICardVideo",2,0,0,0,"UICard/UICardVideo",0,0,0,0,0,0,0),
	[29] = new Cfg_t_sys_ui_form_Info(1031,1030,"","UIChangeName",2,0,0,0,"UICard/UIChangeName",0,0,0,0,0,0,0),
	[30] = new Cfg_t_sys_ui_form_Info(1032,1031,"","UIFormation",2,0,0,0,"UICard/UIFormation",0,1,0,0,2,1,0),
	[31] = new Cfg_t_sys_ui_form_Info(1033,1032,"","UIBattleResult",2,0,0,0,"UIBattle/UIBattleResult",0,0,0,0,0,0,0),
	[32] = new Cfg_t_sys_ui_form_Info(1034,1033,"","UICardProperty",2,0,0,0,"UICard/UICardProperty",0,0,0,0,0,0,0),
	[33] = new Cfg_t_sys_ui_form_Info(1035,1034,"","UIGameLoginPanel",2,0,0,2,"Login/UIGameLoginPanel",0,1,0,0,0,1,0),
	[34] = new Cfg_t_sys_ui_form_Info(1036,1035,"","UIAnnouncementPanel",2,0,0,2,"Login/UIAnnouncementPanel",0,1,0,0,0,1,0),
	[35] = new Cfg_t_sys_ui_form_Info(1037,1036,"","UICreateRolePanel",2,0,0,2,"Login/UICreateRolePanel",0,1,0,0,0,1,0),
	[36] = new Cfg_t_sys_ui_form_Info(1038,1037,"","UITransferPanel",3,0,0,2,"Main/UITransferPanel",0,0,0,1,0,0,0),
	[37] = new Cfg_t_sys_ui_form_Info(1039,1038,"","UIBuildArchitecturePanel",2,0,0,0,"BigMap/UIBuildArchitecturePanel",0,0,0,0,3,0,0),
	[38] = new Cfg_t_sys_ui_form_Info(1040,1039,"","UIBuyGiftBagPop",4,0,0,0,"Common/PopWindow/UIBuyGiftBagPop",0,0,0,0,0,0,1),
	[39] = new Cfg_t_sys_ui_form_Info(1041,1040,"","UIHorseRunning",3,0,0,0,"Main/UIHorseRunning",0,0,0,1,0,0,0),
	[40] = new Cfg_t_sys_ui_form_Info(1042,1041,"","UISettingsPanel",4,0,0,0,"Settings/UISettingsPanel",0,0,0,0,0,0,0),
	[41] = new Cfg_t_sys_ui_form_Info(1043,1042,"","UIArchitectureUpPanel",2,0,0,0,"BigMap/UIArchitectureUpPanel",0,1,0,0,2,1,0),
	[42] = new Cfg_t_sys_ui_form_Info(1044,1043,"","UIArchitectureInfoPanel",2,0,0,0,"BigMap/UIArchitectureInfoPanel",0,1,0,0,2,1,0),
	[43] = new Cfg_t_sys_ui_form_Info(1045,1044,"","UIMysteryChestPanel",4,0,0,0,"BigMap/UIMysteryChestPanel",0,0,0,0,0,0,1),
	[44] = new Cfg_t_sys_ui_form_Info(1046,1045,"","UIArchitectureSpeedUpPanel",4,0,0,0,"BigMap/UIArchitectureSpeedUpPanel",0,0,0,0,0,0,1),
	[45] = new Cfg_t_sys_ui_form_Info(1047,1046,"","UIEmbattle",2,0,0,2,"UIGameLevel/UIEmbattle",0,1,0,0,2,1,0),
	[46] = new Cfg_t_sys_ui_form_Info(1048,1047,"","UIFixedAndRandomBoxPop",4,0,0,0,"Common/PopWindow/UIFixedAndRandomBoxPop",0,0,0,0,0,0,1),
	[47] = new Cfg_t_sys_ui_form_Info(1049,1048,"","UIFurnitureLayer",1,0,0,0,"Home/UIFurnitureLayer",0,0,0,0,0,0,0),
	[48] = new Cfg_t_sys_ui_form_Info(1050,1049,"","UIGetAwardPop",4,0,0,0,"Common/PopWindow/UIGetAwardPop",0,0,0,0,0,0,0),
	[49] = new Cfg_t_sys_ui_form_Info(1051,1050,"","UIGetNewCardPop",4,0,0,0,"Common/PopWindow/UIGetNewCardPop",0,0,0,0,0,0,0),
	[50] = new Cfg_t_sys_ui_form_Info(1052,1051,"","UICardItemInfoPop",4,0,0,0,"Common/PopWindow/UICardItemInfoPop",0,0,0,0,0,0,1),
	[51] = new Cfg_t_sys_ui_form_Info(1053,1052,"","UIArchitectureUseSpeedItemPop",4,0,0,0,"BigMap/UIArchitectureUseSpeedItemPop",0,0,0,0,0,0,1),
	[52] = new Cfg_t_sys_ui_form_Info(1054,1053,"","UIResourceShowPop",4,0,0,0,"Main/UIResourceShowPop",0,0,0,0,0,0,1),
	[53] = new Cfg_t_sys_ui_form_Info(1055,1054,"","UIPlotPanel",5,0,0,2,"Plot/UIPlotPanel",0,0,0,0,0,0,0),
	[54] = new Cfg_t_sys_ui_form_Info(1056,1055,"","UIWorkshopPanel",2,0,0,0,"Workshop/UIWorkshopPanel",0,1,0,0,3,1,0),
	[55] = new Cfg_t_sys_ui_form_Info(1057,1056,"","UIGodSkills",2,0,0,0,"UIGod/UIGodSkills",0,1,0,0,3,1,0),
	[56] = new Cfg_t_sys_ui_form_Info(1058,1057,"","UIGodConsecrate",2,0,0,0,"UIGod/UIGodConsecrate",0,1,0,0,3,1,0),
	[57] = new Cfg_t_sys_ui_form_Info(1059,1058,"","UIBodyPower",4,0,0,0,"UIBodyPower/UIBodyPower",0,0,0,0,1,0,0),
	[58] = new Cfg_t_sys_ui_form_Info(1060,1059,"","UIBattleMatchPanel",2,0,0,0,"BattleMatch/UIBattleMatchPanel",0,1,0,0,1,1,0),
	[59] = new Cfg_t_sys_ui_form_Info(1061,1060,"","UIBattleMatchingPanel",2,0,0,0,"BattleMatch/UIBattleMatchingPanel",0,1,0,0,2,1,0),
	[60] = new Cfg_t_sys_ui_form_Info(1062,1061,"","UIShopGreedyPanel",2,0,0,0,"Shop/UIShopGreedyPanel",0,1,0,0,3,1,0),
	[61] = new Cfg_t_sys_ui_form_Info(1063,1062,"","UIMallPanel",2,0,0,0,"Shop/UIMallPanel",0,1,0,0,0,1,0),
	[62] = new Cfg_t_sys_ui_form_Info(1064,1063,"","UIShopBuyPanel",4,0,0,0,"Shop/UIShopBuyPanel",0,0,0,0,0,0,0),
	[63] = new Cfg_t_sys_ui_form_Info(1065,1064,"","UIBarracks",2,0,0,0,"UIBarracks/UIBarracks",0,1,0,0,2,1,0),
	[64] = new Cfg_t_sys_ui_form_Info(1066,1065,"","UIBattleMatchEraPanel",2,0,0,0,"BattleMatch/UIBattleMatchEraPanel",0,0,0,0,2,1,0),
	[65] = new Cfg_t_sys_ui_form_Info(1067,1066,"","UIComboTip",4,0,0,0,"Combo/UIComboTip",0,0,0,0,0,0,0),
	[66] = new Cfg_t_sys_ui_form_Info(1068,1067,"","UIFiltratePop",4,0,0,0,"Bazaar/UIFiltratePop",0,0,0,0,0,0,0),
	[67] = new Cfg_t_sys_ui_form_Info(1069,1068,"","UITransactionRecordPop",4,0,0,0,"Bazaar/UITransactionRecordPop",0,0,0,0,0,0,1),
	[68] = new Cfg_t_sys_ui_form_Info(1070,1069,"","UITransactionSellLstPop",4,0,0,0,"Bazaar/UITransactionSellLstPop",0,0,0,0,0,0,1),
	[69] = new Cfg_t_sys_ui_form_Info(1071,1070,"","UIBazaarPanel",2,0,0,0,"Bazaar/UIBazaarPanel",0,0,0,0,3,1,0),
	[70] = new Cfg_t_sys_ui_form_Info(1072,1071,"","UITransactionSellPop",4,0,0,0,"Bazaar/UITransactionSellPop",0,0,0,0,0,0,1),
	[71] = new Cfg_t_sys_ui_form_Info(1073,1072,"","UIOpenCardBoxPanel",4,0,0,0,"Shop/UIOpenCardBoxPanel",0,0,0,0,0,0,0),
	[72] = new Cfg_t_sys_ui_form_Info(1074,1073,"","UIPlayerInfoPanel",2,0,0,0,"UIPlayerInfo/UIPlayerInfoPanel",0,1,0,0,3,1,0),
	[73] = new Cfg_t_sys_ui_form_Info(1075,1074,"","UIPlayerHeadPop",4,0,0,0,"UIPlayerInfo/UIPlayerHeadPop",0,0,0,0,0,0,0),
	[74] = new Cfg_t_sys_ui_form_Info(1076,1075,"","UIPlayerLvPop",4,0,0,0,"UIPlayerInfo/UIPlayerLvPop",0,0,0,0,0,0,0),
	[75] = new Cfg_t_sys_ui_form_Info(1077,1076,"","UIPlayerSkinPanel",2,0,0,0,"UIPlayerInfo/UIPlayerSkinPanel",0,0,0,0,3,1,0),
	[76] = new Cfg_t_sys_ui_form_Info(1078,1077,"","UITaskPop",4,0,0,0,"Task/UITaskPop",0,0,0,0,0,0,1),
	[77] = new Cfg_t_sys_ui_form_Info(1079,1078,"","UIMainLineTaskPop",4,0,0,0,"Task/UIMainLineTaskPop",0,0,0,0,0,0,1),
	[78] = new Cfg_t_sys_ui_form_Info(1080,1079,"","UIRewardBoxInfoPop",4,0,0,0,"Common/PopWindow/UIRewardBoxInfoPop",0,0,0,0,0,0,0),
	[79] = new Cfg_t_sys_ui_form_Info(1081,1080,"","UIAchievementPop",4,0,0,0,"Achievement/UIAchievementPop",0,0,0,0,0,0,0),
	[80] = new Cfg_t_sys_ui_form_Info(1082,1081,"","UIWorldAchievementPanel",2,0,0,0,"Achievement/UIWorldAchievementPanel",0,0,0,0,2,1,0),
	[81] = new Cfg_t_sys_ui_form_Info(1083,1082,"","UIBattlePause",6,0,0,0,"UIBattle/UIBattlePause",0,0,0,0,2,1,0),
	[82] = new Cfg_t_sys_ui_form_Info(1084,1083,"","UIRenamePop",4,0,0,0,"Common/UIRenamePop",0,0,0,0,0,0,0),
	[83] = new Cfg_t_sys_ui_form_Info(1085,1084,"","UITransactionFriendPop",4,0,0,0,"Bazaar/UITransactionFriendPop",0,0,0,0,0,0,1),
	[84] = new Cfg_t_sys_ui_form_Info(1086,1085,"","UIFriendAdministrationPop",4,0,0,0,"Friend/UIFriendAdministrationPop",0,0,0,0,0,1,1),
	[85] = new Cfg_t_sys_ui_form_Info(1087,1086,"","UIFriendCataloguePanel",2,0,0,0,"Friend/UIFriendCataloguePanel",0,1,0,0,2,1,0),
	[86] = new Cfg_t_sys_ui_form_Info(1088,1087,"","UIPlayerLevelUpPop",4,0,0,0,"UIPlayerInfo/UIPlayerLevelUpPop",0,0,0,0,0,0,0),
	[87] = new Cfg_t_sys_ui_form_Info(1089,1088,"","UINoticePanel",4,0,0,0,"Login/UINoticePanel",0,0,0,0,0,0,0),
	[88] = new Cfg_t_sys_ui_form_Info(1090,1089,"","UIChatPanel",2,0,0,0,"Chat/UIChatPanel",0,1,0,0,2,1,0),
	[89] = new Cfg_t_sys_ui_form_Info(1091,1090,"","UIItemShopPanel",2,0,0,0,"Shop/UIItemShopPanel",0,1,0,0,3,1,0),
	[90] = new Cfg_t_sys_ui_form_Info(1092,1091,"","UIChatSelectFriendPop",4,0,0,0,"Chat/UIChatSelectFriendPop",0,0,0,0,0,1,1),
	[91] = new Cfg_t_sys_ui_form_Info(1093,1092,"","UIFirstChargePanel",4,0,0,0,"Active/FirstCharge/UIFirstChargePanel",0,0,0,0,0,0,0),
	[92] = new Cfg_t_sys_ui_form_Info(1094,1093,"","UIWelfarePanel",2,0,0,0,"Welfare/UIWelfarePanel",0,0,0,0,3,1,0),
	[93] = new Cfg_t_sys_ui_form_Info(1095,1094,"","UIUseFakeGoldPop",4,0,0,0,"Common/PopWindow/UIUseFakeGoldPop",0,0,0,0,0,1,1),
	[94] = new Cfg_t_sys_ui_form_Info(1096,1095,"","UIUseGenuineGoldInsufficientPop",4,0,0,0,"Common/PopWindow/UIUseGenuineGoldInsufficientPop",0,0,0,0,0,1,1),
	[95] = new Cfg_t_sys_ui_form_Info(1097,1096,"","UIBattleBuffSelectPop",4,0,0,0,"UIBattle/UIBattleBuffSelectPop",0,0,0,0,0,0,0),
	[96] = new Cfg_t_sys_ui_form_Info(1098,1097,"","UIBattleBuffBagPop",4,0,0,0,"UIBattle/UIBattleBuffBagPop",0,0,0,0,0,0,0),
	[97] = new Cfg_t_sys_ui_form_Info(1099,1098,"","UIInfinityTowerFloorRewardPop",4,0,0,0,"PlayingMethod/InfinityTower/UIInfinityTowerFloorRewardPop",0,0,0,0,0,0,1),
	[98] = new Cfg_t_sys_ui_form_Info(1100,1099,"","UIInfinityTowerCarnetFriendPop",4,0,0,0,"PlayingMethod/InfinityTower/UIInfinityTowerCarnetFriendPop",0,0,0,0,0,0,1),
	[99] = new Cfg_t_sys_ui_form_Info(1101,1100,"","UIInfinityTowerCarnetRewardPop",4,0,0,0,"PlayingMethod/InfinityTower/UIInfinityTowerCarnetRewardPop",0,0,0,0,0,0,1),
	[100] = new Cfg_t_sys_ui_form_Info(1102,1101,"","UIInfinityTowerPanel",2,0,0,0,"PlayingMethod/InfinityTower/UIInfinityTowerPanel",0,1,0,0,3,1,0),
	[101] = new Cfg_t_sys_ui_form_Info(1103,1102,"","UIBattleHPAddPOP",4,0,0,0,"UIBattle/UIBattleHPAddPOP",0,0,0,0,0,0,0),
	[102] = new Cfg_t_sys_ui_form_Info(1104,1103,"","UIActivePanel",2,0,0,0,"Active/UIActivePanel",0,1,0,0,3,1,0),
	[103] = new Cfg_t_sys_ui_form_Info(1105,1104,"","UISignInPanel ",2,0,0,0,"Active/SignIn/UISignInPanel ",0,1,0,0,3,1,0),
	[104] = new Cfg_t_sys_ui_form_Info(1106,1105,"","UIOnLinePop",4,0,0,0,"Active/OnLine/UIOnLinePop",0,0,0,0,0,0,0),
	[105] = new Cfg_t_sys_ui_form_Info(1107,1106,"","UISevenLoginPop",4,0,0,0,"Active/SevenLogin/UISevenLoginPop ",0,0,0,0,0,0,0),
	[106] = new Cfg_t_sys_ui_form_Info(1108,1107,"","UIDevildomLevelPop",4,0,0,0,"PlayingMethod/Devildom/UIDevildomLevelPop",0,0,0,0,0,0,1),
	[107] = new Cfg_t_sys_ui_form_Info(1109,1108,"","UIDevildomPanel",2,0,0,0,"PlayingMethod/Devildom/UIDevildomPanel",0,1,0,0,3,1,0),
	[108] = new Cfg_t_sys_ui_form_Info(1110,1109,"","UIArchitectureRepairPanel",2,0,0,0,"BigMap/UIArchitectureRepairPanel",0,1,0,0,2,1,0),
	[109] = new Cfg_t_sys_ui_form_Info(1111,1110,"","UIVipPanel",2,0,0,0,"Vip/UIVipPanel",0,1,0,0,3,1,0),
	[110] = new Cfg_t_sys_ui_form_Info(1112,1111,"","UIVipLevelUpPanel",4,0,0,0,"Vip/UIVipLevelUpPanel",0,0,0,0,0,1,1),
	[111] = new Cfg_t_sys_ui_form_Info(1113,1112,"","UIVipPointShopPanel",4,0,0,0,"Shop/UIVipPointShopPanel",0,0,0,0,0,1,1),
	[112] = new Cfg_t_sys_ui_form_Info(1114,1113,"","UIXinshouyindao",5,0,0,2,"Guide/UIXinshouyindao",0,1,0,0,0,1,0),
	[113] = new Cfg_t_sys_ui_form_Info(1115,1114,"","UISevenTaskPanel",2,0,0,0,"Active/SevenTask/UISevenTaskPanel",0,1,0,0,3,1,1),
	[114] = new Cfg_t_sys_ui_form_Info(1116,1115,"","UIArenaPanel",2,0,0,0,"Arena/UIArenaPanel",0,1,0,0,1,1,0),
	[115] = new Cfg_t_sys_ui_form_Info(1117,1116,"","UIArenaTypesPanel",2,0,0,0,"Arena/UIArenaTypesPanel",0,1,0,0,2,1,0),
	[116] = new Cfg_t_sys_ui_form_Info(1118,1117,"","UIArenaMatchPanel",2,0,0,0,"Arena/UIArenaMatchPanel",0,1,0,0,2,1,0),
	[117] = new Cfg_t_sys_ui_form_Info(1119,1118,"","UIArenaInvitePanel",4,0,0,0,"Arena/UIArenaInvitePanel",0,0,0,0,0,1,0),
	[118] = new Cfg_t_sys_ui_form_Info(1120,1119,"","UIArenaInvitedPanel",4,0,0,0,"Arena/UIArenaInvitedPanel",0,0,0,0,0,1,0),
	[119] = new Cfg_t_sys_ui_form_Info(1121,1120,"","UIArenaChampionshipPanel",2,0,0,0,"Arena/UIArenaChampionshipPanel",0,1,0,0,2,1,0),
	[120] = new Cfg_t_sys_ui_form_Info(1122,1121,"","UIArenaLoading",8,0,0,0,"Arena/UIArenaLoading",0,0,0,0,0,1,0),
	[121] = new Cfg_t_sys_ui_form_Info(1123,1122,"","UIArenaChampionshipDetailPanel",4,0,0,0,"Arena/UIArenaChampionshipDetailPanel",0,0,0,0,0,1,1),
	[122] = new Cfg_t_sys_ui_form_Info(1124,1123,"","UITaskActiveBoxPop",4,0,0,0,"Task/UITaskActiveBoxPop",0,0,0,0,0,0,1),
	[123] = new Cfg_t_sys_ui_form_Info(1125,1124,"","UIItemDesTipsPop",4,0,0,0,"Common/PopWindow/UIItemDesTipsPop",0,0,0,0,0,0,0),
	[124] = new Cfg_t_sys_ui_form_Info(1126,1125,"","UIItemUsePlusPop",4,0,0,0,"Common/PopWindow/UIItemUsePlusPop",0,0,0,0,0,0,1),
	[125] = new Cfg_t_sys_ui_form_Info(1127,1126,"","UIItemInfoPlusPop",4,0,0,0,"Common/PopWindow/UIItemInfoPlusPop",0,0,0,0,0,0,1),
	[126] = new Cfg_t_sys_ui_form_Info(1128,1127,"","UIItemOptionalPlusPop",4,0,0,0,"Common/PopWindow/UIItemOptionalPlusPop",0,0,0,0,0,0,1),
	[127] = new Cfg_t_sys_ui_form_Info(1129,1128,"","UIArenaResultPanel",4,0,0,0,"Arena/UIArenaResultPanel",0,0,0,0,0,0,1),
	[128] = new Cfg_t_sys_ui_form_Info(1130,1129,"","UIArenaChampionshipRankPanel",4,0,0,0,"Arena/UIArenaChampionshipRankPanel",0,0,0,0,0,0,1),
	[129] = new Cfg_t_sys_ui_form_Info(1131,1130,"","UICombineExplain",6,0,0,0,"UIBattle/UICombineExplain",0,0,0,0,0,0,1),
	[130] = new Cfg_t_sys_ui_form_Info(1132,1131,"","UINetConfirmPop",7,0,0,0,"Common/PopWindow/UIConfirmPop",0,0,0,0,0,0,1),
	[131] = new Cfg_t_sys_ui_form_Info(1133,1132,"","UILanguageSettingsPanel",4,0,0,0,"Settings/UILanguageSettingsPanel",0,0,0,0,0,0,0),
	[132] = new Cfg_t_sys_ui_form_Info(1134,1133,"","UINormalLoading",8,0,0,2,"Loading/UINormalLoading",0,0,0,0,0,1,0),
};
}
