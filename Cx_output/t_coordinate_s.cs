using System.Collections.Generic;
public class t_coordinate_sInfo
{
public int id;
public int a_base_coordinatee_id;
public string a_arrayints_init_value;
public t_coordinate_sInfo(int id,int a_base_save_id,int a_base_eliminate_effect_id,int c_base_color_id,int c_base_era_effect,int a_base_dispel_type,string c_arrayints_combinationeffect1_id,string c_arrayints_combinationeffect2_id,string c_arrayints_combinationeffect3_id,string c_ints_effect2_playtime,string c_ints_effect2_flytime,string c_ints_effect3_playtime,int c_base_effectend_playtimeint id,int a_base_coordinatee_id,string a_arrayints_init_value)
{
  this.id = id;
  this.a_base_coordinatee_id = a_base_coordinatee_id;
  this.a_arrayints_init_value = a_arrayints_init_value;
}
}
public class Cfg_t_coordinate_s
{
public static List<t_coordinate_sInfo> list = new List<t_coordinate_sInfo>()
{
	[0] = new t_coordinate_sInfo(1,1,"0"),
	[1] = new t_coordinate_sInfo(2,2,"-6,-5,-4,-3,-2,-1,0,1,2,3,4,5,6"),
	[2] = new t_coordinate_sInfo(3,3,"-101,-100,-99,-1,0,1,99,100,101"),
	[3] = new t_coordinate_sInfo(4,4,"0,100,200,300,400,-100,-200,-300,-400"),
	[4] = new t_coordinate_sInfo(5,5,"-200,-101,-100,-99,-2,-1,0,1,2,99,100,101,200"),
	[5] = new t_coordinate_sInfo(6,6,"0,1,2,3,4,5,6,-1,-2,-3,-4,-5,-6,100,200,300,400,-100,-200,-300,-400"),
	[6] = new t_coordinate_sInfo(7,7,"0,1,2,3,4,5,6,-1,-2,-3,-4,-5,-6,94,95,96,97,98,99,100,101,102,103,104,105,106,-94,-95,-96,-97,-98,-99,-100,-101,-102,-103,-104,-105,-106"),
	[7] = new t_coordinate_sInfo(8,8,"-100,-1,0,1,100"),
};
}