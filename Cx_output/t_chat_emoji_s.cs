using System.Collections.Generic;
public class Cfg_t_chat_emoji_s_Info
{
public int id;
public int a_base_emoji_id;
public int a_base_group;
public string c_base_emoji_short_name;
public string c_base_cover_path;
public string c_base_emoji_res;
public string c_base_res_path;
public Cfg_t_chat_emoji_s_Info(int id,int a_base_emoji_id,int a_base_group,string c_base_emoji_short_name,string c_base_cover_path,string c_base_emoji_res,string c_base_res_path)
{
  this.id = id;
  this.a_base_emoji_id = a_base_emoji_id;
  this.a_base_group = a_base_group;
  this.c_base_emoji_short_name = c_base_emoji_short_name;
  this.c_base_cover_path = c_base_cover_path;
  this.c_base_emoji_res = c_base_emoji_res;
  this.c_base_res_path = c_base_res_path;
}
}
public class Cfg_t_chat_emoji_s
{
public static List<Cfg_t_chat_emoji_s_Info> list = new List<Cfg_t_chat_emoji_s_Info>()
{
	[0] = new Cfg_t_chat_emoji_s_Info(1,101,1,"[#101]","Icons/Chats/UI_Emoji_Cover_1","UI_Emoji_101","Icons/Chats/UI_Emoji_101"),
	[1] = new Cfg_t_chat_emoji_s_Info(2,102,1,"[#102]","","UI_Emoji_102","Icons/Chats/UI_Emoji_102"),
	[2] = new Cfg_t_chat_emoji_s_Info(3,103,1,"[#103]","","UI_Emoji_103","Icons/Chats/UI_Emoji_103"),
	[3] = new Cfg_t_chat_emoji_s_Info(4,104,1,"[#104]","","UI_Emoji_104","Icons/Chats/UI_Emoji_104"),
	[4] = new Cfg_t_chat_emoji_s_Info(5,105,1,"[#105]","","UI_Emoji_105","Icons/Chats/UI_Emoji_105"),
	[5] = new Cfg_t_chat_emoji_s_Info(6,106,1,"[#106]","","UI_Emoji_106","Icons/Chats/UI_Emoji_106"),
	[6] = new Cfg_t_chat_emoji_s_Info(7,107,1,"[#107]","","UI_Emoji_107","Icons/Chats/UI_Emoji_107"),
	[7] = new Cfg_t_chat_emoji_s_Info(8,108,1,"[#108]","","UI_Emoji_108","Icons/Chats/UI_Emoji_108"),
	[8] = new Cfg_t_chat_emoji_s_Info(9,109,1,"[#109]","","UI_Emoji_109","Icons/Chats/UI_Emoji_109"),
	[9] = new Cfg_t_chat_emoji_s_Info(10,110,1,"[#110]","","UI_Emoji_110","Icons/Chats/UI_Emoji_110"),
	[10] = new Cfg_t_chat_emoji_s_Info(11,111,1,"[#111]","","UI_Emoji_111","Icons/Chats/UI_Emoji_111"),
	[11] = new Cfg_t_chat_emoji_s_Info(12,112,1,"[#112]","","UI_Emoji_112","Icons/Chats/UI_Emoji_112"),
	[12] = new Cfg_t_chat_emoji_s_Info(13,113,1,"[#113]","","UI_Emoji_113","Icons/Chats/UI_Emoji_113"),
	[13] = new Cfg_t_chat_emoji_s_Info(14,114,1,"[#114]","","UI_Emoji_114","Icons/Chats/UI_Emoji_114"),
	[14] = new Cfg_t_chat_emoji_s_Info(15,115,1,"[#115]","","UI_Emoji_115","Icons/Chats/UI_Emoji_115"),
	[15] = new Cfg_t_chat_emoji_s_Info(16,116,1,"[#116]","","UI_Emoji_116","Icons/Chats/UI_Emoji_116"),
	[16] = new Cfg_t_chat_emoji_s_Info(17,117,1,"[#117]","","UI_Emoji_117","Icons/Chats/UI_Emoji_117"),
	[17] = new Cfg_t_chat_emoji_s_Info(18,118,1,"[#118]","","UI_Emoji_118","Icons/Chats/UI_Emoji_118"),
	[18] = new Cfg_t_chat_emoji_s_Info(19,119,1,"[#119]","","UI_Emoji_119","Icons/Chats/UI_Emoji_119"),
	[19] = new Cfg_t_chat_emoji_s_Info(20,120,1,"[#120]","","UI_Emoji_120","Icons/Chats/UI_Emoji_120"),
	[20] = new Cfg_t_chat_emoji_s_Info(21,121,1,"[#121]","","UI_Emoji_121","Icons/Chats/UI_Emoji_121"),
	[21] = new Cfg_t_chat_emoji_s_Info(22,122,1,"[#122]","","UI_Emoji_122","Icons/Chats/UI_Emoji_122"),
	[22] = new Cfg_t_chat_emoji_s_Info(23,123,1,"[#123]","","UI_Emoji_123","Icons/Chats/UI_Emoji_123"),
	[23] = new Cfg_t_chat_emoji_s_Info(24,124,1,"[#124]","","UI_Emoji_124","Icons/Chats/UI_Emoji_124"),
	[24] = new Cfg_t_chat_emoji_s_Info(25,125,1,"[#125]","","UI_Emoji_125","Icons/Chats/UI_Emoji_125"),
	[25] = new Cfg_t_chat_emoji_s_Info(26,126,1,"[#126]","","UI_Emoji_126","Icons/Chats/UI_Emoji_126"),
	[26] = new Cfg_t_chat_emoji_s_Info(27,127,1,"[#127]","","UI_Emoji_127","Icons/Chats/UI_Emoji_127"),
	[27] = new Cfg_t_chat_emoji_s_Info(28,128,1,"[#128]","","UI_Emoji_128","Icons/Chats/UI_Emoji_128"),
	[28] = new Cfg_t_chat_emoji_s_Info(29,129,1,"[#129]","","UI_Emoji_129","Icons/Chats/UI_Emoji_129"),
	[29] = new Cfg_t_chat_emoji_s_Info(30,130,1,"[#130]","","UI_Emoji_130","Icons/Chats/UI_Emoji_130"),
	[30] = new Cfg_t_chat_emoji_s_Info(31,131,1,"[#131]","","UI_Emoji_131","Icons/Chats/UI_Emoji_131"),
	[31] = new Cfg_t_chat_emoji_s_Info(32,132,1,"[#132]","","UI_Emoji_132","Icons/Chats/UI_Emoji_132"),
	[32] = new Cfg_t_chat_emoji_s_Info(33,133,1,"[#133]","","UI_Emoji_133","Icons/Chats/UI_Emoji_133"),
	[33] = new Cfg_t_chat_emoji_s_Info(34,134,1,"[#134]","","UI_Emoji_134","Icons/Chats/UI_Emoji_134"),
	[34] = new Cfg_t_chat_emoji_s_Info(35,135,1,"[#135]","","UI_Emoji_135","Icons/Chats/UI_Emoji_135"),
	[35] = new Cfg_t_chat_emoji_s_Info(36,136,1,"[#136]","","UI_Emoji_136","Icons/Chats/UI_Emoji_136"),
	[36] = new Cfg_t_chat_emoji_s_Info(37,137,1,"[#137]","","UI_Emoji_137","Icons/Chats/UI_Emoji_137"),
	[37] = new Cfg_t_chat_emoji_s_Info(38,138,1,"[#138]","","UI_Emoji_138","Icons/Chats/UI_Emoji_138"),
	[38] = new Cfg_t_chat_emoji_s_Info(39,139,1,"[#139]","","UI_Emoji_139","Icons/Chats/UI_Emoji_139"),
	[39] = new Cfg_t_chat_emoji_s_Info(40,140,1,"[#140]","","UI_Emoji_140","Icons/Chats/UI_Emoji_140"),
	[40] = new Cfg_t_chat_emoji_s_Info(41,141,1,"[#141]","","UI_Emoji_141","Icons/Chats/UI_Emoji_141"),
	[41] = new Cfg_t_chat_emoji_s_Info(42,142,1,"[#142]","","UI_Emoji_142","Icons/Chats/UI_Emoji_142"),
	[42] = new Cfg_t_chat_emoji_s_Info(43,143,1,"[#143]","","UI_Emoji_143","Icons/Chats/UI_Emoji_143"),
	[43] = new Cfg_t_chat_emoji_s_Info(44,144,1,"[#144]","","UI_Emoji_144","Icons/Chats/UI_Emoji_144"),
	[44] = new Cfg_t_chat_emoji_s_Info(45,145,1,"[#145]","","UI_Emoji_145","Icons/Chats/UI_Emoji_145"),
	[45] = new Cfg_t_chat_emoji_s_Info(46,146,1,"[#146]","","UI_Emoji_146","Icons/Chats/UI_Emoji_146"),
	[46] = new Cfg_t_chat_emoji_s_Info(47,147,1,"[#147]","","UI_Emoji_147","Icons/Chats/UI_Emoji_147"),
	[47] = new Cfg_t_chat_emoji_s_Info(48,148,1,"[#148]","","UI_Emoji_148","Icons/Chats/UI_Emoji_148"),
	[48] = new Cfg_t_chat_emoji_s_Info(49,149,1,"[#149]","","UI_Emoji_149","Icons/Chats/UI_Emoji_149"),
	[49] = new Cfg_t_chat_emoji_s_Info(50,150,1,"[#150]","","UI_Emoji_150","Icons/Chats/UI_Emoji_150"),
	[50] = new Cfg_t_chat_emoji_s_Info(51,151,1,"[#151]","","UI_Emoji_151","Icons/Chats/UI_Emoji_151"),
	[51] = new Cfg_t_chat_emoji_s_Info(52,152,1,"[#152]","","UI_Emoji_152","Icons/Chats/UI_Emoji_152"),
	[52] = new Cfg_t_chat_emoji_s_Info(53,153,1,"[#153]","","UI_Emoji_153","Icons/Chats/UI_Emoji_153"),
	[53] = new Cfg_t_chat_emoji_s_Info(54,154,1,"[#154]","","UI_Emoji_154","Icons/Chats/UI_Emoji_154"),
	[54] = new Cfg_t_chat_emoji_s_Info(55,155,1,"[#155]","","UI_Emoji_155","Icons/Chats/UI_Emoji_155"),
	[55] = new Cfg_t_chat_emoji_s_Info(56,156,1,"[#156]","","UI_Emoji_156","Icons/Chats/UI_Emoji_156"),
	[56] = new Cfg_t_chat_emoji_s_Info(57,157,1,"[#157]","","UI_Emoji_157","Icons/Chats/UI_Emoji_157"),
	[57] = new Cfg_t_chat_emoji_s_Info(58,158,1,"[#158]","","UI_Emoji_158","Icons/Chats/UI_Emoji_158"),
	[58] = new Cfg_t_chat_emoji_s_Info(59,159,1,"[#159]","","UI_Emoji_159","Icons/Chats/UI_Emoji_159"),
	[59] = new Cfg_t_chat_emoji_s_Info(60,160,1,"[#160]","","UI_Emoji_160","Icons/Chats/UI_Emoji_160"),
	[60] = new Cfg_t_chat_emoji_s_Info(61,161,1,"[#161]","","UI_Emoji_161","Icons/Chats/UI_Emoji_161"),
	[61] = new Cfg_t_chat_emoji_s_Info(62,162,1,"[#162]","","UI_Emoji_162","Icons/Chats/UI_Emoji_162"),
	[62] = new Cfg_t_chat_emoji_s_Info(63,163,1,"[#163]","","UI_Emoji_163","Icons/Chats/UI_Emoji_163"),
	[63] = new Cfg_t_chat_emoji_s_Info(64,164,1,"[#164]","","UI_Emoji_164","Icons/Chats/UI_Emoji_164"),
	[64] = new Cfg_t_chat_emoji_s_Info(65,165,1,"[#165]","","UI_Emoji_165","Icons/Chats/UI_Emoji_165"),
	[65] = new Cfg_t_chat_emoji_s_Info(66,166,1,"[#166]","","UI_Emoji_166","Icons/Chats/UI_Emoji_166"),
	[66] = new Cfg_t_chat_emoji_s_Info(67,167,1,"[#167]","","UI_Emoji_167","Icons/Chats/UI_Emoji_167"),
	[67] = new Cfg_t_chat_emoji_s_Info(68,168,1,"[#168]","","UI_Emoji_168","Icons/Chats/UI_Emoji_168"),
	[68] = new Cfg_t_chat_emoji_s_Info(69,201,2,"","Icons/Chats/UI_Sticker_Cover_2","","Icons/Chats/UI_Sticker_201"),
	[69] = new Cfg_t_chat_emoji_s_Info(70,202,2,"","","","Icons/Chats/UI_Sticker_202"),
	[70] = new Cfg_t_chat_emoji_s_Info(71,203,2,"","","","Icons/Chats/UI_Sticker_203"),
	[71] = new Cfg_t_chat_emoji_s_Info(72,204,2,"","","","Icons/Chats/UI_Sticker_204"),
	[72] = new Cfg_t_chat_emoji_s_Info(73,205,2,"","","","Icons/Chats/UI_Sticker_205"),
	[73] = new Cfg_t_chat_emoji_s_Info(74,206,2,"","","","Icons/Chats/UI_Sticker_206"),
	[74] = new Cfg_t_chat_emoji_s_Info(75,207,2,"","","","Icons/Chats/UI_Sticker_207"),
	[75] = new Cfg_t_chat_emoji_s_Info(76,208,2,"","","","Icons/Chats/UI_Sticker_208"),
	[76] = new Cfg_t_chat_emoji_s_Info(77,209,2,"","","","Icons/Chats/UI_Sticker_209"),
	[77] = new Cfg_t_chat_emoji_s_Info(78,210,2,"","","","Icons/Chats/UI_Sticker_210"),
	[78] = new Cfg_t_chat_emoji_s_Info(79,211,2,"","","","Icons/Chats/UI_Sticker_211"),
};
}
