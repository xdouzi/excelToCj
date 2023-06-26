using System.Collections.Generic;
public class Cfg_t_plot_ground_Info
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
public Cfg_t_plot_ground_Info(int id,int a_base_plot_ground_id,string a_ints_aggregate_id,int a_base_skip,int a_base_auto,int a_base_wait_time,int a_base_cm,int a_base_music,int a_base_music_begin,int a_base_music_loop,int a_base_run_model,int c_base_plot_ground_delytime)
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
public static List<Cfg_t_plot_ground_Info> list = new List<Cfg_t_plot_ground_Info>()
{
	[0] = new Cfg_t_plot_ground_Info(1,1,"100001",1,0,5000,0,,,,0,0),
	[1] = new Cfg_t_plot_ground_Info(2,2,"2",1,0,5000,0,,,,0,0),
	[2] = new Cfg_t_plot_ground_Info(3,3,"3,4",1,0,5000,0,,,,0,0),
	[3] = new Cfg_t_plot_ground_Info(4,4,"5,6,7,8,9,10",1,0,5000,0,,,,0,0),
	[4] = new Cfg_t_plot_ground_Info(5,5,"12,13,14,15,16,17",1,0,5000,0,,,,0,0),
	[5] = new Cfg_t_plot_ground_Info(6,6,"13",1,0,5000,0,,,,0,0),
	[6] = new Cfg_t_plot_ground_Info(7,7,"14",1,0,5000,0,,,,0,0),
	[7] = new Cfg_t_plot_ground_Info(8,8,"15",1,0,5000,0,,,,0,0),
	[8] = new Cfg_t_plot_ground_Info(9,9,"17",1,0,5000,0,,,,0,0),
	[9] = new Cfg_t_plot_ground_Info(10,10,"18,19,20",1,0,5000,0,,,,0,0),
	[10] = new Cfg_t_plot_ground_Info(11,11,"21,22,23",1,0,5000,0,,,,0,0),
	[11] = new Cfg_t_plot_ground_Info(12,12,"24",1,0,5000,0,,,,0,0),
	[12] = new Cfg_t_plot_ground_Info(13,13,"25",1,0,5000,0,,,,0,0),
	[13] = new Cfg_t_plot_ground_Info(14,14,"26,27",1,0,5000,0,,,,0,0),
	[14] = new Cfg_t_plot_ground_Info(15,15,"28",1,0,5000,0,,,,0,0),
	[15] = new Cfg_t_plot_ground_Info(16,16,"29,30,31",1,0,5000,0,,,,0,0),
	[16] = new Cfg_t_plot_ground_Info(17,17,"32",1,0,5000,0,,,,0,0),
	[17] = new Cfg_t_plot_ground_Info(18,18,"33,34",1,0,5000,0,,,,0,0),
	[18] = new Cfg_t_plot_ground_Info(19,19,"35,36",1,0,5000,0,,,,0,0),
	[19] = new Cfg_t_plot_ground_Info(20,20,"37,38,39",1,0,5000,0,,,,0,0),
	[20] = new Cfg_t_plot_ground_Info(21,21,"40,41",1,0,5000,0,,,,0,0),
	[21] = new Cfg_t_plot_ground_Info(22,22,"42,43",1,0,5000,0,,,,0,0),
	[22] = new Cfg_t_plot_ground_Info(23,23,"44",1,0,5000,0,,,,0,0),
	[23] = new Cfg_t_plot_ground_Info(24,24,"45,46,47",1,0,5000,0,,,,0,0),
	[24] = new Cfg_t_plot_ground_Info(25,25,"48,49",1,0,5000,0,,,,0,0),
	[25] = new Cfg_t_plot_ground_Info(26,26,"50",1,0,5000,0,,,,0,0),
	[26] = new Cfg_t_plot_ground_Info(27,27,"51,52,53",1,0,5000,0,,,,0,0),
	[27] = new Cfg_t_plot_ground_Info(28,28,"54,55",1,0,5000,0,,,,0,0),
	[28] = new Cfg_t_plot_ground_Info(29,29,"57,58",1,0,5000,0,,,,0,0),
	[29] = new Cfg_t_plot_ground_Info(30,30,"61",1,0,5000,0,,,,0,0),
	[30] = new Cfg_t_plot_ground_Info(31,31,"62,63,64",1,0,5000,0,,,,0,0),
	[31] = new Cfg_t_plot_ground_Info(32,32,"65",1,0,5000,0,,,,0,0),
	[32] = new Cfg_t_plot_ground_Info(34,34,"66",1,0,5000,0,,,,0,0),
	[33] = new Cfg_t_plot_ground_Info(35,35,"67,68",1,0,5000,0,,,,0,0),
	[34] = new Cfg_t_plot_ground_Info(36,36,"69,70,71",1,0,5000,0,,,,0,0),
	[35] = new Cfg_t_plot_ground_Info(37,37,"72,73",1,0,5000,0,,,,0,0),
	[36] = new Cfg_t_plot_ground_Info(38,38,"74",1,0,5000,0,,,,0,0),
	[37] = new Cfg_t_plot_ground_Info(39,39,"75,76,77",1,0,5000,0,,,,0,0),
	[38] = new Cfg_t_plot_ground_Info(40,40,"78,79",1,0,5000,0,,,,0,0),
	[39] = new Cfg_t_plot_ground_Info(41,41,"80,81,82,83,84,85,86",1,0,5000,0,,,,0,0),
	[40] = new Cfg_t_plot_ground_Info(42,42,"87,88,89",1,0,5000,0,,,,0,0),
	[41] = new Cfg_t_plot_ground_Info(43,43,"90,91,92",1,0,5000,0,,,,0,0),
	[42] = new Cfg_t_plot_ground_Info(44,44,"93,94,95",1,0,5000,0,,,,0,0),
	[43] = new Cfg_t_plot_ground_Info(45,45,"96,97,98",1,0,5000,0,,,,0,0),
	[44] = new Cfg_t_plot_ground_Info(46,46,"99,100",1,0,5000,0,,,,0,0),
	[45] = new Cfg_t_plot_ground_Info(47,47,"101,102",1,0,5000,0,,,,0,0),
	[46] = new Cfg_t_plot_ground_Info(48,48,"103104105106107",1,0,5000,0,,,,0,0),
	[47] = new Cfg_t_plot_ground_Info(49,49,"109",1,0,5000,0,,,,0,0),
	[48] = new Cfg_t_plot_ground_Info(50,50,"110",1,0,5000,0,,,,0,0),
	[49] = new Cfg_t_plot_ground_Info(51,51,"111",1,0,5000,0,,,,0,0),
	[50] = new Cfg_t_plot_ground_Info(52,52,"118119",1,0,5000,0,,,,0,0),
	[51] = new Cfg_t_plot_ground_Info(53,53,"120121122",1,0,5000,0,,,,0,0),
	[52] = new Cfg_t_plot_ground_Info(54,54,"123124125",1,0,5000,0,,,,0,0),
	[53] = new Cfg_t_plot_ground_Info(55,55,"126127128",1,0,5000,0,,,,0,0),
	[54] = new Cfg_t_plot_ground_Info(56,56,"129130131",1,0,5000,0,,,,0,0),
	[55] = new Cfg_t_plot_ground_Info(57,57,"132133",1,0,5000,0,,,,0,0),
	[56] = new Cfg_t_plot_ground_Info(58,58,"134135",1,0,5000,0,,,,0,0),
	[57] = new Cfg_t_plot_ground_Info(59,59,"136137",1,0,5000,0,,,,0,0),
	[58] = new Cfg_t_plot_ground_Info(60,60,"138139",1,0,5000,0,,,,0,0),
	[59] = new Cfg_t_plot_ground_Info(61,61,"140141",1,0,5000,0,,,,0,0),
	[60] = new Cfg_t_plot_ground_Info(62,62,"142143144",1,0,5000,0,,,,0,0),
	[61] = new Cfg_t_plot_ground_Info(63,63,"145146",1,0,5000,0,,,,0,0),
	[62] = new Cfg_t_plot_ground_Info(64,64,"147148",1,0,5000,0,,,,0,0),
	[63] = new Cfg_t_plot_ground_Info(65,65,"149,150",1,0,5000,0,,,,0,0),
	[64] = new Cfg_t_plot_ground_Info(66,66,"151",1,0,5000,0,,,,0,0),
	[65] = new Cfg_t_plot_ground_Info(67,67,"152,153,154",1,0,5000,0,,,,0,0),
	[66] = new Cfg_t_plot_ground_Info(68,68,"155,156",1,0,5000,0,,,,0,0),
	[67] = new Cfg_t_plot_ground_Info(69,69,"157",1,0,5000,0,,,,0,0),
	[68] = new Cfg_t_plot_ground_Info(70,70,"158",1,0,5000,0,,,,0,0),
	[69] = new Cfg_t_plot_ground_Info(71,71,"159,160",1,0,5000,0,,,,0,0),
	[70] = new Cfg_t_plot_ground_Info(72,72,"161,162,163,164",1,0,5000,0,,,,0,0),
	[71] = new Cfg_t_plot_ground_Info(73,73,"165,166,167,168,169",1,0,5000,0,,,,0,0),
	[72] = new Cfg_t_plot_ground_Info(74,74,"171,172,173,174",1,0,5000,0,,,,0,0),
	[73] = new Cfg_t_plot_ground_Info(75,75,"175,176,177",1,0,5000,0,,,,0,0),
	[74] = new Cfg_t_plot_ground_Info(76,76,"178",1,0,5000,0,0,0,0,0,0),
	[75] = new Cfg_t_plot_ground_Info(77,77,"179,180",1,0,5000,0,0,0,0,0,0),
	[76] = new Cfg_t_plot_ground_Info(78,78,"181",1,0,5000,0,0,0,0,0,0),
	[77] = new Cfg_t_plot_ground_Info(79,79,"182,183",1,0,5000,0,0,0,0,0,0),
	[78] = new Cfg_t_plot_ground_Info(80,80,"184,185",1,0,5000,0,0,0,0,0,0),
	[79] = new Cfg_t_plot_ground_Info(81,81,"186,187",1,0,5000,0,0,0,0,0,0),
	[80] = new Cfg_t_plot_ground_Info(82,82,"188",1,0,5000,0,0,0,0,0,0),
	[81] = new Cfg_t_plot_ground_Info(83,83,"189",1,0,5000,0,0,0,0,0,0),
	[82] = new Cfg_t_plot_ground_Info(84,84,"190",1,0,5000,0,0,0,0,0,0),
	[83] = new Cfg_t_plot_ground_Info(85,85,"191,192,193,194",1,0,5000,0,0,0,0,0,0),
	[84] = new Cfg_t_plot_ground_Info(86,86,"195,196",1,0,5000,0,0,0,0,0,0),
	[85] = new Cfg_t_plot_ground_Info(87,87,"197,198",1,0,5000,0,0,0,0,0,0),
	[86] = new Cfg_t_plot_ground_Info(88,88,"199",1,0,5000,0,0,0,0,0,0),
	[87] = new Cfg_t_plot_ground_Info(89,89,"200,201",1,0,5000,0,0,0,0,0,0),
	[88] = new Cfg_t_plot_ground_Info(90,90,"202,203,204",1,0,5000,0,0,0,0,0,0),
	[89] = new Cfg_t_plot_ground_Info(91,91,"205,206",1,0,5000,0,0,0,0,0,0),
	[90] = new Cfg_t_plot_ground_Info(92,92,"207",1,0,5000,0,0,0,0,0,0),
	[91] = new Cfg_t_plot_ground_Info(93,93,"208",1,0,5000,0,0,0,0,0,0),
	[92] = new Cfg_t_plot_ground_Info(94,94,"209",1,0,5000,0,0,0,0,0,0),
	[93] = new Cfg_t_plot_ground_Info(95,95,"210,211",1,0,5000,0,0,0,0,0,0),
	[94] = new Cfg_t_plot_ground_Info(96,96,"212,213,214",1,0,5000,0,0,0,0,0,0),
	[95] = new Cfg_t_plot_ground_Info(97,97,"215",1,0,5000,0,0,0,0,0,0),
	[96] = new Cfg_t_plot_ground_Info(98,98,"216",1,0,5000,0,0,0,0,0,0),
	[97] = new Cfg_t_plot_ground_Info(99,99,"217",1,0,5000,0,0,0,0,0,0),
	[98] = new Cfg_t_plot_ground_Info(100,100,"218",1,0,5000,0,0,0,0,0,0),
	[99] = new Cfg_t_plot_ground_Info(101,101,"219,220",1,0,5000,0,0,0,0,0,0),
	[100] = new Cfg_t_plot_ground_Info(102,102,"221",1,0,5000,0,0,0,0,0,0),
	[101] = new Cfg_t_plot_ground_Info(103,103,"230,231",1,0,5000,0,,,,0,0),
	[102] = new Cfg_t_plot_ground_Info(104,104,"232,233",1,0,5000,0,,,,0,0),
	[103] = new Cfg_t_plot_ground_Info(100001,100001,"100001",1,0,,,,,,,2000),
	[104] = new Cfg_t_plot_ground_Info(100002,100002,"100002",1,1,5000,0,,,,0,5000),
	[105] = new Cfg_t_plot_ground_Info(100003,100003,"100003",1,1,5000,0,,,,0,5000),
	[106] = new Cfg_t_plot_ground_Info(100004,100004,"100004",1,1,5000,0,,,,0,5000),
	[107] = new Cfg_t_plot_ground_Info(100005,100005,"100005,100011",1,0,,,,,,0,0),
	[108] = new Cfg_t_plot_ground_Info(100006,100006,"100006",1,0,0,0,0,0,0,0,0),
	[109] = new Cfg_t_plot_ground_Info(100007,100007,"100007",1,0,0,0,0,0,0,0,0),
	[110] = new Cfg_t_plot_ground_Info(100008,100008,"100008",1,0,0,0,0,0,0,0,0),
	[111] = new Cfg_t_plot_ground_Info(100009,100009,"100009",1,0,0,0,0,0,0,0,0),
	[112] = new Cfg_t_plot_ground_Info(100010,100010,"100010",1,0,0,0,0,0,0,0,0),
	[113] = new Cfg_t_plot_ground_Info(100011,100011,"100007",1,0,0,0,0,0,0,0,0),
	[114] = new Cfg_t_plot_ground_Info(200001,200001,"200001",1,0,0,0,0,0,0,0,0),
	[115] = new Cfg_t_plot_ground_Info(200002,200002,"200002",1,0,0,0,0,0,0,0,0),
	[116] = new Cfg_t_plot_ground_Info(200003,200003,"200003",1,0,0,0,0,0,0,0,0),
	[117] = new Cfg_t_plot_ground_Info(200004,200004,"200004,200005,200006",1,0,0,0,0,0,0,0,0),
	[118] = new Cfg_t_plot_ground_Info(200005,200005,"200007",1,0,0,0,0,0,0,0,0),
	[119] = new Cfg_t_plot_ground_Info(200006,200006,"200008",1,0,0,0,0,0,0,0,0),
	[120] = new Cfg_t_plot_ground_Info(200007,200007,"200009,200010,200011",1,0,0,0,0,0,0,0,0),
	[121] = new Cfg_t_plot_ground_Info(200008,200008,"200010",1,0,0,0,0,0,0,0,0),
	[122] = new Cfg_t_plot_ground_Info(200009,200009,"200011",1,0,0,0,0,0,0,0,0),
	[123] = new Cfg_t_plot_ground_Info(200010,200010,"200004",1,0,0,0,0,0,0,0,0),
	[124] = new Cfg_t_plot_ground_Info(200011,200011,"200005",1,0,0,0,0,0,0,0,0),
	[125] = new Cfg_t_plot_ground_Info(200012,200012,"200006",1,0,0,0,0,0,0,0,0),
	[126] = new Cfg_t_plot_ground_Info(200013,200013,"200012,200013,200014",1,0,0,0,0,0,0,0,0),
	[127] = new Cfg_t_plot_ground_Info(200014,200014,"200015,200016",1,0,0,0,0,0,0,0,0),
	[128] = new Cfg_t_plot_ground_Info(200015,200015,"200018",1,0,0,0,0,0,0,0,0),
	[129] = new Cfg_t_plot_ground_Info(200016,200016,"200019,200020,200021,200022",1,0,0,0,0,0,0,0,0),
};
}
