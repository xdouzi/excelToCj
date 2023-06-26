using System.Collections.Generic;
public class t_jump_sInfo
{
public int id;
public int c_base_jump_id;
public string c_e_jump_enumname;
public int c_base_jumptoid;
public int c_base_jump_name;
public string c_base_jump_2;
public int c_base_trans_open;
public int c_base_system_id;
public t_jump_sInfo(int id,int c_base_jump_id,string c_e_jump_enumname,int c_base_jumptoid,int c_base_jump_name,string c_base_jump_2,int c_base_trans_open,int c_base_system_id)
{
  this.id = id;
  this.c_base_jump_id = c_base_jump_id;
  this.c_e_jump_enumname = c_e_jump_enumname;
  this.c_base_jumptoid = c_base_jumptoid;
  this.c_base_jump_name = c_base_jump_name;
  this.c_base_jump_2 = c_base_jump_2;
  this.c_base_trans_open = c_base_trans_open;
  this.c_base_system_id = c_base_system_id;
}
}
public class Cfg_t_jump_s
{
public static List<t_jump_sInfo> list = new List<t_jump_sInfo>()
{
	[0] = new t_jump_sInfo(1,1,"1",1010,31001001,"",1,23),
	[1] = new t_jump_sInfo(2,2,"2",1005,31001002,"",1,8),
	[2] = new t_jump_sInfo(3,3,"3",1025,31001005,"",1,9),
	[3] = new t_jump_sInfo(4,4,"4",1019,31001006,"",0,0),
	[4] = new t_jump_sInfo(5,5,"5",1055,31001007,"",0,22),
	[5] = new t_jump_sInfo(6,6,"6",1056,31001008,"",0,17),
	[6] = new t_jump_sInfo(7,7,"7",1057,31001009,"",0,18),
	[7] = new t_jump_sInfo(8,8,"8",1058,31001010,"",0,21),
	[8] = new t_jump_sInfo(9,9,"9",1064,101,"",0,24),
	[9] = new t_jump_sInfo(10,10,"10",1061,8206,"",0,19),
	[10] = new t_jump_sInfo(11,11,"11",1070,23023,"",0,31),
	[11] = new t_jump_sInfo(12,12,"12",1062,31001003,"",1,32),
	[12] = new t_jump_sInfo(13,13,"13",1057,31001011,"",0,20),
	[13] = new t_jump_sInfo(14,14,"14",1080,24201,"",0,34),
	[14] = new t_jump_sInfo(15,15,"15",1081,24107,"",0,35),
	[15] = new t_jump_sInfo(16,16,"16",,24401,"",0,37),
	[16] = new t_jump_sInfo(17,17,"17",1077,12,"",0,12),
	[17] = new t_jump_sInfo(18,18,"18",1077,13,"",0,13),
	[18] = new t_jump_sInfo(19,19,"19",1088,,"",0,36),
	[19] = new t_jump_sInfo(20,20,"20",1115,,"",1,38),
	[20] = new t_jump_sInfo(21,21,"21",1090,8202,"",0,45),
	[21] = new t_jump_sInfo(22,22,"Mail",1002,,"",0,10),
	[22] = new t_jump_sInfo(23,23,"23",1101,28200,"",1,46),
	[23] = new t_jump_sInfo(24,24,"24",1108,28103,"",1,47),
	[24] = new t_jump_sInfo(25,25,"25",,6012,"",0,38),
	[25] = new t_jump_sInfo(26,26,"26",1077,31001012,"",0,14),
	[26] = new t_jump_sInfo(27,27,"27",1129,,"",0,53),
};
}
