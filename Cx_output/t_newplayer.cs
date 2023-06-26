using System.Collections.Generic;
public class Cfg_t_newplayer_Info
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
public Cfg_t_newplayer_Info(int id,int a_base_plot_ground_id,string a_ints_aggregate_id,int a_base_skip,int a_base_auto,int a_base_wait_time,int a_base_cm,int a_base_music,int a_base_music_begin,int a_base_music_loop,int a_base_run_model,int c_base_plot_ground_delytimeint id,int a_base_plot_id,int a_base_ground_id,int a_base_plot_type,string a_ints_plot_message,int a_base_plot_talk,int a_base_plot_words,int a_base_plot_auto,int a_base_wait_plot_time,int c_base_plot_show,string c_base_plot_action,int c_base_name_show,string c_base_bust,int c_base_plot_loop,string c_base_picture,int a_base_picture_life,int a_base_picture_move,int a_base_picture_speed,int a_base_animation,string c_base_whitelist,string c_base_refpoint_path,int c_base_arrow,string c_ints_arrowshifting,int c_base_light,string c_ints_lightshifting,int c_base_finger,int c_base_finger_type,int c_base_clickscale,string c_ints_fingershifting_01,string c_ints_fingershifting_02,int c_base_fingermovetime,int c_base_light_finish,string c_ints_talkshifting,string c_ints_camera,int c_base_scale,string c_base_camera_target_point,int c_base_camera_move_time,int c_base_stop,string c_ints_canui,int c_base_endnow,string c_base_picture_name,int c_base_vagueint id,int a_base_step_id,string c_ints_maincitylevel,int a_base_nextstep_id,int a_base_taskstep_id,int a_base_taskreward_id,string a_ints_branchline_id,int a_base_step_show,int c_base_panel_id,int c_base_autoclick,int c_base_scene_id,int c_base_plote_startid,int c_base_delytime)
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
public static Dictionary<string,Cfg_t_newplayer_Info> list = new Dictionary<string,Cfg_t_newplayer_Info>()
{
	["1"] = new Cfg_t_newplayer_Info(1,1,"",5,,,"",1,,,1,,),
	["2"] = new Cfg_t_newplayer_Info(2,2,"",,,,"",2,,,1,,),
	["3"] = new Cfg_t_newplayer_Info(3,3,"",,,,"",100001,,,1,,),
	["4"] = new Cfg_t_newplayer_Info(4,4,"",,,,"",100002,,,1,,),
	["5"] = new Cfg_t_newplayer_Info(5,5,"",7,,,"",3,,,1,,),
	["6"] = new Cfg_t_newplayer_Info(6,6,"",,,,"",100003,,,,,),
	["7"] = new Cfg_t_newplayer_Info(7,7,"",8,,,"",4,,,1,,),
	["8"] = new Cfg_t_newplayer_Info(8,8,"",9,,,"",200005,,,1,,),
	["9"] = new Cfg_t_newplayer_Info(9,9,"",11,,,"",200006,1024,,1,,),
	["10"] = new Cfg_t_newplayer_Info(10,10,"",,,,"",-1,,101,1,,),
	["11"] = new Cfg_t_newplayer_Info(11,11,"",15,,,"",5,1022,,30001,,1000),
	["12"] = new Cfg_t_newplayer_Info(12,12,"",,,,"",8,,,30001,18,),
	["13"] = new Cfg_t_newplayer_Info(13,13,"",,,,"",9,,,30001,,),
	["14"] = new Cfg_t_newplayer_Info(14,14,"",,,,"",,,,1,,),
	["15"] = new Cfg_t_newplayer_Info(15,15,"",17,,,"",11,,,1,,),
	["16"] = new Cfg_t_newplayer_Info(16,16,"",,,,"",100004,,,,,),
	["17"] = new Cfg_t_newplayer_Info(17,17,"",18,,,"",12,,,1,,),
	["18"] = new Cfg_t_newplayer_Info(18,18,"",19,,,"",13,,,1,,),
	["19"] = new Cfg_t_newplayer_Info(19,19,"",20,,,"",100005,,,1,,),
	["20"] = new Cfg_t_newplayer_Info(20,20,"",22,,,"",14,,,1,,3000),
	["21"] = new Cfg_t_newplayer_Info(21,21,"",,,,"",,,,1,,),
	["22"] = new Cfg_t_newplayer_Info(22,22,"",23,,,"",15,,,1,,),
	["23"] = new Cfg_t_newplayer_Info(23,23,"",25,,,"",100006,,,1,,),
	["24"] = new Cfg_t_newplayer_Info(24,24,"",,,,"",,,,1,,),
	["25"] = new Cfg_t_newplayer_Info(25,25,"",26,,,"",16,,,1,,),
	["26"] = new Cfg_t_newplayer_Info(26,26,"",27,,,"",200001,,,1,,),
	["27"] = new Cfg_t_newplayer_Info(27,27,"",28,,,"",200002,1024,,1,,),
	["28"] = new Cfg_t_newplayer_Info(28,28,"",29,4000001,,"",100007,,,1,,),
	["29"] = new Cfg_t_newplayer_Info(29,29,"",31,,,"",76,,,1,,),
	["30"] = new Cfg_t_newplayer_Info(30,30,"",,,,"",,,,,,),
	["31"] = new Cfg_t_newplayer_Info(31,31,"",32,,,"",100008,,,1,,),
	["32"] = new Cfg_t_newplayer_Info(32,32,"",34,,,"",100009,1038,,1,,),
	["33"] = new Cfg_t_newplayer_Info(33,33,"",,,,"",100010,,,1,,),
	["34"] = new Cfg_t_newplayer_Info(34,34,"",35,4000002,,"",100011,,,1,,),
	["35"] = new Cfg_t_newplayer_Info(35,35,"",37,,,"",101,,,1,,),
	["36"] = new Cfg_t_newplayer_Info(36,36,"",,,,"",,,,,,),
	["37"] = new Cfg_t_newplayer_Info(37,37,"",38,4000003,1,"",102,,,1,,),
	["38"] = new Cfg_t_newplayer_Info(38,38,"",39,,,"",200003,,,1,,),
	["39"] = new Cfg_t_newplayer_Info(39,39,"",41,4000004,,"",77,,,1,,),
	["40"] = new Cfg_t_newplayer_Info(40,40,"",,,,"21",,,,,,),
	["41"] = new Cfg_t_newplayer_Info(41,41,"",42,4000005,1,"",79,,,1,,),
	["42"] = new Cfg_t_newplayer_Info(42,42,"",45,,,"",200007,,,1,,),
	["43"] = new Cfg_t_newplayer_Info(43,43,"",,,,"",,,,1,,),
	["44"] = new Cfg_t_newplayer_Info(44,44,"",,,,"",,1042,,1,,),
	["45"] = new Cfg_t_newplayer_Info(45,45,"",48,4000007,,"",80,,,1,,),
	["46"] = new Cfg_t_newplayer_Info(46,46,"",,,,"",,,,,,),
	["47"] = new Cfg_t_newplayer_Info(47,47,"",,,,"",,,,,,),
	["48"] = new Cfg_t_newplayer_Info(48,48,"",50,4000009,1,"",81,,,1,,),
	["49"] = new Cfg_t_newplayer_Info(49,49,"",,,,"",,,,,,),
	["50"] = new Cfg_t_newplayer_Info(50,50,"",52,4000010,1,"",82,,,1,,),
	["51"] = new Cfg_t_newplayer_Info(51,51,"",,,,"",,,,,,),
	["52"] = new Cfg_t_newplayer_Info(52,52,"",54,4000011,1,"",83,,,1,,),
	["53"] = new Cfg_t_newplayer_Info(53,53,"",,,,"",,,,,,),
	["54"] = new Cfg_t_newplayer_Info(54,54,"",58,4000012,,"",84,,,1,,),
	["55"] = new Cfg_t_newplayer_Info(55,55,"",,,,"",,,,,,),
	["56"] = new Cfg_t_newplayer_Info(56,56,"",,,,"",,,,,,),
	["57"] = new Cfg_t_newplayer_Info(57,57,"",,,,"",,,,,,),
	["58"] = new Cfg_t_newplayer_Info(58,58,"",61,4000015,,"",85,,,1,,),
	["59"] = new Cfg_t_newplayer_Info(59,59,"",,,,"",,,,,,),
	["60"] = new Cfg_t_newplayer_Info(60,60,"",,,,"",,,,,,),
	["61"] = new Cfg_t_newplayer_Info(61,61,"",63,4000017,1,"",86,,,1,,),
	["62"] = new Cfg_t_newplayer_Info(62,62,"",,,,"",,,,,,),
	["63"] = new Cfg_t_newplayer_Info(63,63,"",68,4000018,,"",87,,,1,,),
	["64"] = new Cfg_t_newplayer_Info(64,64,"",,,,"",,,,,,),
	["65"] = new Cfg_t_newplayer_Info(65,65,"",,,,"",,,,,,),
	["66"] = new Cfg_t_newplayer_Info(66,66,"",,,,"",,,,,,),
	["67"] = new Cfg_t_newplayer_Info(67,67,"",,,,"",,,,,,),
	["68"] = new Cfg_t_newplayer_Info(68,68,"",72,4000022,1,"",88,,,1,,),
	["69"] = new Cfg_t_newplayer_Info(69,69,"",,,,"",,,,,,),
	["70"] = new Cfg_t_newplayer_Info(70,70,"",,,,"",,,,,,),
	["71"] = new Cfg_t_newplayer_Info(71,71,"",,,,"",,,,,,),
	["72"] = new Cfg_t_newplayer_Info(72,72,"",73,4000025,1,"",89,,,1,,),
	["73"] = new Cfg_t_newplayer_Info(73,73,"",74,,,"",200013,,,1,,),
	["74"] = new Cfg_t_newplayer_Info(74,74,"1,3",75,,,"",200014,,,1,,),
	["75"] = new Cfg_t_newplayer_Info(75,75,"",88,4000026,1,"100078",90,,,1,,),
	["76"] = new Cfg_t_newplayer_Info(76,100081,"",,,,"",200015,1052,,,,),
	["77"] = new Cfg_t_newplayer_Info(77,76,"",,4000027,1,"",91,,,1,,),
	["78"] = new Cfg_t_newplayer_Info(78,77,"",,,,"",,,,,,),
	["79"] = new Cfg_t_newplayer_Info(79,100078,"",100079,,,"",200010,1046,,1,,),
	["80"] = new Cfg_t_newplayer_Info(80,100079,"",100080,,,"",200011,1046,,1,,),
	["81"] = new Cfg_t_newplayer_Info(81,100080,"",,,,"",200012,1046,,1,,),
	["82"] = new Cfg_t_newplayer_Info(82,81,"",,,,"",,,,10001,,),
	["83"] = new Cfg_t_newplayer_Info(83,82,"",,,,"",,,,1,,),
	["84"] = new Cfg_t_newplayer_Info(84,83,"",,,,"",,,,10001,,),
	["85"] = new Cfg_t_newplayer_Info(85,84,"",,,,"",,,,10001,,),
	["86"] = new Cfg_t_newplayer_Info(86,85,"",,,,"",,,,10001,,),
	["87"] = new Cfg_t_newplayer_Info(87,86,"",,,,"",,,,,,),
	["88"] = new Cfg_t_newplayer_Info(88,87,"",,,,"",,,,,,),
	["89"] = new Cfg_t_newplayer_Info(89,88,"",90,4000030,1,"",39,,,1,,),
	["90"] = new Cfg_t_newplayer_Info(90,89,"",,,,"",,,,,,),
	["91"] = new Cfg_t_newplayer_Info(91,90,"",94,4000031,1,"",95,,,1,,),
	["92"] = new Cfg_t_newplayer_Info(92,91,"",,,,"",,,,,,),
	["93"] = new Cfg_t_newplayer_Info(93,92,"",,,,"",,,,,,),
	["94"] = new Cfg_t_newplayer_Info(94,93,"",,,,"",,,,,,),
	["95"] = new Cfg_t_newplayer_Info(95,94,"",96,4000034,1,"",96,,,1,,),
	["96"] = new Cfg_t_newplayer_Info(96,95,"",,,,"",,,,,,),
	["97"] = new Cfg_t_newplayer_Info(97,96,"",100,4000035,1,"",41,,,1,,),
	["98"] = new Cfg_t_newplayer_Info(98,97,"",,,,"",,,,,,),
	["99"] = new Cfg_t_newplayer_Info(99,98,"",,,,"",,,,,,),
	["100"] = new Cfg_t_newplayer_Info(100,99,"",,,,"",,,,,,),
	["101"] = new Cfg_t_newplayer_Info(101,100,"",107,4000038,1,"",97,,,1,,),
	["102"] = new Cfg_t_newplayer_Info(102,101,"",,,,"",,,,,,),
	["103"] = new Cfg_t_newplayer_Info(103,102,"",,,,"",,,,,,),
	["104"] = new Cfg_t_newplayer_Info(104,103,"",,,,"",,,,,,),
	["105"] = new Cfg_t_newplayer_Info(105,104,"",,,,"",,,,,,),
	["106"] = new Cfg_t_newplayer_Info(106,105,"",,,,"",,,,,,),
	["107"] = new Cfg_t_newplayer_Info(107,106,"",,,,"",,,,,,),
	["108"] = new Cfg_t_newplayer_Info(108,107,"",110,4000043,1,"",98,,,1,,),
	["109"] = new Cfg_t_newplayer_Info(109,108,"",,,,"",,,,,,),
	["110"] = new Cfg_t_newplayer_Info(110,109,"",,,,"",,,,,,),
	["111"] = new Cfg_t_newplayer_Info(111,110,"",114,4000045,1,"",44,,,1,,),
	["112"] = new Cfg_t_newplayer_Info(112,111,"",,,,"",,,,,,),
	["113"] = new Cfg_t_newplayer_Info(113,112,"",,,,"",,,,,,),
	["114"] = new Cfg_t_newplayer_Info(114,113,"",,,,"",,,,,,),
	["115"] = new Cfg_t_newplayer_Info(115,114,"",,,,"",,,,1,,),
	["116"] = new Cfg_t_newplayer_Info(116,115,"",,,,"",,,,,,),
	["117"] = new Cfg_t_newplayer_Info(117,116,"",,,,"",,,,,,),
	["118"] = new Cfg_t_newplayer_Info(118,119,"",,,,"",,,,,,),
	["119"] = new Cfg_t_newplayer_Info(119,120,"",,,,"",,,,,,),
	["120"] = new Cfg_t_newplayer_Info(120,121,"",,,,"",,,,,,),
	["121"] = new Cfg_t_newplayer_Info(121,122,"",,,,"",,,,,,),
};
}
