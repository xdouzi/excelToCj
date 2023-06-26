using System.Collections.Generic;
public class t_seglevel_sInfo
{
public int a_base_key_id;
public int a_base_seglevelconfig_id;
public int a_base_ear;
public int a_base_mode;
public int a_base_seglevel;
public string a_ints_score_range;
public int c_base_iconres;
public t_seglevel_sInfo(int a_base_key_id,int a_base_seglevelconfig_id,int a_base_ear,int a_base_mode,int a_base_seglevel,string a_ints_score_range,int c_base_iconres)
{
  this.a_base_key_id = a_base_key_id;
  this.a_base_seglevelconfig_id = a_base_seglevelconfig_id;
  this.a_base_ear = a_base_ear;
  this.a_base_mode = a_base_mode;
  this.a_base_seglevel = a_base_seglevel;
  this.a_ints_score_range = a_ints_score_range;
  this.c_base_iconres = c_base_iconres;
}
}
public class Cfg_t_seglevel_s
{
public static List<t_seglevel_sInfo> list = new List<t_seglevel_sInfo>()
{
	[0] = new t_seglevel_sInfo(1,1,1,1,1,"0,500",50001),
};
}
