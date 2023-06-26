using System.Collections.Generic;
public class Cfg_t_timeline_Info
{
public int id;
public int a_base_timeline_id;
public string a_base_animation;
public int c_base_palytime;
public Cfg_t_timeline_Info(int id,int a_base_plot_ground_id,string a_ints_aggregate_id,int a_base_skip,int a_base_auto,int a_base_wait_time,int a_base_cm,int a_base_music,int a_base_music_begin,int a_base_music_loop,int a_base_run_model,int c_base_plot_ground_delytimeint id,int a_base_plot_id,int a_base_ground_id,int a_base_plot_type,string a_ints_plot_message,int a_base_plot_talk,int a_base_plot_words,int a_base_plot_auto,int a_base_wait_plot_time,int c_base_plot_show,string c_base_plot_action,int c_base_name_show,string c_base_bust,int c_base_plot_loop,string c_base_picture,int a_base_picture_life,int a_base_picture_move,int a_base_picture_speed,int a_base_animation,string c_base_whitelist,string c_base_refpoint_path,int c_base_arrow,string c_ints_arrowshifting,int c_base_light,string c_ints_lightshifting,int c_base_finger,int c_base_finger_type,int c_base_clickscale,string c_ints_fingershifting_01,string c_ints_fingershifting_02,int c_base_fingermovetime,int c_base_light_finish,string c_ints_talkshifting,string c_ints_camera,int c_base_scale,string c_base_camera_target_point,int c_base_camera_move_time,int c_base_stop,string c_ints_canui,int c_base_endnow,string c_base_picture_name,int c_base_vagueint id,int a_base_step_id,string c_ints_maincitylevel,int a_base_nextstep_id,int a_base_taskstep_id,int a_base_taskreward_id,string a_ints_branchline_id,int a_base_step_show,int c_base_panel_id,int c_base_autoclick,int c_base_scene_id,int c_base_plote_startid,int c_base_delytimeint id,int a_base_timeline_id,string a_base_animation,int c_base_palytime)
{
  this.id = id;
  this.a_base_timeline_id = a_base_timeline_id;
  this.a_base_animation = a_base_animation;
  this.c_base_palytime = c_base_palytime;
}
}
public class Cfg_t_timeline
{
public static List<Cfg_t_timeline_Info> list = new List<Cfg_t_timeline_Info>()
{
	[0] = new Cfg_t_timeline_Info(1,100001,"",1500),
};
}
