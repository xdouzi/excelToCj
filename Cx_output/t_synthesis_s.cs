using System.Collections.Generic;
public class Cfg_t_synthesis_s_Info
{
	public int id;
	public int a_base_synthesis_id;
	public string a_base_operater_id;
	public string a_arrayints_material;
	public string a_ints_deplete_currency;
	public string a_arrayints_use_condition;
public Cfg_t_synthesis_s_Info(int id,int a_base_synthesis_id,string a_base_operater_id,string a_arrayints_material,string a_ints_deplete_currency,string a_arrayints_use_condition)
{
  this.id = id;
  this.a_base_synthesis_id = a_base_synthesis_id;
  this.a_base_operater_id = a_base_operater_id;
  this.a_arrayints_material = a_arrayints_material;
  this.a_ints_deplete_currency = a_ints_deplete_currency;
  this.a_arrayints_use_condition = a_arrayints_use_condition;
}
}
public class Cfg_t_synthesis_s
{
public static List<Cfg_t_synthesis_s_Info> list = new List<Cfg_t_synthesis_s_Info>()
{
	[%!d(string=1)] = new Cfg_t_synthesis_s_Info(1,3001,"","-101,1000;-102,2000","-2,20000","2,14,1"),
	[%!d(string=2)] = new Cfg_t_synthesis_s_Info(2,3002,"","-103,2000;-104,4000","-2,20000","2,14,3"),
	[%!d(string=3)] = new Cfg_t_synthesis_s_Info(3,3003,"","-101,2000;-103,4000","-2,20000","2,14,5"),
	[%!d(string=4)] = new Cfg_t_synthesis_s_Info(4,3004,"","-102,1200;-103,2400","-2,20000","2,14,7"),
	[%!d(string=5)] = new Cfg_t_synthesis_s_Info(5,3005,"","3001,5;3004,10","-2,40000","2,14,9"),
	[%!d(string=6)] = new Cfg_t_synthesis_s_Info(6,3006,"","-103,40000;3005,15","-2,80000","2,14,11"),
};
}
