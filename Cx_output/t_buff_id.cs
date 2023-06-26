using System.Collections.Generic;
public class Cfg_t_buff_id_Info
{
	public int id;
	public int a_base_buff_id;
	public int a_base_name;
	public string c_base_icon;
	public int a_base_buff_type;
	public int a_base_clear_type;
	public int a_base_buff_lv;
	public int a_base_continue_time;
	public string a_ints_call_buff;
	public string a_ints_break_type;
	public int a_base_effects;
	public int a_base_buff_superposition;
	public string a_ints_shadertypevalue;
public Cfg_t_buff_id_Info(int id,int a_base_buff_id,int a_base_name,string c_base_icon,int a_base_buff_type,int a_base_clear_type,int a_base_buff_lv,int a_base_continue_time,string a_ints_call_buff,string a_ints_break_type,int a_base_effects,int a_base_buff_superposition,string a_ints_shadertypevalue)
{
  this.id = id;
  this.a_base_buff_id = a_base_buff_id;
  this.a_base_name = a_base_name;
  this.c_base_icon = c_base_icon;
  this.a_base_buff_type = a_base_buff_type;
  this.a_base_clear_type = a_base_clear_type;
  this.a_base_buff_lv = a_base_buff_lv;
  this.a_base_continue_time = a_base_continue_time;
  this.a_ints_call_buff = a_ints_call_buff;
  this.a_ints_break_type = a_ints_break_type;
  this.a_base_effects = a_base_effects;
  this.a_base_buff_superposition = a_base_buff_superposition;
  this.a_ints_shadertypevalue = a_ints_shadertypevalue;
}
}
public class Cfg_t_buff_id
{
public static List<Cfg_t_buff_id_Info> list = new List<Cfg_t_buff_id_Info>()
{
	[0] = new Cfg_t_buff_id_Info(1,1,,"",2,0,1,0,"1","","","",""),
	[1] = new Cfg_t_buff_id_Info(2,2,,"",2,0,1,0,"2","","","",""),
	[2] = new Cfg_t_buff_id_Info(3,3,,"",2,0,1,0,"3","","","",""),
	[3] = new Cfg_t_buff_id_Info(4,4,,"",2,0,1,0,"4","","","",""),
	[4] = new Cfg_t_buff_id_Info(5,5,,"",2,0,1,0,"5","","","",""),
	[5] = new Cfg_t_buff_id_Info(6,7,,"",2,0,1,0,"7","","","",""),
	[6] = new Cfg_t_buff_id_Info(14,210,,"",3,0,1,0,"210,211,212","","","",""),
	[7] = new Cfg_t_buff_id_Info(15,220,,"",3,0,1,0,"220,221,222","","","",""),
	[8] = new Cfg_t_buff_id_Info(16,230,,"",3,0,1,0,"230,231,232","","","",""),
	[9] = new Cfg_t_buff_id_Info(17,300,,"",3,0,1,0,"201,202","","","",""),
	[10] = new Cfg_t_buff_id_Info(18,400,,"",1,0,1,0,"400","","","",""),
	[11] = new Cfg_t_buff_id_Info(19,401,,"",1,0,1,0,"401","","","",""),
	[12] = new Cfg_t_buff_id_Info(20,402,,"",1,0,1,0,"402","","","",""),
	[13] = new Cfg_t_buff_id_Info(21,403,,"",1,0,1,0,"403","","","",""),
	[14] = new Cfg_t_buff_id_Info(23,420,,"",1,0,1,0,"420","","","",""),
	[15] = new Cfg_t_buff_id_Info(24,421,,"",1,0,1,0,"421","","","",""),
	[16] = new Cfg_t_buff_id_Info(25,422,,"",1,0,1,0,"422","","","",""),
	[17] = new Cfg_t_buff_id_Info(26,501,,"",4,0,1,0,"501","","","",""),
	[18] = new Cfg_t_buff_id_Info(27,502,,"",4,0,1,0,"502","","","",""),
	[19] = new Cfg_t_buff_id_Info(28,601,,"",2,0,1,0,"601,602","","","",""),
	[20] = new Cfg_t_buff_id_Info(29,611,,"",2,0,1,0,"611,612","","","",""),
	[21] = new Cfg_t_buff_id_Info(30,1000,,"",2,0,1,0,"1000","","","",""),
	[22] = new Cfg_t_buff_id_Info(31,1001,,"",0,0,1,1000,"1001","","","",""),
	[23] = new Cfg_t_buff_id_Info(32,1002,,"",0,0,1,0,"1002","","","",""),
	[24] = new Cfg_t_buff_id_Info(33,1010,,"",2,0,1,0,"1010","","","",""),
	[25] = new Cfg_t_buff_id_Info(34,2001,,"",2,0,1,0,"2001","","","",""),
	[26] = new Cfg_t_buff_id_Info(35,2002,,"",2,0,1,0,"2002","","","",""),
	[27] = new Cfg_t_buff_id_Info(36,3001,,"",1,0,1,0,"3001","","","",""),
	[28] = new Cfg_t_buff_id_Info(37,3002,,"",1,0,1,0,"3002","","","",""),
	[29] = new Cfg_t_buff_id_Info(38,3003,,"",1,0,1,0,"3003","","","",""),
	[30] = new Cfg_t_buff_id_Info(39,3004,,"",1,0,1,0,"3004","","","",""),
	[31] = new Cfg_t_buff_id_Info(40,3005,,"",1,0,1,0,"3005","","","",""),
	[32] = new Cfg_t_buff_id_Info(41,3006,,"",1,0,1,0,"3006","","","",""),
	[33] = new Cfg_t_buff_id_Info(42,3007,,"",1,0,1,0,"3007","","","",""),
	[34] = new Cfg_t_buff_id_Info(43,3008,,"",1,0,1,0,"3008","","","",""),
	[35] = new Cfg_t_buff_id_Info(44,3009,,"",1,0,1,0,"3009","","","",""),
	[36] = new Cfg_t_buff_id_Info(45,3010,,"",1,0,1,0,"3010","","","",""),
	[37] = new Cfg_t_buff_id_Info(46,3011,,"",1,0,1,0,"3011","","","",""),
	[38] = new Cfg_t_buff_id_Info(47,3012,,"",1,0,1,0,"3012","","","",""),
	[39] = new Cfg_t_buff_id_Info(48,3013,,"",1,0,1,0,"3013","","","",""),
	[40] = new Cfg_t_buff_id_Info(49,3014,,"",1,0,1,0,"3014","","","",""),
	[41] = new Cfg_t_buff_id_Info(50,3015,,"",1,0,1,0,"3015","","","",""),
	[42] = new Cfg_t_buff_id_Info(51,3016,,"",1,0,1,0,"3016","","","",""),
	[43] = new Cfg_t_buff_id_Info(52,3017,,"",1,0,1,0,"3017","","","",""),
	[44] = new Cfg_t_buff_id_Info(53,3018,,"",1,0,1,0,"3018","","","",""),
	[45] = new Cfg_t_buff_id_Info(54,3019,,"",1,0,1,0,"3019","","","",""),
	[46] = new Cfg_t_buff_id_Info(55,3020,,"",1,0,1,0,"3020","","","",""),
	[47] = new Cfg_t_buff_id_Info(56,3100,,"",1,0,1,0,"3100,3201","",,1,""),
	[48] = new Cfg_t_buff_id_Info(57,3101,,"",1,0,1,0,"3101,3201","",,1,""),
	[49] = new Cfg_t_buff_id_Info(58,3102,,"",1,0,1,0,"3102,3202","",,1,""),
	[50] = new Cfg_t_buff_id_Info(59,3103,,"",1,0,1,0,"3103,3203","",,1,""),
	[51] = new Cfg_t_buff_id_Info(60,3104,,"",1,0,1,0,"3104,3204","",,1,""),
	[52] = new Cfg_t_buff_id_Info(61,3105,,"",1,0,1,0,"3105,3205","",,1,""),
	[53] = new Cfg_t_buff_id_Info(62,3106,,"",1,0,1,0,"3106,3206","",,1,""),
	[54] = new Cfg_t_buff_id_Info(63,3107,,"",1,0,1,0,"3107,3207","",,1,""),
	[55] = new Cfg_t_buff_id_Info(64,3108,,"",1,0,1,0,"3108,3208","",,1,""),
	[56] = new Cfg_t_buff_id_Info(65,3109,,"",1,0,1,0,"3109,3209","",,1,""),
	[57] = new Cfg_t_buff_id_Info(66,3110,,"",1,0,1,0,"3110,3210","",,1,""),
	[58] = new Cfg_t_buff_id_Info(67,3111,,"",1,0,1,0,"3111,3211","",,1,""),
	[59] = new Cfg_t_buff_id_Info(68,3112,,"",1,0,1,0,"3112,3212","",,1,""),
	[60] = new Cfg_t_buff_id_Info(69,3113,,"",1,0,1,0,"3113,3213","",,1,""),
	[61] = new Cfg_t_buff_id_Info(70,3114,,"",1,0,1,0,"3114,3214","",,1,""),
	[62] = new Cfg_t_buff_id_Info(71,3115,,"",1,0,1,0,"3115,3215","",,1,""),
	[63] = new Cfg_t_buff_id_Info(72,3116,,"",1,0,1,0,"3116,3216","",,1,""),
	[64] = new Cfg_t_buff_id_Info(73,3117,,"",1,0,1,0,"3117,3217","",,1,""),
	[65] = new Cfg_t_buff_id_Info(74,3118,,"",1,0,1,0,"3118,3218","",,1,""),
	[66] = new Cfg_t_buff_id_Info(75,3119,,"",1,0,1,0,"3119,3219","",,1,""),
	[67] = new Cfg_t_buff_id_Info(76,3120,,"",1,0,1,0,"3120,3219","",,1,""),
	[68] = new Cfg_t_buff_id_Info(77,3121,,"",1,0,1,0,"3121,3219","",,1,""),
	[69] = new Cfg_t_buff_id_Info(78,3122,,"",1,0,1,0,"3122,3219","",,1,""),
	[70] = new Cfg_t_buff_id_Info(79,3123,,"",1,0,1,0,"3123,3219","",,1,""),
	[71] = new Cfg_t_buff_id_Info(80,3124,,"",1,0,1,0,"3124,3219","",,1,""),
	[72] = new Cfg_t_buff_id_Info(81,3125,,"",1,0,1,0,"3125,3219","",,1,""),
	[73] = new Cfg_t_buff_id_Info(82,3126,,"",1,0,1,0,"3126,3219","",,1,""),
	[74] = new Cfg_t_buff_id_Info(83,3127,,"",1,0,1,0,"3127,3219","",,1,""),
	[75] = new Cfg_t_buff_id_Info(84,3128,,"",1,0,1,0,"3128,3219","",,1,""),
	[76] = new Cfg_t_buff_id_Info(85,3129,,"",1,0,1,0,"3129,3219","",,1,""),
	[77] = new Cfg_t_buff_id_Info(86,3130,,"",1,0,1,0,"3130,3219","",,1,""),
	[78] = new Cfg_t_buff_id_Info(87,3131,,"",1,0,1,0,"3131,3219","",,1,""),
	[79] = new Cfg_t_buff_id_Info(88,3132,,"",1,0,1,0,"3132,3219","",,1,""),
	[80] = new Cfg_t_buff_id_Info(89,3300,,"",1,0,1,0,"3300,3201","",,1,""),
	[81] = new Cfg_t_buff_id_Info(90,3301,,"",1,0,1,0,"3301,3201","",,1,""),
	[82] = new Cfg_t_buff_id_Info(91,3302,,"",1,0,1,0,"3302,3202","",,1,""),
	[83] = new Cfg_t_buff_id_Info(92,3303,,"",1,0,1,0,"3303,3203","",,1,""),
	[84] = new Cfg_t_buff_id_Info(93,3304,,"",1,0,1,0,"3304,3204","",,1,""),
	[85] = new Cfg_t_buff_id_Info(94,3305,,"",1,0,1,0,"3305,3205","",,1,""),
	[86] = new Cfg_t_buff_id_Info(95,3306,,"",1,0,1,0,"3306,3206","",,1,""),
	[87] = new Cfg_t_buff_id_Info(96,3307,,"",1,0,1,0,"3307,3207","",,1,""),
	[88] = new Cfg_t_buff_id_Info(97,3308,,"",1,0,1,0,"3308,3208","",,1,""),
	[89] = new Cfg_t_buff_id_Info(98,3309,,"",1,0,1,0,"3309,3209","",,1,""),
	[90] = new Cfg_t_buff_id_Info(99,3310,,"",1,0,1,0,"3310,3210","",,1,""),
	[91] = new Cfg_t_buff_id_Info(100,3311,,"",1,0,1,0,"3311,3211","",,1,""),
	[92] = new Cfg_t_buff_id_Info(101,3312,,"",1,0,1,0,"3312,3212","",,1,""),
	[93] = new Cfg_t_buff_id_Info(102,3313,,"",1,0,1,0,"3313,3213","",,1,""),
	[94] = new Cfg_t_buff_id_Info(103,3314,,"",1,0,1,0,"3314,3214","",,1,""),
	[95] = new Cfg_t_buff_id_Info(104,3315,,"",1,0,1,0,"3315,3215","",,1,""),
	[96] = new Cfg_t_buff_id_Info(105,3316,,"",1,0,1,0,"3316,3216","",,1,""),
	[97] = new Cfg_t_buff_id_Info(106,3317,,"",1,0,1,0,"3317,3217","",,1,""),
	[98] = new Cfg_t_buff_id_Info(107,3318,,"",1,0,1,0,"3318,3218","",,1,""),
	[99] = new Cfg_t_buff_id_Info(108,3319,,"",1,0,1,0,"3319,3219","",,1,""),
	[100] = new Cfg_t_buff_id_Info(109,3320,,"",1,0,1,0,"3320,3219","",,1,""),
	[101] = new Cfg_t_buff_id_Info(110,3321,,"",1,0,1,0,"3321,3219","",,1,""),
	[102] = new Cfg_t_buff_id_Info(111,3322,,"",1,0,1,0,"3322,3219","",,1,""),
	[103] = new Cfg_t_buff_id_Info(112,3323,,"",1,0,1,0,"3323,3219","",,1,""),
	[104] = new Cfg_t_buff_id_Info(113,3324,,"",1,0,1,0,"3324,3219","",,1,""),
	[105] = new Cfg_t_buff_id_Info(114,3325,,"",1,0,1,0,"3325,3219","",,1,""),
	[106] = new Cfg_t_buff_id_Info(115,3326,,"",1,0,1,0,"3326,3219","",,1,""),
	[107] = new Cfg_t_buff_id_Info(116,3327,,"",1,0,1,0,"3327,3219","",,1,""),
	[108] = new Cfg_t_buff_id_Info(117,3328,,"",1,0,1,0,"3328,3219","",,1,""),
	[109] = new Cfg_t_buff_id_Info(118,3329,,"",1,0,1,0,"3329,3219","",,1,""),
	[110] = new Cfg_t_buff_id_Info(119,3330,,"",1,0,1,0,"3330,3219","",,1,""),
	[111] = new Cfg_t_buff_id_Info(120,3331,,"",1,0,1,0,"3331,3219","",,1,""),
	[112] = new Cfg_t_buff_id_Info(121,3332,,"",1,0,1,0,"3332,3219","",,1,""),
	[113] = new Cfg_t_buff_id_Info(122,10010,,"",1,0,1,0,"10010","",,1,""),
	[114] = new Cfg_t_buff_id_Info(123,10011,,"",1,0,2,0,"10011","",,1,""),
	[115] = new Cfg_t_buff_id_Info(124,10012,,"",1,0,3,0,"10012","",,1,""),
	[116] = new Cfg_t_buff_id_Info(125,10020,,"",1,0,1,0,"10020","",,1,""),
	[117] = new Cfg_t_buff_id_Info(126,10021,,"",1,0,2,0,"10021","",,1,""),
	[118] = new Cfg_t_buff_id_Info(127,10022,,"",1,0,3,0,"10022","",,1,""),
	[119] = new Cfg_t_buff_id_Info(128,10030,,"",1,0,1,0,"10030","",,1,""),
	[120] = new Cfg_t_buff_id_Info(129,10031,,"",1,0,2,0,"10031","",,1,""),
	[121] = new Cfg_t_buff_id_Info(130,10032,,"",1,0,3,0,"10032","",,1,""),
	[122] = new Cfg_t_buff_id_Info(131,10040,,"",1,0,1,0,"10040","",,1,""),
	[123] = new Cfg_t_buff_id_Info(132,10041,,"",1,0,2,0,"10041","",,1,""),
	[124] = new Cfg_t_buff_id_Info(133,10042,,"",1,0,3,0,"10042","",,1,""),
	[125] = new Cfg_t_buff_id_Info(134,111010,,"",2,0,1,0,"111010","","","",""),
	[126] = new Cfg_t_buff_id_Info(135,112010,,"",2,1,1,2000,"112010","","","",""),
	[127] = new Cfg_t_buff_id_Info(136,113010,,"",0,0,1,0,"113010","1,2",604,604,""),
	[128] = new Cfg_t_buff_id_Info(137,115010,,"",2,0,1,0,"115010","","","",""),
	[129] = new Cfg_t_buff_id_Info(138,121010,,"",2,0,1,0,"121010","","","",""),
	[130] = new Cfg_t_buff_id_Info(139,123010,,"",0,0,1,0,"123010","1,2",604,604,""),
	[131] = new Cfg_t_buff_id_Info(140,124010,,"",2,0,1,0,"124010","","","",""),
	[132] = new Cfg_t_buff_id_Info(141,125010,,"",2,0,1,0,"125010","","","",""),
	[133] = new Cfg_t_buff_id_Info(142,221010,,"",2,0,1,0,"221010,221011","","","",""),
	[134] = new Cfg_t_buff_id_Info(143,421010,,"",0,0,1,0,"421010","1,2",604,604,""),
	[135] = new Cfg_t_buff_id_Info(144,521010,,"",0,0,1,8000,"521010","","","",""),
	[136] = new Cfg_t_buff_id_Info(145,621010,,"",2,0,1,0,"621010","","","",""),
	[137] = new Cfg_t_buff_id_Info(146,723010,,"",2,0,1,0,"723010","","","",""),
	[138] = new Cfg_t_buff_id_Info(147,3000001,,"",0,0,1,6000,"3000001","","","",""),
	[139] = new Cfg_t_buff_id_Info(148,3000002,,"",0,0,1,10000,"3000002","","","",""),
	[140] = new Cfg_t_buff_id_Info(149,3000113,,"",2,0,1,0,"3000113,3000114","","","",""),
	[141] = new Cfg_t_buff_id_Info(150,3000120,,"",2,0,1,0,"3000120,3000121","","","",""),
	[142] = new Cfg_t_buff_id_Info(151,3000114,,"",0,0,1,5000,"3000115","","","",""),
	[143] = new Cfg_t_buff_id_Info(152,3000214,,"",0,0,1,10000,"3000214","","","",""),
	[144] = new Cfg_t_buff_id_Info(153,3000320,,"",2,0,1,0,"3000320,3000321","","","",""),
	[145] = new Cfg_t_buff_id_Info(154,3100121,,"",0,0,1,5000,"3100121","","","",""),
	[146] = new Cfg_t_buff_id_Info(155,3100123,,"",2,0,1,0,"3100123","","","",""),
	[147] = new Cfg_t_buff_id_Info(156,3100220,,"",0,0,1,5000,"3100220","","","",""),
	[148] = new Cfg_t_buff_id_Info(157,3100223,,"",2,0,1,0,"3100223","","","",""),
	[149] = new Cfg_t_buff_id_Info(158,3100224,,"",0,0,1,8000,"3100224","","","",""),
	[150] = new Cfg_t_buff_id_Info(159,3402011,,"",2,0,1,0,"3402011","",204,204,""),
	[151] = new Cfg_t_buff_id_Info(160,3404011,,"",2,0,1,0,"3404011","","","",""),
	[152] = new Cfg_t_buff_id_Info(161,4001010,,"",0,0,1,2000,"4001010","",,1,""),
	[153] = new Cfg_t_buff_id_Info(162,4002012,,"",0,0,1,8000,"4002012","",429,429,""),
	[154] = new Cfg_t_buff_id_Info(163,4003010,,"",2,0,1,0,"4003010","","","",""),
	[155] = new Cfg_t_buff_id_Info(164,4003011,,"",0,7,1,5000,"10201010","",433,433,""),
	[156] = new Cfg_t_buff_id_Info(165,4004010,,"",2,0,1,0,"4004010","","","",""),
	[157] = new Cfg_t_buff_id_Info(166,4004013,,"",0,0,1,0,"4004013","",,1,""),
	[158] = new Cfg_t_buff_id_Info(167,4004014,,"",0,0,1,0,"4004014","",,1,""),
	[159] = new Cfg_t_buff_id_Info(168,4004015,,"",0,0,1,0,"4004015","",,1,""),
	[160] = new Cfg_t_buff_id_Info(169,4101010,,"",0,1,1,3000,"4101010","",,,"1,3000"),
	[161] = new Cfg_t_buff_id_Info(170,4101011,,"",0,1,1,3000,"4101011","",,,"1,5000"),
	[162] = new Cfg_t_buff_id_Info(171,4101012,,"",0,1,1,3000,"4101012","",,,"1,7000"),
	[163] = new Cfg_t_buff_id_Info(172,4102011,,"",0,4,1,5000,"4102011","","","",""),
	[164] = new Cfg_t_buff_id_Info(173,4102012,,"",0,5,1,5000,"4102012","",,1,""),
	[165] = new Cfg_t_buff_id_Info(174,4102013,,"",0,5,1,10000,"4102013","",,1,""),
	[166] = new Cfg_t_buff_id_Info(175,4103015,,"",0,2,1,10000,"4103015","","","",""),
	[167] = new Cfg_t_buff_id_Info(176,4105010,,"",0,4,1,10000,"4105010","","","",""),
	[168] = new Cfg_t_buff_id_Info(177,10201010,,"",0,7,1,2000,"10201010","",433,433,""),
	[169] = new Cfg_t_buff_id_Info(178,99999998,,"",0,0,1,0,"99999998","","","",""),
	[170] = new Cfg_t_buff_id_Info(179,99999999,,"",0,0,1,0,"99999999","","","",""),
	[171] = new Cfg_t_buff_id_Info(180,100000001,,"",0,0,1,0,"100000001","3","3","3",""),
	[172] = new Cfg_t_buff_id_Info(181,100002010,,"",0,1,1,4000,"100002010","","","",""),
	[173] = new Cfg_t_buff_id_Info(182,100003010,,"",0,3,1,1000,"100003010","",,,"1,10000"),
	[174] = new Cfg_t_buff_id_Info(183,100005010,,"",0,2,1,5000,"100005010","","","",""),
};
}
