using System.Collections.Generic;
public class t_synthesis_sInfo
{
public int id;
public int a_base_synthesis_id;
public string a_base_operater_id;
public string a_arrayints_material;
public string a_ints_deplete_currency;
public string a_arrayints_use_condition;
public t_synthesis_sInfo(int id,int a_base_synthesis_id,string a_base_operater_id,string a_arrayints_material,string a_ints_deplete_currency,string a_arrayints_use_condition)
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
public static List<t_synthesis_sInfo> list = new List<t_synthesis_sInfo>()
{
	[0] = new t_synthesis_sInfo(1,3001,"","-101,1000;-102,2000","-2,20000","2,14,1"),
	[1] = new t_synthesis_sInfo(2,3002,"","-103,2000;-104,4000","-2,20000","2,14,3"),
	[2] = new t_synthesis_sInfo(3,3003,"","-101,2000;-103,4000","-2,20000","2,14,5"),
	[3] = new t_synthesis_sInfo(4,3004,"","-102,1200;-103,2400","-2,20000","2,14,7"),
	[4] = new t_synthesis_sInfo(5,3005,"","3001,5;3004,10","-2,40000","2,14,9"),
	[5] = new t_synthesis_sInfo(6,3006,"","-103,40000;3005,15","-2,80000","2,14,11"),
};
}
