using System.Collections.Generic;
public class t_plot_groundInfo
{
public int id;
public int a_base_plot_ground_id;
public string a_ints_aggregate_id;
public int a_base_skip;
public int a_base_auto;
public int a_base_wait_time;
public int a_base_cm;
public int a_base_music;
public int a_base_music_begin;
public int a_base_music_loop;
public int a_base_run_model;
public int c_base_plot_ground_delytime;
public t_plot_groundInfo(int id,int a_base_plot_ground_id,string a_ints_aggregate_id,int a_base_skip,int a_base_auto,int a_base_wait_time,int a_base_cm,int a_base_music,int a_base_music_begin,int a_base_music_loop,int a_base_run_model,int c_base_plot_ground_delytime)
{
  this.id = id;
  this.a_base_plot_ground_id = a_base_plot_ground_id;
  this.a_ints_aggregate_id = a_ints_aggregate_id;
  this.a_base_skip = a_base_skip;
  this.a_base_auto = a_base_auto;
  this.a_base_wait_time = a_base_wait_time;
  this.a_base_cm = a_base_cm;
  this.a_base_music = a_base_music;
  this.a_base_music_begin = a_base_music_begin;
  this.a_base_music_loop = a_base_music_loop;
  this.a_base_run_model = a_base_run_model;
  this.c_base_plot_ground_delytime = c_base_plot_ground_delytime;
}
}
public class Cfg_t_plot_ground
{
public static List<t_plot_groundInfo> list = new List<t_plot_groundInfo>()
{
	[0] = new t_plot_groundInfo(1,1,"100001",1,0,5000,0,,,,0,0),
	[1] = new t_plot_groundInfo(2,2,"2",1,0,5000,0,,,,0,0),
	[2] = new t_plot_groundInfo(3,3,"3,4",1,0,5000,0,,,,0,0),
	[3] = new t_plot_groundInfo(4,4,"5,6,7,8,9,10",1,0,5000,0,,,,0,0),
	[4] = new t_plot_groundInfo(5,5,"12,13,14,15,16,17",1,0,5000,0,,,,0,0),
	[5] = new t_plot_groundInfo(6,6,"13",1,0,5000,0,,,,0,0),
	[6] = new t_plot_groundInfo(7,7,"14",1,0,5000,0,,,,0,0),
	[7] = new t_plot_groundInfo(8,8,"15",1,0,5000,0,,,,0,0),
	[8] = new t_plot_groundInfo(9,9,"17",1,0,5000,0,,,,0,0),
	[9] = new t_plot_groundInfo(10,10,"18,19,20",1,0,5000,0,,,,0,0),
	[10] = new t_plot_groundInfo(11,11,"21,22,23",1,0,5000,0,,,,0,0),
	[11] = new t_plot_groundInfo(12,12,"24",1,0,5000,0,,,,0,0),
	[12] = new t_plot_groundInfo(13,13,"25",1,0,5000,0,,,,0,0),
	[13] = new t_plot_groundInfo(14,14,"26,27",1,0,5000,0,,,,0,0),
	[14] = new t_plot_groundInfo(15,15,"28",1,0,5000,0,,,,0,0),
	[15] = new t_plot_groundInfo(16,16,"29,30,31",1,0,5000,0,,,,0,0),
	[16] = new t_plot_groundInfo(17,17,"32",1,0,5000,0,,,,0,0),
	[17] = new t_plot_groundInfo(18,18,"33,34",1,0,5000,0,,,,0,0),
	[18] = new t_plot_groundInfo(19,19,"35,36",1,0,5000,0,,,,0,0),
	[19] = new t_plot_groundInfo(20,20,"37,38,39",1,0,5000,0,,,,0,0),
	[20] = new t_plot_groundInfo(21,21,"40,41",1,0,5000,0,,,,0,0),
	[21] = new t_plot_groundInfo(22,22,"42,43",1,0,5000,0,,,,0,0),
	[22] = new t_plot_groundInfo(23,23,"44",1,0,5000,0,,,,0,0),
	[23] = new t_plot_groundInfo(24,24,"45,46,47",1,0,5000,0,,,,0,0),
	[24] = new t_plot_groundInfo(25,25,"48,49",1,0,5000,0,,,,0,0),
	[25] = new t_plot_groundInfo(26,26,"50",1,0,5000,0,,,,0,0),
	[26] = new t_plot_groundInfo(27,27,"51,52,53",1,0,5000,0,,,,0,0),
	[27] = new t_plot_groundInfo(28,28,"54,55",1,0,5000,0,,,,0,0),
	[28] = new t_plot_groundInfo(29,29,"57,58",1,0,5000,0,,,,0,0),
	[29] = new t_plot_groundInfo(30,30,"61",1,0,5000,0,,,,0,0),
	[30] = new t_plot_groundInfo(31,31,"62,63,64",1,0,5000,0,,,,0,0),
	[31] = new t_plot_groundInfo(32,32,"65",1,0,5000,0,,,,0,0),
	[32] = new t_plot_groundInfo(34,34,"66",1,0,5000,0,,,,0,0),
	[33] = new t_plot_groundInfo(35,35,"67,68",1,0,5000,0,,,,0,0),
	[34] = new t_plot_groundInfo(36,36,"69,70,71",1,0,5000,0,,,,0,0),
	[35] = new t_plot_groundInfo(37,37,"72,73",1,0,5000,0,,,,0,0),
	[36] = new t_plot_groundInfo(38,38,"74",1,0,5000,0,,,,0,0),
	[37] = new t_plot_groundInfo(39,39,"75,76,77",1,0,5000,0,,,,0,0),
	[38] = new t_plot_groundInfo(40,40,"78,79",1,0,5000,0,,,,0,0),
	[39] = new t_plot_groundInfo(41,41,"80,81,82,83,84,85,86",1,0,5000,0,,,,0,0),
	[40] = new t_plot_groundInfo(42,42,"87,88,89",1,0,5000,0,,,,0,0),
	[41] = new t_plot_groundInfo(43,43,"90,91,92",1,0,5000,0,,,,0,0),
	[42] = new t_plot_groundInfo(44,44,"93,94,95",1,0,5000,0,,,,0,0),
	[43] = new t_plot_groundInfo(45,45,"96,97,98",1,0,5000,0,,,,0,0),
	[44] = new t_plot_groundInfo(46,46,"99,100",1,0,5000,0,,,,0,0),
	[45] = new t_plot_groundInfo(47,47,"101,102",1,0,5000,0,,,,0,0),
	[46] = new t_plot_groundInfo(48,48,"103104105106107",1,0,5000,0,,,,0,0),
	[47] = new t_plot_groundInfo(49,49,"109",1,0,5000,0,,,,0,0),
	[48] = new t_plot_groundInfo(50,50,"110",1,0,5000,0,,,,0,0),
	[49] = new t_plot_groundInfo(51,51,"111",1,0,5000,0,,,,0,0),
	[50] = new t_plot_groundInfo(52,52,"118119",1,0,5000,0,,,,0,0),
	[51] = new t_plot_groundInfo(53,53,"120121122",1,0,5000,0,,,,0,0),
	[52] = new t_plot_groundInfo(54,54,"123124125",1,0,5000,0,,,,0,0),
	[53] = new t_plot_groundInfo(55,55,"126127128",1,0,5000,0,,,,0,0),
	[54] = new t_plot_groundInfo(56,56,"129130131",1,0,5000,0,,,,0,0),
	[55] = new t_plot_groundInfo(57,57,"132133",1,0,5000,0,,,,0,0),
	[56] = new t_plot_groundInfo(58,58,"134135",1,0,5000,0,,,,0,0),
	[57] = new t_plot_groundInfo(59,59,"136137",1,0,5000,0,,,,0,0),
	[58] = new t_plot_groundInfo(60,60,"138139",1,0,5000,0,,,,0,0),
	[59] = new t_plot_groundInfo(61,61,"140141",1,0,5000,0,,,,0,0),
	[60] = new t_plot_groundInfo(62,62,"142143144",1,0,5000,0,,,,0,0),
	[61] = new t_plot_groundInfo(63,63,"145146",1,0,5000,0,,,,0,0),
	[62] = new t_plot_groundInfo(64,64,"147148",1,0,5000,0,,,,0,0),
	[63] = new t_plot_groundInfo(65,65,"149,150",1,0,5000,0,,,,0,0),
	[64] = new t_plot_groundInfo(66,66,"151",1,0,5000,0,,,,0,0),
	[65] = new t_plot_groundInfo(67,67,"152,153,154",1,0,5000,0,,,,0,0),
	[66] = new t_plot_groundInfo(68,68,"155,156",1,0,5000,0,,,,0,0),
	[67] = new t_plot_groundInfo(69,69,"157",1,0,5000,0,,,,0,0),
	[68] = new t_plot_groundInfo(70,70,"158",1,0,5000,0,,,,0,0),
	[69] = new t_plot_groundInfo(71,71,"159,160",1,0,5000,0,,,,0,0),
	[70] = new t_plot_groundInfo(72,72,"161,162,163,164",1,0,5000,0,,,,0,0),
	[71] = new t_plot_groundInfo(73,73,"165,166,167,168,169",1,0,5000,0,,,,0,0),
	[72] = new t_plot_groundInfo(74,74,"171,172,173,174",1,0,5000,0,,,,0,0),
	[73] = new t_plot_groundInfo(75,75,"175,176,177",1,0,5000,0,,,,0,0),
	[74] = new t_plot_groundInfo(76,76,"178",1,0,5000,0,0,0,0,0,0),
	[75] = new t_plot_groundInfo(77,77,"179,180",1,0,5000,0,0,0,0,0,0),
	[76] = new t_plot_groundInfo(78,78,"181",1,0,5000,0,0,0,0,0,0),
	[77] = new t_plot_groundInfo(79,79,"182,183",1,0,5000,0,0,0,0,0,0),
	[78] = new t_plot_groundInfo(80,80,"184,185",1,0,5000,0,0,0,0,0,0),
	[79] = new t_plot_groundInfo(81,81,"186,187",1,0,5000,0,0,0,0,0,0),
	[80] = new t_plot_groundInfo(82,82,"188",1,0,5000,0,0,0,0,0,0),
	[81] = new t_plot_groundInfo(83,83,"189",1,0,5000,0,0,0,0,0,0),
	[82] = new t_plot_groundInfo(84,84,"190",1,0,5000,0,0,0,0,0,0),
	[83] = new t_plot_groundInfo(85,85,"191,192,193,194",1,0,5000,0,0,0,0,0,0),
	[84] = new t_plot_groundInfo(86,86,"195,196",1,0,5000,0,0,0,0,0,0),
	[85] = new t_plot_groundInfo(87,87,"197,198",1,0,5000,0,0,0,0,0,0),
	[86] = new t_plot_groundInfo(88,88,"199",1,0,5000,0,0,0,0,0,0),
	[87] = new t_plot_groundInfo(89,89,"200,201",1,0,5000,0,0,0,0,0,0),
	[88] = new t_plot_groundInfo(90,90,"202,203,204",1,0,5000,0,0,0,0,0,0),
	[89] = new t_plot_groundInfo(91,91,"205,206",1,0,5000,0,0,0,0,0,0),
	[90] = new t_plot_groundInfo(92,92,"207",1,0,5000,0,0,0,0,0,0),
	[91] = new t_plot_groundInfo(93,93,"208",1,0,5000,0,0,0,0,0,0),
	[92] = new t_plot_groundInfo(94,94,"209",1,0,5000,0,0,0,0,0,0),
	[93] = new t_plot_groundInfo(95,95,"210,211",1,0,5000,0,0,0,0,0,0),
	[94] = new t_plot_groundInfo(96,96,"212,213,214",1,0,5000,0,0,0,0,0,0),
	[95] = new t_plot_groundInfo(97,97,"215",1,0,5000,0,0,0,0,0,0),
	[96] = new t_plot_groundInfo(98,98,"216",1,0,5000,0,0,0,0,0,0),
	[97] = new t_plot_groundInfo(99,99,"217",1,0,5000,0,0,0,0,0,0),
	[98] = new t_plot_groundInfo(100,100,"218",1,0,5000,0,0,0,0,0,0),
	[99] = new t_plot_groundInfo(101,101,"219,220",1,0,5000,0,0,0,0,0,0),
	[100] = new t_plot_groundInfo(102,102,"221",1,0,5000,0,0,0,0,0,0),
	[101] = new t_plot_groundInfo(103,103,"230,231",1,0,5000,0,,,,0,0),
	[102] = new t_plot_groundInfo(104,104,"232,233",1,0,5000,0,,,,0,0),
	[103] = new t_plot_groundInfo(100001,100001,"100001",1,0,,,,,,,2000),
	[104] = new t_plot_groundInfo(100002,100002,"100002",1,1,5000,0,,,,0,5000),
	[105] = new t_plot_groundInfo(100003,100003,"100003",1,1,5000,0,,,,0,5000),
	[106] = new t_plot_groundInfo(100004,100004,"100004",1,1,5000,0,,,,0,5000),
	[107] = new t_plot_groundInfo(100005,100005,"100005,100011",1,0,,,,,,0,0),
	[108] = new t_plot_groundInfo(100006,100006,"100006",1,0,0,0,0,0,0,0,0),
	[109] = new t_plot_groundInfo(100007,100007,"100007",1,0,0,0,0,0,0,0,0),
	[110] = new t_plot_groundInfo(100008,100008,"100008",1,0,0,0,0,0,0,0,0),
	[111] = new t_plot_groundInfo(100009,100009,"100009",1,0,0,0,0,0,0,0,0),
	[112] = new t_plot_groundInfo(100010,100010,"100010",1,0,0,0,0,0,0,0,0),
	[113] = new t_plot_groundInfo(100011,100011,"100007",1,0,0,0,0,0,0,0,0),
	[114] = new t_plot_groundInfo(200001,200001,"200001",1,0,0,0,0,0,0,0,0),
	[115] = new t_plot_groundInfo(200002,200002,"200002",1,0,0,0,0,0,0,0,0),
	[116] = new t_plot_groundInfo(200003,200003,"200003",1,0,0,0,0,0,0,0,0),
	[117] = new t_plot_groundInfo(200004,200004,"200004,200005,200006",1,0,0,0,0,0,0,0,0),
	[118] = new t_plot_groundInfo(200005,200005,"200007",1,0,0,0,0,0,0,0,0),
	[119] = new t_plot_groundInfo(200006,200006,"200008",1,0,0,0,0,0,0,0,0),
	[120] = new t_plot_groundInfo(200007,200007,"200009,200010,200011",1,0,0,0,0,0,0,0,0),
	[121] = new t_plot_groundInfo(200008,200008,"200010",1,0,0,0,0,0,0,0,0),
	[122] = new t_plot_groundInfo(200009,200009,"200011",1,0,0,0,0,0,0,0,0),
	[123] = new t_plot_groundInfo(200010,200010,"200004",1,0,0,0,0,0,0,0,0),
	[124] = new t_plot_groundInfo(200011,200011,"200005",1,0,0,0,0,0,0,0,0),
	[125] = new t_plot_groundInfo(200012,200012,"200006",1,0,0,0,0,0,0,0,0),
	[126] = new t_plot_groundInfo(200013,200013,"200012,200013,200014",1,0,0,0,0,0,0,0,0),
	[127] = new t_plot_groundInfo(200014,200014,"200015,200016",1,0,0,0,0,0,0,0,0),
	[128] = new t_plot_groundInfo(200015,200015,"200018",1,0,0,0,0,0,0,0,0),
	[129] = new t_plot_groundInfo(200016,200016,"200019,200020,200021,200022",1,0,0,0,0,0,0,0,0),
};
}
