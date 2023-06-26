using System.Collections.Generic;
public class t_dress_sInfo
{
public int id;
public int a_base_dress_id;
public int a_base_initial;
public int c_base_name;
public int c_base_mark;
public string a_ints_activate;
public t_dress_sInfo(int id,int a_base_dress_id,int a_base_initial,int c_base_name,int c_base_mark,string a_ints_activate)
{
  this.id = id;
  this.a_base_dress_id = a_base_dress_id;
  this.a_base_initial = a_base_initial;
  this.c_base_name = c_base_name;
  this.c_base_mark = c_base_mark;
  this.a_ints_activate = a_ints_activate;
}
}
public class Cfg_t_dress_s
{
public static List<t_dress_sInfo> list = new List<t_dress_sInfo>()
{
	[0] = new t_dress_sInfo(1,1001,1,544001,1,""),
	[1] = new t_dress_sInfo(2,1002,0,544002,2,"-1,1"),
	[2] = new t_dress_sInfo(3,1003,0,544003,3,"1001,1"),
	[3] = new t_dress_sInfo(4,1004,0,544004,4,"-101,1"),
};
}
