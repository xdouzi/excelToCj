using System.Collections.Generic;
public class Cfg_t_soldirtype_s_Info
{
	public int id;
	public int a_base_send_soldier_id;
	public int a_base_send_soldier_type;
	public int a_base_synthesis_num;
	public int a_base_synthesis_numMax;
	public int a_base_soldier_star;
	public int a_base_soldier_probability;
	public int a_base_starlevel_num;
	public int a_base_buff;
public Cfg_t_soldirtype_s_Info(int id,int a_base_send_soldier_id,int a_base_send_soldier_type,int a_base_synthesis_num,int a_base_synthesis_numMax,int a_base_soldier_star,int a_base_soldier_probability,int a_base_starlevel_num,int a_base_buff)
{
  this.id = id;
  this.a_base_send_soldier_id = a_base_send_soldier_id;
  this.a_base_send_soldier_type = a_base_send_soldier_type;
  this.a_base_synthesis_num = a_base_synthesis_num;
  this.a_base_synthesis_numMax = a_base_synthesis_numMax;
  this.a_base_soldier_star = a_base_soldier_star;
  this.a_base_soldier_probability = a_base_soldier_probability;
  this.a_base_starlevel_num = a_base_starlevel_num;
  this.a_base_buff = a_base_buff;
}
}
public class Cfg_t_soldirtype_s
{
public static List<Cfg_t_soldirtype_s_Info> list = new List<Cfg_t_soldirtype_s_Info>()
{
	[%!d(string=1)] = new Cfg_t_soldirtype_s_Info(1,101,1,1,1,1,10000,0,),
	[%!d(string=2)] = new Cfg_t_soldirtype_s_Info(2,201,2,1,3,1,3000,0,210),
	[%!d(string=3)] = new Cfg_t_soldirtype_s_Info(3,202,2,2,3,1,5000,3,220),
	[%!d(string=4)] = new Cfg_t_soldirtype_s_Info(4,203,2,3,3,1,10000,3,230),
	[%!d(string=5)] = new Cfg_t_soldirtype_s_Info(5,301,3,1,5,1,0,0,210),
	[%!d(string=6)] = new Cfg_t_soldirtype_s_Info(6,302,3,2,5,1,0,3,210),
	[%!d(string=7)] = new Cfg_t_soldirtype_s_Info(7,303,3,3,5,1,10000,3,210),
	[%!d(string=8)] = new Cfg_t_soldirtype_s_Info(8,304,3,4,5,2,10000,3,220),
	[%!d(string=9)] = new Cfg_t_soldirtype_s_Info(9,305,3,5,5,3,10000,3,230),
};
}
