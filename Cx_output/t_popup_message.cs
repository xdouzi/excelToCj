using System.Collections.Generic;
public class t_popup_messageInfo
{
public int id;
public int a_base_popup_id;
public string a_base_operater_id;
public int c_e_name_id;
public int a_base_popup_message_type;
public int a_base_headline;
public int c_base_location;
public int a_base_text;
public int a_base_button1;
public int a_base_button2;
public int a_base_trigger;
public string a_ints_condition;
public int c_base_number;
public t_popup_messageInfo(int id,int a_base_popup_id,string a_base_operater_id,int c_e_name_id,int a_base_popup_message_type,int a_base_headline,int c_base_location,int a_base_text,int a_base_button1,int a_base_button2,int a_base_trigger,string a_ints_condition,int c_base_number)
{
  this.id = id;
  this.a_base_popup_id = a_base_popup_id;
  this.a_base_operater_id = a_base_operater_id;
  this.c_e_name_id = c_e_name_id;
  this.a_base_popup_message_type = a_base_popup_message_type;
  this.a_base_headline = a_base_headline;
  this.c_base_location = c_base_location;
  this.a_base_text = a_base_text;
  this.a_base_button1 = a_base_button1;
  this.a_base_button2 = a_base_button2;
  this.a_base_trigger = a_base_trigger;
  this.a_ints_condition = a_ints_condition;
  this.c_base_number = c_base_number;
}
}
public class Cfg_t_popup_message
{
public static List<t_popup_messageInfo> list = new List<t_popup_messageInfo>()
{
	[0] = new t_popup_messageInfo(1,1,"",1,2,20001,,20002,20003,20004,20004,"",""),
	[1] = new t_popup_messageInfo(2,2,"",2,0,20007,0,20008,20009,20010,20010,"",""),
	[2] = new t_popup_messageInfo(3,3,"",3,2,2,2,2,2,2,2,"",""),
	[3] = new t_popup_messageInfo(4,4,"",4,0,,0,100010014,100010014,100010014,100010014,"",""),
	[4] = new t_popup_messageInfo(5,10001,"",10001,0,,0,100010001,100010001,100010001,100010001,"",""),
	[5] = new t_popup_messageInfo(6,10002,"",10002,0,,0,100010002,100010002,100010002,100010002,"",""),
	[6] = new t_popup_messageInfo(7,10003,"",10003,0,,0,100010003,100010003,100010003,100010003,"",""),
	[7] = new t_popup_messageInfo(8,10004,"",10004,0,,0,100010004,100010004,100010004,100010004,"",""),
	[8] = new t_popup_messageInfo(9,10005,"",10005,0,,0,100010005,100010005,100010005,100010005,"",""),
	[9] = new t_popup_messageInfo(10,10006,"",10006,0,,0,100010006,100010006,100010006,100010006,"",""),
	[10] = new t_popup_messageInfo(11,10007,"",10007,0,,0,100010007,100010007,100010007,100010007,"",""),
	[11] = new t_popup_messageInfo(12,10008,"",10008,0,,0,100010008,100010008,100010008,100010008,"",""),
	[12] = new t_popup_messageInfo(13,10010,"",10010,0,,0,100010010,,60000,60000,"",""),
	[13] = new t_popup_messageInfo(14,10013,"",10013,0,,0,100010013,100010013,100010013,100010013,"",""),
	[14] = new t_popup_messageInfo(15,10014,"",10014,2,20005,,10401,20003,20004,20004,"",""),
	[15] = new t_popup_messageInfo(16,10015,"",10015,2,20005,,10402,20003,20004,20004,"",""),
	[16] = new t_popup_messageInfo(17,10016,"",10016,0,,0,10403,10403,10403,10403,"",""),
	[17] = new t_popup_messageInfo(18,10017,"",10017,0,,0,10404,10404,10404,10404,"",""),
	[18] = new t_popup_messageInfo(19,10018,"",10018,0,,0,10405,10405,10405,10405,"",""),
	[19] = new t_popup_messageInfo(20,10019,"",10019,0,,0,10406,10406,10406,10406,"",""),
	[20] = new t_popup_messageInfo(21,10020,"",10020,2,20006,,10407,20003,20004,20004,"",""),
	[21] = new t_popup_messageInfo(22,10021,"",10021,0,,0,20101,20101,20101,20101,"",""),
	[22] = new t_popup_messageInfo(23,20001,"",20001,0,,0,10408,10408,10408,10408,"",""),
	[23] = new t_popup_messageInfo(24,20002,"",20002,2,20001,,10216,20003,20004,20004,"",""),
	[24] = new t_popup_messageInfo(25,20003,"",20003,0,,2,2010,2010,2010,2010,"",""),
	[25] = new t_popup_messageInfo(26,20004,"",20004,0,,2,21001,21001,21001,21001,"",""),
	[26] = new t_popup_messageInfo(27,20005,"",20005,0,,1,5001,5001,5001,5001,"",""),
	[27] = new t_popup_messageInfo(28,20006,"",20006,0,,1,30001,30001,30001,30001,"",""),
	[28] = new t_popup_messageInfo(29,20007,"",20007,0,,1,30002,30002,30002,30002,"",""),
	[29] = new t_popup_messageInfo(30,20008,"",20008,0,,1,30003,30003,30003,30003,"",""),
	[30] = new t_popup_messageInfo(31,20009,"",20009,0,,1,30004,30004,30004,30004,"",""),
	[31] = new t_popup_messageInfo(32,20010,"",20010,0,,0,20201,20201,20201,20201,"",""),
	[32] = new t_popup_messageInfo(33,20011,"",20011,2,20001,,20203,20003,20004,20004,"",""),
	[33] = new t_popup_messageInfo(34,20012,"",20012,0,,0,20204,20204,20204,20204,"",""),
	[34] = new t_popup_messageInfo(35,20013,"",20013,0,,0,20205,20205,20205,20205,"",""),
	[35] = new t_popup_messageInfo(36,20014,"",20014,0,,0,20207,20207,20207,20207,"",""),
	[36] = new t_popup_messageInfo(37,20015,"",20015,0,,0,20208,20208,20208,20208,"",""),
	[37] = new t_popup_messageInfo(38,20016,"",20016,0,,0,20301,20301,20301,20301,"",""),
	[38] = new t_popup_messageInfo(39,20017,"",20017,0,,0,20302,20302,20302,20302,"",""),
	[39] = new t_popup_messageInfo(40,20018,"",20018,0,,0,8003,8003,8003,8003,"",""),
	[40] = new t_popup_messageInfo(41,20019,"",20019,0,,0,8004,8004,8004,8004,"",""),
	[41] = new t_popup_messageInfo(42,20020,"",20020,0,,0,20012,20012,20012,20012,"",""),
	[42] = new t_popup_messageInfo(43,20021,"",20021,0,,0,20013,20013,20013,20013,"",""),
	[43] = new t_popup_messageInfo(44,20022,"",20022,0,,0,21006,21006,21006,21006,"",""),
	[44] = new t_popup_messageInfo(45,20023,"",20023,0,,1,26010,26010,26010,26010,"",""),
	[45] = new t_popup_messageInfo(46,20024,"",20024,0,,1,65,65,65,65,"",""),
	[46] = new t_popup_messageInfo(47,20025,"",20025,0,,1,66,66,66,66,"",""),
	[47] = new t_popup_messageInfo(48,20026,"",20026,0,,1,30005,30005,30005,30005,"",""),
	[48] = new t_popup_messageInfo(49,20027,"",20027,0,,1,30006,30006,30006,30006,"",""),
	[49] = new t_popup_messageInfo(50,20028,"",20028,0,,1,30007,30007,30007,30007,"",""),
	[50] = new t_popup_messageInfo(51,20029,"",20029,0,,1,30008,30008,30008,30008,"",""),
	[51] = new t_popup_messageInfo(52,20030,"",20030,0,,1,30009,30009,30009,30009,"",""),
	[52] = new t_popup_messageInfo(53,20031,"",20031,0,,1,11002,11002,11002,11002,"",""),
	[53] = new t_popup_messageInfo(54,30001,"",30001,0,,1,20018,20018,20018,20018,"",""),
	[54] = new t_popup_messageInfo(55,30002,"",30002,0,,1,20019,20019,20019,20019,"",""),
	[55] = new t_popup_messageInfo(56,30003,"",30003,0,,1,20020,20020,20020,20020,"",""),
	[56] = new t_popup_messageInfo(57,30004,"",30004,0,,1,20021,20021,20021,20021,"",""),
	[57] = new t_popup_messageInfo(58,30005,"",30005,0,,1,20022,20022,20022,20022,"",""),
	[58] = new t_popup_messageInfo(59,30006,"",30006,0,,1,20023,20023,20023,20023,"",""),
	[59] = new t_popup_messageInfo(60,30007,"",30007,0,,1,20024,20024,20024,20024,"",""),
	[60] = new t_popup_messageInfo(61,30008,"",30008,0,,1,20025,20025,20025,20025,"",""),
	[61] = new t_popup_messageInfo(62,30009,"",30009,0,,1,20026,20026,20026,20026,"",""),
	[62] = new t_popup_messageInfo(63,30010,"",30010,0,,1,20027,20027,20027,20027,"",""),
	[63] = new t_popup_messageInfo(64,30011,"",30011,0,,1,20028,20028,20028,20028,"",""),
	[64] = new t_popup_messageInfo(65,30012,"",30012,0,,1,20029,20029,20029,20029,"",""),
	[65] = new t_popup_messageInfo(66,30013,"",30013,0,,1,20030,20030,20030,20030,"",""),
	[66] = new t_popup_messageInfo(67,30014,"",30014,0,,1,20031,20031,20031,20031,"",""),
	[67] = new t_popup_messageInfo(68,30015,"",30015,0,,1,20032,20032,20032,20032,"",""),
	[68] = new t_popup_messageInfo(69,30016,"",30016,0,,1,20033,20033,20033,20033,"",""),
	[69] = new t_popup_messageInfo(70,30017,"",30017,0,,1,20034,20034,20034,20034,"",""),
	[70] = new t_popup_messageInfo(71,30018,"",30018,0,,1,20035,20035,20035,20035,"",""),
	[71] = new t_popup_messageInfo(72,30019,"",30019,0,,1,20036,20036,20036,20036,"",""),
	[72] = new t_popup_messageInfo(73,30020,"",30020,0,,1,20037,20037,20037,20037,"",""),
	[73] = new t_popup_messageInfo(74,30021,"",30021,0,,1,20038,20038,20038,20038,"",""),
	[74] = new t_popup_messageInfo(75,30022,"",30022,0,,1,20039,20039,20039,20039,"",""),
	[75] = new t_popup_messageInfo(76,30023,"",30023,0,,1,20040,20040,20040,20040,"",""),
	[76] = new t_popup_messageInfo(77,30024,"",30024,0,,1,20041,20041,20041,20041,"",""),
};
}
