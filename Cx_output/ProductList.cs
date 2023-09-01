using System.Collections.Generic;
public class Cfg_ProductList_Item
{
	public int id;//ID:1~999999
	public string key;//内购购买key
	public float pricel;//购买金额(美刀)
public Cfg_ProductList_Item(int id,string key,float pricel)
{
  this.id = id;
  this.key = key;
  this.pricel = pricel;
}
}
public class Cfg_ProductList
{
public static Dictionary<string,Cfg_ProductList_Item> list = new Dictionary<string,Cfg_ProductList_Item>()
{
	["0"] = new Cfg_ProductList_Item(0,"common.099",0.99f),
	["1"] = new Cfg_ProductList_Item(1,"common.199",1.99f),
	["2"] = new Cfg_ProductList_Item(2,"common.299",2.99f),
	["3"] = new Cfg_ProductList_Item(3,"common.399",3.99f),
	["4"] = new Cfg_ProductList_Item(4,"common.499",4.99f),
	["5"] = new Cfg_ProductList_Item(5,"common.599",5.99f),
	["6"] = new Cfg_ProductList_Item(6,"common.699",6.99f),
	["7"] = new Cfg_ProductList_Item(7,"common.799",7.99f),
	["8"] = new Cfg_ProductList_Item(8,"common.899",8.99f),
	["9"] = new Cfg_ProductList_Item(9,"common.999",9.99f),
	["10"] = new Cfg_ProductList_Item(10,"common.1099",10.99f),
	["11"] = new Cfg_ProductList_Item(11,"common.1199",11.99f),
	["12"] = new Cfg_ProductList_Item(12,"common.1299",12.99f),
	["13"] = new Cfg_ProductList_Item(13,"common.1399",13.99f),
	["14"] = new Cfg_ProductList_Item(14,"common.1499",14.99f),
	["15"] = new Cfg_ProductList_Item(15,"common.1599",15.99f),
	["16"] = new Cfg_ProductList_Item(16,"common.1699",16.99f),
	["17"] = new Cfg_ProductList_Item(17,"common.1799",17.99f),
	["18"] = new Cfg_ProductList_Item(18,"common.1899",18.99f),
	["19"] = new Cfg_ProductList_Item(19,"common.1999",19.99f),
	["20"] = new Cfg_ProductList_Item(20,"common.2099",20.99f),
	["21"] = new Cfg_ProductList_Item(21,"common.2199",21.99f),
	["22"] = new Cfg_ProductList_Item(22,"common.2299",22.99f),
	["23"] = new Cfg_ProductList_Item(23,"common.2399",23.99f),
	["24"] = new Cfg_ProductList_Item(24,"common.2499",24.99f),
	["25"] = new Cfg_ProductList_Item(25,"common.2599",25.99f),
	["26"] = new Cfg_ProductList_Item(26,"common.2699",26.99f),
	["27"] = new Cfg_ProductList_Item(27,"common.2799",27.99f),
	["28"] = new Cfg_ProductList_Item(28,"common.2899",28.99f),
	["29"] = new Cfg_ProductList_Item(29,"common.2999",29.99f),
	["30"] = new Cfg_ProductList_Item(30,"common.3099",30.99f),
	["31"] = new Cfg_ProductList_Item(31,"common.3199",31.99f),
	["32"] = new Cfg_ProductList_Item(32,"common.3299",32.99f),
	["33"] = new Cfg_ProductList_Item(33,"common.3399",33.99f),
	["34"] = new Cfg_ProductList_Item(34,"common.3499",34.99f),
	["35"] = new Cfg_ProductList_Item(35,"common.3599",35.99f),
	["36"] = new Cfg_ProductList_Item(36,"common.3699",36.99f),
	["37"] = new Cfg_ProductList_Item(37,"common.3799",37.99f),
	["38"] = new Cfg_ProductList_Item(38,"common.3899",38.99f),
	["39"] = new Cfg_ProductList_Item(39,"common.3999",39.99f),
	["40"] = new Cfg_ProductList_Item(40,"common.4099",40.99f),
	["41"] = new Cfg_ProductList_Item(41,"common.4199",41.99f),
	["42"] = new Cfg_ProductList_Item(42,"common.4299",42.99f),
	["43"] = new Cfg_ProductList_Item(43,"common.4399",43.99f),
	["44"] = new Cfg_ProductList_Item(44,"common.4499",44.99f),
	["45"] = new Cfg_ProductList_Item(45,"common.4599",45.99f),
	["46"] = new Cfg_ProductList_Item(46,"common.4699",46.99f),
	["47"] = new Cfg_ProductList_Item(47,"common.4799",47.99f),
	["48"] = new Cfg_ProductList_Item(48,"common.4899",48.99f),
	["49"] = new Cfg_ProductList_Item(49,"common.4999",49.99f),
	["50"] = new Cfg_ProductList_Item(50,"common.5099",50.99f),
	["51"] = new Cfg_ProductList_Item(51,"common.5199",51.99f),
	["52"] = new Cfg_ProductList_Item(52,"common.5299",52.99f),
	["53"] = new Cfg_ProductList_Item(53,"common.5399",53.99f),
	["54"] = new Cfg_ProductList_Item(54,"common.5499",54.99f),
	["55"] = new Cfg_ProductList_Item(55,"common.5599",55.99f),
	["56"] = new Cfg_ProductList_Item(56,"common.5699",56.99f),
	["57"] = new Cfg_ProductList_Item(57,"common.5799",57.99f),
	["58"] = new Cfg_ProductList_Item(58,"common.5899",58.99f),
	["59"] = new Cfg_ProductList_Item(59,"common.5999",59.99f),
	["60"] = new Cfg_ProductList_Item(60,"common.6099",60.99f),
	["61"] = new Cfg_ProductList_Item(61,"common.6199",61.99f),
	["62"] = new Cfg_ProductList_Item(62,"common.6299",62.99f),
	["63"] = new Cfg_ProductList_Item(63,"common.6399",63.99f),
	["64"] = new Cfg_ProductList_Item(64,"common.6499",64.99f),
	["65"] = new Cfg_ProductList_Item(65,"common.6599",65.99f),
	["66"] = new Cfg_ProductList_Item(66,"common.6699",66.99f),
	["67"] = new Cfg_ProductList_Item(67,"common.6799",67.99f),
	["68"] = new Cfg_ProductList_Item(68,"common.6899",68.99f),
	["69"] = new Cfg_ProductList_Item(69,"common.6999",69.99f),
	["70"] = new Cfg_ProductList_Item(70,"common.7099",70.99f),
};
}
