using System.Collections.Generic;
public class Cfg_t_demon_inbreak_buff_s_Info
{
public int id;
public int a_base_buff_id;
public int a_base_quality;
public string c_base_buff_res;
public int c_base_name;
public string c_ints_desc;
public string a_arrayints_application_range;
public Cfg_t_demon_inbreak_buff_s_Info(int id,int a_base_pool_id,string a_arrayints_buffint id,int a_base_buff_id,int a_base_quality,string c_base_buff_res,int c_base_name,string c_ints_desc,string a_arrayints_application_range)
{
  this.id = id;
  this.a_base_buff_id = a_base_buff_id;
  this.a_base_quality = a_base_quality;
  this.c_base_buff_res = c_base_buff_res;
  this.c_base_name = c_base_name;
  this.c_ints_desc = c_ints_desc;
  this.a_arrayints_application_range = a_arrayints_application_range;
}
}
public class Cfg_t_demon_inbreak_buff_s
{
public static List<Cfg_t_demon_inbreak_buff_s_Info> list = new List<Cfg_t_demon_inbreak_buff_s_Info>()
{
	[0] = new Cfg_t_demon_inbreak_buff_s_Info(1,1101,1,"icon_mojie_buff_110",231101,"241101","1,1,1000"),
	[1] = new Cfg_t_demon_inbreak_buff_s_Info(2,1102,2,"icon_mojie_buff_110",231101,"241101","1,1,1500"),
	[2] = new Cfg_t_demon_inbreak_buff_s_Info(3,1103,3,"icon_mojie_buff_110",231101,"241101","1,1,2000"),
	[3] = new Cfg_t_demon_inbreak_buff_s_Info(4,1201,1,"icon_mojie_buff_120",231201,"241201","1,2,1000"),
	[4] = new Cfg_t_demon_inbreak_buff_s_Info(5,1202,2,"icon_mojie_buff_120",231201,"241201","1,2,1500"),
	[5] = new Cfg_t_demon_inbreak_buff_s_Info(6,1203,3,"icon_mojie_buff_120",231201,"241201","1,2,2000"),
	[6] = new Cfg_t_demon_inbreak_buff_s_Info(7,2001,1,"icon_mojie_buff_200",232001,"242001","2,0,10030"),
	[7] = new Cfg_t_demon_inbreak_buff_s_Info(8,2002,2,"icon_mojie_buff_200",232001,"242002","2,0,10031"),
	[8] = new Cfg_t_demon_inbreak_buff_s_Info(9,2003,3,"icon_mojie_buff_200",232001,"242003","2,0,10032"),
	[9] = new Cfg_t_demon_inbreak_buff_s_Info(10,2011,1,"icon_mojie_buff_201",232011,"242011","2,0,10040"),
	[10] = new Cfg_t_demon_inbreak_buff_s_Info(11,2012,2,"icon_mojie_buff_201",232011,"242012","2,0,10041"),
	[11] = new Cfg_t_demon_inbreak_buff_s_Info(12,2013,3,"icon_mojie_buff_201",232011,"242013","2,0,10042"),
	[12] = new Cfg_t_demon_inbreak_buff_s_Info(13,2101,1,"icon_mojie_buff_210",232101,"242101","2,1,10010"),
	[13] = new Cfg_t_demon_inbreak_buff_s_Info(14,2102,2,"icon_mojie_buff_210",232101,"242102","2,1,10011"),
	[14] = new Cfg_t_demon_inbreak_buff_s_Info(15,2103,3,"icon_mojie_buff_210",232101,"242103","2,1,10012"),
	[15] = new Cfg_t_demon_inbreak_buff_s_Info(16,2111,1,"icon_mojie_buff_211",232111,"242111","2,1,10020"),
	[16] = new Cfg_t_demon_inbreak_buff_s_Info(17,2112,2,"icon_mojie_buff_211",232111,"242112","2,1,10021"),
	[17] = new Cfg_t_demon_inbreak_buff_s_Info(18,2113,3,"icon_mojie_buff_211",232111,"242113","2,1,10022"),
	[18] = new Cfg_t_demon_inbreak_buff_s_Info(19,2201,1,"icon_mojie_buff_220",232201,"242201","2,2,10010"),
	[19] = new Cfg_t_demon_inbreak_buff_s_Info(20,2202,2,"icon_mojie_buff_220",232201,"242202","2,2,10011"),
	[20] = new Cfg_t_demon_inbreak_buff_s_Info(21,2203,3,"icon_mojie_buff_220",232201,"242203","2,2,10012"),
	[21] = new Cfg_t_demon_inbreak_buff_s_Info(22,2211,1,"icon_mojie_buff_221",232211,"242211","2,2,10020"),
	[22] = new Cfg_t_demon_inbreak_buff_s_Info(23,2212,2,"icon_mojie_buff_221",232211,"242212","2,2,10021"),
	[23] = new Cfg_t_demon_inbreak_buff_s_Info(24,2213,3,"icon_mojie_buff_221",232211,"242213","2,2,10022"),
	[24] = new Cfg_t_demon_inbreak_buff_s_Info(25,2301,1,"icon_mojie_buff_230",232301,"242301","2,3,10010"),
	[25] = new Cfg_t_demon_inbreak_buff_s_Info(26,2302,2,"icon_mojie_buff_230",232301,"242302","2,3,10011"),
	[26] = new Cfg_t_demon_inbreak_buff_s_Info(27,2303,3,"icon_mojie_buff_230",232301,"242303","2,3,10012"),
	[27] = new Cfg_t_demon_inbreak_buff_s_Info(28,2311,1,"icon_mojie_buff_231",232311,"242311","2,3,10020"),
	[28] = new Cfg_t_demon_inbreak_buff_s_Info(29,2312,2,"icon_mojie_buff_231",232311,"242312","2,3,10021"),
	[29] = new Cfg_t_demon_inbreak_buff_s_Info(30,2313,3,"icon_mojie_buff_231",232311,"242313","2,3,10022"),
	[30] = new Cfg_t_demon_inbreak_buff_s_Info(31,2401,1,"icon_mojie_buff_240",232401,"242401","2,4,10010"),
	[31] = new Cfg_t_demon_inbreak_buff_s_Info(32,2402,2,"icon_mojie_buff_240",232401,"242402","2,4,10011"),
	[32] = new Cfg_t_demon_inbreak_buff_s_Info(33,2403,3,"icon_mojie_buff_240",232401,"242403","2,4,10012"),
	[33] = new Cfg_t_demon_inbreak_buff_s_Info(34,2411,1,"icon_mojie_buff_241",232411,"242411","2,4,10020"),
	[34] = new Cfg_t_demon_inbreak_buff_s_Info(35,2412,2,"icon_mojie_buff_241",232411,"242412","2,4,10021"),
	[35] = new Cfg_t_demon_inbreak_buff_s_Info(36,2413,3,"icon_mojie_buff_241",232411,"242413","2,4,10022"),
	[36] = new Cfg_t_demon_inbreak_buff_s_Info(37,3101,1,"icon_mojie_buff_310",233101,"243101","3,1,1"),
	[37] = new Cfg_t_demon_inbreak_buff_s_Info(38,3102,2,"icon_mojie_buff_310",233101,"243101","3,1,2"),
	[38] = new Cfg_t_demon_inbreak_buff_s_Info(39,3103,3,"icon_mojie_buff_310",233101,"243101","3,1,3"),
	[39] = new Cfg_t_demon_inbreak_buff_s_Info(40,4101,1,"icon_mojie_buff_410",234101,"244101","4,1,2000"),
	[40] = new Cfg_t_demon_inbreak_buff_s_Info(41,4102,2,"icon_mojie_buff_410",234101,"244101","4,1,3500"),
	[41] = new Cfg_t_demon_inbreak_buff_s_Info(42,4103,3,"icon_mojie_buff_410",234101,"244101","4,1,6000"),
	[42] = new Cfg_t_demon_inbreak_buff_s_Info(43,4201,1,"icon_mojie_buff_420",234201,"244201","4,2,500"),
	[43] = new Cfg_t_demon_inbreak_buff_s_Info(44,4202,2,"icon_mojie_buff_420",234201,"244201","4,2,1000"),
	[44] = new Cfg_t_demon_inbreak_buff_s_Info(45,4203,3,"icon_mojie_buff_420",234201,"244201","4,2,1500"),
	[45] = new Cfg_t_demon_inbreak_buff_s_Info(46,6001,2,"icon_mojie_buff_601",236001,"246001","6,0,10000101,1"),
	[46] = new Cfg_t_demon_inbreak_buff_s_Info(47,6002,2,"icon_mojie_buff_602",236002,"246002","6,0,10000201,1"),
	[47] = new Cfg_t_demon_inbreak_buff_s_Info(48,6003,2,"icon_mojie_buff_603",236003,"246003","6,0,10000301,1"),
	[48] = new Cfg_t_demon_inbreak_buff_s_Info(49,6004,2,"icon_mojie_buff_604",236004,"246004","6,0,10000401,1"),
	[49] = new Cfg_t_demon_inbreak_buff_s_Info(50,6005,2,"icon_mojie_buff_605",236005,"246005","6,0,10000501,1"),
	[50] = new Cfg_t_demon_inbreak_buff_s_Info(51,7001,1,"icon_mojie_buff_700",237001,"247001","7,1000"),
	[51] = new Cfg_t_demon_inbreak_buff_s_Info(52,7002,2,"icon_mojie_buff_700",237001,"247001","7,1500"),
	[52] = new Cfg_t_demon_inbreak_buff_s_Info(53,7003,3,"icon_mojie_buff_700",237001,"247001","7,2000"),
	[53] = new Cfg_t_demon_inbreak_buff_s_Info(54,8010,3,"icon_mojie_buff_700",238010,"248010,248011,248012,248013,248014","8,8010"),
	[54] = new Cfg_t_demon_inbreak_buff_s_Info(55,8020,3,"icon_mojie_buff_700",238020,"248020,248021,248022,248023","8,8020"),
	[55] = new Cfg_t_demon_inbreak_buff_s_Info(56,8030,3,"icon_mojie_buff_700",238030,"248030,248031,248032,248033","8,8030"),
	[56] = new Cfg_t_demon_inbreak_buff_s_Info(57,8040,3,"icon_mojie_buff_700",238040,"248040,248041,248042,248043","8,8040"),
	[57] = new Cfg_t_demon_inbreak_buff_s_Info(58,8050,3,"icon_mojie_buff_700",238050,"248050,248051,248052,248053","8,8050"),
	[58] = new Cfg_t_demon_inbreak_buff_s_Info(59,8060,3,"icon_mojie_buff_700",238060,"248060,248061,248062,248063","8,8060"),
	[59] = new Cfg_t_demon_inbreak_buff_s_Info(60,8070,3,"icon_mojie_buff_700",238070,"248070,248071,248072,248073","8,8070"),
	[60] = new Cfg_t_demon_inbreak_buff_s_Info(61,8080,3,"icon_mojie_buff_700",238080,"248080,248081,248082","8,8080"),
	[61] = new Cfg_t_demon_inbreak_buff_s_Info(62,8090,3,"icon_mojie_buff_700",238090,"248090,248091,248092","8,8090"),
};
}
