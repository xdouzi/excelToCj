using System.Collections.Generic;
public class t_newplayerInfo
{
public int id;
public int a_base_step_id;
public string c_ints_maincitylevel;
public int a_base_nextstep_id;
public int a_base_taskstep_id;
public int a_base_taskreward_id;
public string a_ints_branchline_id;
public int a_base_step_show;
public int c_base_panel_id;
public int c_base_autoclick;
public int c_base_scene_id;
public int c_base_plote_startid;
public int c_base_delytime;
public t_newplayerInfo(int id,int a_base_plot_ground_id,string a_ints_aggregate_id,int a_base_skip,int a_base_auto,int a_base_wait_time,int a_base_cm,int a_base_music,int a_base_music_begin,int a_base_music_loop,int a_base_run_model,int c_base_plot_ground_delytimeint id,int a_base_plot_id,int a_base_ground_id,int a_base_plot_type,string a_ints_plot_message,int a_base_plot_talk,int a_base_plot_words,int a_base_plot_auto,int a_base_wait_plot_time,int c_base_plot_show,string c_base_plot_action,int c_base_name_show,string c_base_bust,int c_base_plot_loop,string c_base_picture,int a_base_picture_life,int a_base_picture_move,int a_base_picture_speed,int a_base_animation,string c_base_whitelist,string c_base_refpoint_path,int c_base_arrow,string c_ints_arrowshifting,int c_base_light,string c_ints_lightshifting,int c_base_finger,int c_base_finger_type,int c_base_clickscale,string c_ints_fingershifting_01,string c_ints_fingershifting_02,int c_base_fingermovetime,int c_base_light_finish,string c_ints_talkshifting,string c_ints_camera,int c_base_scale,string c_base_camera_target_point,int c_base_camera_move_time,int c_base_stop,string c_ints_canui,int c_base_endnow,string c_base_picture_name,int c_base_vagueint id,int a_base_step_id,string c_ints_maincitylevel,int a_base_nextstep_id,int a_base_taskstep_id,int a_base_taskreward_id,string a_ints_branchline_id,int a_base_step_show,int c_base_panel_id,int c_base_autoclick,int c_base_scene_id,int c_base_plote_startid,int c_base_delytime)
{
  this.id = id;
  this.a_base_step_id = a_base_step_id;
  this.c_ints_maincitylevel = c_ints_maincitylevel;
  this.a_base_nextstep_id = a_base_nextstep_id;
  this.a_base_taskstep_id = a_base_taskstep_id;
  this.a_base_taskreward_id = a_base_taskreward_id;
  this.a_ints_branchline_id = a_ints_branchline_id;
  this.a_base_step_show = a_base_step_show;
  this.c_base_panel_id = c_base_panel_id;
  this.c_base_autoclick = c_base_autoclick;
  this.c_base_scene_id = c_base_scene_id;
  this.c_base_plote_startid = c_base_plote_startid;
  this.c_base_delytime = c_base_delytime;
}
}
public class Cfg_t_newplayer
{
public static List<t_newplayerInfo> list = new List<t_newplayerInfo>()
{
	[0] = new t_newplayerInfo(1,1,"",5,,,"",1,,,1,1,1),
	[1] = new t_newplayerInfo(2,2,"",,,,"",2,,,1,1,1),
	[2] = new t_newplayerInfo(3,3,"",,,,"",100001,,,1,1,1),
	[3] = new t_newplayerInfo(4,4,"",,,,"",100002,,,1,1,1),
	[4] = new t_newplayerInfo(5,5,"",7,,,"",3,,,1,1,1),
	[5] = new t_newplayerInfo(6,6,"",,,,"",100003,100003,100003,100003,100003,100003),
	[6] = new t_newplayerInfo(7,7,"",8,,,"",4,,,1,1,1),
	[7] = new t_newplayerInfo(8,8,"",9,,,"",200005,,,1,1,1),
	[8] = new t_newplayerInfo(9,9,"",11,,,"",200006,1024,,1,1,1),
	[9] = new t_newplayerInfo(10,10,"",,,,"",-1,,101,1,1,1),
	[10] = new t_newplayerInfo(11,11,"",15,,,"",5,1022,,30001,,1000),
	[11] = new t_newplayerInfo(12,12,"",,,,"",8,,,30001,18,18),
	[12] = new t_newplayerInfo(13,13,"",,,,"",9,,,30001,30001,30001),
	[13] = new t_newplayerInfo(14,14,"",,,,"",,,,1,1,1),
	[14] = new t_newplayerInfo(15,15,"",17,,,"",11,,,1,1,1),
	[15] = new t_newplayerInfo(16,16,"",,,,"",100004,100004,100004,100004,100004,100004),
	[16] = new t_newplayerInfo(17,17,"",18,,,"",12,,,1,1,1),
	[17] = new t_newplayerInfo(18,18,"",19,,,"",13,,,1,1,1),
	[18] = new t_newplayerInfo(19,19,"",20,,,"",100005,,,1,1,1),
	[19] = new t_newplayerInfo(20,20,"",22,,,"",14,,,1,,3000),
	[20] = new t_newplayerInfo(21,21,"",,,,"",,,,1,1,1),
	[21] = new t_newplayerInfo(22,22,"",23,,,"",15,,,1,1,1),
	[22] = new t_newplayerInfo(23,23,"",25,,,"",100006,,,1,1,1),
	[23] = new t_newplayerInfo(24,24,"",,,,"",,,,1,1,1),
	[24] = new t_newplayerInfo(25,25,"",26,,,"",16,,,1,1,1),
	[25] = new t_newplayerInfo(26,26,"",27,,,"",200001,,,1,1,1),
	[26] = new t_newplayerInfo(27,27,"",28,,,"",200002,1024,,1,1,1),
	[27] = new t_newplayerInfo(28,28,"",29,4000001,,"",100007,,,1,1,1),
	[28] = new t_newplayerInfo(29,29,"",31,,,"",76,,,1,1,1),
	[29] = new t_newplayerInfo(30,30,"","","","","","","","","","",""),
	[30] = new t_newplayerInfo(31,31,"",32,,,"",100008,,,1,1,1),
	[31] = new t_newplayerInfo(32,32,"",34,,,"",100009,1038,,1,1,1),
	[32] = new t_newplayerInfo(33,33,"",,,,"",100010,,,1,1,1),
	[33] = new t_newplayerInfo(34,34,"",35,4000002,,"",100011,,,1,1,1),
	[34] = new t_newplayerInfo(35,35,"",37,,,"",101,,,1,1,1),
	[35] = new t_newplayerInfo(36,36,"","","","","","","","","","",""),
	[36] = new t_newplayerInfo(37,37,"",38,4000003,1,"",102,,,1,1,1),
	[37] = new t_newplayerInfo(38,38,"",39,,,"",200003,,,1,1,1),
	[38] = new t_newplayerInfo(39,39,"",41,4000004,,"",77,,,1,1,1),
	[39] = new t_newplayerInfo(40,40,"",,,,"21","21","21","21","21","21","21"),
	[40] = new t_newplayerInfo(41,41,"",42,4000005,1,"",79,,,1,1,1),
	[41] = new t_newplayerInfo(42,42,"",45,,,"",200007,,,1,1,1),
	[42] = new t_newplayerInfo(43,43,"",,,,"",,,,1,1,1),
	[43] = new t_newplayerInfo(44,44,"",,,,"",,1042,,1,1,1),
	[44] = new t_newplayerInfo(45,45,"",48,4000007,,"",80,,,1,1,1),
	[45] = new t_newplayerInfo(46,46,"","","","","","","","","","",""),
	[46] = new t_newplayerInfo(47,47,"","","","","","","","","","",""),
	[47] = new t_newplayerInfo(48,48,"",50,4000009,1,"",81,,,1,1,1),
	[48] = new t_newplayerInfo(49,49,"","","","","","","","","","",""),
	[49] = new t_newplayerInfo(50,50,"",52,4000010,1,"",82,,,1,1,1),
	[50] = new t_newplayerInfo(51,51,"","","","","","","","","","",""),
	[51] = new t_newplayerInfo(52,52,"",54,4000011,1,"",83,,,1,1,1),
	[52] = new t_newplayerInfo(53,53,"","","","","","","","","","",""),
	[53] = new t_newplayerInfo(54,54,"",58,4000012,,"",84,,,1,1,1),
	[54] = new t_newplayerInfo(55,55,"","","","","","","","","","",""),
	[55] = new t_newplayerInfo(56,56,"","","","","","","","","","",""),
	[56] = new t_newplayerInfo(57,57,"","","","","","","","","","",""),
	[57] = new t_newplayerInfo(58,58,"",61,4000015,,"",85,,,1,1,1),
	[58] = new t_newplayerInfo(59,59,"","","","","","","","","","",""),
	[59] = new t_newplayerInfo(60,60,"","","","","","","","","","",""),
	[60] = new t_newplayerInfo(61,61,"",63,4000017,1,"",86,,,1,1,1),
	[61] = new t_newplayerInfo(62,62,"","","","","","","","","","",""),
	[62] = new t_newplayerInfo(63,63,"",68,4000018,,"",87,,,1,1,1),
	[63] = new t_newplayerInfo(64,64,"","","","","","","","","","",""),
	[64] = new t_newplayerInfo(65,65,"","","","","","","","","","",""),
	[65] = new t_newplayerInfo(66,66,"","","","","","","","","","",""),
	[66] = new t_newplayerInfo(67,67,"","","","","","","","","","",""),
	[67] = new t_newplayerInfo(68,68,"",72,4000022,1,"",88,,,1,1,1),
	[68] = new t_newplayerInfo(69,69,"","","","","","","","","","",""),
	[69] = new t_newplayerInfo(70,70,"","","","","","","","","","",""),
	[70] = new t_newplayerInfo(71,71,"","","","","","","","","","",""),
	[71] = new t_newplayerInfo(72,72,"",73,4000025,1,"",89,,,1,1,1),
	[72] = new t_newplayerInfo(73,73,"",74,,,"",200013,,,1,1,1),
	[73] = new t_newplayerInfo(74,74,"1,3",75,,,"",200014,,,1,1,1),
	[74] = new t_newplayerInfo(75,75,"",88,4000026,1,"100078",90,,,1,1,1),
	[75] = new t_newplayerInfo(76,100081,"",,,,"",200015,1052,1052,1052,1052,1052),
	[76] = new t_newplayerInfo(77,76,"",,4000027,1,"",91,,,1,1,1),
	[77] = new t_newplayerInfo(78,77,"","","","","","","","","","",""),
	[78] = new t_newplayerInfo(79,100078,"",100079,,,"",200010,1046,,1,1,1),
	[79] = new t_newplayerInfo(80,100079,"",100080,,,"",200011,1046,,1,1,1),
	[80] = new t_newplayerInfo(81,100080,"",,,,"",200012,1046,,1,1,1),
	[81] = new t_newplayerInfo(82,81,"",,,,"",,,,10001,10001,10001),
	[82] = new t_newplayerInfo(83,82,"",,,,"",,,,1,1,1),
	[83] = new t_newplayerInfo(84,83,"",,,,"",,,,10001,10001,10001),
	[84] = new t_newplayerInfo(85,84,"",,,,"",,,,10001,10001,10001),
	[85] = new t_newplayerInfo(86,85,"",,,,"",,,,10001,10001,10001),
	[86] = new t_newplayerInfo(87,86,"","","","","","","","","","",""),
	[87] = new t_newplayerInfo(88,87,"","","","","","","","","","",""),
	[88] = new t_newplayerInfo(89,88,"",90,4000030,1,"",39,,,1,1,1),
	[89] = new t_newplayerInfo(90,89,"","","","","","","","","","",""),
	[90] = new t_newplayerInfo(91,90,"",94,4000031,1,"",95,,,1,1,1),
	[91] = new t_newplayerInfo(92,91,"","","","","","","","","","",""),
	[92] = new t_newplayerInfo(93,92,"","","","","","","","","","",""),
	[93] = new t_newplayerInfo(94,93,"","","","","","","","","","",""),
	[94] = new t_newplayerInfo(95,94,"",96,4000034,1,"",96,,,1,1,1),
	[95] = new t_newplayerInfo(96,95,"","","","","","","","","","",""),
	[96] = new t_newplayerInfo(97,96,"",100,4000035,1,"",41,,,1,1,1),
	[97] = new t_newplayerInfo(98,97,"","","","","","","","","","",""),
	[98] = new t_newplayerInfo(99,98,"","","","","","","","","","",""),
	[99] = new t_newplayerInfo(100,99,"","","","","","","","","","",""),
	[100] = new t_newplayerInfo(101,100,"",107,4000038,1,"",97,,,1,1,1),
	[101] = new t_newplayerInfo(102,101,"","","","","","","","","","",""),
	[102] = new t_newplayerInfo(103,102,"","","","","","","","","","",""),
	[103] = new t_newplayerInfo(104,103,"","","","","","","","","","",""),
	[104] = new t_newplayerInfo(105,104,"","","","","","","","","","",""),
	[105] = new t_newplayerInfo(106,105,"","","","","","","","","","",""),
	[106] = new t_newplayerInfo(107,106,"","","","","","","","","","",""),
	[107] = new t_newplayerInfo(108,107,"",110,4000043,1,"",98,,,1,1,1),
	[108] = new t_newplayerInfo(109,108,"","","","","","","","","","",""),
	[109] = new t_newplayerInfo(110,109,"","","","","","","","","","",""),
	[110] = new t_newplayerInfo(111,110,"",114,4000045,1,"",44,,,1,1,1),
	[111] = new t_newplayerInfo(112,111,"","","","","","","","","","",""),
	[112] = new t_newplayerInfo(113,112,"","","","","","","","","","",""),
	[113] = new t_newplayerInfo(114,113,"","","","","","","","","","",""),
	[114] = new t_newplayerInfo(115,114,"",,,,"",,,,1,1,1),
	[115] = new t_newplayerInfo(116,115,"","","","","","","","","","",""),
	[116] = new t_newplayerInfo(117,116,"","","","","","","","","","",""),
	[117] = new t_newplayerInfo(118,119,"","","","","","","","","","",""),
	[118] = new t_newplayerInfo(119,120,"","","","","","","","","","",""),
	[119] = new t_newplayerInfo(120,121,"","","","","","","","","","",""),
	[120] = new t_newplayerInfo(121,122,"","","","","","","","","","",""),
};
}
