using System.Collections.Generic;
public class Cfg_c_condtione_Info
{
	public int id;
	public int a_base_condition_id;
	public string c_e_condition_name;
	public int c_base_condition_text;
public Cfg_c_condtione_Info(int id,int a_base_condition_id,string c_e_condition_name,int c_base_condition_text)
{
  this.id = id;
  this.a_base_condition_id = a_base_condition_id;
  this.c_e_condition_name = c_e_condition_name;
  this.c_base_condition_text = c_base_condition_text;
}
}
public class Cfg_c_condtione
{
public static List<Cfg_c_condtione_Info> list = new List<Cfg_c_condtione_Info>()
{
	[0] = new Cfg_c_condtione_Info(1,1,"AccountLevel ",520001),
	[1] = new Cfg_c_condtione_Info(2,2,"MainCityBuildLevel",520002),
	[2] = new Cfg_c_condtione_Info(3,3,"TaskIdCompeteNums",520003),
	[3] = new Cfg_c_condtione_Info(4,4,"LevelCompeteNums",520004),
	[4] = new Cfg_c_condtione_Info(5,5,"VipLevel",520005),
	[5] = new Cfg_c_condtione_Info(6,6,"EraLevel",520006),
	[6] = new Cfg_c_condtione_Info(7,7,"HomeLevel",520007),
	[7] = new Cfg_c_condtione_Info(8,8,"ServerTimeAfterDay",520008),
	[8] = new Cfg_c_condtione_Info(9,9,"DataTimeStartToEnd",520009),
	[9] = new Cfg_c_condtione_Info(10,10,"AccumulatedRecharge",520010),
	[10] = new Cfg_c_condtione_Info(11,11,"TodayRecharge",520011),
	[11] = new Cfg_c_condtione_Info(12,12,"ItemIdUseNums",520012),
	[12] = new Cfg_c_condtione_Info(13,21,"CombatEffectiveness",520021),
	[13] = new Cfg_c_condtione_Info(14,22,"TotelGetNumberOfCards",520022),
	[14] = new Cfg_c_condtione_Info(15,23,"TotelGetNumberOfProps",520023),
	[15] = new Cfg_c_condtione_Info(16,24,"TotelUseNumberOfProps",520024),
	[16] = new Cfg_c_condtione_Info(17,25,"CardLevelUp",520025),
	[17] = new Cfg_c_condtione_Info(18,26,"TaskIdClaimReward",520026),
	[18] = new Cfg_c_condtione_Info(19,27,"ClearAssignClutter",520027),
	[19] = new Cfg_c_condtione_Info(20,28,"RepairAssignBuilding",520028),
	[20] = new Cfg_c_condtione_Info(21,101,"ChallengeBarrier",520101),
	[21] = new Cfg_c_condtione_Info(22,102,"ChallengeLevelSubtype",520102),
	[22] = new Cfg_c_condtione_Info(23,103,"ChallengePVP",520103),
	[23] = new Cfg_c_condtione_Info(24,104,"LoginDay",520104),
	[24] = new Cfg_c_condtione_Info(25,105,"GetMaterial",520105),
	[25] = new Cfg_c_condtione_Info(26,106,"BuyFurniture",520106),
	[26] = new Cfg_c_condtione_Info(27,107,"ShopBuyCount",520107),
	[27] = new Cfg_c_condtione_Info(28,108,"UseAccelerateProps",520108),
	[28] = new Cfg_c_condtione_Info(29,109,"GetBuildItem",520109),
	[29] = new Cfg_c_condtione_Info(30,110,"GetBuildFood",520110),
	[30] = new Cfg_c_condtione_Info(31,111,"GetBuildMeat",520111),
	[31] = new Cfg_c_condtione_Info(32,112,"GetBuildWood",520112),
	[32] = new Cfg_c_condtione_Info(33,113,"GetBuildStone",520113),
	[33] = new Cfg_c_condtione_Info(34,114,"CardLevelUpCount",520114),
	[34] = new Cfg_c_condtione_Info(35,115,"BuildingLevelUpCount",520115),
	[35] = new Cfg_c_condtione_Info(36,116,"ShoppingCount",520116),
	[36] = new Cfg_c_condtione_Info(37,117,"ClearWasteland",520117),
	[37] = new Cfg_c_condtione_Info(38,118,"ShopShelvesBuyCount",520118),
	[38] = new Cfg_c_condtione_Info(39,119,"TotalBuildNums",520119),
	[39] = new Cfg_c_condtione_Info(40,120,"ChallengeTypePVP",520120),
	[40] = new Cfg_c_condtione_Info(41,201,"GlobalEraLevel",520201),
	[41] = new Cfg_c_condtione_Info(42,202,"GlobalClearWasteland",520202),
	[42] = new Cfg_c_condtione_Info(43,203,"GlobalLevelCompeteNums",520203),
	[43] = new Cfg_c_condtione_Info(44,204,"GlobalServerTimeAfterDay",520204),
	[44] = new Cfg_c_condtione_Info(45,301,"FirstRecharge",520301),
	[45] = new Cfg_c_condtione_Info(46,302,"DepositActivation",520302),
	[46] = new Cfg_c_condtione_Info(47,303,"",""),
	[47] = new Cfg_c_condtione_Info(48,304,"",""),
};
}
