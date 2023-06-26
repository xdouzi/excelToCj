using System.Collections.Generic;
public class Cfg_t_gender_s_Info
{
	public int id;
	public int a_base_gender_id;
	public int a_base_dress_id;
	public int a_base_gender;
	public int c_base_model;
	public string c_vector3_position;
	public string c_vector3_scale;
public Cfg_t_gender_s_Info(int id,int a_base_dress_id,int a_base_initial,int c_base_name,int c_base_mark,string a_ints_activateint id,int a_base_gender_id,int a_base_dress_id,int a_base_gender,int c_base_model,string c_vector3_position,string c_vector3_scale)
{
  this.id = id;
  this.a_base_gender_id = a_base_gender_id;
  this.a_base_dress_id = a_base_dress_id;
  this.a_base_gender = a_base_gender;
  this.c_base_model = c_base_model;
  this.c_vector3_position = c_vector3_position;
  this.c_vector3_scale = c_vector3_scale;
}
}
public class Cfg_t_gender_s
{
public static List<Cfg_t_gender_s_Info> list = new List<Cfg_t_gender_s_Info>()
{
	[0] = new Cfg_t_gender_s_Info(1,10010,1001,0,50002,"0,-1.05,5","250,250,250"),
	[1] = new Cfg_t_gender_s_Info(2,10011,1001,1,50001,"0,-1.05,5","250,250,250"),
	[2] = new Cfg_t_gender_s_Info(3,10020,1002,0,50000001,"0,-1.1,6.6","2.5,2.5,2.5"),
	[3] = new Cfg_t_gender_s_Info(4,10021,1002,1,50000002,"0,-1.19,7.5","1.1,1.1,1.1"),
	[4] = new Cfg_t_gender_s_Info(5,10030,1003,0,50000003,"0,-1.25,6.75","1.9,1.9,1.9"),
	[5] = new Cfg_t_gender_s_Info(6,10031,1003,1,50000004,"0,-1.15,5.75","3.2,3.2,3.2"),
	[6] = new Cfg_t_gender_s_Info(7,10040,1004,0,50000005,"0,0,6","2,2,2"),
	[7] = new Cfg_t_gender_s_Info(8,10041,1004,1,46000004,"0,-1.14,5.67","2.85,2.85,2.85"),
};
}
