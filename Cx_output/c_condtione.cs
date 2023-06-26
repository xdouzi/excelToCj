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
	[%!d(string=1)] = new Cfg_c_condtione_Info(1,1,"AccountLevel ",520001),
	[%!d(string=2)] = new Cfg_c_condtione_Info(2,2,"MainCityBuildLevel",520002),
	[%!d(string=3)] = new Cfg_c_condtione_Info(3,3,"TaskIdCompeteNums",520003),
	[%!d(string=4)] = new Cfg_c_condtione_Info(4,4,"LevelCompeteNums",520004),
	[%!d(string=5)] = new Cfg_c_condtione_Info(5,5,"VipLevel",520005),
	[%!d(string=6)] = new Cfg_c_condtione_Info(6,6,"EraLevel",520006),
	[%!d(string=7)] = new Cfg_c_condtione_Info(7,7,"HomeLevel",520007),
	[%!d(string=8)] = new Cfg_c_condtione_Info(8,8,"ServerTimeAfterDay",520008),
	[%!d(string=9)] = new Cfg_c_condtione_Info(9,9,"DataTimeStartToEnd",520009),
	[%!d(string=10)] = new Cfg_c_condtione_Info(10,10,"AccumulatedRecharge",520010),
	[%!d(string=11)] = new Cfg_c_condtione_Info(11,11,"TodayRecharge",520011),
	[%!d(string=12)] = new Cfg_c_condtione_Info(12,12,"ItemIdUseNums",520012),
	[%!d(string=13)] = new Cfg_c_condtione_Info(13,21,"CombatEffectiveness",520021),
	[%!d(string=14)] = new Cfg_c_condtione_Info(14,22,"TotelGetNumberOfCards",520022),
	[%!d(string=15)] = new Cfg_c_condtione_Info(15,23,"TotelGetNumberOfProps",520023),
	[%!d(string=16)] = new Cfg_c_condtione_Info(16,24,"TotelUseNumberOfProps",520024),
	[%!d(string=17)] = new Cfg_c_condtione_Info(17,25,"CardLevelUp",520025),
	[%!d(string=18)] = new Cfg_c_condtione_Info(18,26,"TaskIdClaimReward",520026),
	[%!d(string=19)] = new Cfg_c_condtione_Info(19,27,"ClearAssignClutter",520027),
	[%!d(string=20)] = new Cfg_c_condtione_Info(20,28,"RepairAssignBuilding",520028),
	[%!d(string=21)] = new Cfg_c_condtione_Info(21,101,"ChallengeBarrier",520101),
	[%!d(string=22)] = new Cfg_c_condtione_Info(22,102,"ChallengeLevelSubtype",520102),
	[%!d(string=23)] = new Cfg_c_condtione_Info(23,103,"ChallengePVP",520103),
	[%!d(string=24)] = new Cfg_c_condtione_Info(24,104,"LoginDay",520104),
	[%!d(string=25)] = new Cfg_c_condtione_Info(25,105,"GetMaterial",520105),
	[%!d(string=26)] = new Cfg_c_condtione_Info(26,106,"BuyFurniture",520106),
	[%!d(string=27)] = new Cfg_c_condtione_Info(27,107,"ShopBuyCount",520107),
	[%!d(string=28)] = new Cfg_c_condtione_Info(28,108,"UseAccelerateProps",520108),
	[%!d(string=29)] = new Cfg_c_condtione_Info(29,109,"GetBuildItem",520109),
	[%!d(string=30)] = new Cfg_c_condtione_Info(30,110,"GetBuildFood",520110),
	[%!d(string=31)] = new Cfg_c_condtione_Info(31,111,"GetBuildMeat",520111),
	[%!d(string=32)] = new Cfg_c_condtione_Info(32,112,"GetBuildWood",520112),
	[%!d(string=33)] = new Cfg_c_condtione_Info(33,113,"GetBuildStone",520113),
	[%!d(string=34)] = new Cfg_c_condtione_Info(34,114,"CardLevelUpCount",520114),
	[%!d(string=35)] = new Cfg_c_condtione_Info(35,115,"BuildingLevelUpCount",520115),
	[%!d(string=36)] = new Cfg_c_condtione_Info(36,116,"ShoppingCount",520116),
	[%!d(string=37)] = new Cfg_c_condtione_Info(37,117,"ClearWasteland",520117),
	[%!d(string=38)] = new Cfg_c_condtione_Info(38,118,"ShopShelvesBuyCount",520118),
	[%!d(string=39)] = new Cfg_c_condtione_Info(39,119,"TotalBuildNums",520119),
	[%!d(string=40)] = new Cfg_c_condtione_Info(40,120,"ChallengeTypePVP",520120),
	[%!d(string=41)] = new Cfg_c_condtione_Info(41,201,"GlobalEraLevel",520201),
	[%!d(string=42)] = new Cfg_c_condtione_Info(42,202,"GlobalClearWasteland",520202),
	[%!d(string=43)] = new Cfg_c_condtione_Info(43,203,"GlobalLevelCompeteNums",520203),
	[%!d(string=44)] = new Cfg_c_condtione_Info(44,204,"GlobalServerTimeAfterDay",520204),
	[%!d(string=45)] = new Cfg_c_condtione_Info(45,301,"FirstRecharge",520301),
	[%!d(string=46)] = new Cfg_c_condtione_Info(46,302,"DepositActivation",520302),
	[%!d(string=47)] = new Cfg_c_condtione_Info(47,303,"",),
	[%!d(string=48)] = new Cfg_c_condtione_Info(48,304,"",),
};
}
