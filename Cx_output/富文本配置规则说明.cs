using System.Collections.Generic;
public class Cfg_富文本配置规则说明_Info
{
public string 格式："1,24,{0}"、"2,www.baidu.com";
public string 赛事{0}{1}{2}已经结束啦，您的排名为{3}\n恭喜获得以下奖励\n点击<u><color=#ff0000><link=\"3,53,{4}\">详细结果入口</link></color></u>查看详细信息吧;
public Cfg_富文本配置规则说明_Info(int id,int a_base_message_id,string a_base_operater_id,string c_e_name_id,string c_base_zh_cn,string c_base_zh_hk,string c_base_en_us,string c_base_th_th,string c_base_ko_kr,string c_base_nl_nl,string c_base_pt_pt,string c_base_fr_fr,string c_base_es_es,string c_base_de_de,string c_base_it_it,string c_base_no_no,string c_base_tr_tr,string c_base_sl_sl,string c_base_sv_se,string c_base_fi_fi,string c_base_da_dk,string c_base_he_il,string c_base_ja_jp,string c_base_nl_be,string c_base_ru_ru,string c_base_el_gr,string c_base_hu_hu,string c_base_cs_cz,string c_base_pl_pl,string c_base_es_cl,string c_base_in_hi,string c_base_ur_ur,string c_base_be_bestring 格式："1,24,{0}"、"2,www.baidu.com",string 赛事{0}{1}{2}已经结束啦，您的排名为{3}\n恭喜获得以下奖励\n点击<u><color=#ff0000><link=\"3,53,{4}\">详细结果入口</link></color></u>查看详细信息吧)
{
  this.格式："1,24,{0}"、"2,www.baidu.com" = 格式："1,24,{0}"、"2,www.baidu.com";
  this.赛事{0}{1}{2}已经结束啦，您的排名为{3}\n恭喜获得以下奖励\n点击<u><color=#ff0000><link=\"3,53,{4}\">详细结果入口</link></color></u>查看详细信息吧 = 赛事{0}{1}{2}已经结束啦，您的排名为{3}\n恭喜获得以下奖励\n点击<u><color=#ff0000><link=\"3,53,{4}\">详细结果入口</link></color></u>查看详细信息吧;
}
}
public class Cfg_富文本配置规则说明
{
public static List<Cfg_富文本配置规则说明_Info> list = new List<Cfg_富文本配置规则说明_Info>()
{
	[0] = new Cfg_富文本配置规则说明_Info("3、赛事跳转",""),
	[1] = new Cfg_富文本配置规则说明_Info("",""),
	[2] = new Cfg_富文本配置规则说明_Info("",""),
	[3] = new Cfg_富文本配置规则说明_Info("","赛事{0}【时代 a_base_eratype_title 】{1}【玩法：1V1\2V2\6V6 a_base_patterntype 】{2}【日赛、周赛、月赛a_base_gametypemsgid 】已经结束啦，您的排名为{3}【玩家该赛事的当前排名信息】\n恭喜获得以下奖励\n点击<u><color=#ff0000><link=\"3,53,{4}【赛事id】\">详细结果入口</link></color></u>查看详细信息吧"),
	[4] = new Cfg_富文本配置规则说明_Info("",""),
	[5] = new Cfg_富文本配置规则说明_Info("",""),
	[6] = new Cfg_富文本配置规则说明_Info("",""),
	[7] = new Cfg_富文本配置规则说明_Info("",""),
	[8] = new Cfg_富文本配置规则说明_Info("","尊敬的旅行者，非常抱歉\n赛事{0}{1}{2}异常终止\n您的资源已经通过邮件全部返还"),
	[9] = new Cfg_富文本配置规则说明_Info("","尊敬的旅行者，非常抱歉\n赛事{0}【时代 a_base_eratype_title 】{1}【玩法：1V1\2V2\6V6 a_base_patterntype 】{2}【日赛、周赛、月赛a_base_gametypemsgid 】异常终止\n您的资源已经通过邮件全部返还"),
};
}
