using System.Collections.Generic;
public class Cfg_roleInfo_Info
{
	public int id;
	public string name;
	public string model;
	public string icon;
	public int hp;
	public int roundSpeed;
	public float walkSpeed;
	public int runSpeed;
public Cfg_roleInfo_Info(int id,string name,string model,string icon,int hp,int roundSpeed,float walkSpeed,int runSpeed)
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
public class Cfg_roleInfo
{
public static Dictionary<string,Cfg_roleInfo_Info> list = new Dictionary<string,Cfg_roleInfo_Info>()
{
	["1"] = new Cfg_roleInfo_Info(1,"任务","","46_11100033",100,10,0.8f,2),
	["2"] = new Cfg_roleInfo_Info(2,"时间","Fighter","46_11100033",100,10,0.8f,2),
	["3"] = new Cfg_roleInfo_Info(3,"第A点","Fighter","46_11100033",100,10,0.8f,2),
	["200"] = new Cfg_roleInfo_Info(200,"wawa","Fighter","46_11100033",,,,),
	["300"] = new Cfg_roleInfo_Info(300,"biuniu","Fighter","46_11100033",,,,),
};
}
