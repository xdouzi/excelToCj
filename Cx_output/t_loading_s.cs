using System.Collections.Generic;
public class t_loading_sInfo
{
public int a_base_key_id;
public int a_base_loadingid;
public int a_base_loadinggroupid_id;
public string c_ints_appears_location;
public string a_ints_player_level;
public string a_ints_chapter_level;
public string a_ints_house_level;
public string a_ints_era;
public int a_base_hold_time;
public int a_base_loadingbg_res;
public int c_base_animation_id;
public int c_base_progress_bar_id;
public string a_ints_tipstxt_group;
public t_loading_sInfo(int a_base_key_id,int a_base_loadingid,int a_base_loadinggroupid_id,string c_ints_appears_location,string a_ints_player_level,string a_ints_chapter_level,string a_ints_house_level,string a_ints_era,int a_base_hold_time,int a_base_loadingbg_res,int c_base_animation_id,int c_base_progress_bar_id,string a_ints_tipstxt_group)
{
  this.a_base_key_id = a_base_key_id;
  this.a_base_loadingid = a_base_loadingid;
  this.a_base_loadinggroupid_id = a_base_loadinggroupid_id;
  this.c_ints_appears_location = c_ints_appears_location;
  this.a_ints_player_level = a_ints_player_level;
  this.a_ints_chapter_level = a_ints_chapter_level;
  this.a_ints_house_level = a_ints_house_level;
  this.a_ints_era = a_ints_era;
  this.a_base_hold_time = a_base_hold_time;
  this.a_base_loadingbg_res = a_base_loadingbg_res;
  this.c_base_animation_id = c_base_animation_id;
  this.c_base_progress_bar_id = c_base_progress_bar_id;
  this.a_ints_tipstxt_group = a_ints_tipstxt_group;
}
}
public class Cfg_t_loading_s
{
public static List<t_loading_sInfo> list = new List<t_loading_sInfo>()
{
	[0] = new t_loading_sInfo(1,1,1,"1","1","101102","1,10","1",3000,100001,110001,111001,"200001,200002"),
	[1] = new t_loading_sInfo(2,2,1,"2","1","101102","1,10","2",3000,100002,110002,111002,"200001,200003"),
	[2] = new t_loading_sInfo(3,3,1,"1","1","101102","1,10","3",3000,100003,110003,111003,"200001,200004"),
	[3] = new t_loading_sInfo(4,4,1,"1","1","101102","1,10","4",3000,100004,110004,111004,"200001,200005"),
	[4] = new t_loading_sInfo(5,5,1,"1","2,7","101102","1,10","5",3000,100005,110005,111005,"200001,200006"),
	[5] = new t_loading_sInfo(6,6,2,"2","2,7","101102","1,10","1",3000,100006,110006,111006,"200006,200007,200008"),
	[6] = new t_loading_sInfo(7,7,2,"2","2,7","101102","1,10","2",3000,100007,110007,111007,"200007"),
	[7] = new t_loading_sInfo(8,8,2,"2","2,7","101102","1,10","3",3000,100008,110008,111008,"200008"),
	[8] = new t_loading_sInfo(9,9,2,"2","2,7","101102","1,10","4",3000,100009,110009,111009,"200009"),
	[9] = new t_loading_sInfo(10,10,3,"2","3,10","101102","1,10","5",3000,100010,110010,111010,"200010"),
	[10] = new t_loading_sInfo(11,11,3,"2","3,10","101102","1,10","1",3000,100011,110011,111011,"200011"),
	[11] = new t_loading_sInfo(12,12,3,"2","3,10","101102","1,10","2",3000,100012,110012,111012,"200012"),
	[12] = new t_loading_sInfo(13,13,3,"2","3,10","101102","1,10","3",3000,100013,110013,111013,"200013"),
	[13] = new t_loading_sInfo(14,14,3,"2","3,10","101102","1,10","4",3000,100014,110014,111014,"200014"),
	[14] = new t_loading_sInfo(15,15,3,"2","3,10","101102","1,10","5",3000,100015,110015,111015,"200015"),
	[15] = new t_loading_sInfo(16,16,3,"2","3,10","101102","1,10","2",3000,100016,110016,111016,"200016"),
	[16] = new t_loading_sInfo(17,17,3,"2","3,10","101102","1,10","2",3000,100017,110017,111017,"200017"),
};
}
