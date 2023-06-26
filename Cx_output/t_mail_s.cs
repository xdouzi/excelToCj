using System.Collections.Generic;
public class Cfg_t_mail_s_Info
{
public int id;
public int a_base_mail_id;
public int a_base_mail_headline;
public int a_base_mail_text;
public Cfg_t_mail_s_Info(int id,int a_base_mail_id,int a_base_mail_headline,int a_base_mail_text)
{
  this.id = id;
  this.a_base_mail_id = a_base_mail_id;
  this.a_base_mail_headline = a_base_mail_headline;
  this.a_base_mail_text = a_base_mail_text;
}
}
public class Cfg_t_mail_s
{
public static List<Cfg_t_mail_s_Info> list = new List<Cfg_t_mail_s_Info>()
{
	[0] = new Cfg_t_mail_s_Info(1,101,24701,24801),
	[1] = new Cfg_t_mail_s_Info(2,102,24702,24802),
	[2] = new Cfg_t_mail_s_Info(3,103,24705,24805),
};
}
