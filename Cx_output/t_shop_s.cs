using System.Collections.Generic;
public class Cfg_t_shop_s_Info
{
public int id;
public int a_base_shop_id;
public string c_e_name_id;
public int c_base_shop_name;
public string a_arrayints_open_shop_condition;
public string a_arrayints_shop_reset;
public string a_arrayints_hand_reset;
public int a_base_reset_limit;
public string a_ints_shelves;
public int a_base_shop_time_type;
public string a_arrayints_shop_time_scope;
public int a_base_entrance;
public int a_base_buy_limit;
public Cfg_t_shop_s_Info(int id,int a_base_commodity,int a_base_weight,string a_ints_item,string a_ints_price,int a_base_buy_second,string a_arrayints_discount_show,string a_arrayints_condition,int a_base_time_type,string a_ints_time_scopeint id,int a_base_goods_id,int a_base_shelves,int a_base_goods_lv,string a_arrayints_use_condition,string a_ints_commodityint id,int a_base_shop_id,string c_e_name_id,int c_base_shop_name,string a_arrayints_open_shop_condition,string a_arrayints_shop_reset,string a_arrayints_hand_reset,int a_base_reset_limit,string a_ints_shelves,int a_base_shop_time_type,string a_arrayints_shop_time_scope,int a_base_entrance,int a_base_buy_limit)
{
  this.id = id;
  this.a_base_shop_id = a_base_shop_id;
  this.c_e_name_id = c_e_name_id;
  this.c_base_shop_name = c_base_shop_name;
  this.a_arrayints_open_shop_condition = a_arrayints_open_shop_condition;
  this.a_arrayints_shop_reset = a_arrayints_shop_reset;
  this.a_arrayints_hand_reset = a_arrayints_hand_reset;
  this.a_base_reset_limit = a_base_reset_limit;
  this.a_ints_shelves = a_ints_shelves;
  this.a_base_shop_time_type = a_base_shop_time_type;
  this.a_arrayints_shop_time_scope = a_arrayints_shop_time_scope;
  this.a_base_entrance = a_base_entrance;
  this.a_base_buy_limit = a_base_buy_limit;
}
}
public class Cfg_t_shop_s
{
public static List<Cfg_t_shop_s_Info> list = new List<Cfg_t_shop_s_Info>()
{
	[0] = new Cfg_t_shop_s_Info(1,1,"Limit_shop",8201,"","0 8 * * *;0 12 * * *;0 18 * * *","",,"701",0,"",1,1),
	[1] = new Cfg_t_shop_s_Info(2,2,"Item_shop",8202,"2,19,1","0 8 * * *","-1,0;-1,20;-1,50;-1,50;-1,100;-1,100;-1,200;-1,200",4,"101,102,103,104,105,106,107,108,109,110,111,112",0,"",3,3),
	[2] = new Cfg_t_shop_s_Info(3,3,"Card_shop",8203,"2,17,1","0 8 * * *;0 18 * * *","",,"401,402,403,404,405,406",0,"",1,1),
	[3] = new Cfg_t_shop_s_Info(4,4,"Box_shop",8204,"","0 8 * * * ","",,"501,502,503",0,"",1,50),
	[4] = new Cfg_t_shop_s_Info(5,5,"Gold_shop",8205,"","","",,"601,602,603",0,"",1,1),
	[5] = new Cfg_t_shop_s_Info(6,6,"Sacrifice",8206,"2,6,1","0 8 * * * ","",,"201,202,203,204,205,206",0,"",2,2),
	[6] = new Cfg_t_shop_s_Info(7,7,"Greed_shop",8207,"2,6,1","0 8 * * *;0 18 * * *","",,"301,302,303,304,305,306",0,"",2,2),
	[7] = new Cfg_t_shop_s_Info(8,8,"Vip_exp_shop",8208,"","","",,"801,802,803,804,805",0,"",4,4),
	[8] = new Cfg_t_shop_s_Info(9,9,"Vip_privilege_shop",8209,"","0 4 * * *","-1,0;-1,20;-1,50;-1,50;-1,100;-1,100;-1,200;-1,200",4,"901,902,903,904,905,906,907,908,909,910,911,912",0,"",5,5),
};
}
