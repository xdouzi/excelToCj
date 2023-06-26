using System.Collections.Generic;
public class t_matchpoint_sInfo
{
public int id;
public int a_base_matchpoint_id;
public string a_arrayints_matchpoint_segment;
public int a_base_matchpointget;
public int a_base_matchpointlose;
public t_matchpoint_sInfo(string 1,string 2,string 3,string 4,string 5,string 6,string 7,string 8,string 9,string 10,string 11,string 12string 10200,10201,10202,10203,10204,21110,21120,21130,21140,21150,21210,21220,21230,21240,21250,32210,33210,34210,35210,36210,47210,47220,47230,47240,47250,10300,10301,10302,21310,21320,21330,21340,21350,32310,33310,34310,35310,36310,47310,47320,47330,10400,10401,10402,21410,21420,21430,21440,21450,32410,33410,34410,35410,36410,47410,47420,10500,10501,21510,21520,21530,21540,21550,32510,33510,34510,35510,36510,47510,47520int id,int a_base_mod_id,int a_base_matchpattern,int a_base_gametype,int a_base_booking,int a_base_eratype,int a_base_patterntype,int a_base_matchnum,string a_arrayints_aiconfig,string a_arrayints_matchingunclock,string a_base_matchingbg_path,string a_base_matchingicon_path,int a_base_matchingitype_title,int a_base_matchingitype_content,string a_arrayints_eraunclock,string a_base_erabg_path,string a_base_eraicon_path,int a_base_eratype_title,int a_base_eratype_content,int a_base_gametypemsgid,string a_arrayints_modeunclock,string a_base_modebg_path,string a_base_modeicon_path,int a_base_modetype_title,int a_base_modetype_content,string a_ints_pointsoutput,string a_ints_pointsdeduct,string a_ints_room_cost,string a_base_gamerefund,int a_base_booking_num,string a_ints_creatroom_cost,string a_arrayints_roomcreator_right,string a_arrayints_room_unlock,string a_ints_room_creatcost,string a_ints_createcondition,string a_ints_roomkey,string a_ints_roommaneger,string a_ints_creatroom_issue,string a_arrayints_roomissue_right,string a_arrayints_points_segment,string a_arrayints_scoreinterval,string a_ints_rankicon,string a_ints_mode_card,int a_base_usablecard_level,int a_base_usablecard_mun,int a_base_cardlevel,string a_ints_buildings_level,string a_ints_phaseone,string a_ints_phasetwo,string a_ints_winreward,int a_base_winreturn,int a_base_jackpot_ratio,int a_base_jackpot_ratiorisen,int a_base_decimation_factor,int a_base_reclaim_factor,string a_arrayints_defeatreward,int a_base_guarantees,string a_arrayints_rewardratiorisen,int a_base_levelchapter_idstring 1,string 1,string 0.00833333333333333,string 120,string 0.19277563597396,string 6410.4339122241,string 2136.8113040747,string 8547.2452162988string 500,string 1,string 5,string 500,1,5int id,int a_base_streakid,int a_base_streaknum,int a_base_factor,int a_base_point,int a_base_rewardfactorint id,int a_base_matchpoint_id,string a_arrayints_matchpoint_segment,int a_base_matchpointget,int a_base_matchpointlose)
{
  this.id = id;
  this.a_base_matchpoint_id = a_base_matchpoint_id;
  this.a_arrayints_matchpoint_segment = a_arrayints_matchpoint_segment;
  this.a_base_matchpointget = a_base_matchpointget;
  this.a_base_matchpointlose = a_base_matchpointlose;
}
}
public class Cfg_t_matchpoint_s
{
public static List<t_matchpoint_sInfo> list = new List<t_matchpoint_sInfo>()
{
	[0] = new t_matchpoint_sInfo(1,1,"0,500",5,0),
	[1] = new t_matchpoint_sInfo(2,2,"501,1000",6,-1),
	[2] = new t_matchpoint_sInfo(3,3,"1001,2500",13,-8),
	[3] = new t_matchpoint_sInfo(4,4,"2501,5000",32,-27),
	[4] = new t_matchpoint_sInfo(5,5,"5001,8000",69,-64),
	[5] = new t_matchpoint_sInfo(6,6,"8001,9999",130,-125),
};
}
