using System.Collections.Generic;
public class c_condtioneInfo
{
public int id;
public int a_base_condition_id;
public string c_e_condition_name;
public int c_base_condition_text;
public c_condtioneInfo(int id,int a_base_condition_id,string c_e_condition_name,int c_base_condition_text)
{
  this.id = id;
  this.a_base_condition_id = a_base_condition_id;
  this.c_e_condition_name = c_e_condition_name;
  this.c_base_condition_text = c_base_condition_text;
}
}
public class Cfg_c_condtione
{
public static List<c_condtioneInfo> list = new List<c_condtioneInfo>()
{
	[0] = new c_condtioneInfo(1,1,"AccountLevel ",520001),
	[1] = new c_condtioneInfo(2,2,"MainCityBuildLevel",520002),
	[2] = new c_condtioneInfo(3,3,"TaskIdCompeteNums",520003),
	[3] = new c_condtioneInfo(4,4,"LevelCompeteNums",520004),
	[4] = new c_condtioneInfo(5,5,"VipLevel",520005),
	[5] = new c_condtioneInfo(6,6,"EraLevel",520006),
	[6] = new c_condtioneInfo(7,7,"HomeLevel",520007),
	[7] = new c_condtioneInfo(8,8,"ServerTimeAfterDay",520008),
	[8] = new c_condtioneInfo(9,9,"DataTimeStartToEnd",520009),
	[9] = new c_condtioneInfo(10,10,"AccumulatedRecharge",520010),
	[10] = new c_condtioneInfo(11,11,"TodayRecharge",520011),
	[11] = new c_condtioneInfo(12,12,"ItemIdUseNums",520012),
	[12] = new c_condtioneInfo(13,21,"CombatEffectiveness",520021),
	[13] = new c_condtioneInfo(14,22,"TotelGetNumberOfCards",520022),
	[14] = new c_condtioneInfo(15,23,"TotelGetNumberOfProps",520023),
	[15] = new c_condtioneInfo(16,24,"TotelUseNumberOfProps",520024),
	[16] = new c_condtioneInfo(17,25,"CardLevelUp",520025),
	[17] = new c_condtioneInfo(18,26,"TaskIdClaimReward",520026),
	[18] = new c_condtioneInfo(19,27,"ClearAssignClutter",520027),
	[19] = new c_condtioneInfo(20,28,"RepairAssignBuilding",520028),
	[20] = new c_condtioneInfo(21,101,"ChallengeBarrier",520101),
	[21] = new c_condtioneInfo(22,102,"ChallengeLevelSubtype",520102),
	[22] = new c_condtioneInfo(23,103,"ChallengePVP",520103),
	[23] = new c_condtioneInfo(24,104,"LoginDay",520104),
	[24] = new c_condtioneInfo(25,105,"GetMaterial",520105),
	[25] = new c_condtioneInfo(26,106,"BuyFurniture",520106),
	[26] = new c_condtioneInfo(27,107,"ShopBuyCount",520107),
	[27] = new c_condtioneInfo(28,108,"UseAccelerateProps",520108),
	[28] = new c_condtioneInfo(29,109,"GetBuildItem",520109),
	[29] = new c_condtioneInfo(30,110,"GetBuildFood",520110),
	[30] = new c_condtioneInfo(31,111,"GetBuildMeat",520111),
	[31] = new c_condtioneInfo(32,112,"GetBuildWood",520112),
	[32] = new c_condtioneInfo(33,113,"GetBuildStone",520113),
	[33] = new c_condtioneInfo(34,114,"CardLevelUpCount",520114),
	[34] = new c_condtioneInfo(35,115,"BuildingLevelUpCount",520115),
	[35] = new c_condtioneInfo(36,116,"ShoppingCount",520116),
	[36] = new c_condtioneInfo(37,117,"ClearWasteland",520117),
	[37] = new c_condtioneInfo(38,118,"ShopShelvesBuyCount",520118),
	[38] = new c_condtioneInfo(39,119,"TotalBuildNums",520119),
	[39] = new c_condtioneInfo(40,120,"ChallengeTypePVP",520120),
	[40] = new c_condtioneInfo(41,201,"GlobalEraLevel",520201),
	[41] = new c_condtioneInfo(42,202,"GlobalClearWasteland",520202),
	[42] = new c_condtioneInfo(43,203,"GlobalLevelCompeteNums",520203),
	[43] = new c_condtioneInfo(44,204,"GlobalServerTimeAfterDay",520204),
	[44] = new c_condtioneInfo(45,301,"FirstRecharge",520301),
	[45] = new c_condtioneInfo(46,302,"DepositActivation",520302),
	[46] = new c_condtioneInfo(47,303,"",""),
	[47] = new c_condtioneInfo(48,304,"",""),
};
}
