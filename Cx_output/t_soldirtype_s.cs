using System.Collections.Generic;
public class t_soldirtype_sInfo
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
public t_soldirtype_sInfo(int id,int a_base_send_soldier_id,int a_base_send_soldier_type,int a_base_synthesis_num,int a_base_synthesis_numMax,int a_base_soldier_star,int a_base_soldier_probability,int a_base_starlevel_num,int a_base_buff)
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
public static List<t_soldirtype_sInfo> list = new List<t_soldirtype_sInfo>()
{
	[0] = new t_soldirtype_sInfo(1,101,1,1,1,1,10000,0,0),
	[1] = new t_soldirtype_sInfo(2,201,2,1,3,1,3000,0,210),
	[2] = new t_soldirtype_sInfo(3,202,2,2,3,1,5000,3,220),
	[3] = new t_soldirtype_sInfo(4,203,2,3,3,1,10000,3,230),
	[4] = new t_soldirtype_sInfo(5,301,3,1,5,1,0,0,210),
	[5] = new t_soldirtype_sInfo(6,302,3,2,5,1,0,3,210),
	[6] = new t_soldirtype_sInfo(7,303,3,3,5,1,10000,3,210),
	[7] = new t_soldirtype_sInfo(8,304,3,4,5,2,10000,3,220),
	[8] = new t_soldirtype_sInfo(9,305,3,5,5,3,10000,3,230),
};
}
