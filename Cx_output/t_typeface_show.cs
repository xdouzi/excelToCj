using System.Collections.Generic;
public class Cfg_t_typeface_show_Info
{
public int id;
public int a_base_show_id;
public string a_base_typeface;
public string a_base_point;
public int a_base_speed;
public int a_base_time;
public Cfg_t_typeface_show_Info(int id,int a_base_show_id,string a_base_typeface,string a_base_point,int a_base_speed,int a_base_time)
{
  this.id = id;
  this.a_base_show_id = a_base_show_id;
  this.a_base_typeface = a_base_typeface;
  this.a_base_point = a_base_point;
  this.a_base_speed = a_base_speed;
  this.a_base_time = a_base_time;
}
}
public class Cfg_t_typeface_show
{
public static List<Cfg_t_typeface_show_Info> list = new List<Cfg_t_typeface_show_Info>()
{
	[0] = new Cfg_t_typeface_show_Info(1,-1,"","","",""),
	[1] = new Cfg_t_typeface_show_Info(2,1,"","","",""),
	[2] = new Cfg_t_typeface_show_Info(3,2,"","","",""),
};
}
