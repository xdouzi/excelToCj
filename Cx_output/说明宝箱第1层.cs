using System.Collections.Generic;
public class Cfg_说明宝箱第1层_Info
{
	public string id;
	public string 名称;
	public string 宝箱;
	public string 时代;
public Cfg_说明宝箱第1层_Info(int id,int a_base_item_id,int a_base_operater_id,int c_base_name,string c_base_item_name,string c_base_item_show_name,int c_base_tips,int c_base_child_type,int a_base_type,int a_base_sort,int c_base_tab,int a_base_property,int a_base_quality,int c_base_kinds_icon,int c_base_stack,string c_ints_fetch_way,int c_base_tips_type,string a_arrayints_use_limit,string c_base_flash,int a_base_term,int a_base_trade,string a_arrayints_item_use_id,string a_arrayints_item_time,int a_base_award_id,string a_ints_price,int a_base_card_group_id,int a_base_automatic_open,int c_base_item_flyint id,int a_base_item_id,int a_base_operater_id,int c_base_name,string c_base_icon_name,int c_base_tips,int c_base_child_type,int a_base_type,int a_base_sort,int c_base_tab,int a_base_property,int a_base_quality,int c_base_kinds_icon,int c_base_stack,string c_ints_fetch_way,string a_ints_tips_type,string a_ints_use_limit,string c_base_flash,int a_base_term,int a_base_trade,string a_arrayints_item_use_id,string a_arrayints_item_time,int a_base_award_id,string a_ints_price,int a_base_card_group_id,int a_base_automatic_open,int c_base_item_flystring 页签类型,string 顺序,string 10000,string 宝箱1,string 宝箱2,string 宝箱3,int 注：玩法表中数据引用,string 验证,string 卡牌总数,string 部分1数量,string 部分1次数,string 部分2数量,string 部分2次数,string 石器时代,string 1,string 1,string 2,string 品质,string 随机卡牌,string 数量int 第1部分,int 第2部分,int 第1部分,int 第2部分,int 第1部分,int 第2部分,string 宝箱:,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 3,int 3,int 3,int 3,int 3,int 3,int 3,int 3,int 3,int 3string id,string 名称,string 宝箱,string 时代)
{
  this.id = id;
  this.名称 = 名称;
  this.宝箱 = 宝箱;
  this.时代 = 时代;
}
}
public class Cfg_说明宝箱第1层
{
public static Dictionary<string,Cfg_说明宝箱第1层_Info> list = new Dictionary<Cfg_说明宝箱第1层_Info>()
{
	["5040"] = new Cfg_说明宝箱第1层_Info("5040","宝箱1时代4,初始","1","4"),
	["5050"] = new Cfg_说明宝箱第1层_Info("5050","宝箱1时代5,初始","1","5"),
	["5110"] = new Cfg_说明宝箱第1层_Info("5110","宝箱1时代1,大于100抽","1","1"),
	["5120"] = new Cfg_说明宝箱第1层_Info("5120","宝箱1时代2,大于100抽","1","2"),
	["5130"] = new Cfg_说明宝箱第1层_Info("5130","宝箱1时代3,大于100抽","1","3"),
	["5140"] = new Cfg_说明宝箱第1层_Info("5140","宝箱1时代4,大于100抽","1","4"),
	["5150"] = new Cfg_说明宝箱第1层_Info("5150","宝箱1时代5,大于100抽","1","5"),
	["5210"] = new Cfg_说明宝箱第1层_Info("5210","宝箱2时代1,初始","2","1"),
	["5220"] = new Cfg_说明宝箱第1层_Info("5220","宝箱2时代2,初始","2","2"),
	["5230"] = new Cfg_说明宝箱第1层_Info("5230","宝箱2时代3,初始","2","3"),
	["5240"] = new Cfg_说明宝箱第1层_Info("5240","宝箱2时代4,初始","2","4"),
	["5250"] = new Cfg_说明宝箱第1层_Info("5250","宝箱2时代5,初始","2","5"),
	["5310"] = new Cfg_说明宝箱第1层_Info("5310","宝箱2时代1,大于100抽","2","1"),
	["5320"] = new Cfg_说明宝箱第1层_Info("5320","宝箱2时代2,大于100抽","2","2"),
	["5330"] = new Cfg_说明宝箱第1层_Info("5330","宝箱2时代3,大于100抽","2","3"),
	["5340"] = new Cfg_说明宝箱第1层_Info("5340","宝箱2时代4,大于100抽","2","4"),
	["5350"] = new Cfg_说明宝箱第1层_Info("5350","宝箱2时代5,大于100抽","2","5"),
	["5410"] = new Cfg_说明宝箱第1层_Info("5410","宝箱3时代1,初始","3","1"),
	["5420"] = new Cfg_说明宝箱第1层_Info("5420","宝箱3时代2,初始","3","2"),
	["5430"] = new Cfg_说明宝箱第1层_Info("5430","宝箱3时代3,初始","3","3"),
	["5440"] = new Cfg_说明宝箱第1层_Info("5440","宝箱3时代4,初始","3","4"),
	["5450"] = new Cfg_说明宝箱第1层_Info("5450","宝箱3时代5,初始","3","5"),
	["5510"] = new Cfg_说明宝箱第1层_Info("5510","宝箱3时代1,大于100抽","3","1"),
	["5520"] = new Cfg_说明宝箱第1层_Info("5520","宝箱3时代2,大于100抽","3","2"),
	["5530"] = new Cfg_说明宝箱第1层_Info("5530","宝箱3时代3,大于100抽","3","3"),
	["5540"] = new Cfg_说明宝箱第1层_Info("5540","宝箱3时代4,大于100抽","3","4"),
	["5550"] = new Cfg_说明宝箱第1层_Info("5550","宝箱3时代5,大于100抽","3","5"),
};
}
