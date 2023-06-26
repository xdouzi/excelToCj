using System.Collections.Generic;
public class t_attribute_show_sInfo
{
public int id;
public int a_base_attribute_id;
public string a_base_operater_id;
public int c_base_name;
public int c_base_tips;
public int a_base_show_type;
public string c_base_attribute_icon;
public int c_base_attribute_suffix;
public int c_base_attribute_add;
public int a_base_type;
public string a_ints_item_parameter;
public t_attribute_show_sInfo(int id,int a_base_attribute_id,string a_base_operater_id,int c_base_name,int c_base_tips,int a_base_show_type,string c_base_attribute_icon,int c_base_attribute_suffix,int c_base_attribute_add,int a_base_type,string a_ints_item_parameter)
{
  this.id = id;
  this.a_base_attribute_id = a_base_attribute_id;
  this.a_base_operater_id = a_base_operater_id;
  this.c_base_name = c_base_name;
  this.c_base_tips = c_base_tips;
  this.a_base_show_type = a_base_show_type;
  this.c_base_attribute_icon = c_base_attribute_icon;
  this.c_base_attribute_suffix = c_base_attribute_suffix;
  this.c_base_attribute_add = c_base_attribute_add;
  this.a_base_type = a_base_type;
  this.a_ints_item_parameter = a_ints_item_parameter;
}
}
public class Cfg_t_attribute_show_s
{
public static List<t_attribute_show_sInfo> list = new List<t_attribute_show_sInfo>()
{
	[0] = new t_attribute_show_sInfo(1,1,"0",1001,1011,,"icon1",,,0,""),
	[1] = new t_attribute_show_sInfo(2,2,"0",1002,1011,,"icon2",,,0,""),
	[2] = new t_attribute_show_sInfo(3,3,"0",1003,1011,,"icon3",,1,0,""),
	[3] = new t_attribute_show_sInfo(4,4,"0",1004,1011,,"icon4",,0,0,""),
	[4] = new t_attribute_show_sInfo(5,5,"0",101,1011,,"icon5",,,0,""),
	[5] = new t_attribute_show_sInfo(6,6,"0",101,1011,,"icon6",,,0,""),
	[6] = new t_attribute_show_sInfo(7,7,"0",101,1011,,"icon7",,,0,""),
	[7] = new t_attribute_show_sInfo(8,8,"0",101,1011,,"icon8",,,0,""),
	[8] = new t_attribute_show_sInfo(9,9,"0",101,1011,,"icon9",,,0,""),
	[9] = new t_attribute_show_sInfo(10,10,"0",101,1011,,"icon10",,,0,""),
	[10] = new t_attribute_show_sInfo(11,11,"0",101,1011,,"icon11",,,0,""),
	[11] = new t_attribute_show_sInfo(12,12,"0",101,1011,,"icon12",,,0,""),
	[12] = new t_attribute_show_sInfo(13,13,"0",101,1011,,"icon13",,,0,""),
	[13] = new t_attribute_show_sInfo(14,14,"0",101,1011,,"icon14",,,0,""),
	[14] = new t_attribute_show_sInfo(15,15,"0",101,1011,,"icon15",,,0,""),
	[15] = new t_attribute_show_sInfo(16,20,"0",1020,1011,,"icon20",,1,0,""),
};
}
