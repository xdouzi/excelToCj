using System.Collections.Generic;
public class Cfg_t_streak_s_Info
{
public int id;
public int a_base_streakid;
public int a_base_streaknum;
public int a_base_factor;
public int a_base_point;
public int a_base_rewardfactor;
public Cfg_t_streak_s_Info(string 1,string 2,string 3,string 4,string 5,string 6,string 7,string 8,string 9,string 10,string 11,string 12string 10200,10201,10202,10203,10204,21110,21120,21130,21140,21150,21210,21220,21230,21240,21250,32210,33210,34210,35210,36210,47210,47220,47230,47240,47250,10300,10301,10302,21310,21320,21330,21340,21350,32310,33310,34310,35310,36310,47310,47320,47330,10400,10401,10402,21410,21420,21430,21440,21450,32410,33410,34410,35410,36410,47410,47420,10500,10501,21510,21520,21530,21540,21550,32510,33510,34510,35510,36510,47510,47520int id,int a_base_mod_id,int a_base_matchpattern,int a_base_gametype,int a_base_booking,int a_base_eratype,int a_base_patterntype,int a_base_matchnum,string a_arrayints_aiconfig,string a_arrayints_matchingunclock,string a_base_matchingbg_path,string a_base_matchingicon_path,int a_base_matchingitype_title,int a_base_matchingitype_content,string a_arrayints_eraunclock,string a_base_erabg_path,string a_base_eraicon_path,int a_base_eratype_title,int a_base_eratype_content,int a_base_gametypemsgid,string a_arrayints_modeunclock,string a_base_modebg_path,string a_base_modeicon_path,int a_base_modetype_title,int a_base_modetype_content,string a_ints_pointsoutput,string a_ints_pointsdeduct,string a_ints_room_cost,string a_base_gamerefund,int a_base_booking_num,string a_ints_creatroom_cost,string a_arrayints_roomcreator_right,string a_arrayints_room_unlock,string a_ints_room_creatcost,string a_ints_createcondition,string a_ints_roomkey,string a_ints_roommaneger,string a_ints_creatroom_issue,string a_arrayints_roomissue_right,string a_arrayints_points_segment,string a_arrayints_scoreinterval,string a_ints_rankicon,string a_ints_mode_card,int a_base_usablecard_level,int a_base_usablecard_mun,int a_base_cardlevel,string a_ints_buildings_level,string a_ints_phaseone,string a_ints_phasetwo,string a_ints_winreward,int a_base_winreturn,int a_base_jackpot_ratio,int a_base_jackpot_ratiorisen,int a_base_decimation_factor,int a_base_reclaim_factor,string a_arrayints_defeatreward,int a_base_guarantees,string a_arrayints_rewardratiorisen,int a_base_levelchapter_idstring 1,string 1,string 0.00833333333333333,string 120,string 0.19277563597396,string 6410.4339122241,string 2136.8113040747,string 8547.2452162988string 500,string 1,string 5,string 500,1,5int id,int a_base_streakid,int a_base_streaknum,int a_base_factor,int a_base_point,int a_base_rewardfactor)
{
  this.id = id;
  this.a_base_streakid = a_base_streakid;
  this.a_base_streaknum = a_base_streaknum;
  this.a_base_factor = a_base_factor;
  this.a_base_point = a_base_point;
  this.a_base_rewardfactor = a_base_rewardfactor;
}
}
public class Cfg_t_streak_s
{
public static List<Cfg_t_streak_s_Info> list = new List<Cfg_t_streak_s_Info>()
{
	[0] = new Cfg_t_streak_s_Info(1,1,1,1,5,10000),
	[1] = new Cfg_t_streak_s_Info(2,2,2,1,6,11000),
	[2] = new Cfg_t_streak_s_Info(3,3,3,1,9,12000),
	[3] = new Cfg_t_streak_s_Info(4,4,4,1,14,13000),
	[4] = new Cfg_t_streak_s_Info(5,5,5,1,21,14000),
	[5] = new Cfg_t_streak_s_Info(6,6,6,1,30,15000),
	[6] = new Cfg_t_streak_s_Info(7,7,7,1,41,16000),
	[7] = new Cfg_t_streak_s_Info(8,8,8,1,54,17000),
	[8] = new Cfg_t_streak_s_Info(9,9,9,1,69,18000),
	[9] = new Cfg_t_streak_s_Info(10,10,10,1,86,19000),
	[10] = new Cfg_t_streak_s_Info(11,11,11,1,105,20000),
	[11] = new Cfg_t_streak_s_Info(12,12,12,1,126,21000),
	[12] = new Cfg_t_streak_s_Info(13,13,13,1,149,22000),
	[13] = new Cfg_t_streak_s_Info(14,14,14,1,174,23000),
	[14] = new Cfg_t_streak_s_Info(15,15,15,1,201,24000),
	[15] = new Cfg_t_streak_s_Info(16,16,16,1,230,25000),
	[16] = new Cfg_t_streak_s_Info(17,17,17,1,261,26000),
	[17] = new Cfg_t_streak_s_Info(18,18,18,1,294,27000),
	[18] = new Cfg_t_streak_s_Info(19,19,19,1,329,28000),
	[19] = new Cfg_t_streak_s_Info(20,20,20,1,366,29000),
	[20] = new Cfg_t_streak_s_Info(21,21,21,1,405,30000),
	[21] = new Cfg_t_streak_s_Info(22,22,22,1,446,31000),
	[22] = new Cfg_t_streak_s_Info(23,23,23,1,489,32000),
	[23] = new Cfg_t_streak_s_Info(24,24,24,1,534,33000),
	[24] = new Cfg_t_streak_s_Info(25,25,25,1,581,34000),
	[25] = new Cfg_t_streak_s_Info(26,26,26,1,630,35000),
	[26] = new Cfg_t_streak_s_Info(27,27,27,1,681,36000),
	[27] = new Cfg_t_streak_s_Info(28,28,28,1,734,37000),
	[28] = new Cfg_t_streak_s_Info(29,29,29,1,789,38000),
	[29] = new Cfg_t_streak_s_Info(30,30,30,1,846,39000),
	[30] = new Cfg_t_streak_s_Info(31,31,31,1,905,40000),
	[31] = new Cfg_t_streak_s_Info(32,32,32,1,966,41000),
	[32] = new Cfg_t_streak_s_Info(33,33,33,1,1029,42000),
	[33] = new Cfg_t_streak_s_Info(34,34,34,1,1094,43000),
	[34] = new Cfg_t_streak_s_Info(35,35,35,1,1161,44000),
	[35] = new Cfg_t_streak_s_Info(36,36,36,1,1230,45000),
	[36] = new Cfg_t_streak_s_Info(37,37,37,1,1301,46000),
	[37] = new Cfg_t_streak_s_Info(38,38,38,1,1374,47000),
	[38] = new Cfg_t_streak_s_Info(39,39,39,1,1449,48000),
	[39] = new Cfg_t_streak_s_Info(40,40,40,1,1526,49000),
	[40] = new Cfg_t_streak_s_Info(41,41,41,1,1605,50000),
	[41] = new Cfg_t_streak_s_Info(42,42,42,1,1686,51000),
	[42] = new Cfg_t_streak_s_Info(43,43,43,1,1769,52000),
	[43] = new Cfg_t_streak_s_Info(44,44,44,1,1854,53000),
	[44] = new Cfg_t_streak_s_Info(45,45,45,1,1941,54000),
	[45] = new Cfg_t_streak_s_Info(46,46,46,1,2030,55000),
	[46] = new Cfg_t_streak_s_Info(47,47,47,1,2121,56000),
	[47] = new Cfg_t_streak_s_Info(48,48,48,1,2214,57000),
	[48] = new Cfg_t_streak_s_Info(49,49,49,1,2309,58000),
	[49] = new Cfg_t_streak_s_Info(50,50,50,1,2406,59000),
	[50] = new Cfg_t_streak_s_Info(51,20001,1,-1,5,10000),
	[51] = new Cfg_t_streak_s_Info(52,20002,2,-1,6,11000),
	[52] = new Cfg_t_streak_s_Info(53,20003,3,-1,9,12000),
	[53] = new Cfg_t_streak_s_Info(54,20004,4,-1,14,13000),
	[54] = new Cfg_t_streak_s_Info(55,20005,5,-1,21,14000),
	[55] = new Cfg_t_streak_s_Info(56,20006,6,-1,30,15000),
	[56] = new Cfg_t_streak_s_Info(57,20007,7,-1,41,16000),
	[57] = new Cfg_t_streak_s_Info(58,20008,8,-1,54,17000),
	[58] = new Cfg_t_streak_s_Info(59,20009,9,-1,69,18000),
	[59] = new Cfg_t_streak_s_Info(60,20010,10,-1,86,19000),
	[60] = new Cfg_t_streak_s_Info(61,20011,11,-1,105,20000),
	[61] = new Cfg_t_streak_s_Info(62,20012,12,-1,126,21000),
	[62] = new Cfg_t_streak_s_Info(63,20013,13,-1,149,22000),
	[63] = new Cfg_t_streak_s_Info(64,20014,14,-1,174,23000),
	[64] = new Cfg_t_streak_s_Info(65,20015,15,-1,201,24000),
	[65] = new Cfg_t_streak_s_Info(66,20016,16,-1,230,25000),
	[66] = new Cfg_t_streak_s_Info(67,20017,17,-1,261,26000),
	[67] = new Cfg_t_streak_s_Info(68,20018,18,-1,294,27000),
	[68] = new Cfg_t_streak_s_Info(69,20019,19,-1,329,28000),
	[69] = new Cfg_t_streak_s_Info(70,20020,20,-1,366,29000),
	[70] = new Cfg_t_streak_s_Info(71,20021,21,-1,405,30000),
	[71] = new Cfg_t_streak_s_Info(72,20022,22,-1,446,31000),
	[72] = new Cfg_t_streak_s_Info(73,20023,23,-1,489,32000),
	[73] = new Cfg_t_streak_s_Info(74,20024,24,-1,534,33000),
	[74] = new Cfg_t_streak_s_Info(75,20025,25,-1,581,34000),
	[75] = new Cfg_t_streak_s_Info(76,20026,26,-1,630,35000),
	[76] = new Cfg_t_streak_s_Info(77,20027,27,-1,681,36000),
	[77] = new Cfg_t_streak_s_Info(78,20028,28,-1,734,37000),
	[78] = new Cfg_t_streak_s_Info(79,20029,29,-1,789,38000),
	[79] = new Cfg_t_streak_s_Info(80,20030,30,-1,846,39000),
	[80] = new Cfg_t_streak_s_Info(81,20031,31,-1,905,40000),
	[81] = new Cfg_t_streak_s_Info(82,20032,32,-1,966,41000),
	[82] = new Cfg_t_streak_s_Info(83,20033,33,-1,1029,42000),
	[83] = new Cfg_t_streak_s_Info(84,20034,34,-1,1094,43000),
	[84] = new Cfg_t_streak_s_Info(85,20035,35,-1,1161,44000),
	[85] = new Cfg_t_streak_s_Info(86,20036,36,-1,1230,45000),
	[86] = new Cfg_t_streak_s_Info(87,20037,37,-1,1301,46000),
	[87] = new Cfg_t_streak_s_Info(88,20038,38,-1,1374,47000),
	[88] = new Cfg_t_streak_s_Info(89,20039,39,-1,1449,48000),
	[89] = new Cfg_t_streak_s_Info(90,20040,40,-1,1526,49000),
	[90] = new Cfg_t_streak_s_Info(91,20041,41,-1,1605,50000),
	[91] = new Cfg_t_streak_s_Info(92,20042,42,-1,1686,51000),
	[92] = new Cfg_t_streak_s_Info(93,20043,43,-1,1769,52000),
	[93] = new Cfg_t_streak_s_Info(94,20044,44,-1,1854,53000),
	[94] = new Cfg_t_streak_s_Info(95,20045,45,-1,1941,54000),
	[95] = new Cfg_t_streak_s_Info(96,20046,46,-1,2030,55000),
	[96] = new Cfg_t_streak_s_Info(97,20047,47,-1,2121,56000),
	[97] = new Cfg_t_streak_s_Info(98,20048,48,-1,2214,57000),
	[98] = new Cfg_t_streak_s_Info(99,20049,49,-1,2309,58000),
	[99] = new Cfg_t_streak_s_Info(100,20050,50,-1,2406,59000),
};
}
