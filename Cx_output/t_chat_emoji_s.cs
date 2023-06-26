using System.Collections.Generic;
public class t_chat_emoji_sInfo
{
public int id;
public int a_base_emoji_id;
public int a_base_group;
public string c_base_emoji_short_name;
public string c_base_cover_path;
public string c_base_emoji_res;
public string c_base_res_path;
public t_chat_emoji_sInfo(int id,int a_base_emoji_id,int a_base_group,string c_base_emoji_short_name,string c_base_cover_path,string c_base_emoji_res,string c_base_res_path)
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
public static List<t_chat_emoji_sInfo> list = new List<t_chat_emoji_sInfo>()
{
	[0] = new t_chat_emoji_sInfo(1,101,1,"[#101]","Icons/Chats/UI_Emoji_Cover_1","UI_Emoji_101","Icons/Chats/UI_Emoji_101"),
	[1] = new t_chat_emoji_sInfo(2,102,1,"[#102]","","UI_Emoji_102","Icons/Chats/UI_Emoji_102"),
	[2] = new t_chat_emoji_sInfo(3,103,1,"[#103]","","UI_Emoji_103","Icons/Chats/UI_Emoji_103"),
	[3] = new t_chat_emoji_sInfo(4,104,1,"[#104]","","UI_Emoji_104","Icons/Chats/UI_Emoji_104"),
	[4] = new t_chat_emoji_sInfo(5,105,1,"[#105]","","UI_Emoji_105","Icons/Chats/UI_Emoji_105"),
	[5] = new t_chat_emoji_sInfo(6,106,1,"[#106]","","UI_Emoji_106","Icons/Chats/UI_Emoji_106"),
	[6] = new t_chat_emoji_sInfo(7,107,1,"[#107]","","UI_Emoji_107","Icons/Chats/UI_Emoji_107"),
	[7] = new t_chat_emoji_sInfo(8,108,1,"[#108]","","UI_Emoji_108","Icons/Chats/UI_Emoji_108"),
	[8] = new t_chat_emoji_sInfo(9,109,1,"[#109]","","UI_Emoji_109","Icons/Chats/UI_Emoji_109"),
	[9] = new t_chat_emoji_sInfo(10,110,1,"[#110]","","UI_Emoji_110","Icons/Chats/UI_Emoji_110"),
	[10] = new t_chat_emoji_sInfo(11,111,1,"[#111]","","UI_Emoji_111","Icons/Chats/UI_Emoji_111"),
	[11] = new t_chat_emoji_sInfo(12,112,1,"[#112]","","UI_Emoji_112","Icons/Chats/UI_Emoji_112"),
	[12] = new t_chat_emoji_sInfo(13,113,1,"[#113]","","UI_Emoji_113","Icons/Chats/UI_Emoji_113"),
	[13] = new t_chat_emoji_sInfo(14,114,1,"[#114]","","UI_Emoji_114","Icons/Chats/UI_Emoji_114"),
	[14] = new t_chat_emoji_sInfo(15,115,1,"[#115]","","UI_Emoji_115","Icons/Chats/UI_Emoji_115"),
	[15] = new t_chat_emoji_sInfo(16,116,1,"[#116]","","UI_Emoji_116","Icons/Chats/UI_Emoji_116"),
	[16] = new t_chat_emoji_sInfo(17,117,1,"[#117]","","UI_Emoji_117","Icons/Chats/UI_Emoji_117"),
	[17] = new t_chat_emoji_sInfo(18,118,1,"[#118]","","UI_Emoji_118","Icons/Chats/UI_Emoji_118"),
	[18] = new t_chat_emoji_sInfo(19,119,1,"[#119]","","UI_Emoji_119","Icons/Chats/UI_Emoji_119"),
	[19] = new t_chat_emoji_sInfo(20,120,1,"[#120]","","UI_Emoji_120","Icons/Chats/UI_Emoji_120"),
	[20] = new t_chat_emoji_sInfo(21,121,1,"[#121]","","UI_Emoji_121","Icons/Chats/UI_Emoji_121"),
	[21] = new t_chat_emoji_sInfo(22,122,1,"[#122]","","UI_Emoji_122","Icons/Chats/UI_Emoji_122"),
	[22] = new t_chat_emoji_sInfo(23,123,1,"[#123]","","UI_Emoji_123","Icons/Chats/UI_Emoji_123"),
	[23] = new t_chat_emoji_sInfo(24,124,1,"[#124]","","UI_Emoji_124","Icons/Chats/UI_Emoji_124"),
	[24] = new t_chat_emoji_sInfo(25,125,1,"[#125]","","UI_Emoji_125","Icons/Chats/UI_Emoji_125"),
	[25] = new t_chat_emoji_sInfo(26,126,1,"[#126]","","UI_Emoji_126","Icons/Chats/UI_Emoji_126"),
	[26] = new t_chat_emoji_sInfo(27,127,1,"[#127]","","UI_Emoji_127","Icons/Chats/UI_Emoji_127"),
	[27] = new t_chat_emoji_sInfo(28,128,1,"[#128]","","UI_Emoji_128","Icons/Chats/UI_Emoji_128"),
	[28] = new t_chat_emoji_sInfo(29,129,1,"[#129]","","UI_Emoji_129","Icons/Chats/UI_Emoji_129"),
	[29] = new t_chat_emoji_sInfo(30,130,1,"[#130]","","UI_Emoji_130","Icons/Chats/UI_Emoji_130"),
	[30] = new t_chat_emoji_sInfo(31,131,1,"[#131]","","UI_Emoji_131","Icons/Chats/UI_Emoji_131"),
	[31] = new t_chat_emoji_sInfo(32,132,1,"[#132]","","UI_Emoji_132","Icons/Chats/UI_Emoji_132"),
	[32] = new t_chat_emoji_sInfo(33,133,1,"[#133]","","UI_Emoji_133","Icons/Chats/UI_Emoji_133"),
	[33] = new t_chat_emoji_sInfo(34,134,1,"[#134]","","UI_Emoji_134","Icons/Chats/UI_Emoji_134"),
	[34] = new t_chat_emoji_sInfo(35,135,1,"[#135]","","UI_Emoji_135","Icons/Chats/UI_Emoji_135"),
	[35] = new t_chat_emoji_sInfo(36,136,1,"[#136]","","UI_Emoji_136","Icons/Chats/UI_Emoji_136"),
	[36] = new t_chat_emoji_sInfo(37,137,1,"[#137]","","UI_Emoji_137","Icons/Chats/UI_Emoji_137"),
	[37] = new t_chat_emoji_sInfo(38,138,1,"[#138]","","UI_Emoji_138","Icons/Chats/UI_Emoji_138"),
	[38] = new t_chat_emoji_sInfo(39,139,1,"[#139]","","UI_Emoji_139","Icons/Chats/UI_Emoji_139"),
	[39] = new t_chat_emoji_sInfo(40,140,1,"[#140]","","UI_Emoji_140","Icons/Chats/UI_Emoji_140"),
	[40] = new t_chat_emoji_sInfo(41,141,1,"[#141]","","UI_Emoji_141","Icons/Chats/UI_Emoji_141"),
	[41] = new t_chat_emoji_sInfo(42,142,1,"[#142]","","UI_Emoji_142","Icons/Chats/UI_Emoji_142"),
	[42] = new t_chat_emoji_sInfo(43,143,1,"[#143]","","UI_Emoji_143","Icons/Chats/UI_Emoji_143"),
	[43] = new t_chat_emoji_sInfo(44,144,1,"[#144]","","UI_Emoji_144","Icons/Chats/UI_Emoji_144"),
	[44] = new t_chat_emoji_sInfo(45,145,1,"[#145]","","UI_Emoji_145","Icons/Chats/UI_Emoji_145"),
	[45] = new t_chat_emoji_sInfo(46,146,1,"[#146]","","UI_Emoji_146","Icons/Chats/UI_Emoji_146"),
	[46] = new t_chat_emoji_sInfo(47,147,1,"[#147]","","UI_Emoji_147","Icons/Chats/UI_Emoji_147"),
	[47] = new t_chat_emoji_sInfo(48,148,1,"[#148]","","UI_Emoji_148","Icons/Chats/UI_Emoji_148"),
	[48] = new t_chat_emoji_sInfo(49,149,1,"[#149]","","UI_Emoji_149","Icons/Chats/UI_Emoji_149"),
	[49] = new t_chat_emoji_sInfo(50,150,1,"[#150]","","UI_Emoji_150","Icons/Chats/UI_Emoji_150"),
	[50] = new t_chat_emoji_sInfo(51,151,1,"[#151]","","UI_Emoji_151","Icons/Chats/UI_Emoji_151"),
	[51] = new t_chat_emoji_sInfo(52,152,1,"[#152]","","UI_Emoji_152","Icons/Chats/UI_Emoji_152"),
	[52] = new t_chat_emoji_sInfo(53,153,1,"[#153]","","UI_Emoji_153","Icons/Chats/UI_Emoji_153"),
	[53] = new t_chat_emoji_sInfo(54,154,1,"[#154]","","UI_Emoji_154","Icons/Chats/UI_Emoji_154"),
	[54] = new t_chat_emoji_sInfo(55,155,1,"[#155]","","UI_Emoji_155","Icons/Chats/UI_Emoji_155"),
	[55] = new t_chat_emoji_sInfo(56,156,1,"[#156]","","UI_Emoji_156","Icons/Chats/UI_Emoji_156"),
	[56] = new t_chat_emoji_sInfo(57,157,1,"[#157]","","UI_Emoji_157","Icons/Chats/UI_Emoji_157"),
	[57] = new t_chat_emoji_sInfo(58,158,1,"[#158]","","UI_Emoji_158","Icons/Chats/UI_Emoji_158"),
	[58] = new t_chat_emoji_sInfo(59,159,1,"[#159]","","UI_Emoji_159","Icons/Chats/UI_Emoji_159"),
	[59] = new t_chat_emoji_sInfo(60,160,1,"[#160]","","UI_Emoji_160","Icons/Chats/UI_Emoji_160"),
	[60] = new t_chat_emoji_sInfo(61,161,1,"[#161]","","UI_Emoji_161","Icons/Chats/UI_Emoji_161"),
	[61] = new t_chat_emoji_sInfo(62,162,1,"[#162]","","UI_Emoji_162","Icons/Chats/UI_Emoji_162"),
	[62] = new t_chat_emoji_sInfo(63,163,1,"[#163]","","UI_Emoji_163","Icons/Chats/UI_Emoji_163"),
	[63] = new t_chat_emoji_sInfo(64,164,1,"[#164]","","UI_Emoji_164","Icons/Chats/UI_Emoji_164"),
	[64] = new t_chat_emoji_sInfo(65,165,1,"[#165]","","UI_Emoji_165","Icons/Chats/UI_Emoji_165"),
	[65] = new t_chat_emoji_sInfo(66,166,1,"[#166]","","UI_Emoji_166","Icons/Chats/UI_Emoji_166"),
	[66] = new t_chat_emoji_sInfo(67,167,1,"[#167]","","UI_Emoji_167","Icons/Chats/UI_Emoji_167"),
	[67] = new t_chat_emoji_sInfo(68,168,1,"[#168]","","UI_Emoji_168","Icons/Chats/UI_Emoji_168"),
	[68] = new t_chat_emoji_sInfo(69,201,2,"","Icons/Chats/UI_Sticker_Cover_2","","Icons/Chats/UI_Sticker_201"),
	[69] = new t_chat_emoji_sInfo(70,202,2,"","","","Icons/Chats/UI_Sticker_202"),
	[70] = new t_chat_emoji_sInfo(71,203,2,"","","","Icons/Chats/UI_Sticker_203"),
	[71] = new t_chat_emoji_sInfo(72,204,2,"","","","Icons/Chats/UI_Sticker_204"),
	[72] = new t_chat_emoji_sInfo(73,205,2,"","","","Icons/Chats/UI_Sticker_205"),
	[73] = new t_chat_emoji_sInfo(74,206,2,"","","","Icons/Chats/UI_Sticker_206"),
	[74] = new t_chat_emoji_sInfo(75,207,2,"","","","Icons/Chats/UI_Sticker_207"),
	[75] = new t_chat_emoji_sInfo(76,208,2,"","","","Icons/Chats/UI_Sticker_208"),
	[76] = new t_chat_emoji_sInfo(77,209,2,"","","","Icons/Chats/UI_Sticker_209"),
	[77] = new t_chat_emoji_sInfo(78,210,2,"","","","Icons/Chats/UI_Sticker_210"),
	[78] = new t_chat_emoji_sInfo(79,211,2,"","","","Icons/Chats/UI_Sticker_211"),
};
}
