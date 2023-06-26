using System.Collections.Generic;
public class t_mail_sInfo
{
public int id;
public int a_base_mail_id;
public int a_base_mail_headline;
public int a_base_mail_text;
public t_mail_sInfo(int id,int a_base_mail_id,int a_base_mail_headline,int a_base_mail_text)
{
  this.id = id;
  this.a_base_mail_id = a_base_mail_id;
  this.a_base_mail_headline = a_base_mail_headline;
  this.a_base_mail_text = a_base_mail_text;
}
}
public class Cfg_t_mail_s
{
public static List<t_mail_sInfo> list = new List<t_mail_sInfo>()
{
	[0] = new t_mail_sInfo(1,101,24701,24801),
	[1] = new t_mail_sInfo(2,102,24702,24802),
	[2] = new t_mail_sInfo(3,103,24705,24805),
};
}
