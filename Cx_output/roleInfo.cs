using System.Collections.Generic;
public class Cfg_RoleInfo_Item
{
	public int id;//ID:1~999999
	public string name;//角色名
	public string model;//模型配置路径
	public string icon;//图标名
	public int hp;//初始血量
	public int roundSpeed;//转身速度
	public float walkSpeed;//行走速度
	public int runSpeed;//跑步速度
public Cfg_RoleInfo_Item(int id,string name,string model,string icon,int hp,int roundSpeed,float walkSpeed,int runSpeed)
{
  this.id = id;
  this.name = name;
  this.model = model;
  this.icon = icon;
  this.hp = hp;
  this.roundSpeed = roundSpeed;
  this.walkSpeed = walkSpeed;
  this.runSpeed = runSpeed;
}
}
public class Cfg_RoleInfo
{
public static Dictionary<string,Cfg_RoleInfo_Item> list = new Dictionary<string,Cfg_RoleInfo_Item>()
{
	["1"] = new Cfg_RoleInfo_Item(1,"任务","","46_11100033",100,10,0.8f,2),
	["2"] = new Cfg_RoleInfo_Item(2,"时间","Fighter","46_11100033",100,10,0.8f,2),
	["3"] = new Cfg_RoleInfo_Item(3,"第A点","Fighter","46_11100033",100,10,0.8f,2),
	["200"] = new Cfg_RoleInfo_Item(200,"wawa","Fighter","46_11100033",0,0,0f,0),
	["300"] = new Cfg_RoleInfo_Item(300,"biuniu","Fighter","46_11100033",0,0,0f,0),
	["55"] = new Cfg_RoleInfo_Item(55,"","","",0,0,0.8f,0),
};
}
