using System.Collections.Generic;
public class t_buff_effect_sInfo
{
public int id;
public int a_base_buff_effect_id;
public int a_base_effect_type;
public string a_ints_call_effect_parameter;
public string a_ints_effect_target;
public int a_base_start_time;
public int a_base_effect_frequency;
public string a_ints_buff_superposition;
public string a_ints_mutual_effect;
public int a_base_call_effect_id;
public int a_base_break;
public t_buff_effect_sInfo(int id,int a_base_buff_id,int a_base_name,string c_base_icon,int a_base_buff_type,int a_base_clear_type,int a_base_buff_lv,int a_base_continue_time,string a_ints_call_buff,string a_ints_break_type,int a_base_effects,int a_base_buff_superposition,string a_ints_shadertypevalueint id,int a_base_buff_effect_id,int a_base_effect_type,string a_ints_call_effect_parameter,string a_ints_effect_target,int a_base_start_time,int a_base_effect_frequency,string a_ints_buff_superposition,string a_ints_mutual_effect,int a_base_call_effect_id,int a_base_break)
{
  this.id = id;
  this.a_base_buff_effect_id = a_base_buff_effect_id;
  this.a_base_effect_type = a_base_effect_type;
  this.a_ints_call_effect_parameter = a_ints_call_effect_parameter;
  this.a_ints_effect_target = a_ints_effect_target;
  this.a_base_start_time = a_base_start_time;
  this.a_base_effect_frequency = a_base_effect_frequency;
  this.a_ints_buff_superposition = a_ints_buff_superposition;
  this.a_ints_mutual_effect = a_ints_mutual_effect;
  this.a_base_call_effect_id = a_base_call_effect_id;
  this.a_base_break = a_base_break;
}
}
public class Cfg_t_buff_effect_s
{
public static List<t_buff_effect_sInfo> list = new List<t_buff_effect_sInfo>()
{
	[0] = new t_buff_effect_sInfo(1,1,14,"1","","","","","","",""),
	[1] = new t_buff_effect_sInfo(2,2,14,"2","","","","","","",""),
	[2] = new t_buff_effect_sInfo(3,3,14,"3","","","","","","",""),
	[3] = new t_buff_effect_sInfo(4,4,14,"4","","","","","","",""),
	[4] = new t_buff_effect_sInfo(5,5,14,"5","","","","","","",""),
	[5] = new t_buff_effect_sInfo(6,7,14,"7","","","","","","",""),
	[6] = new t_buff_effect_sInfo(7,201,1,"3,-5000,0","","","","","","",""),
	[7] = new t_buff_effect_sInfo(8,202,1,"1,-3000,0","","","","","","",""),
	[8] = new t_buff_effect_sInfo(9,210,1,"3,-3000,0","","","","","","",""),
	[9] = new t_buff_effect_sInfo(10,211,1,"1,-3000,0","","","","","","",""),
	[10] = new t_buff_effect_sInfo(11,212,13,"9000","","","","","","",""),
	[11] = new t_buff_effect_sInfo(12,220,1,"3,-2000,0","","","","","","",""),
	[12] = new t_buff_effect_sInfo(13,221,1,"1,1000,0","","","","","","",""),
	[13] = new t_buff_effect_sInfo(14,222,13,"9500","","","","","","",""),
	[14] = new t_buff_effect_sInfo(15,230,1,"3,3000,0","","","","","","",""),
	[15] = new t_buff_effect_sInfo(16,231,1,"1,5000,0","","","","","","",""),
	[16] = new t_buff_effect_sInfo(17,232,13,"11000","","","","","","",""),
	[17] = new t_buff_effect_sInfo(18,240,1,"4,5000,0","","","","","","",""),
	[18] = new t_buff_effect_sInfo(19,250,2,"100,5000,0","1,0","1,0","1,0","","","",""),
	[19] = new t_buff_effect_sInfo(20,260,2,"200,2000,0","1,0","1,0","1,0","","","",""),
	[20] = new t_buff_effect_sInfo(21,270,2,"200,-2000,0","1,0","1,0","1,0","","","",""),
	[21] = new t_buff_effect_sInfo(22,400,1,"1,20000,0","","","","","","",""),
	[22] = new t_buff_effect_sInfo(23,401,1,"3,20000,0","","","","","","",""),
	[23] = new t_buff_effect_sInfo(24,402,1,"306,20000,0","","","","","","",""),
	[24] = new t_buff_effect_sInfo(25,403,3,"2,500,0","1,1",1000,1000,"","","",""),
	[25] = new t_buff_effect_sInfo(26,420,1,"1,-3000,0","","","","","","",""),
	[26] = new t_buff_effect_sInfo(27,421,1,"4,-5000,0","","","","","","",""),
	[27] = new t_buff_effect_sInfo(28,422,1,"3,-3000,0","","","","","","",""),
	[28] = new t_buff_effect_sInfo(29,501,1,"3,500,0","","","","","","",""),
	[29] = new t_buff_effect_sInfo(30,502,1,"1,500,0","","","","","","",""),
	[30] = new t_buff_effect_sInfo(31,601,1,"3,4000,0","0,3","0,3","0,3","","","",""),
	[31] = new t_buff_effect_sInfo(32,602,1,"1,1000,0","0,1","0,1","0,1","","","",""),
	[32] = new t_buff_effect_sInfo(33,611,1,"3,8000,0","0,3","0,3","0,3","","","",""),
	[33] = new t_buff_effect_sInfo(34,612,1,"1,3000,0","0,1","0,1","0,1","","","",""),
	[34] = new t_buff_effect_sInfo(35,1000,2,"200,7000,0","1073741824,0","1073741824,0","1073741824,0","","","",""),
	[35] = new t_buff_effect_sInfo(36,1001,4,"","","","","","","",""),
	[36] = new t_buff_effect_sInfo(37,1002,1,"306,20000,0","","","","","","",""),
	[37] = new t_buff_effect_sInfo(38,1010,2,"200,-10000,0","1073741824,0","1073741824,0","1073741824,0","","","",""),
	[38] = new t_buff_effect_sInfo(39,2001,3,"2,-200,0","1,1",1000,1000,"","","",""),
	[39] = new t_buff_effect_sInfo(40,2002,3,"2,-120,0","1,1",1000,1000,"","","",""),
	[40] = new t_buff_effect_sInfo(41,3001,1,"3,3000,0","","","","","","",""),
	[41] = new t_buff_effect_sInfo(42,3002,1,"3,6000,0","","","","","","",""),
	[42] = new t_buff_effect_sInfo(43,3003,1,"3,9000,0","","","","","","",""),
	[43] = new t_buff_effect_sInfo(44,3004,1,"3,12000,0","","","","","","",""),
	[44] = new t_buff_effect_sInfo(45,3005,1,"3,15000,0","","","","","","",""),
	[45] = new t_buff_effect_sInfo(46,3006,1,"3,18000,0","","","","","","",""),
	[46] = new t_buff_effect_sInfo(47,3007,1,"3,21000,0","","","","","","",""),
	[47] = new t_buff_effect_sInfo(48,3008,1,"3,24000,0","","","","","","",""),
	[48] = new t_buff_effect_sInfo(49,3009,1,"3,27000,0","","","","","","",""),
	[49] = new t_buff_effect_sInfo(50,3010,1,"3,30000,0","","","","","","",""),
	[50] = new t_buff_effect_sInfo(51,3011,1,"3,33000,0","","","","","","",""),
	[51] = new t_buff_effect_sInfo(52,3012,1,"3,36000,0","","","","","","",""),
	[52] = new t_buff_effect_sInfo(53,3013,1,"3,39000,0","","","","","","",""),
	[53] = new t_buff_effect_sInfo(54,3014,1,"3,42000,0","","","","","","",""),
	[54] = new t_buff_effect_sInfo(55,3015,1,"3,45000,0","","","","","","",""),
	[55] = new t_buff_effect_sInfo(56,3016,1,"3,48000,0","","","","","","",""),
	[56] = new t_buff_effect_sInfo(57,3017,1,"3,51000,0","","","","","","",""),
	[57] = new t_buff_effect_sInfo(58,3018,1,"3,54000,0","","","","","","",""),
	[58] = new t_buff_effect_sInfo(59,3019,1,"3,57000,0","","","","","","",""),
	[59] = new t_buff_effect_sInfo(60,3020,1,"3,60000,0","","","","","","",""),
	[60] = new t_buff_effect_sInfo(61,3100,1,"1,-8000,0","","","","","","",""),
	[61] = new t_buff_effect_sInfo(62,3101,1,"1,-6000,0","","","","","","",""),
	[62] = new t_buff_effect_sInfo(63,3102,1,"1,-4000,0","","","","","","",""),
	[63] = new t_buff_effect_sInfo(64,3103,1,"1,-2000,0","","","","","","",""),
	[64] = new t_buff_effect_sInfo(65,3104,1,"1,1000,0","","","","","","",""),
	[65] = new t_buff_effect_sInfo(66,3105,1,"1,3000,0","","","","","","",""),
	[66] = new t_buff_effect_sInfo(67,3106,1,"1,7000,0","","","","","","",""),
	[67] = new t_buff_effect_sInfo(68,3107,1,"1,11000,0","","","","","","",""),
	[68] = new t_buff_effect_sInfo(69,3108,1,"1,11000,0","","","","","","",""),
	[69] = new t_buff_effect_sInfo(70,3109,1,"1,12000,0","","","","","","",""),
	[70] = new t_buff_effect_sInfo(71,3110,1,"1,13000,0","","","","","","",""),
	[71] = new t_buff_effect_sInfo(72,3111,1,"1,14000,0","","","","","","",""),
	[72] = new t_buff_effect_sInfo(73,3112,1,"1,18000,0","","","","","","",""),
	[73] = new t_buff_effect_sInfo(74,3113,1,"1,18000,0","","","","","","",""),
	[74] = new t_buff_effect_sInfo(75,3114,1,"1,22000,0","","","","","","",""),
	[75] = new t_buff_effect_sInfo(76,3115,1,"1,25000,0","","","","","","",""),
	[76] = new t_buff_effect_sInfo(77,3116,1,"1,24000,0","","","","","","",""),
	[77] = new t_buff_effect_sInfo(78,3117,1,"1,25000,0","","","","","","",""),
	[78] = new t_buff_effect_sInfo(79,3118,1,"1,26000,0","","","","","","",""),
	[79] = new t_buff_effect_sInfo(80,3119,1,"1,29000,0","","","","","","",""),
	[80] = new t_buff_effect_sInfo(81,3120,1,"1,28000,0","","","","","","",""),
	[81] = new t_buff_effect_sInfo(82,3121,1,"1,29000,0","","","","","","",""),
	[82] = new t_buff_effect_sInfo(83,3122,1,"1,33000,0","","","","","","",""),
	[83] = new t_buff_effect_sInfo(84,3123,1,"1,38000,0","","","","","","",""),
	[84] = new t_buff_effect_sInfo(85,3124,1,"1,38000,0","","","","","","",""),
	[85] = new t_buff_effect_sInfo(86,3125,1,"1,35000,0","","","","","","",""),
	[86] = new t_buff_effect_sInfo(87,3126,1,"1,39000,0","","","","","","",""),
	[87] = new t_buff_effect_sInfo(88,3127,1,"1,42000,0","","","","","","",""),
	[88] = new t_buff_effect_sInfo(89,3128,1,"1,46000,0","","","","","","",""),
	[89] = new t_buff_effect_sInfo(90,3129,1,"1,47000,0","","","","","","",""),
	[90] = new t_buff_effect_sInfo(91,3130,1,"1,48000,0","","","","","","",""),
	[91] = new t_buff_effect_sInfo(92,3131,1,"1,52000,0","","","","","","",""),
	[92] = new t_buff_effect_sInfo(93,3132,1,"1,65000,0","","","","","","",""),
	[93] = new t_buff_effect_sInfo(94,3201,1,"4,200,0","","","","","","",""),
	[94] = new t_buff_effect_sInfo(95,3202,1,"4,400,0","","","","","","",""),
	[95] = new t_buff_effect_sInfo(96,3203,1,"4,600,0","","","","","","",""),
	[96] = new t_buff_effect_sInfo(97,3204,1,"4,800,0","","","","","","",""),
	[97] = new t_buff_effect_sInfo(98,3205,1,"4,1000,0","","","","","","",""),
	[98] = new t_buff_effect_sInfo(99,3206,1,"4,1200,0","","","","","","",""),
	[99] = new t_buff_effect_sInfo(100,3207,1,"4,1400,0","","","","","","",""),
	[100] = new t_buff_effect_sInfo(101,3208,1,"4,1600,0","","","","","","",""),
	[101] = new t_buff_effect_sInfo(102,3209,1,"4,1800,0","","","","","","",""),
	[102] = new t_buff_effect_sInfo(103,3210,1,"4,2000,0","","","","","","",""),
	[103] = new t_buff_effect_sInfo(104,3211,1,"4,2200,0","","","","","","",""),
	[104] = new t_buff_effect_sInfo(105,3212,1,"4,2400,0","","","","","","",""),
	[105] = new t_buff_effect_sInfo(106,3213,1,"4,2600,0","","","","","","",""),
	[106] = new t_buff_effect_sInfo(107,3214,1,"4,2800,0","","","","","","",""),
	[107] = new t_buff_effect_sInfo(108,3215,1,"4,3000,0","","","","","","",""),
	[108] = new t_buff_effect_sInfo(109,3216,1,"4,3200,0","","","","","","",""),
	[109] = new t_buff_effect_sInfo(110,3217,1,"4,3400,0","","","","","","",""),
	[110] = new t_buff_effect_sInfo(111,3218,1,"4,3600,0","","","","","","",""),
	[111] = new t_buff_effect_sInfo(112,3219,1,"4,3800,0","","","","","","",""),
	[112] = new t_buff_effect_sInfo(113,3300,1,"1,-8000,0","","","","","","",""),
	[113] = new t_buff_effect_sInfo(114,3301,1,"1,-4000,0","","","","","","",""),
	[114] = new t_buff_effect_sInfo(115,3302,1,"1,1000,0","","","","","","",""),
	[115] = new t_buff_effect_sInfo(116,3303,1,"1,3000,0","","","","","","",""),
	[116] = new t_buff_effect_sInfo(117,3304,1,"1,6000,0","","","","","","",""),
	[117] = new t_buff_effect_sInfo(118,3305,1,"1,12000,0","","","","","","",""),
	[118] = new t_buff_effect_sInfo(119,3306,1,"1,13000,0","","","","","","",""),
	[119] = new t_buff_effect_sInfo(120,3307,1,"1,17000,0","","","","","","",""),
	[120] = new t_buff_effect_sInfo(121,3308,1,"1,24000,0","","","","","","",""),
	[121] = new t_buff_effect_sInfo(122,3309,1,"1,29000,0","","","","","","",""),
	[122] = new t_buff_effect_sInfo(123,3310,1,"1,35000,0","","","","","","",""),
	[123] = new t_buff_effect_sInfo(124,3311,1,"1,40000,0","","","","","","",""),
	[124] = new t_buff_effect_sInfo(125,3312,1,"1,45000,0","","","","","","",""),
	[125] = new t_buff_effect_sInfo(126,3313,1,"1,50000,0","","","","","","",""),
	[126] = new t_buff_effect_sInfo(127,3314,1,"1,60000,0","","","","","","",""),
	[127] = new t_buff_effect_sInfo(128,3315,1,"1,68000,0","","","","","","",""),
	[128] = new t_buff_effect_sInfo(129,3316,1,"1,75000,0","","","","","","",""),
	[129] = new t_buff_effect_sInfo(130,3317,1,"1,80000,0","","","","","","",""),
	[130] = new t_buff_effect_sInfo(131,3318,1,"1,90000,0","","","","","","",""),
	[131] = new t_buff_effect_sInfo(132,3319,1,"1,92000,0","","","","","","",""),
	[132] = new t_buff_effect_sInfo(133,3320,1,"1,94000,0","","","","","","",""),
	[133] = new t_buff_effect_sInfo(134,3321,1,"1,96000,0","","","","","","",""),
	[134] = new t_buff_effect_sInfo(135,3322,1,"1,105000,0","","","","","","",""),
	[135] = new t_buff_effect_sInfo(136,3323,1,"1,110000,0","","","","","","",""),
	[136] = new t_buff_effect_sInfo(137,3324,1,"1,120000,0","","","","","","",""),
	[137] = new t_buff_effect_sInfo(138,3325,1,"1,130000,0","","","","","","",""),
	[138] = new t_buff_effect_sInfo(139,3326,1,"1,150000,0","","","","","","",""),
	[139] = new t_buff_effect_sInfo(140,3327,1,"1,180000,0","","","","","","",""),
	[140] = new t_buff_effect_sInfo(141,3328,1,"1,200000,0","","","","","","",""),
	[141] = new t_buff_effect_sInfo(142,3329,1,"1,230000,0","","","","","","",""),
	[142] = new t_buff_effect_sInfo(143,3330,1,"1,260000,0","","","","","","",""),
	[143] = new t_buff_effect_sInfo(144,3331,1,"1,300000,0","","","","","","",""),
	[144] = new t_buff_effect_sInfo(145,3332,1,"1,360000,0","","","","","","",""),
	[145] = new t_buff_effect_sInfo(146,10010,1,"3,1000,0","","","","","","",""),
	[146] = new t_buff_effect_sInfo(147,10011,1,"3,1500,0","","","","","","",""),
	[147] = new t_buff_effect_sInfo(148,10012,1,"3,2000,0","","","","","","",""),
	[148] = new t_buff_effect_sInfo(149,10020,1,"306,1000,0","","","","","","",""),
	[149] = new t_buff_effect_sInfo(150,10021,1,"306,1500,0","","","","","","",""),
	[150] = new t_buff_effect_sInfo(151,10022,1,"306,2000,0","","","","","","",""),
	[151] = new t_buff_effect_sInfo(152,10030,1,"3,300,0","","","","","","",""),
	[152] = new t_buff_effect_sInfo(153,10031,1,"3,500,0","","","","","","",""),
	[153] = new t_buff_effect_sInfo(154,10032,1,"3,700,0","","","","","","",""),
	[154] = new t_buff_effect_sInfo(155,10040,1,"306,300,0","","","","","","",""),
	[155] = new t_buff_effect_sInfo(156,10041,1,"306,500,0","","","","","","",""),
	[156] = new t_buff_effect_sInfo(157,10042,1,"306,700,0","","","","","","",""),
	[157] = new t_buff_effect_sInfo(158,111010,2,"100,10000,0","16,0","16,0","16,0","","","",""),
	[158] = new t_buff_effect_sInfo(159,112010,1,"4,-5000,0","","","","","","",""),
	[159] = new t_buff_effect_sInfo(160,113010,11,"4,10000,0","1,4","1,4","1,4","","","",""),
	[160] = new t_buff_effect_sInfo(161,115010,2,"100,10000,0","512,0","512,0","512,0","","","",""),
	[161] = new t_buff_effect_sInfo(162,115011,2,"100,10000,0","16384,0","16384,0","16384,0","","","",""),
	[162] = new t_buff_effect_sInfo(163,121010,2,"200,3000,0","8,0","8,0","8,0","","","",""),
	[163] = new t_buff_effect_sInfo(164,123010,11,"4,10000,0","1,4","1,4","1,4","","","",""),
	[164] = new t_buff_effect_sInfo(165,124010,2,"200,100000,0","1073741824,0","1073741824,0","1073741824,0","","","",""),
	[165] = new t_buff_effect_sInfo(166,125010,2,"200,5000,0","4096,0","4096,0","4096,0","","","",""),
	[166] = new t_buff_effect_sInfo(167,221010,2,"100,3000,0","512,0","512,0","512,0","","","",""),
	[167] = new t_buff_effect_sInfo(168,221011,2,"100,3000,0","24576,0","24576,0","24576,0","","","",""),
	[168] = new t_buff_effect_sInfo(169,421010,11,"4,10000,0","1,4","1,4","1,4","","","",""),
	[169] = new t_buff_effect_sInfo(170,521010,3,"2,-200,0","1,1",,1000,"","","",""),
	[170] = new t_buff_effect_sInfo(171,621010,2,"200,5000,0","4096,0","4096,0","4096,0","","","",""),
	[171] = new t_buff_effect_sInfo(172,723010,6,"5000","","","","","","",""),
	[172] = new t_buff_effect_sInfo(173,3000001,1,"200,3000,0","","","","","","",""),
	[173] = new t_buff_effect_sInfo(174,3000002,1,"200,5000,0","","","","","","",""),
	[174] = new t_buff_effect_sInfo(175,3000113,1,"3,18000,0","","","","","","",""),
	[175] = new t_buff_effect_sInfo(176,3000114,1,"1,18000,0","","","","","","",""),
	[176] = new t_buff_effect_sInfo(177,3000115,1,"200,-3000,0","","","","","","",""),
	[177] = new t_buff_effect_sInfo(178,3000120,1,"3,10000,0","","","","","","",""),
	[178] = new t_buff_effect_sInfo(179,3000121,1,"1,10000,0","","","","","","",""),
	[179] = new t_buff_effect_sInfo(180,3000214,1,"200,-5000,0","","","","","","",""),
	[180] = new t_buff_effect_sInfo(181,3000320,1,"3,25000,0","","","","","","",""),
	[181] = new t_buff_effect_sInfo(182,3000321,1,"1,25000,0","","","","","","",""),
	[182] = new t_buff_effect_sInfo(183,3100121,3,"2,-2000,0","0,3",,1000,"","","",""),
	[183] = new t_buff_effect_sInfo(184,3100123,1,"1,30000,0","","","","","","",""),
	[184] = new t_buff_effect_sInfo(185,3100220,2,"200,50000,0","4096,0","4096,0","4096,0","","","",""),
	[185] = new t_buff_effect_sInfo(186,3100223,1,"3,40000,0","","","","","","",""),
	[186] = new t_buff_effect_sInfo(187,3100224,1,"3,-5000,0","","","","","","",""),
	[187] = new t_buff_effect_sInfo(188,3402011,12,"3402011","","","","","","",""),
	[188] = new t_buff_effect_sInfo(189,3404011,12,"3404011","","","","","","",""),
	[189] = new t_buff_effect_sInfo(190,4001010,1,"306,2000,0","","","","","","",""),
	[190] = new t_buff_effect_sInfo(191,4002012,12,"4002016","",1000,1000,"","","",""),
	[191] = new t_buff_effect_sInfo(192,4003010,3,"2,-330,0","1,1",1000,1000,"","","",""),
	[192] = new t_buff_effect_sInfo(193,4004010,3,"2,-330,0","1,1",1000,1000,"","","",""),
	[193] = new t_buff_effect_sInfo(194,4004013,1,"3,2000,0","","","","","","",""),
	[194] = new t_buff_effect_sInfo(195,4004014,1,"3,5000,0","","","","","","",""),
	[195] = new t_buff_effect_sInfo(196,4004015,1,"3,10000,0","","","","","","",""),
	[196] = new t_buff_effect_sInfo(197,4101010,1,"4,-5000,0","","","","","","",""),
	[197] = new t_buff_effect_sInfo(198,4101011,1,"4,-6000,0","","","","","","",""),
	[198] = new t_buff_effect_sInfo(199,4101012,1,"4,-7000,0","","","","","","",""),
	[199] = new t_buff_effect_sInfo(200,4102011,3,"2,-100,0","1,1",,1000,"","","",""),
	[200] = new t_buff_effect_sInfo(201,4102012,2,"200,-1000,0","3,0","3,0","3,0","","","",""),
	[201] = new t_buff_effect_sInfo(202,4102013,2,"200,-1500,0","3,0","3,0","3,0","","","",""),
	[202] = new t_buff_effect_sInfo(203,4103015,3,"2,-200,0","1,2",,1000,"","","",""),
	[203] = new t_buff_effect_sInfo(204,4105010,3,"2,-100,0","1,1",,1000,"","","",""),
	[204] = new t_buff_effect_sInfo(205,10201010,4,"","","","","","","",""),
	[205] = new t_buff_effect_sInfo(206,99999998,12,"99999998","","","","","","",""),
	[206] = new t_buff_effect_sInfo(207,99999999,12,"99999999","","","","","","",""),
	[207] = new t_buff_effect_sInfo(208,100000001,1,"4,1000,0","","","","","","",""),
	[208] = new t_buff_effect_sInfo(209,100002010,1,"4,-4000,0","","","","","","",""),
	[209] = new t_buff_effect_sInfo(210,100003010,4,"","","","","","","",""),
	[210] = new t_buff_effect_sInfo(211,100005010,3,"2,-200,0","1,1",,500,"","","",""),
};
}