using System.Collections.Generic;
public class t_combo_sInfo
{
public int id;
public int a_base_combo_id;
public int a_base_lavel_type;
public int a_base_combomum;
public int a_base_ennergyadd;
public int a_base_buffid;
public int c_base_res;
public int c_base_comb_effectid;
public t_combo_sInfo(int id,int a_base_combo_id,int a_base_lavel_type,int a_base_combomum,int a_base_ennergyadd,int a_base_buffid,int c_base_res,int c_base_comb_effectid)
{
  this.id = id;
  this.a_base_combo_id = a_base_combo_id;
  this.a_base_lavel_type = a_base_lavel_type;
  this.a_base_combomum = a_base_combomum;
  this.a_base_ennergyadd = a_base_ennergyadd;
  this.a_base_buffid = a_base_buffid;
  this.c_base_res = c_base_res;
  this.c_base_comb_effectid = c_base_comb_effectid;
}
}
public class Cfg_t_combo_s
{
public static List<t_combo_sInfo> list = new List<t_combo_sInfo>()
{
	[0] = new t_combo_sInfo(1,10001,1,1,,1,1,23101),
	[1] = new t_combo_sInfo(2,10002,1,2,2000,2,1,23101),
	[2] = new t_combo_sInfo(3,10003,1,3,2500,3,1,23101),
	[3] = new t_combo_sInfo(4,10004,1,4,3000,4,1,23101),
	[4] = new t_combo_sInfo(5,10005,1,5,3500,5,1,23101),
	[5] = new t_combo_sInfo(6,10006,1,6,4000,6,2,23101),
	[6] = new t_combo_sInfo(7,10007,1,7,4500,7,2,23101),
	[7] = new t_combo_sInfo(8,10008,1,8,5000,8,2,23101),
	[8] = new t_combo_sInfo(9,10009,1,9,5500,9,2,23101),
	[9] = new t_combo_sInfo(10,10010,1,10,6000,10,2,23101),
	[10] = new t_combo_sInfo(11,10011,1,11,6500,11,3,23101),
	[11] = new t_combo_sInfo(12,10012,1,12,7000,12,3,23101),
	[12] = new t_combo_sInfo(13,10013,1,13,7500,13,3,23101),
	[13] = new t_combo_sInfo(14,10014,1,14,8000,14,3,23101),
	[14] = new t_combo_sInfo(15,10015,1,15,8500,15,3,23101),
	[15] = new t_combo_sInfo(16,10016,1,16,9000,16,4,23101),
	[16] = new t_combo_sInfo(17,10017,1,17,9500,17,4,23101),
	[17] = new t_combo_sInfo(18,10018,1,18,10000,18,4,23101),
	[18] = new t_combo_sInfo(19,10019,1,19,10500,19,4,23101),
	[19] = new t_combo_sInfo(20,10020,1,20,11000,20,4,23101),
	[20] = new t_combo_sInfo(21,20001,2,1,,1,1,23101),
	[21] = new t_combo_sInfo(22,20002,2,2,2000,2,1,23101),
	[22] = new t_combo_sInfo(23,20003,2,3,2500,3,1,23101),
	[23] = new t_combo_sInfo(24,20004,2,4,3000,4,1,23101),
	[24] = new t_combo_sInfo(25,20005,2,5,3500,5,1,23101),
	[25] = new t_combo_sInfo(26,20006,2,6,4000,6,2,23101),
	[26] = new t_combo_sInfo(27,20007,2,7,4500,7,2,23101),
	[27] = new t_combo_sInfo(28,20008,2,8,5000,8,2,23101),
	[28] = new t_combo_sInfo(29,20009,2,9,5500,9,2,23101),
	[29] = new t_combo_sInfo(30,20010,2,10,6000,10,2,23101),
	[30] = new t_combo_sInfo(31,20011,2,11,6500,11,3,23101),
	[31] = new t_combo_sInfo(32,20012,2,12,7000,12,3,23101),
	[32] = new t_combo_sInfo(33,20013,2,13,7500,13,3,23101),
	[33] = new t_combo_sInfo(34,20014,2,14,8000,14,3,23101),
	[34] = new t_combo_sInfo(35,20015,2,15,8500,15,3,23101),
	[35] = new t_combo_sInfo(36,20016,2,16,9000,16,4,23101),
	[36] = new t_combo_sInfo(37,20017,2,17,9500,17,4,23101),
	[37] = new t_combo_sInfo(38,20018,2,18,10000,18,4,23101),
	[38] = new t_combo_sInfo(39,20019,2,19,10500,19,4,23101),
	[39] = new t_combo_sInfo(40,20020,2,20,11000,20,4,23101),
	[40] = new t_combo_sInfo(41,30001,3,1,,1,1,23101),
	[41] = new t_combo_sInfo(42,30002,3,2,2000,2,1,23101),
	[42] = new t_combo_sInfo(43,30003,3,3,2500,3,1,23101),
	[43] = new t_combo_sInfo(44,30004,3,4,3000,4,1,23101),
	[44] = new t_combo_sInfo(45,30005,3,5,3500,5,1,23101),
	[45] = new t_combo_sInfo(46,30006,3,6,4000,6,2,23101),
	[46] = new t_combo_sInfo(47,30007,3,7,4500,7,2,23101),
	[47] = new t_combo_sInfo(48,30008,3,8,5000,8,2,23101),
	[48] = new t_combo_sInfo(49,30009,3,9,5500,9,2,23101),
	[49] = new t_combo_sInfo(50,30010,3,10,6000,10,2,23101),
	[50] = new t_combo_sInfo(51,30011,3,11,6500,11,3,23101),
	[51] = new t_combo_sInfo(52,30012,3,12,7000,12,3,23101),
	[52] = new t_combo_sInfo(53,30013,3,13,7500,13,3,23101),
	[53] = new t_combo_sInfo(54,30014,3,14,8000,14,3,23101),
	[54] = new t_combo_sInfo(55,30015,3,15,8500,15,3,23101),
	[55] = new t_combo_sInfo(56,30016,3,16,9000,16,4,23101),
	[56] = new t_combo_sInfo(57,30017,3,17,9500,17,4,23101),
	[57] = new t_combo_sInfo(58,30018,3,18,10000,18,4,23101),
	[58] = new t_combo_sInfo(59,30019,3,19,10500,19,4,23101),
	[59] = new t_combo_sInfo(60,30020,3,20,11000,20,4,23101),
};
}
