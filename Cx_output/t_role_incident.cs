using System.Collections.Generic;
public class Cfg_t_role_incident_Info
{
	public int id;
	public int a_base_incident_id;
	public string a_ints_begin_triggers;
	public int a_base_condition_probability;
	public int a_base_repetition;
	public string a_arrayints_add_self_buff;
	public int a_base_skill;
public Cfg_t_role_incident_Info(int id,int a_base_role_id,int a_base_role_group,int c_base_prefab_id,int c_base_show_prefabid,int a_base_lv,int c_base_name,int c_base_description,int a_base_kind,int c_base_model_size,int c_base_chessbordmodel_size,string c_ints_controlbox_size,int a_base_levelupeffect,int a_base_leveluptip,string a_arrayints_property,int a_base_td_invade_point,string a_ints_bloodline,string a_ints_bloodline_length,string a_ints_enemybloodline,int a_base_move_type,int a_base_move_priority,int a_base_role_type,int a_base_role_profession,int c_base_born_effect,int c_base_trans_effect,int c_base_die_effect,string a_ints_role_collision,string a_ints_role_detect,int a_base_rotatetransform,int a_base_guard_scope,string a_ints_xunlu_target,string a_ints_priority_target,string a_ints_role_skill,string a_ints_passivity_skill,string a_ints_incident,int c_base_skillname,string c_base_skillicon,string c_ints_skilldescribe,int a_base_cheesetype,string c_base_head,int c_base_role_died_sound,string a_base_group_color,string a_base_weapon_color,string a_base_body_color,string a_base_mounts_color,string c_vector3_position,string c_vector3_scale,string a_ints_cameraconfig,string a_base_action_effectint id,int a_base_incident_id,string a_ints_begin_triggers,int a_base_condition_probability,int a_base_repetition,string a_arrayints_add_self_buff,int a_base_skill)
{
  this.id = id;
  this.a_base_incident_id = a_base_incident_id;
  this.a_ints_begin_triggers = a_ints_begin_triggers;
  this.a_base_condition_probability = a_base_condition_probability;
  this.a_base_repetition = a_base_repetition;
  this.a_arrayints_add_self_buff = a_arrayints_add_self_buff;
  this.a_base_skill = a_base_skill;
}
}
public class Cfg_t_role_incident
{
public static List<Cfg_t_role_incident_Info> list = new List<Cfg_t_role_incident_Info>()
{
	[%!d(string=1)] = new Cfg_t_role_incident_Info(1,1,"",,,"",),
	[%!d(string=2)] = new Cfg_t_role_incident_Info(2,2,"",,,"",),
};
}
