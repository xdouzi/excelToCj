using System.Collections.Generic;
public class Cfg_t_attribute_show_s_Info
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
public Cfg_t_attribute_show_s_Info(int id,int a_base_attribute_id,string a_base_operater_id,int c_base_name,int c_base_tips,int a_base_show_type,string c_base_attribute_icon,int c_base_attribute_suffix,int c_base_attribute_add,int a_base_type,string a_ints_item_parameter)
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
public static List<Cfg_t_attribute_show_s_Info> list = new List<Cfg_t_attribute_show_s_Info>()
{
	[0] = new Cfg_t_attribute_show_s_Info(1,1,"0",1001,1011,,"icon1",,,0,""),
	[1] = new Cfg_t_attribute_show_s_Info(2,2,"0",1002,1011,,"icon2",,,0,""),
	[2] = new Cfg_t_attribute_show_s_Info(3,3,"0",1003,1011,,"icon3",,1,0,""),
	[3] = new Cfg_t_attribute_show_s_Info(4,4,"0",1004,1011,,"icon4",,0,0,""),
	[4] = new Cfg_t_attribute_show_s_Info(5,5,"0",101,1011,,"icon5",,,0,""),
	[5] = new Cfg_t_attribute_show_s_Info(6,6,"0",101,1011,,"icon6",,,0,""),
	[6] = new Cfg_t_attribute_show_s_Info(7,7,"0",101,1011,,"icon7",,,0,""),
	[7] = new Cfg_t_attribute_show_s_Info(8,8,"0",101,1011,,"icon8",,,0,""),
	[8] = new Cfg_t_attribute_show_s_Info(9,9,"0",101,1011,,"icon9",,,0,""),
	[9] = new Cfg_t_attribute_show_s_Info(10,10,"0",101,1011,,"icon10",,,0,""),
	[10] = new Cfg_t_attribute_show_s_Info(11,11,"0",101,1011,,"icon11",,,0,""),
	[11] = new Cfg_t_attribute_show_s_Info(12,12,"0",101,1011,,"icon12",,,0,""),
	[12] = new Cfg_t_attribute_show_s_Info(13,13,"0",101,1011,,"icon13",,,0,""),
	[13] = new Cfg_t_attribute_show_s_Info(14,14,"0",101,1011,,"icon14",,,0,""),
	[14] = new Cfg_t_attribute_show_s_Info(15,15,"0",101,1011,,"icon15",,,0,""),
	[15] = new Cfg_t_attribute_show_s_Info(16,20,"0",1020,1011,,"icon20",,1,0,""),
	[16] = new Cfg_t_attribute_show_s_Info(17,21,"0",1021,1011,,"icon21",22001,1,0,""),
	[17] = new Cfg_t_attribute_show_s_Info(18,22,"0",1022,1011,,"icon22",,1,0,""),
	[18] = new Cfg_t_attribute_show_s_Info(19,23,"0",1023,1011,,"icon23",,1,0,""),
	[19] = new Cfg_t_attribute_show_s_Info(20,24,"0",1024,1011,,"icon24",,0,0,""),
	[20] = new Cfg_t_attribute_show_s_Info(21,25,"0",1025,1011,,"icon25",,0,0,""),
	[21] = new Cfg_t_attribute_show_s_Info(22,26,"0",1026,1011,,"icon26",,0,0,""),
	[22] = new Cfg_t_attribute_show_s_Info(23,27,"0",1027,1011,,"icon27",,1,0,""),
	[23] = new Cfg_t_attribute_show_s_Info(24,28,"0",1028,1011,,"icon28",,1,0,""),
	[24] = new Cfg_t_attribute_show_s_Info(25,29,"0",1029,1011,,"icon29",22001,0,0,""),
	[25] = new Cfg_t_attribute_show_s_Info(26,30,"0",1030,1011,,"icon30",22002,1,0,""),
	[26] = new Cfg_t_attribute_show_s_Info(27,31,"0",1031,1011,,"icon31",22001,1,0,""),
	[27] = new Cfg_t_attribute_show_s_Info(28,32,"0",1032,1011,,"icon32",22003,0,0,""),
	[28] = new Cfg_t_attribute_show_s_Info(29,33,"0",1033,1011,,"icon33",,0,0,""),
	[29] = new Cfg_t_attribute_show_s_Info(30,34,"0",1034,1011,,"icon34",,1,0,""),
	[30] = new Cfg_t_attribute_show_s_Info(31,35,"0",1035,1011,,"icon35",,1,0,""),
	[31] = new Cfg_t_attribute_show_s_Info(32,36,"0",1036,1011,,"icon36",,0,0,""),
	[32] = new Cfg_t_attribute_show_s_Info(33,37,"0",1037,1011,,"icon37",22001,0,0,""),
	[33] = new Cfg_t_attribute_show_s_Info(34,38,"0",1038,1011,,"icon38",,1,0,""),
	[34] = new Cfg_t_attribute_show_s_Info(35,40,"0",1040,1011,,"icon40",,0,0,""),
	[35] = new Cfg_t_attribute_show_s_Info(36,41,"0",1041,1011,,"icon41",22003,0,0,""),
	[36] = new Cfg_t_attribute_show_s_Info(37,42,"0",1042,1011,,"icon42",22003,0,0,""),
	[37] = new Cfg_t_attribute_show_s_Info(38,43,"0",1043,1011,,"icon43",22003,0,0,""),
	[38] = new Cfg_t_attribute_show_s_Info(39,44,"0",1044,1011,,"icon44",22003,0,0,""),
	[39] = new Cfg_t_attribute_show_s_Info(40,45,"0",1045,1011,,"icon45",22003,0,0,""),
	[40] = new Cfg_t_attribute_show_s_Info(41,46,"0",1046,1011,,"icon46",,1,0,""),
	[41] = new Cfg_t_attribute_show_s_Info(42,47,"0",1047,1011,,"icon47",22001,0,0,""),
	[42] = new Cfg_t_attribute_show_s_Info(43,48,"0",1048,1011,,"icon48",,1,0,""),
	[43] = new Cfg_t_attribute_show_s_Info(44,49,"0",1049,1011,,"icon49",22003,0,0,""),
	[44] = new Cfg_t_attribute_show_s_Info(45,50,"0",1050,1011,,"icon50",22003,0,0,""),
	[45] = new Cfg_t_attribute_show_s_Info(46,51,"0",1051,1011,,"icon51",22003,0,0,""),
	[46] = new Cfg_t_attribute_show_s_Info(47,52,"0",1052,1011,,"icon52",22001,0,0,""),
	[47] = new Cfg_t_attribute_show_s_Info(48,53,"0",1053,1011,,"icon53",22003,0,0,""),
	[48] = new Cfg_t_attribute_show_s_Info(49,54,"0",1054,1011,,"icon54",,0,0,""),
	[49] = new Cfg_t_attribute_show_s_Info(50,100,"0",,,,"",,,0,""),
	[50] = new Cfg_t_attribute_show_s_Info(51,200,"0",,,,"",,,0,""),
	[51] = new Cfg_t_attribute_show_s_Info(52,306,"0",,,,"",,,0,""),
	[52] = new Cfg_t_attribute_show_s_Info(53,308,"0",,,,"",,,0,""),
	[53] = new Cfg_t_attribute_show_s_Info(54,309,"0",,,,"",,,0,""),
	[54] = new Cfg_t_attribute_show_s_Info(55,1001,"0",1101,1011,1,"icon26",,,0,""),
	[55] = new Cfg_t_attribute_show_s_Info(56,2001,"0",1102,1011,1,"icon29",,,1,"-2,60,86400"),
	[56] = new Cfg_t_attribute_show_s_Info(57,2002,"0",1103,1011,1,"icon30",,,1,"-101,60,86400"),
	[57] = new Cfg_t_attribute_show_s_Info(58,2003,"0",1104,1011,1,"icon31",,,1,"-102,60,86400"),
	[58] = new Cfg_t_attribute_show_s_Info(59,2004,"0",1105,1011,1,"icon32",,,1,"-103,60,86400"),
	[59] = new Cfg_t_attribute_show_s_Info(60,2005,"0",1106,1011,1,"icon33",,,1,"-104,60,86400"),
	[60] = new Cfg_t_attribute_show_s_Info(61,2006,"0",1107,1011,1,"icon34",,,2,"-3,300,720000"),
	[61] = new Cfg_t_attribute_show_s_Info(62,3000,"0",1108,1011,1,"icon34",,,3,"-2,0,0"),
	[62] = new Cfg_t_attribute_show_s_Info(63,3001,"0",1109,1011,1,"icon35",,,3,"-101,0,0"),
	[63] = new Cfg_t_attribute_show_s_Info(64,3002,"0",1110,1011,1,"icon36",,,3,"-102,0,0"),
	[64] = new Cfg_t_attribute_show_s_Info(65,3003,"0",1111,1011,1,"icon37",,,3,"-103,0,0"),
	[65] = new Cfg_t_attribute_show_s_Info(66,3004,"0",1112,1011,1,"icon38",,,3,"-104,0,0"),
	[66] = new Cfg_t_attribute_show_s_Info(67,4001,"0",1113,1011,2,"","","","",""),
	[67] = new Cfg_t_attribute_show_s_Info(68,4002,"0",1114,1011,1,"","","","",""),
	[68] = new Cfg_t_attribute_show_s_Info(69,4003,"0",1115,1011,0,"","","","",""),
	[69] = new Cfg_t_attribute_show_s_Info(70,4004,"0",1116,1011,1,"","","","",""),
	[70] = new Cfg_t_attribute_show_s_Info(71,4005,"0",1117,1011,1,"","","","",""),
	[71] = new Cfg_t_attribute_show_s_Info(72,4006,"0",1118,1011,2,"","","","",""),
	[72] = new Cfg_t_attribute_show_s_Info(73,4007,"0",1119,1011,2,"","","","",""),
	[73] = new Cfg_t_attribute_show_s_Info(74,4008,"0",1120,1011,1,"","","","",""),
	[74] = new Cfg_t_attribute_show_s_Info(75,4009,"0",1121,1011,2,"","","","",""),
	[75] = new Cfg_t_attribute_show_s_Info(76,4010,"0",1122,1011,2,"","","","",""),
	[76] = new Cfg_t_attribute_show_s_Info(77,4011,"0",1123,1011,1,"","","","",""),
	[77] = new Cfg_t_attribute_show_s_Info(78,4012,"0",1124,1011,1,"","","","",""),
	[78] = new Cfg_t_attribute_show_s_Info(79,4013,"0",1125,1011,0,"","","","",""),
	[79] = new Cfg_t_attribute_show_s_Info(80,4014,"0",1126,1011,0,"","","","",""),
	[80] = new Cfg_t_attribute_show_s_Info(81,4015,"0",1127,1011,2,"","","","",""),
};
}
