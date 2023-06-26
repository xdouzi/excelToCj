using System.Collections.Generic;
public class Cfg_t_shop_goods_s_Info
{
public int id;
public int a_base_goods_id;
public int a_base_shelves;
public int a_base_goods_lv;
public string a_arrayints_use_condition;
public string a_ints_commodity;
public Cfg_t_shop_goods_s_Info(int id,int a_base_commodity,int a_base_weight,string a_ints_item,string a_ints_price,int a_base_buy_second,string a_arrayints_discount_show,string a_arrayints_condition,int a_base_time_type,string a_ints_time_scopeint id,int a_base_goods_id,int a_base_shelves,int a_base_goods_lv,string a_arrayints_use_condition,string a_ints_commodity)
{
  this.id = id;
  this.a_base_goods_id = a_base_goods_id;
  this.a_base_shelves = a_base_shelves;
  this.a_base_goods_lv = a_base_goods_lv;
  this.a_arrayints_use_condition = a_arrayints_use_condition;
  this.a_ints_commodity = a_ints_commodity;
}
}
public class Cfg_t_shop_goods_s
{
public static List<Cfg_t_shop_goods_s_Info> list = new List<Cfg_t_shop_goods_s_Info>()
{
	[0] = new Cfg_t_shop_goods_s_Info(1,10101,101,1,"","1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016,1017,1018,1019,1020,1021,1022,1023,1024,1025,1026,1027,1028,1029,1030,1031,1032,1033,1034,1035,1036,1037,1038,1039,1040"),
	[1] = new Cfg_t_shop_goods_s_Info(2,10201,102,1,"","1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016,1017,1018,1019,1020,1021,1022,1023,1024,1025,1026,1027,1028,1029,1030,1031,1032,1033,1034,1035,1036,1037,1038,1039,1040"),
	[2] = new Cfg_t_shop_goods_s_Info(3,10301,103,1,"","1001,1002,1003,1004,1005,1006,1007,1008,1009,1010,1011,1012,1013,1014,1015,1016,1017,1018,1019,1020,1021,1022,1023,1024,1025,1026,1027,1028,1029,1030,1031,1032,1033,1034,1035,1036,1037,1038,1039,1040"),
	[3] = new Cfg_t_shop_goods_s_Info(4,10401,104,1,"6,2","1041,1042,1043,1044,1045,1046,1047,1048,1049,1050,1051,1052,1053,1054,1055,1056,1057,1058,1059,1060,1061,1062,1063,1064,1065,1066,1067,1068,1069,1070,1071,1072,1073,1074,1075,1076,1077,1078,1079,1080"),
	[4] = new Cfg_t_shop_goods_s_Info(5,10501,105,1,"6,2","1041,1042,1043,1044,1045,1046,1047,1048,1049,1050,1051,1052,1053,1054,1055,1056,1057,1058,1059,1060,1061,1062,1063,1064,1065,1066,1067,1068,1069,1070,1071,1072,1073,1074,1075,1076,1077,1078,1079,1080"),
	[5] = new Cfg_t_shop_goods_s_Info(6,10601,106,1,"6,2","1041,1042,1043,1044,1045,1046,1047,1048,1049,1050,1051,1052,1053,1054,1055,1056,1057,1058,1059,1060,1061,1062,1063,1064,1065,1066,1067,1068,1069,1070,1071,1072,1073,1074,1075,1076,1077,1078,1079,1080"),
	[6] = new Cfg_t_shop_goods_s_Info(7,10701,107,1,"","1081,1082,1083,1084,1085,1086,1087,1088,1089,1090,1091,1092"),
	[7] = new Cfg_t_shop_goods_s_Info(8,10801,108,1,"","1081,1082,1083,1084,1085,1086,1087,1088,1089,1090,1091,1092"),
	[8] = new Cfg_t_shop_goods_s_Info(9,10901,109,1,"","1081,1082,1083,1084,1085,1086,1087,1088,1089,1090,1091,1092"),
	[9] = new Cfg_t_shop_goods_s_Info(10,11001,110,1,"6,2","1085,1086,1087,1088,1089,1090,1091,1092"),
	[10] = new Cfg_t_shop_goods_s_Info(11,11101,111,1,"6,2","1085,1086,1087,1088,1089,1090,1091,1092"),
	[11] = new Cfg_t_shop_goods_s_Info(12,11201,112,1,"6,2","1085,1086,1087,1088,1089,1090,1091,1092"),
	[12] = new Cfg_t_shop_goods_s_Info(13,20101,201,1,"","2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026,2027,2028,2029,2030,2031,2032,2033,2034,2035,2036,2037,2038,2039,2040,2041,2042,2043,2044,2045,2046,2047,2048,2049,2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,2070"),
	[13] = new Cfg_t_shop_goods_s_Info(14,20201,202,1,"","2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026,2027,2028,2029,2030,2031,2032,2033,2034,2035,2036,2037,2038,2039,2040,2041,2042,2043,2044,2045,2046,2047,2048,2049,2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,2070"),
	[14] = new Cfg_t_shop_goods_s_Info(15,20301,203,1,"","2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026,2027,2028,2029,2030,2031,2032,2033,2034,2035,2036,2037,2038,2039,2040,2041,2042,2043,2044,2045,2046,2047,2048,2049,2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,2070"),
	[15] = new Cfg_t_shop_goods_s_Info(16,20401,204,1,"6,2","2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026,2027,2028,2029,2030,2031,2032,2033,2034,2035,2036,2037,2038,2039,2040,2041,2042,2043,2044,2045,2046,2047,2048,2049,2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,2070"),
	[16] = new Cfg_t_shop_goods_s_Info(17,20501,205,1,"6,2","2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026,2027,2028,2029,2030,2031,2032,2033,2034,2035,2036,2037,2038,2039,2040,2041,2042,2043,2044,2045,2046,2047,2048,2049,2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,2070"),
	[17] = new Cfg_t_shop_goods_s_Info(18,20601,206,1,"6,2","2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020,2021,2022,2023,2024,2025,2026,2027,2028,2029,2030,2031,2032,2033,2034,2035,2036,2037,2038,2039,2040,2041,2042,2043,2044,2045,2046,2047,2048,2049,2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,2070"),
	[18] = new Cfg_t_shop_goods_s_Info(19,30101,301,1,"","3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070"),
	[19] = new Cfg_t_shop_goods_s_Info(20,30201,302,1,"","3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070"),
	[20] = new Cfg_t_shop_goods_s_Info(21,30301,303,1,"","3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070"),
	[21] = new Cfg_t_shop_goods_s_Info(22,30401,304,1,"6,2","3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070"),
	[22] = new Cfg_t_shop_goods_s_Info(23,30501,305,1,"6,2","3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070"),
	[23] = new Cfg_t_shop_goods_s_Info(24,30601,306,1,"6,2","3001,3002,3003,3004,3005,3006,3007,3008,3009,3010,3011,3012,3013,3014,3015,3016,3017,3018,3019,3020,3021,3022,3023,3024,3025,3026,3027,3028,3029,3030,3031,3032,3033,3034,3035,3036,3037,3038,3039,3040,3041,3042,3043,3044,3045,3046,3047,3048,3049,3050,3051,3052,3053,3054,3055,3056,3057,3058,3059,3060,3061,3062,3063,3064,3065,3066,3067,3068,3069,3070"),
	[24] = new Cfg_t_shop_goods_s_Info(25,40101,401,1,"","4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011,4012,4013,4014,4015,4016,4017,4018,4019,4020,4021,4022,4023,4024,4025,4026,4027,4028,4029,4030,4031,4032,4033,4034,4035,4036,4037,4038,4039,4040,4041,4042,4043,4044,4045,4046,4047,4048,4049,4050,4051,4052,4053,4054,4055,4056,4057,4058,4059,4060,4061,4062,4063,4064,4065,4066,4067,4068,4069,4070,4071,4072,4073,4074,4075,4076,4077,4078,4079,4080,4081,4082,4083,4084,4085,4086,4087,4088,4089,4090,4091,4092,4093,4094,4095,4096,4097,4098,4099,4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,4120,4121,4122,4123,4124,4125,4126,4127,4128,4129,4130,4131,4132,4133,4134,4135,4136,4137,4138,4139"),
	[25] = new Cfg_t_shop_goods_s_Info(26,40201,402,1,"","4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011,4012,4013,4014,4015,4016,4017,4018,4019,4020,4021,4022,4023,4024,4025,4026,4027,4028,4029,4030,4031,4032,4033,4034,4035,4036,4037,4038,4039,4040,4041,4042,4043,4044,4045,4046,4047,4048,4049,4050,4051,4052,4053,4054,4055,4056,4057,4058,4059,4060,4061,4062,4063,4064,4065,4066,4067,4068,4069,4070,4071,4072,4073,4074,4075,4076,4077,4078,4079,4080,4081,4082,4083,4084,4085,4086,4087,4088,4089,4090,4091,4092,4093,4094,4095,4096,4097,4098,4099,4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,4120,4121,4122,4123,4124,4125,4126,4127,4128,4129,4130,4131,4132,4133,4134,4135,4136,4137,4138,4139"),
	[26] = new Cfg_t_shop_goods_s_Info(27,40301,403,1,"","4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011,4012,4013,4014,4015,4016,4017,4018,4019,4020,4021,4022,4023,4024,4025,4026,4027,4028,4029,4030,4031,4032,4033,4034,4035,4036,4037,4038,4039,4040,4041,4042,4043,4044,4045,4046,4047,4048,4049,4050,4051,4052,4053,4054,4055,4056,4057,4058,4059,4060,4061,4062,4063,4064,4065,4066,4067,4068,4069,4070,4071,4072,4073,4074,4075,4076,4077,4078,4079,4080,4081,4082,4083,4084,4085,4086,4087,4088,4089,4090,4091,4092,4093,4094,4095,4096,4097,4098,4099,4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,4120,4121,4122,4123,4124,4125,4126,4127,4128,4129,4130,4131,4132,4133,4134,4135,4136,4137,4138,4139"),
	[27] = new Cfg_t_shop_goods_s_Info(28,40401,404,1,"6,2","4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011,4012,4013,4014,4015,4016,4017,4018,4019,4020,4021,4022,4023,4024,4025,4026,4027,4028,4029,4030,4031,4032,4033,4034,4035,4036,4037,4038,4039,4040,4041,4042,4043,4044,4045,4046,4047,4048,4049,4050,4051,4052,4053,4054,4055,4056,4057,4058,4059,4060,4061,4062,4063,4064,4065,4066,4067,4068,4069,4070,4071,4072,4073,4074,4075,4076,4077,4078,4079,4080,4081,4082,4083,4084,4085,4086,4087,4088,4089,4090,4091,4092,4093,4094,4095,4096,4097,4098,4099,4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,4120,4121,4122,4123,4124,4125,4126,4127,4128,4129,4130,4131,4132,4133,4134,4135,4136,4137,4138,4139"),
	[28] = new Cfg_t_shop_goods_s_Info(29,40501,405,1,"6,2","4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011,4012,4013,4014,4015,4016,4017,4018,4019,4020,4021,4022,4023,4024,4025,4026,4027,4028,4029,4030,4031,4032,4033,4034,4035,4036,4037,4038,4039,4040,4041,4042,4043,4044,4045,4046,4047,4048,4049,4050,4051,4052,4053,4054,4055,4056,4057,4058,4059,4060,4061,4062,4063,4064,4065,4066,4067,4068,4069,4070,4071,4072,4073,4074,4075,4076,4077,4078,4079,4080,4081,4082,4083,4084,4085,4086,4087,4088,4089,4090,4091,4092,4093,4094,4095,4096,4097,4098,4099,4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,4120,4121,4122,4123,4124,4125,4126,4127,4128,4129,4130,4131,4132,4133,4134,4135,4136,4137,4138,4139"),
	[29] = new Cfg_t_shop_goods_s_Info(30,40601,406,1,"6,2","4001,4002,4003,4004,4005,4006,4007,4008,4009,4010,4011,4012,4013,4014,4015,4016,4017,4018,4019,4020,4021,4022,4023,4024,4025,4026,4027,4028,4029,4030,4031,4032,4033,4034,4035,4036,4037,4038,4039,4040,4041,4042,4043,4044,4045,4046,4047,4048,4049,4050,4051,4052,4053,4054,4055,4056,4057,4058,4059,4060,4061,4062,4063,4064,4065,4066,4067,4068,4069,4070,4071,4072,4073,4074,4075,4076,4077,4078,4079,4080,4081,4082,4083,4084,4085,4086,4087,4088,4089,4090,4091,4092,4093,4094,4095,4096,4097,4098,4099,4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,4120,4121,4122,4123,4124,4125,4126,4127,4128,4129,4130,4131,4132,4133,4134,4135,4136,4137,4138,4139"),
	[30] = new Cfg_t_shop_goods_s_Info(31,50101,501,1,"6,1","5001"),
	[31] = new Cfg_t_shop_goods_s_Info(32,50102,501,2,"6,2","5002"),
	[32] = new Cfg_t_shop_goods_s_Info(33,50103,501,3,"6,3","5003"),
	[33] = new Cfg_t_shop_goods_s_Info(34,50104,501,4,"6,4","5004"),
	[34] = new Cfg_t_shop_goods_s_Info(35,50105,501,5,"6,5","5005"),
	[35] = new Cfg_t_shop_goods_s_Info(36,50106,501,6,"6,6","5006"),
	[36] = new Cfg_t_shop_goods_s_Info(37,50107,501,7,"6,7","5007"),
	[37] = new Cfg_t_shop_goods_s_Info(38,50108,501,8,"6,8","5008"),
	[38] = new Cfg_t_shop_goods_s_Info(39,50109,501,9,"6,9","5009"),
	[39] = new Cfg_t_shop_goods_s_Info(40,50110,501,10,"6,10","5010"),
	[40] = new Cfg_t_shop_goods_s_Info(41,50201,502,1,"6,1","5011"),
	[41] = new Cfg_t_shop_goods_s_Info(42,50202,502,2,"6,2","5012"),
	[42] = new Cfg_t_shop_goods_s_Info(43,50203,502,3,"6,3","5013"),
	[43] = new Cfg_t_shop_goods_s_Info(44,50204,502,4,"6,4","5014"),
	[44] = new Cfg_t_shop_goods_s_Info(45,50205,502,5,"6,5","5015"),
	[45] = new Cfg_t_shop_goods_s_Info(46,50206,502,6,"6,6","5016"),
	[46] = new Cfg_t_shop_goods_s_Info(47,50207,502,7,"6,7","5017"),
	[47] = new Cfg_t_shop_goods_s_Info(48,50208,502,8,"6,8","5018"),
	[48] = new Cfg_t_shop_goods_s_Info(49,50209,502,9,"6,9","5019"),
	[49] = new Cfg_t_shop_goods_s_Info(50,50210,502,10,"6,10","5020"),
	[50] = new Cfg_t_shop_goods_s_Info(51,50301,503,1,"6,1","5021"),
	[51] = new Cfg_t_shop_goods_s_Info(52,50302,503,2,"6,2","5022"),
	[52] = new Cfg_t_shop_goods_s_Info(53,50303,503,3,"6,3","5023"),
	[53] = new Cfg_t_shop_goods_s_Info(54,50304,503,4,"6,4","5024"),
	[54] = new Cfg_t_shop_goods_s_Info(55,50305,503,5,"6,5","5025"),
	[55] = new Cfg_t_shop_goods_s_Info(56,50306,503,6,"6,6","5026"),
	[56] = new Cfg_t_shop_goods_s_Info(57,50307,503,7,"6,7","5027"),
	[57] = new Cfg_t_shop_goods_s_Info(58,50308,503,8,"6,8","5028"),
	[58] = new Cfg_t_shop_goods_s_Info(59,50309,503,9,"6,9","5029"),
	[59] = new Cfg_t_shop_goods_s_Info(60,50310,503,10,"6,10","5030"),
	[60] = new Cfg_t_shop_goods_s_Info(61,60101,601,1,"","6001"),
	[61] = new Cfg_t_shop_goods_s_Info(62,60201,602,1,"","6002"),
	[62] = new Cfg_t_shop_goods_s_Info(63,60301,603,1,"","6003"),
	[63] = new Cfg_t_shop_goods_s_Info(64,70101,701,1,"","7001"),
	[64] = new Cfg_t_shop_goods_s_Info(65,80101,801,1,"","8001"),
	[65] = new Cfg_t_shop_goods_s_Info(66,80102,802,1,"","8002"),
	[66] = new Cfg_t_shop_goods_s_Info(67,80103,803,1,"","8003"),
	[67] = new Cfg_t_shop_goods_s_Info(68,80104,804,1,"","8004"),
	[68] = new Cfg_t_shop_goods_s_Info(69,80105,805,1,"","8005"),
	[69] = new Cfg_t_shop_goods_s_Info(70,90101,901,1,"","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[70] = new Cfg_t_shop_goods_s_Info(71,90201,902,1,"","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[71] = new Cfg_t_shop_goods_s_Info(72,90301,903,1,"","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[72] = new Cfg_t_shop_goods_s_Info(73,90401,904,1,"5,3","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[73] = new Cfg_t_shop_goods_s_Info(74,90501,905,1,"5,3","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[74] = new Cfg_t_shop_goods_s_Info(75,90601,906,1,"5,3","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[75] = new Cfg_t_shop_goods_s_Info(76,90701,907,1,"5,6","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[76] = new Cfg_t_shop_goods_s_Info(77,90801,908,1,"5,6","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[77] = new Cfg_t_shop_goods_s_Info(78,90901,909,1,"5,6","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[78] = new Cfg_t_shop_goods_s_Info(79,91001,910,1,"5,10","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[79] = new Cfg_t_shop_goods_s_Info(80,91101,911,1,"5,10","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
	[80] = new Cfg_t_shop_goods_s_Info(81,91201,912,1,"5,10","9001,9002,9003,9004,9005,9006,9007,9008,9009,9010,9011,9012,9013,9014,9015,9016,9017,9018,9019,9020,9021,9022,9023,9024,9025,9026,9027,9028,9029,9030,9031"),
};
}
