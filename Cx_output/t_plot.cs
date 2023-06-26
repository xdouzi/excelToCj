using System.Collections.Generic;
public class t_plotInfo
{
public int id;
public int a_base_plot_id;
public int a_base_ground_id;
public int a_base_plot_type;
public string a_ints_plot_message;
public int a_base_plot_talk;
public int a_base_plot_words;
public int a_base_plot_auto;
public int a_base_wait_plot_time;
public int c_base_plot_show;
public string c_base_plot_action;
public int c_base_name_show;
public string c_base_bust;
public int c_base_plot_loop;
public string c_base_picture;
public int a_base_picture_life;
public int a_base_picture_move;
public int a_base_picture_speed;
public int a_base_animation;
public string c_base_whitelist;
public string c_base_refpoint_path;
public int c_base_arrow;
public string c_ints_arrowshifting;
public int c_base_light;
public string c_ints_lightshifting;
public int c_base_finger;
public int c_base_finger_type;
public int c_base_clickscale;
public string c_ints_fingershifting_01;
public string c_ints_fingershifting_02;
public int c_base_fingermovetime;
public int c_base_light_finish;
public string c_ints_talkshifting;
public string c_ints_camera;
public int c_base_scale;
public string c_base_camera_target_point;
public int c_base_camera_move_time;
public int c_base_stop;
public string c_ints_canui;
public int c_base_endnow;
public string c_base_picture_name;
public int c_base_vague;
public t_plotInfo(int id,int a_base_plot_ground_id,string a_ints_aggregate_id,int a_base_skip,int a_base_auto,int a_base_wait_time,int a_base_cm,int a_base_music,int a_base_music_begin,int a_base_music_loop,int a_base_run_model,int c_base_plot_ground_delytimeint id,int a_base_plot_id,int a_base_ground_id,int a_base_plot_type,string a_ints_plot_message,int a_base_plot_talk,int a_base_plot_words,int a_base_plot_auto,int a_base_wait_plot_time,int c_base_plot_show,string c_base_plot_action,int c_base_name_show,string c_base_bust,int c_base_plot_loop,string c_base_picture,int a_base_picture_life,int a_base_picture_move,int a_base_picture_speed,int a_base_animation,string c_base_whitelist,string c_base_refpoint_path,int c_base_arrow,string c_ints_arrowshifting,int c_base_light,string c_ints_lightshifting,int c_base_finger,int c_base_finger_type,int c_base_clickscale,string c_ints_fingershifting_01,string c_ints_fingershifting_02,int c_base_fingermovetime,int c_base_light_finish,string c_ints_talkshifting,string c_ints_camera,int c_base_scale,string c_base_camera_target_point,int c_base_camera_move_time,int c_base_stop,string c_ints_canui,int c_base_endnow,string c_base_picture_name,int c_base_vague)
{
  this.id = id;
  this.a_base_plot_id = a_base_plot_id;
  this.a_base_ground_id = a_base_ground_id;
  this.a_base_plot_type = a_base_plot_type;
  this.a_ints_plot_message = a_ints_plot_message;
  this.a_base_plot_talk = a_base_plot_talk;
  this.a_base_plot_words = a_base_plot_words;
  this.a_base_plot_auto = a_base_plot_auto;
  this.a_base_wait_plot_time = a_base_wait_plot_time;
  this.c_base_plot_show = c_base_plot_show;
  this.c_base_plot_action = c_base_plot_action;
  this.c_base_name_show = c_base_name_show;
  this.c_base_bust = c_base_bust;
  this.c_base_plot_loop = c_base_plot_loop;
  this.c_base_picture = c_base_picture;
  this.a_base_picture_life = a_base_picture_life;
  this.a_base_picture_move = a_base_picture_move;
  this.a_base_picture_speed = a_base_picture_speed;
  this.a_base_animation = a_base_animation;
  this.c_base_whitelist = c_base_whitelist;
  this.c_base_refpoint_path = c_base_refpoint_path;
  this.c_base_arrow = c_base_arrow;
  this.c_ints_arrowshifting = c_ints_arrowshifting;
  this.c_base_light = c_base_light;
  this.c_ints_lightshifting = c_ints_lightshifting;
  this.c_base_finger = c_base_finger;
  this.c_base_finger_type = c_base_finger_type;
  this.c_base_clickscale = c_base_clickscale;
  this.c_ints_fingershifting_01 = c_ints_fingershifting_01;
  this.c_ints_fingershifting_02 = c_ints_fingershifting_02;
  this.c_base_fingermovetime = c_base_fingermovetime;
  this.c_base_light_finish = c_base_light_finish;
  this.c_ints_talkshifting = c_ints_talkshifting;
  this.c_ints_camera = c_ints_camera;
  this.c_base_scale = c_base_scale;
  this.c_base_camera_target_point = c_base_camera_target_point;
  this.c_base_camera_move_time = c_base_camera_move_time;
  this.c_base_stop = c_base_stop;
  this.c_ints_canui = c_ints_canui;
  this.c_base_endnow = c_base_endnow;
  this.c_base_picture_name = c_base_picture_name;
  this.c_base_vague = c_base_vague;
}
}
public class Cfg_t_plot
{
public static List<t_plotInfo> list = new List<t_plotInfo>()
{
	[0] = new t_plotInfo(1,1,1,3,"101000201",0,0,,,,"idle",,"",1,"Download/UI/UIRes/NonAtlasRes/BG/UI_plot_feichuan",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"",0),
	[1] = new t_plotInfo(2,2,2,3,"101000202",0,0,,,,"idle",,"",1,"Download/UI/UIRes/NonAtlasRes/BG/UI_plot_yun",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[2] = new t_plotInfo(3,3,3,1,"101000203",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia03.png",0),
	[3] = new t_plotInfo(4,4,3,1,"101000204",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[4] = new t_plotInfo(5,5,4,1,"101000205",1,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_feixu",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[5] = new t_plotInfo(6,6,4,1,"101000206",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[6] = new t_plotInfo(7,7,4,1,"101000207",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[7] = new t_plotInfo(8,8,4,1,"101000208",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[8] = new t_plotInfo(9,9,4,1,"101000209",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia01.png",0),
	[9] = new t_plotInfo(10,10,4,1,"101000210",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[10] = new t_plotInfo(11,11,5,2,"101000211",2,1,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[11] = new t_plotInfo(12,12,5,2,"101000212",1,1,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","all_tower/CheseGroups/MapChess/103",0,"",2,"",3,1,,"0,4000,0","0,4000,-12000",1000,,"","0,0",12000,"",,1,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[12] = new t_plotInfo(13,13,5,2,"101000213",1,1,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","all_tower/CheseGroups/MapChess/203",0,"",2,"",3,1,,"0,4000,0","-75000,10200,126500",1000,1,"","0,0",12000,"",,1,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[13] = new t_plotInfo(14,14,5,2,"101000214",2,1,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","all_tower/CheseGroups/MapChess/303",0,"",2,"",3,1,,"0,4000,0","0,4000,-14000",1000,,"","0,0",12000,"",,1,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[14] = new t_plotInfo(15,15,5,2,"101000215",1,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","all_tower/CheseGroups/MapChess/403",0,"",2,"",3,1,,"0,4000,0","4400,4200,71500",1000,1,"","0,0",12000,"",,1,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[15] = new t_plotInfo(16,16,5,2,"101000216",1,1,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","all_tower/CheseGroups/MapChess/305",0,"",2,"",3,1,,"0,4000,0","0,0,-16400",1000,,"","0,0",12000,"",,1,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[16] = new t_plotInfo(17,17,5,2,"101000217",1,1,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","all_tower/CheseGroups/MapChess/405",0,"",2,"",3,1,,"0,4000,0","72600,0,168400",1000,1,"","0,0",12000,"",,1,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[17] = new t_plotInfo(18,18,10,1,"101000218",1,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[18] = new t_plotInfo(19,19,10,1,"101000219",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia01.png",0),
	[19] = new t_plotInfo(20,20,10,1,"101000220",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[20] = new t_plotInfo(21,21,11,1,"101000221",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"interactive/285",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[21] = new t_plotInfo(22,22,11,1,"101000222",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[22] = new t_plotInfo(23,23,11,1,"101000223",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[23] = new t_plotInfo(24,24,12,2,"101000224",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"285","interactive/285",,"",3,"-1500,5700,0",3,2,,"-1500,5700,0","",,,"","",12000,"interactive/285",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[24] = new t_plotInfo(25,25,13,2,"101000225",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_feixu",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[25] = new t_plotInfo(26,26,14,1,"101000226",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[26] = new t_plotInfo(27,27,14,1,"101000227",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[27] = new t_plotInfo(28,28,15,2,"101000228",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"interactive/1030",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[28] = new t_plotInfo(29,29,16,1,"101000229",0,0,,,80000006,"idle",101000021,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"Monsters/100001","500",,"",500,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_xiaojingling01.png",0),
	[29] = new t_plotInfo(30,30,16,1,"101000230",1,0,,,80000002,"idle",101000013,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_jianchihu01.png",0),
	[30] = new t_plotInfo(31,31,16,1,"101000231",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[31] = new t_plotInfo(32,32,17,1,"101000232",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[32] = new t_plotInfo(33,33,18,1,"101000233",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[33] = new t_plotInfo(34,34,18,1,"101000234",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[34] = new t_plotInfo(35,35,19,1,"101000235",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_zhucheng_01(Clone)",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[35] = new t_plotInfo(36,36,19,1,"101000236",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[36] = new t_plotInfo(37,37,20,1,"101000237",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Monsters/100002",500,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[37] = new t_plotInfo(38,38,20,1,"101000238",1,0,,,80000003,"idle",101000011,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_sanjiaolong01.png",0),
	[38] = new t_plotInfo(39,39,20,1,"101000239",0,0,,,30101,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[39] = new t_plotInfo(40,40,21,2,"101000240",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[40] = new t_plotInfo(41,41,21,2,"101000241",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[41] = new t_plotInfo(42,42,22,1,"101000242",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[42] = new t_plotInfo(43,43,22,1,"101000243",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[43] = new t_plotInfo(44,44,23,2,"101000244",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[44] = new t_plotInfo(45,45,24,1,"101000245",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[45] = new t_plotInfo(46,46,24,1,"101000246",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[46] = new t_plotInfo(47,47,24,1,"101000247",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[47] = new t_plotInfo(48,48,25,1,"101000248",1,0,,,50001,"idle",101000002,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[48] = new t_plotInfo(49,49,25,1,"101000249",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[49] = new t_plotInfo(50,50,26,1,"101000250",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[50] = new t_plotInfo(51,51,27,1,"101000251",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[51] = new t_plotInfo(52,52,27,1,"101000252",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[52] = new t_plotInfo(53,53,27,1,"101000253",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[53] = new t_plotInfo(54,54,28,1,"101000254",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[54] = new t_plotInfo(55,55,28,1,"101000255",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[55] = new t_plotInfo(56,56,0,1,"101000256",1,0,,,80000004,"idle",101000010,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_huolong01.png",0),
	[56] = new t_plotInfo(57,57,29,1,"101000257",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[57] = new t_plotInfo(58,58,29,1,"101000258",1,0,,,80000004,"idle",101000010,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_huolong01.png",0),
	[58] = new t_plotInfo(59,59,0,1,"101000259",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[59] = new t_plotInfo(60,60,0,1,"101000260",1,0,,,30013,"idle",101000003,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[60] = new t_plotInfo(61,61,30,1,"101000261",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_huolong01.png",0),
	[61] = new t_plotInfo(62,62,31,1,"101000262",1,0,,,80000004,"idle",101000010,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_huolong01.png",0),
	[62] = new t_plotInfo(63,63,31,1,"101000263",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[63] = new t_plotInfo(64,64,31,1,"101000264",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[64] = new t_plotInfo(65,65,32,1,"101000265",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[65] = new t_plotInfo(66,66,34,1,"101000266",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[66] = new t_plotInfo(67,67,35,1,"101000267",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[67] = new t_plotInfo(68,68,35,1,"101000268",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[68] = new t_plotInfo(69,69,36,1,"101000269",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[69] = new t_plotInfo(70,70,36,1,"101000270",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[70] = new t_plotInfo(71,71,36,1,"101000271",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[71] = new t_plotInfo(72,72,37,2,"101000272",2,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[72] = new t_plotInfo(73,73,37,2,"101000273",2,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[73] = new t_plotInfo(74,74,38,2,"101000274",2,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[74] = new t_plotInfo(75,75,39,1,"101000275",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[75] = new t_plotInfo(76,76,39,1,"101000276",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[76] = new t_plotInfo(77,77,39,1,"101000277",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[77] = new t_plotInfo(78,78,40,1,"101000278",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[78] = new t_plotInfo(79,79,40,1,"101000279",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[79] = new t_plotInfo(80,80,41,1,"101000280",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[80] = new t_plotInfo(81,81,41,1,"101000281",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[81] = new t_plotInfo(82,82,41,1,"101000282",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[82] = new t_plotInfo(83,83,41,1,"101000283",1,0,,,50001,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[83] = new t_plotInfo(84,84,41,1,"101000284",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[84] = new t_plotInfo(85,85,41,1,"101000285",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[85] = new t_plotInfo(86,86,41,1,"101000286",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[86] = new t_plotInfo(87,87,42,1,"101000287",1,0,,,80000002,"idle",101000008,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[87] = new t_plotInfo(88,88,42,1,"101000288",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[88] = new t_plotInfo(89,89,42,1,"101000289",1,0,,,80000002,"idle",101000008,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[89] = new t_plotInfo(90,90,43,1,"101000290",1,0,,,80000002,"idle",101000008,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[90] = new t_plotInfo(91,91,43,1,"101000291",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[91] = new t_plotInfo(92,92,43,1,"101000292",1,0,,,80000002,"idle",101000008,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[92] = new t_plotInfo(93,93,44,1,"101000293",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[93] = new t_plotInfo(94,94,44,1,"101000294",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[94] = new t_plotInfo(95,95,44,1,"101000295",0,0,,,30086,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[95] = new t_plotInfo(96,96,45,1,"101000296",1,0,,,30003,"idle",101000009,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[96] = new t_plotInfo(97,97,45,1,"101000297",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[97] = new t_plotInfo(98,98,45,1,"101000298",1,0,,,30003,"idle",101000009,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[98] = new t_plotInfo(99,99,46,1,"101000299",1,0,,,30003,"idle",101000009,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[99] = new t_plotInfo(100,100,46,1,"101000300",1,0,,,30003,"idle",101000009,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_bawanglong03.png",0),
	[100] = new t_plotInfo(101,101,47,1,"101000301",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[101] = new t_plotInfo(102,102,47,1,"101000302",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[102] = new t_plotInfo(103,103,48,2,"101000303",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[103] = new t_plotInfo(104,104,48,2,"101000304",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[104] = new t_plotInfo(105,105,48,2,"101000305",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[105] = new t_plotInfo(106,106,48,2,"101000306",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[106] = new t_plotInfo(107,107,48,2,"101000307",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[107] = new t_plotInfo(108,108,48,2,"101000308",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[108] = new t_plotInfo(109,109,49,2,"101000309",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[109] = new t_plotInfo(110,110,50,2,"101000310",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[110] = new t_plotInfo(111,111,51,2,"101000311",0,0,,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[111] = new t_plotInfo(118,118,52,1,"101000318",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[112] = new t_plotInfo(119,119,52,1,"101000319",0,0,,,30019,"idle",101000014,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[113] = new t_plotInfo(120,120,53,1,"101000320",0,0,,,30019,"idle",101000014,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[114] = new t_plotInfo(121,121,53,1,"101000321",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[115] = new t_plotInfo(122,122,53,1,"101000322",1,0,,,30019,"idle",101000014,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[116] = new t_plotInfo(123,123,54,1,"101000323",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[117] = new t_plotInfo(124,124,54,1,"101000324",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[118] = new t_plotInfo(125,125,54,1,"101000325",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[119] = new t_plotInfo(126,126,55,1,"101000326",1,0,,,30051,"idle",101000012,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[120] = new t_plotInfo(127,127,55,1,"101000327",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[121] = new t_plotInfo(128,128,55,1,"101000328",1,0,,,30051,"idle",101000012,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[122] = new t_plotInfo(129,129,56,1,"101000329",0,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[123] = new t_plotInfo(130,130,56,1,"101000330",1,0,,,30051,"idle",101000012,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[124] = new t_plotInfo(131,131,56,1,"101000331",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[125] = new t_plotInfo(132,132,57,1,"101000332",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[126] = new t_plotInfo(133,133,57,1,"101000333",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[127] = new t_plotInfo(134,134,58,1,"101000334",1,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[128] = new t_plotInfo(135,135,58,1,"101000335",1,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[129] = new t_plotInfo(136,136,59,1,"101000336",0,0,,,30042,"idle",101000015,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[130] = new t_plotInfo(137,137,59,1,"101000337",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[131] = new t_plotInfo(138,138,60,1,"101000338",0,0,,,80000002,"idle",101000016,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[132] = new t_plotInfo(139,139,60,1,"101000339",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[133] = new t_plotInfo(140,140,61,1,"101000340",0,0,,,80000002,"idle",101000016,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[134] = new t_plotInfo(141,141,61,1,"101000341",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[135] = new t_plotInfo(142,142,62,1,"101000342",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[136] = new t_plotInfo(143,143,62,1,"101000343",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[137] = new t_plotInfo(144,144,62,1,"101000344",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[138] = new t_plotInfo(145,145,63,1,"101000345",0,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[139] = new t_plotInfo(146,146,63,1,"101000346",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[140] = new t_plotInfo(147,147,64,1,"101000347",0,0,,,30037,"idle",101000017,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[141] = new t_plotInfo(148,148,64,1,"101000348",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[142] = new t_plotInfo(149,149,65,1,"101000349",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[143] = new t_plotInfo(150,150,65,1,"101000350",0,0,,,30037,"idle",101000017,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[144] = new t_plotInfo(151,151,66,1,"101000351",0,0,,,30064,"idle",101000018,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[145] = new t_plotInfo(152,152,67,1,"101000352",1,0,,,50001,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[146] = new t_plotInfo(153,153,67,1,"101000353",0,0,,,30064,"idle",101000018,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[147] = new t_plotInfo(154,154,67,1,"101000354",0,0,,,30064,"idle",101000018,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[148] = new t_plotInfo(155,155,68,1,"101000355",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[149] = new t_plotInfo(156,156,68,1,"101000356",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[150] = new t_plotInfo(157,157,69,1,"101000357",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[151] = new t_plotInfo(158,158,70,1,"101000358",1,0,,,80000006,"idle",101000019,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[152] = new t_plotInfo(159,159,71,1,"101000359",0,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[153] = new t_plotInfo(160,160,71,1,"101000360",1,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[154] = new t_plotInfo(161,161,72,1,"101000361",0,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[155] = new t_plotInfo(162,162,72,1,"101000362",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[156] = new t_plotInfo(163,163,72,1,"101000363",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[157] = new t_plotInfo(164,164,72,1,"101000364",1,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[158] = new t_plotInfo(165,165,73,1,"101000365",0,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[159] = new t_plotInfo(166,166,73,1,"101000366",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[160] = new t_plotInfo(167,167,73,1,"101000367",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[161] = new t_plotInfo(168,168,73,1,"101000368",1,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[162] = new t_plotInfo(169,169,73,1,"101000369",1,0,,,80000001,"idle",101000005,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[163] = new t_plotInfo(170,170,73,1,"101000370",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[164] = new t_plotInfo(171,171,74,1,"101000371",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[165] = new t_plotInfo(172,172,74,1,"101000372",1,0,,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[166] = new t_plotInfo(173,173,74,1,"101000373",0,0,,,80000005,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[167] = new t_plotInfo(174,174,74,1,"101000374",1,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[168] = new t_plotInfo(175,175,75,1,"101000375",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[169] = new t_plotInfo(176,176,75,1,"101000376",1,0,,,30086,"idle",101000007,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[170] = new t_plotInfo(177,177,75,1,"101000377",0,0,,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[171] = new t_plotInfo(178,178,76,1,"101100001",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[172] = new t_plotInfo(179,179,77,1,"101100002",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[173] = new t_plotInfo(180,180,77,1,"101100003",1,1,1,,80000003,"idle",101000020,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_sanjiaolong01.png",0),
	[174] = new t_plotInfo(181,181,78,2,"101100004",2,1,1,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[175] = new t_plotInfo(182,182,79,1,"101100005",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_zhucheng_01(Clone)",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[176] = new t_plotInfo(183,183,79,1,"101100006",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[177] = new t_plotInfo(184,184,80,1,"101100007",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[178] = new t_plotInfo(185,185,80,1,"101100008",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[179] = new t_plotInfo(186,186,81,1,"101100009",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[180] = new t_plotInfo(187,187,81,1,"101100010",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[181] = new t_plotInfo(188,188,82,1,"101100011",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_zhucheng_01(Clone)",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[182] = new t_plotInfo(189,189,83,1,"101100012",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[183] = new t_plotInfo(190,190,84,1,"101100013",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[184] = new t_plotInfo(191,191,85,1,"101100014",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_fx_quanshui_01",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[185] = new t_plotInfo(192,192,85,1,"101100015",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[186] = new t_plotInfo(193,193,85,1,"101100016",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[187] = new t_plotInfo(194,194,85,1,"101100017",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Monsters/100005",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[188] = new t_plotInfo(195,195,86,1,"101100018",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[189] = new t_plotInfo(196,196,86,1,"101100019",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[190] = new t_plotInfo(197,197,87,1,"101100020",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"interactive/1145",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[191] = new t_plotInfo(198,198,87,1,"101100021",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Monsters/100006",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[192] = new t_plotInfo(199,199,88,1,"101100022",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"Map_stone_fx_quanshui_01",1000,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[193] = new t_plotInfo(200,200,89,1,"101100023",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[194] = new t_plotInfo(201,201,89,1,"101100024",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[195] = new t_plotInfo(202,202,90,1,"101100025",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[196] = new t_plotInfo(203,203,90,1,"101100026",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_maoxianjia02.png",0),
	[197] = new t_plotInfo(204,204,90,1,"101100027",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[198] = new t_plotInfo(205,205,91,1,"101100028",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[199] = new t_plotInfo(206,206,91,1,"101100029",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[200] = new t_plotInfo(207,207,92,2,"101100030",2,1,1,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[201] = new t_plotInfo(208,208,93,2,"101100031",2,1,1,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[202] = new t_plotInfo(209,209,94,2,"101100032",2,1,1,,80000005,"idle",101000006,"tunvneng",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[203] = new t_plotInfo(210,210,95,1,"101100033",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[204] = new t_plotInfo(211,211,95,1,"101100034",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[205] = new t_plotInfo(212,212,96,1,"101100035",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[206] = new t_plotInfo(213,213,96,1,"101100036",1,1,1,,50001,"idle",101000001,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[207] = new t_plotInfo(214,214,96,1,"101100037",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[208] = new t_plotInfo(215,215,97,1,"101100038",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[209] = new t_plotInfo(216,216,98,1,"101100039",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[210] = new t_plotInfo(217,217,99,1,"101100040",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[211] = new t_plotInfo(218,218,100,1,"101100041",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[212] = new t_plotInfo(219,219,101,1,"101100042",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[213] = new t_plotInfo(220,220,101,1,"101100043",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[214] = new t_plotInfo(221,221,102,1,"101100044",0,1,1,,80000005,"idle",101000006,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_lvsheng02.png",0),
	[215] = new t_plotInfo(230,230,103,1,"101100049",0,1,1,,80000006,"idle",101000021,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_xiaojingling01.png",0),
	[216] = new t_plotInfo(231,231,103,1,"101100050",1,1,1,,80000002,"idle",101000013,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_jianchihu01.png",0),
	[217] = new t_plotInfo(232,232,104,1,"101100051",1,1,1,,80000002,"idle",101000013,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_jianchihu01.png",0),
	[218] = new t_plotInfo(233,233,104,1,"101100052",0,1,1,,80000006,"idle",101000021,"",1,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"Download/UI/UIRes/NonAtlasRes/PlotPics/UI_Plot_xiaojingling01.png",0),
	[219] = new t_plotInfo(100001,100001,100001,3,"101000216",2,1,,,,"",,"",,"",5000,,,,"chess3","Chess/chess3",0,"",3,"",3,1,,"","1500000,0",1500,,"","2",20000,"",,1,"",,"",0),
	[220] = new t_plotInfo(100002,100002,100002,4,"",,,1,1000,,"",,"",,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"",0),
	[221] = new t_plotInfo(100003,100003,100003,4,"",,,1,1000,,"",,"",,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"",0),
	[222] = new t_plotInfo(100004,100004,100004,4,"",,,1,1000,,"",,"",,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"",0),
	[223] = new t_plotInfo(100005,100005,100005,2,"101000312",0,1,0,,,"",,"tunvneng",,"",5000,,,,"Map_stone_feixu","Map_stone_feixu",,"",3,"3800,4800,0",3,2,,"3800,4800,0","",,,"","0",12000,"Map_stone_feixu",1000,,"1109",1,"",0),
	[224] = new t_plotInfo(100006,100006,100006,2,"101000313",0,1,0,,,"",,"tunvneng",,"",5000,,,,"1030","interactive/1030",,"",3,"1010,4440,0",3,2,,"1010,4440,0","",,,"","0",18000,"interactive/1030",1000,,"",,"",0),
	[225] = new t_plotInfo(100007,100007,100007,2,"101000314",2,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]MainLineTaskBtn","[btn]MainLineTaskBtn",,"",3,"",3,2,,"","",,,"","2",,"",,,"",,"",0),
	[226] = new t_plotInfo(100008,100008,100008,2,"101000315",2,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]buildBtn","[btn]buildBtn",4,"0,775000,0",2,"",,0,,"","",,,"","2",11000,"Map_stone_zhucheng_01(Clone)",1000,,"1038",1,"",0),
	[227] = new t_plotInfo(100009,100009,100009,2,"101000316",2,1,0,,,"",,"tunvneng",,"",5000,,,,"BuildArchitecture7/[btn]ItemBtn","[view]ArchitectureBuildRoot/[tmp]TitleTxt",,"",3,"220000,-1350000,0",3,2,,"220000,-1350000,0","",,,"","2",15000,"",300,,"",1,"",0),
	[228] = new t_plotInfo(100010,100010,100010,2,"101000317",2,1,0,,,"",,"tunvneng",,"",5000,,,,"building_common_button(Clone)","building_common_button(Clone)",4,"0,-50,0",2,"",,,,"","",,,"","",12000,"",,,"",1,"",0),
	[229] = new t_plotInfo(100011,100011,100005,2,"101000390",1,1,1,,,"",,"tunvneng",,"",5000,,,,"[btn]RepairBtn","GameEntry/UI/UIRoot/GroupDefault/UIArchitectureRepairPanel(Clone)/BackGroundPanel/[btn]RepairBtn",,"",2,"0,0,0",3,2,,"","",,,"","2",11000,"",,,"",1,"",0),
	[230] = new t_plotInfo(200001,200001,200001,2,"101000318",0,1,1,,,"",,"tunvneng",,"",5000,,,,"100001","Monsters/100001",,"",1,"0,8400,0",3,2,,"0,8400,0","",,,"","0",10000,"Monsters/100001",500,,"1024",1,"",0),
	[231] = new t_plotInfo(200002,200002,200001,2,"101000319",1,1,1,,,"",,"tunvneng",,"",5000,,,,"[btn]goBattle","[btn]goBattle",,"",1,"",3,2,,"0,0,0","",,,"","2",12000,"",,,"",1,"",0),
	[232] = new t_plotInfo(200003,200003,200003,2,"101100045",1,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]battleBtn","[btn]battleBtn",,"",2,"0,0,0",3,2,,"0,0,0","",,,"","2",12000,"",,,"",1,"",0),
	[233] = new t_plotInfo(200004,200004,200010,2,"101100046",0,1,0,,,"",,"tunvneng",,"",5000,,,,"0/[img]imgFrame","UI/UIRoot/GroupDefault/UIEmbattle(Clone)/[obj]objCardPanel/[btn]btnSort",,"",1,"-630000,-1240000,0",3,2,,"-630000,-1240000,0","",,,"","2",10000,"",,,"",1,"",0),
	[234] = new t_plotInfo(200005,200005,200011,2,"101100047",0,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]btnEquip","UIEmbattle(Clone)/[obj]objTip/[btn]btnEquip",,"",1,"",3,2,,"0,0,0","",,,"","2",10000,"",,,"",1,"",0),
	[235] = new t_plotInfo(200006,200006,200012,2,"101100048",0,1,0,,,"",,"tunvneng",,"",5000,,,,"","",,"",,"",,,,"","",,,"","",,"",,,"",,"",0),
	[236] = new t_plotInfo(200007,200007,200005,2,"101000380",0,1,1,,,"",,"tunvneng",,"",5000,,,,"100000","Monsters/100000",,"",1,"400,9800,0",3,2,,"400,9800,0","",,,"","0",10000,"Monsters/100000",500,,"1024",1,"",0),
	[237] = new t_plotInfo(200008,200008,200006,2,"101000381",1,1,1,,,"",,"tunvneng",,"",5000,,,,"[btn]goBattle","[btn]goBattle",,"",1,"",3,2,,"0,0,0","",,,"","2",11000,"",,,"",1,"",0),
	[238] = new t_plotInfo(200009,200009,200007,2,"101000382",0,1,0,,,"",,"tunvneng",,"",5000,,,,"Map_stone_zhucheng_01(Clone)","Map_stone_zhucheng_01(Clone)",,"",3,"3800,4800,0",3,2,,"3800,4800,0","",,,"","0",20000,"Map_stone_zhucheng_01(Clone)",500,,"",1,"",0),
	[239] = new t_plotInfo(200010,200010,200008,2,"101000383",1,1,0,,,"",,"tunvneng",,"",5000,,,,"ButtonInfo_3","ButtonInfo_3",,"",2,"",3,2,,"0,0,0","",,,"","2",10000,"Map_stone_zhucheng_01(Clone)",,,"1042",1,"",0),
	[240] = new t_plotInfo(200011,200011,200009,2,"101000384",2,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]UpFreeBtn","UI/UIRoot/GroupDefault/UIArchitectureUpPanel(Clone)/Bottom/[obj]BackGroundPanel/[btn]UpFreeBtn",,"",2,"",3,2,,"0,0,0","",,,"","2",11000,"",,,"",1,"",0),
	[241] = new t_plotInfo(200012,200012,200013,2,"101000382",0,1,0,,,"",,"tunvneng",,"",5000,,,,"Map_stone_zhucheng_01(Clone)","Map_stone_zhucheng_01(Clone)",,"",3,"3800,4800,0",3,2,,"3800,4800,0","",,,"","0",20000,"Map_stone_zhucheng_01(Clone)",500,,"",1,"",0),
	[242] = new t_plotInfo(200013,200013,200013,2,"101000383",1,1,0,,,"",,"tunvneng",,"",5000,,,,"ButtonInfo_3","ButtonInfo_3",,"",2,"",3,2,,"","",,,"","2",11000,"Map_stone_zhucheng_01(Clone)",,,"1042",1,"",0),
	[243] = new t_plotInfo(200014,200014,200013,2,"101000385",0,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]UpBtn","GameEntry/UI/UIRoot/GroupDefault/UIArchitectureUpPanel(Clone)/Bottom/[obj]BackGroundPanel/[obj]Up",,"",2,"0,0,0",3,2,,"","",,,"","2",12000,"",,,"",1,"",0),
	[244] = new t_plotInfo(200015,200015,200014,2,"101000386",0,1,0,,,"",,"tunvneng",,"",5000,,,,"Map_stone_zhucheng_01(Clone)","Map_stone_zhucheng_01(Clone)",,"",3,"3800,4800,0",3,2,,"3800,4800,0","",,,"","0",20000,"Map_stone_zhucheng_01(Clone)",500,,"",1,"",0),
	[245] = new t_plotInfo(200016,200016,200014,2,"101000387",1,1,0,,,"",,"tunvneng",,"",5000,,,,"ButtonInfo_4","ButtonInfo_4",,"",2,"",3,2,,"","",,,"","2",11000,"",,,"1045",1,"",0),
	[246] = new t_plotInfo(200017,200017,200014,2,"101000388",0,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]BuildSpeedUpBtn","GameEntry/UI/UIRoot/GroupPop/UIArchitectureSpeedUpPanel(Clone)/[AnimationHelper]BackGroundPanel/Top",,"",2,"2130000,-3560000,0",3,2,,"2130000,-3560000,0","",,,"","2",12000,"",,,"1052",1,"",0),
	[247] = new t_plotInfo(200018,200018,200015,2,"101000389",1,1,0,,,"",,"tunvneng",,"",5000,,,,"[btn]UseBtn","GameEntry/UI/UIRoot/GroupPop/UIArchitectureUseSpeedItemPop(Clone)/[AnimationHelper]BackGroundPanel/[btn]UseBtn",,"",2,"",2,1,,"","",,,"","2",12000,"",,,"",1,"",0),
	[248] = new t_plotInfo(200019,200019,200016,2,"101000391",1,1,0,,,"",,"tunvneng",,"",5000,,,,"","all_tower/CheseGroups/MapChess/103",,"",2,"",3,1,,"0,4000,0","0,4000,-12000",1000,,"","0,0",12000,"",,1,"",,"",0),
	[249] = new t_plotInfo(200020,200020,200016,2,"101000392",1,1,0,,,"",,"tunvneng",,"",5000,,,,"","all_tower/CheseGroups/MapChess/101",,"",2,"0,0,15300",,,,"","",,,"","",,"",,1,"",1,"",0),
	[250] = new t_plotInfo(200021,200021,200016,2,"101000393",1,1,0,,,"",,"tunvneng",,"",5000,,,,"","all_tower/CheseGroups/MapChess/101",,"",2,"0,0,36000",,,,"","",,,"","",,"",,1,"",1,"",0),
	[251] = new t_plotInfo(200022,200022,200016,2,"101000394",1,1,0,,,"",,"tunvneng",,"",5000,,,,"","all_tower/CheseGroups/MapChess/101",,"",2,"0,0,36000",3,1,,"0,0,36000","59300,0,90900",1000,1,"","0,0",12000,"",,1,"",,"",0),
};
}
