using System.Collections.Generic;
public class roleInfoItem
{
	public int id;//ID:1~999999
	public string name;//角色名
	public string model;//模型配置路径
	public string icon;//图标名
	public int hp;//初始血量
	public int roundSpeed;//转身速度
	public float walkSpeed;//行走速度
	public int runSpeed;//跑步速度
public roleInfoItem(int id,string name,string model,string icon,int hp,int roundSpeed,float walkSpeed,int runSpeed)
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
public class cfg_roleInfo
{
public static Dictionary<string,roleInfoItem> list = new Dictionary<string,roleInfoItem>()
{
	["1"] = new roleInfoItem(1,"任务","","46_11100033",100,10,0.8f,2),
	["2"] = new roleInfoItem(2,"时间","Fighter","46_11100033",100,10,0.8f,2),
	["3"] = new roleInfoItem(3,"第A点","Fighter","46_11100033",100,10,0.8f,2),
	["200"] = new roleInfoItem(200,"wawa","Fighter","46_11100033",0,0,0f,0),
	["300"] = new roleInfoItem(300,"biuniu","Fighter","46_11100033",0,0,0f,0),
	["55"] = new roleInfoItem(55,"","","",0,0,0.8f,0),
};
}
