using System.Collections.Generic;
public class t_head_sInfo
{
public int id;
public int a_base_head_id;
public int a_base_group;
public int a_base_initial;
public int c_base_name;
public int c_base_desc;
public t_head_sInfo(int id,int a_base_border_id,int a_base_initial,int c_base_name,int c_base_descint id,int a_base_head_id,int a_base_group,int a_base_initial,int c_base_name,int c_base_desc)
{
  this.id = id;
  this.a_base_head_id = a_base_head_id;
  this.a_base_group = a_base_group;
  this.a_base_initial = a_base_initial;
  this.c_base_name = c_base_name;
  this.c_base_desc = c_base_desc;
}
}
public class Cfg_t_head_s
{
public static List<t_head_sInfo> list = new List<t_head_sInfo>()
{
	[0] = new t_head_sInfo(1,1001,0,1,540001,541001),
	[1] = new t_head_sInfo(2,2001,0,1,540002,541002),
	[2] = new t_head_sInfo(3,3001,21110,0,540003,541003),
};
}
