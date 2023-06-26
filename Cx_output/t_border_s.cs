using System.Collections.Generic;
public class t_border_sInfo
{
public int id;
public int a_base_border_id;
public int a_base_initial;
public int c_base_name;
public int c_base_desc;
public t_border_sInfo(int id,int a_base_border_id,int a_base_initial,int c_base_name,int c_base_desc)
{
  this.id = id;
  this.a_base_border_id = a_base_border_id;
  this.a_base_initial = a_base_initial;
  this.c_base_name = c_base_name;
  this.c_base_desc = c_base_desc;
}
}
public class Cfg_t_border_s
{
public static List<t_border_sInfo> list = new List<t_border_sInfo>()
{
	[0] = new t_border_sInfo(1,7001,1,542001,543001),
	[1] = new t_border_sInfo(2,7002,0,542002,543002),
	[2] = new t_border_sInfo(3,7003,0,542003,543003),
};
}
