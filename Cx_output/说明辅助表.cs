using System.Collections.Generic;
public class 说明辅助表Info
{
public string 页签类型;
public string 顺序;
public string 10000;
public string 宝箱1;
public string 宝箱2;
public string 宝箱3;
public int 注：玩法表中数据引用;
public string 验证;
public string 卡牌总数;
public string 部分1数量;
public string 部分1次数;
public string 部分2数量;
public string 部分2次数;
public string 石器时代;
public string 1;
public string 1;
public string 2;
public string 品质;
public string 随机卡牌;
public string 数量;
public 说明辅助表Info(int id,int a_base_item_id,int a_base_operater_id,int c_base_name,string c_base_item_name,string c_base_item_show_name,int c_base_tips,int c_base_child_type,int a_base_type,int a_base_sort,int c_base_tab,int a_base_property,int a_base_quality,int c_base_kinds_icon,int c_base_stack,string c_ints_fetch_way,int c_base_tips_type,string a_arrayints_use_limit,string c_base_flash,int a_base_term,int a_base_trade,string a_arrayints_item_use_id,string a_arrayints_item_time,int a_base_award_id,string a_ints_price,int a_base_card_group_id,int a_base_automatic_open,int c_base_item_flyint id,int a_base_item_id,int a_base_operater_id,int c_base_name,string c_base_icon_name,int c_base_tips,int c_base_child_type,int a_base_type,int a_base_sort,int c_base_tab,int a_base_property,int a_base_quality,int c_base_kinds_icon,int c_base_stack,string c_ints_fetch_way,string a_ints_tips_type,string a_ints_use_limit,string c_base_flash,int a_base_term,int a_base_trade,string a_arrayints_item_use_id,string a_arrayints_item_time,int a_base_award_id,string a_ints_price,int a_base_card_group_id,int a_base_automatic_open,int c_base_item_flystring 页签类型,string 顺序,string 10000,string 宝箱1,string 宝箱2,string 宝箱3,int 注：玩法表中数据引用,string 验证,string 卡牌总数,string 部分1数量,string 部分1次数,string 部分2数量,string 部分2次数,string 石器时代,string 1,string 1,string 2,string 品质,string 随机卡牌,string 数量)
{
  this.页签类型 = 页签类型;
  this.顺序 = 顺序;
  this.10000 = 10000;
  this.宝箱1 = 宝箱1;
  this.宝箱2 = 宝箱2;
  this.宝箱3 = 宝箱3;
  this.注：玩法表中数据引用 = 注：玩法表中数据引用;
  this.验证 = 验证;
  this.卡牌总数 = 卡牌总数;
  this.部分1数量 = 部分1数量;
  this.部分1次数 = 部分1次数;
  this.部分2数量 = 部分2数量;
  this.部分2次数 = 部分2次数;
  this.石器时代 = 石器时代;
  this.1 = 1;
  this.1 = 1;
  this.2 = 2;
  this.品质 = 品质;
  this.随机卡牌 = 随机卡牌;
  this.数量 = 数量;
}
}
public class Cfg_说明辅助表
{
public static List<说明辅助表Info> list = new List<说明辅助表Info>()
{
	[0] = new 说明辅助表Info("3","3","3","5","10","30",,"0","10","3","2","4","1","现代","5","131","2","4","5星卡牌","1"),
	[1] = new 说明辅助表Info("","","4","0","1","5",,"0","5","2","2","1","1","","","141","0","","",""),
	[2] = new 说明辅助表Info("","","","","","",,"0","1","1","1","0","0","","","112","2","","",""),
	[3] = new 说明辅助表Info("","","","","","",,"0","0","0","0","0","0","","","122","1","","",""),
	[4] = new 说明辅助表Info("","","","","","",,"","","","","","","","","132","1","","",""),
	[5] = new 说明辅助表Info("","","","","","",,"","","","","","","","","142","0","","",""),
	[6] = new 说明辅助表Info("引用表格：","","","","","",,"","","","","","","","","213","2","","",""),
	[7] = new 说明辅助表Info("","数值规划","","","","",,"","","","","","","","","223","2","","",""),
	[8] = new 说明辅助表Info("","","","","","",,"","","","","","","","","233","2","","",""),
	[9] = new 说明辅助表Info("","","","","","",,"","","","","","","","","243","1","","",""),
	[10] = new 说明辅助表Info("","","","","","",,"","","","","","","","","214","1","","",""),
	[11] = new 说明辅助表Info("","","","","","",,"","","","","","","","","224","1","","",""),
	[12] = new 说明辅助表Info("","","","","","",,"","","","","","","","","234","1","","",""),
	[13] = new 说明辅助表Info("","","","","","",,"","","","","","","","","244","0","","",""),
	[14] = new 说明辅助表Info("","","","","","",,"","","","","","","","","315","0","","",""),
	[15] = new 说明辅助表Info("","","","","","",,"","","","","","","","","325","2","","",""),
	[16] = new 说明辅助表Info("","","","","","",,"","","","","","","","","335","3","","",""),
	[17] = new 说明辅助表Info("","","","","","",,"","","","","","","","","345","2","","",""),
	[18] = new 说明辅助表Info("","","","","","",,"","","","","","","","","316","0","","",""),
	[19] = new 说明辅助表Info("","","","","","",,"","","","","","","","","326","1","","",""),
	[20] = new 说明辅助表Info("","","","","","",,"","","","","","","","","336","1","","",""),
	[21] = new 说明辅助表Info("","","","","","",,"","","","","","","","","346","1","","",""),
};
}
