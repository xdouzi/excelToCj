using System.Collections.Generic;
public class 说明新道具Info
{
public string 1小时;
public string 金币;
public string 1小时金币;
public 说明新道具Info(int id,int a_base_item_id,int a_base_operater_id,int c_base_name,string c_base_item_name,string c_base_item_show_name,int c_base_tips,int c_base_child_type,int a_base_type,int a_base_sort,int c_base_tab,int a_base_property,int a_base_quality,int c_base_kinds_icon,int c_base_stack,string c_ints_fetch_way,int c_base_tips_type,string a_arrayints_use_limit,string c_base_flash,int a_base_term,int a_base_trade,string a_arrayints_item_use_id,string a_arrayints_item_time,int a_base_award_id,string a_ints_price,int a_base_card_group_id,int a_base_automatic_open,int c_base_item_flyint id,int a_base_item_id,int a_base_operater_id,int c_base_name,string c_base_icon_name,int c_base_tips,int c_base_child_type,int a_base_type,int a_base_sort,int c_base_tab,int a_base_property,int a_base_quality,int c_base_kinds_icon,int c_base_stack,string c_ints_fetch_way,string a_ints_tips_type,string a_ints_use_limit,string c_base_flash,int a_base_term,int a_base_trade,string a_arrayints_item_use_id,string a_arrayints_item_time,int a_base_award_id,string a_ints_price,int a_base_card_group_id,int a_base_automatic_open,int c_base_item_flystring 页签类型,string 顺序,string 10000,string 宝箱1,string 宝箱2,string 宝箱3,int 注：玩法表中数据引用,string 验证,string 卡牌总数,string 部分1数量,string 部分1次数,string 部分2数量,string 部分2次数,string 石器时代,string 1,string 1,string 2,string 品质,string 随机卡牌,string 数量int 第1部分,int 第2部分,int 第1部分,int 第2部分,int 第1部分,int 第2部分,string 宝箱:,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 1,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 2,int 3,int 3,int 3,int 3,int 3,int 3,int 3,int 3,int 3,int 3string id,string 名称,string 宝箱,string 时代string 奖励次数,string id,A,0,0,0,string id,string 名称,string 宝箱,string 时代,string 卡牌品质,string 部分,string 奖励组合int id,int a_base_award_id,string a_arrayints_type,string a_arrayints_award,string a_arrayints_random_awardstring 1小时,string 金币,string 1小时金币)
{
  this.1小时 = 1小时;
  this.金币 = 金币;
  this.1小时金币 = 1小时金币;
}
}
public class Cfg_说明新道具
{
public static List<说明新道具Info> list = new List<说明新道具Info>()
{
	[0] = new 说明新道具Info("8小时","食物","8小时食物"),
	[1] = new 说明新道具Info("5分钟","肉类","5分钟肉类"),
	[2] = new 说明新道具Info("1小时","肉类","1小时肉类"),
	[3] = new 说明新道具Info("8小时","肉类","8小时肉类"),
	[4] = new 说明新道具Info("5分钟","木材","5分钟木材"),
	[5] = new 说明新道具Info("1小时","木材","1小时木材"),
	[6] = new 说明新道具Info("8小时","木材","8小时木材"),
	[7] = new 说明新道具Info("5分钟","矿石","5分钟矿石"),
	[8] = new 说明新道具Info("1小时","矿石","1小时矿石"),
	[9] = new 说明新道具Info("8小时","矿石","8小时矿石"),
	[10] = new 说明新道具Info("开出1点","体力","开出1点体力"),
	[11] = new 说明新道具Info("开出10点","体力","开出10点体力"),
	[12] = new 说明新道具Info("开出100点","体力","开出100点体力"),
};
}
