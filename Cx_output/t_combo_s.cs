using System.Collections.Generic;
public class Cfg_t_combo_s_Info
{
	public int id;
	public int a_base_combo_id;
	public int a_base_lavel_type;
	public int a_base_combomum;
	public int a_base_ennergyadd;
	public int a_base_buffid;
	public int c_base_res;
	public int c_base_comb_effectid;
public Cfg_t_combo_s_Info(int id,int a_base_combo_id,int a_base_lavel_type,int a_base_combomum,int a_base_ennergyadd,int a_base_buffid,int c_base_res,int c_base_comb_effectid)
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
public static List<Cfg_t_combo_s_Info> list = new List<Cfg_t_combo_s_Info>()
{
	[%!d(string=1)] = new Cfg_t_combo_s_Info(1,10001,1,1,,1,1,23101),
	[%!d(string=2)] = new Cfg_t_combo_s_Info(2,10002,1,2,2000,2,1,23101),
	[%!d(string=3)] = new Cfg_t_combo_s_Info(3,10003,1,3,2500,3,1,23101),
	[%!d(string=4)] = new Cfg_t_combo_s_Info(4,10004,1,4,3000,4,1,23101),
	[%!d(string=5)] = new Cfg_t_combo_s_Info(5,10005,1,5,3500,5,1,23101),
	[%!d(string=6)] = new Cfg_t_combo_s_Info(6,10006,1,6,4000,6,2,23101),
	[%!d(string=7)] = new Cfg_t_combo_s_Info(7,10007,1,7,4500,7,2,23101),
	[%!d(string=8)] = new Cfg_t_combo_s_Info(8,10008,1,8,5000,8,2,23101),
	[%!d(string=9)] = new Cfg_t_combo_s_Info(9,10009,1,9,5500,9,2,23101),
	[%!d(string=10)] = new Cfg_t_combo_s_Info(10,10010,1,10,6000,10,2,23101),
	[%!d(string=11)] = new Cfg_t_combo_s_Info(11,10011,1,11,6500,11,3,23101),
	[%!d(string=12)] = new Cfg_t_combo_s_Info(12,10012,1,12,7000,12,3,23101),
	[%!d(string=13)] = new Cfg_t_combo_s_Info(13,10013,1,13,7500,13,3,23101),
	[%!d(string=14)] = new Cfg_t_combo_s_Info(14,10014,1,14,8000,14,3,23101),
	[%!d(string=15)] = new Cfg_t_combo_s_Info(15,10015,1,15,8500,15,3,23101),
	[%!d(string=16)] = new Cfg_t_combo_s_Info(16,10016,1,16,9000,16,4,23101),
	[%!d(string=17)] = new Cfg_t_combo_s_Info(17,10017,1,17,9500,17,4,23101),
	[%!d(string=18)] = new Cfg_t_combo_s_Info(18,10018,1,18,10000,18,4,23101),
	[%!d(string=19)] = new Cfg_t_combo_s_Info(19,10019,1,19,10500,19,4,23101),
	[%!d(string=20)] = new Cfg_t_combo_s_Info(20,10020,1,20,11000,20,4,23101),
	[%!d(string=21)] = new Cfg_t_combo_s_Info(21,20001,2,1,,1,1,23101),
	[%!d(string=22)] = new Cfg_t_combo_s_Info(22,20002,2,2,2000,2,1,23101),
	[%!d(string=23)] = new Cfg_t_combo_s_Info(23,20003,2,3,2500,3,1,23101),
	[%!d(string=24)] = new Cfg_t_combo_s_Info(24,20004,2,4,3000,4,1,23101),
	[%!d(string=25)] = new Cfg_t_combo_s_Info(25,20005,2,5,3500,5,1,23101),
	[%!d(string=26)] = new Cfg_t_combo_s_Info(26,20006,2,6,4000,6,2,23101),
	[%!d(string=27)] = new Cfg_t_combo_s_Info(27,20007,2,7,4500,7,2,23101),
	[%!d(string=28)] = new Cfg_t_combo_s_Info(28,20008,2,8,5000,8,2,23101),
	[%!d(string=29)] = new Cfg_t_combo_s_Info(29,20009,2,9,5500,9,2,23101),
	[%!d(string=30)] = new Cfg_t_combo_s_Info(30,20010,2,10,6000,10,2,23101),
	[%!d(string=31)] = new Cfg_t_combo_s_Info(31,20011,2,11,6500,11,3,23101),
	[%!d(string=32)] = new Cfg_t_combo_s_Info(32,20012,2,12,7000,12,3,23101),
	[%!d(string=33)] = new Cfg_t_combo_s_Info(33,20013,2,13,7500,13,3,23101),
	[%!d(string=34)] = new Cfg_t_combo_s_Info(34,20014,2,14,8000,14,3,23101),
	[%!d(string=35)] = new Cfg_t_combo_s_Info(35,20015,2,15,8500,15,3,23101),
	[%!d(string=36)] = new Cfg_t_combo_s_Info(36,20016,2,16,9000,16,4,23101),
	[%!d(string=37)] = new Cfg_t_combo_s_Info(37,20017,2,17,9500,17,4,23101),
	[%!d(string=38)] = new Cfg_t_combo_s_Info(38,20018,2,18,10000,18,4,23101),
	[%!d(string=39)] = new Cfg_t_combo_s_Info(39,20019,2,19,10500,19,4,23101),
	[%!d(string=40)] = new Cfg_t_combo_s_Info(40,20020,2,20,11000,20,4,23101),
	[%!d(string=41)] = new Cfg_t_combo_s_Info(41,30001,3,1,,1,1,23101),
	[%!d(string=42)] = new Cfg_t_combo_s_Info(42,30002,3,2,2000,2,1,23101),
	[%!d(string=43)] = new Cfg_t_combo_s_Info(43,30003,3,3,2500,3,1,23101),
	[%!d(string=44)] = new Cfg_t_combo_s_Info(44,30004,3,4,3000,4,1,23101),
	[%!d(string=45)] = new Cfg_t_combo_s_Info(45,30005,3,5,3500,5,1,23101),
	[%!d(string=46)] = new Cfg_t_combo_s_Info(46,30006,3,6,4000,6,2,23101),
	[%!d(string=47)] = new Cfg_t_combo_s_Info(47,30007,3,7,4500,7,2,23101),
	[%!d(string=48)] = new Cfg_t_combo_s_Info(48,30008,3,8,5000,8,2,23101),
	[%!d(string=49)] = new Cfg_t_combo_s_Info(49,30009,3,9,5500,9,2,23101),
	[%!d(string=50)] = new Cfg_t_combo_s_Info(50,30010,3,10,6000,10,2,23101),
	[%!d(string=51)] = new Cfg_t_combo_s_Info(51,30011,3,11,6500,11,3,23101),
	[%!d(string=52)] = new Cfg_t_combo_s_Info(52,30012,3,12,7000,12,3,23101),
	[%!d(string=53)] = new Cfg_t_combo_s_Info(53,30013,3,13,7500,13,3,23101),
	[%!d(string=54)] = new Cfg_t_combo_s_Info(54,30014,3,14,8000,14,3,23101),
	[%!d(string=55)] = new Cfg_t_combo_s_Info(55,30015,3,15,8500,15,3,23101),
	[%!d(string=56)] = new Cfg_t_combo_s_Info(56,30016,3,16,9000,16,4,23101),
	[%!d(string=57)] = new Cfg_t_combo_s_Info(57,30017,3,17,9500,17,4,23101),
	[%!d(string=58)] = new Cfg_t_combo_s_Info(58,30018,3,18,10000,18,4,23101),
	[%!d(string=59)] = new Cfg_t_combo_s_Info(59,30019,3,19,10500,19,4,23101),
	[%!d(string=60)] = new Cfg_t_combo_s_Info(60,30020,3,20,11000,20,4,23101),
};
}
