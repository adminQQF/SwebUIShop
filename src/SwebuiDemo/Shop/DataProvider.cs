using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwebuiDemo
{
    class DataProvider
    {
        public static UserInfo GetUserInfo(string name)
        {
            return new UserInfo() { Name = name, WaitConfirm = 7, WaitPay = 4, WaitRate = 2, buyerDisputeList = 1, WaitSend = 3 };
        }
        public static string[] GetNavigationItemText()
        {
            return new string[] { "女装 / 内衣 / 家居         >", "女鞋 / 男鞋 / 箱包         >", "母婴 / 童装 / 玩具         >", "男装 / 运动户外           >", "美妆 / 彩妆 / 个护         >", "手机 / 数码 / 企业         >", "大家电 / 生活电器         >", "零食 / 生鲜 / 茶酒         >", "厨具 / 收纳 / 清洁         >", "家纺 / 家饰 / 鲜花         >", "图书音像 / 文具           >", "医药保健 / 进口           >", "汽车 / 二手车 / 用品       >", "房产 / 装修家具 / 建材     >", "手表 / 眼镜 / 珠宝饰品     >" };
        }
        public static List<NavData> GetNavDatas()
        {
            List<NavData> navDatasList = new List<NavData>();

            NavData navData1 = new NavData()
            {
                Labels = new string[] { "流行趋势", "女装", "上装", "女裤" },
                Buttons = new List<string[]> {
                    new string[] { "小黑裙 ", "芭比裤", " 阔腿神裤", "宝藏羊毛", " 毛衣外套", " 西装大衣" },
                    new string[]{ "短外套 ","西装 ","羽绒服 ","风衣"," 毛呢大衣 ","皮草 ","棉衣棉服","皮衣" },
                    new string []{" 袜子 ","家居服套装"," 睡裙 ","背心","吊带 ","睡裤 ","睡袍 ","保暖内衣 ","睡衣" },
                    new string[]{ "连衣裙"," 半身裙","旗袍" }
                },
                Imgs = new string[] { "女士运动鞋", "男士帆布鞋", "女士马丁靴", "男士休闲鞋", "女士单鞋", "女士高跟鞋" }
            };
            NavData navData2 = new NavData()
            {
                Labels = new string[] { "女鞋", "男鞋，流行趋势", "箱包", "男士包袋", "功能类箱包" },
                Buttons = new List<string[]> {
                    new string[] { "女士凉鞋", " 女士罗马鞋 ", "一字带凉鞋", " 女士高跟鞋 ", "女士单鞋 ", "女士玛丽珍 ", "女士豆豆鞋 ", "女士穆勒鞋 ", "女士运动鞋", "女士奶奶鞋 ", "女士乐福鞋 ", "女士帆布鞋", " 女切尔西靴 ", "女士雪地靴", " 女士马丁靴", " 女士雨鞋" },
                    new string[]{ "男士豆豆鞋 ","男休闲皮鞋 ","男正装皮鞋"," 男士网面鞋 ","男士帆布鞋 ","男士人字拖","男士罗马鞋"," 男士洞洞鞋 ","男沙滩凉鞋 ","男士雨鞋"," 男士工装靴 ","男士马丁靴"},
                    new string []{" 奶油鞋"," 暗黑马丁 ","小皮鞋"," 烟筒靴"," 瘦瘦靴","小方包"," 水桶包 ","链条包" },
                    new string[]{ "女士单肩包 ","女士帆布包"," 女士手拿包" },
                    new string[]{ "男士单肩包"," 男士斜挎包"," 男士真皮包"," 男士胸包"," 男士腰包" },
                    new string[]{ "双肩背包"," 旅行箱"," 钱包"," 旅行袋"," 卡包" }
                },
                Imgs = new string[] { "女士运动鞋", "男士帆布鞋", "女士马丁靴", "男士休闲鞋", "女士单鞋", "女士高跟鞋" }
            };
            NavData navData3 = new NavData()
            {
                Labels = new string[] { "零食", "饼干", "蜜饯" },
                Buttons = new List<string[]> {
                    new string[] { "网红ip ","零食大礼包"," 趣味食玩"," 健康轻零食"," 蛋黄酥"," 薯片"," 糖果"," 饼干 ","儿童零食"," 冻干"," 海味 ","巧克力 ","月饼" },
                    new string[]{ "粉丝米线 ","方便面"," 开味下饭菜"," 挂面"," 煎饼冷面 ","速冻面点 ","方便粥饭 ","火腿肠"," 甜品罐头"," 熟食","午餐肉"," 快手菜"},
                    new string []{"碳酸饮料 ","儿童奶 ","酸奶"," 纯牛奶 ","饮用水 ","冰淇淋 ","奶粉"," 乳酸饮料"," 鲜奶" },
                },
                Imgs = new string[] { "女士运动鞋", "男士帆布鞋", "女士马丁靴", "男士休闲鞋", "女士单鞋", "女士高跟鞋" }
            };
            navDatasList.Add(navData1);
            navDatasList.Add(navData2);
            navDatasList.Add(navData3);

            return navDatasList;
        }

        public static ShopProductInfo GetShopProductInfo(string pid)
        {
            ShopProductInfo shopProductInfo = new ShopProductInfo();
            shopProductInfo.PID = pid;
            shopProductInfo.Name = "欧式多层甜品台蛋糕架浮雕三层架蛋糕盘点心水果托盘下午茶蛋糕架";
            shopProductInfo.Img = "b-de-pro1.jpg";
            shopProductInfo.Price = "24.80-134.40";
            shopProductInfo.OldOPrice = "31.00-168.00";
            shopProductInfo.StockNum = 35648;
            shopProductInfo.Types = new ProductImgs[]
            {
                new ProductImgs(){SImgID="s-de-pro1.jpg",Remarks="金色三层",Remarks1="134.54"},
                new ProductImgs(){SImgID="s-de-pro2.jpg",Remarks="银色三层",Remarks1="134.54"},
                new ProductImgs(){SImgID="s-de-pro3.jpg",Remarks="金色二层",Remarks1="104.54"},
                new ProductImgs(){SImgID="s-de-pro4.jpg",Remarks="银色二层",Remarks1="104.54"}
            };
            shopProductInfo.ProImgs = new ProductImgs[]
            {
                new ProductImgs(){SImgID="s-de-pro1.jpg"},
                new ProductImgs(){SImgID="s-de-pro2.jpg"},
                new ProductImgs(){SImgID="s-de-pro3.jpg"},
                new ProductImgs(){SImgID="s-de-pro4.jpg"}
            };

            DataTable dt = new DataTable();
            dt.Columns.Add("img");
            dt.Rows.Add("b-de-pro1.jpg");
            dt.Rows.Add("b-de-pro2.jpg");
            dt.Rows.Add("b-de-pro3.jpg");
            dt.Rows.Add("b-de-pro4.jpg");
            shopProductInfo.ProImgData = dt;
            return shopProductInfo;
        }

        public static ShopInfo GetShopInfo()
        {
            ShopInfo shopInfo = new ShopInfo();
            shopInfo.Name = "青木映画";
            shopInfo.ShopIcon = "gold.png";
            shopInfo.Promos = new ProductImgs[] {
            new ProductImgs(){ SImgID="i1.png",Remarks="15天退货"},
            new ProductImgs(){ SImgID="i2.png",Remarks="1次破损补寄"},
            new ProductImgs(){ SImgID="i3.png",Remarks="破损包退"},
            new ProductImgs(){ SImgID="i4.png",Remarks="订单险"},
            new ProductImgs(){ SImgID="i5.png",Remarks="运费险"}
            };
            shopInfo.PayWays = new ProductImgs[] {
            new ProductImgs(){ SImgID="i6.png",Remarks="信用卡支付"},
            new ProductImgs(){ SImgID="i7.png",Remarks="集分宝"} };
            return shopInfo;
        }

        private static List<OrderListItem> orderProList=new List<OrderListItem>();
        public static List<OrderListItem> GetOrderLists()
        {
            orderProList = new List<OrderListItem>();
            OrderListItem orderListItem = new OrderListItem();
            orderListItem.ShopInfo = GetShopInfo();
            List<OrderShopProductInfo> orderShopProductInfos = new List<OrderShopProductInfo>();
            orderShopProductInfos.Add( new OrderShopProductInfo()
            {PID="1",
            Name= "赛博朋克2077北通蝙蝠4有线pc电脑ps3电视双人steam游戏手柄usb摇杆NBA2k21飞",
            Img= "b-de-pro1.jpg",
            Price=55.5f,
            Num=1,
            Type= "颜色分类：D2E深夜版."
            });
            orderShopProductInfos.Add(new OrderShopProductInfo()
            {
                PID = "2",
                Name = "立顿燕麦片低糖低脂冲泡代餐奶植物早餐冲饮1瓶装",
                Img = "b-de-pro2.jpg",
                Price = 39f,
                Num = 1,
                Type = "白桃乌龙燕麦奶"
            });
            orderListItem.OrderShopProductInfos = orderShopProductInfos;
            orderProList.Add(orderListItem);
            
            OrderListItem orderListItem1 = new OrderListItem();
            orderListItem1.ShopInfo = new ShopInfo()
            {
                Name = "北通旗舰店",
                ShopIcon = "gold.png",
                Promos = new ProductImgs[] {
            new ProductImgs(){ SImgID="i1.png",Remarks="15天退货"},
            new ProductImgs(){ SImgID="i2.png",Remarks="1次破损补寄"},
            new ProductImgs(){ SImgID="i3.png",Remarks="破损包退"},
            new ProductImgs(){ SImgID="i4.png",Remarks="订单险"},
            new ProductImgs(){ SImgID="i5.png",Remarks="运费险"}
            },
                PayWays = new ProductImgs[] {
            new ProductImgs(){ SImgID="i6.png",Remarks="信用卡支付"},
            new ProductImgs(){ SImgID="i7.png",Remarks="集分宝"} }
            };
            List<OrderShopProductInfo> orderShopProductInfos1 = new List<OrderShopProductInfo>();
            orderShopProductInfos1.Add(new OrderShopProductInfo()
            {
                PID = "3",
                Name = "xxxxxxxxxxxxxxxxxxxxxxxxxxYYYYYYYYYYYYYYYYYYY",
                Img = "b-de-pro1.jpg",
                Price = 55.5f,
                Num = 1,
                Type = "颜色分类：D2E深夜版."
            });
            orderListItem1.OrderShopProductInfos = orderShopProductInfos1;
            orderProList.Add(orderListItem1);
            return orderProList;
        }
    }
    public class UserInfo
    {
        public string Name { set; get; }
        public int WaitPay { set; get; }
        public int WaitConfirm { set; get; }
        public int WaitSend { set; get; }
        public int WaitRate { set; get; }
        public int buyerDisputeList { set; get; }
    }
    public class ShopInfo
    {
        public string Name { set; get; }
        public string ShopIcon { set; get; }
        public ProductImgs[] Promos { set; get; }
        public ProductImgs[] PayWays { set; get; }
    }
    public class OrderListItem
    {
        public ShopInfo ShopInfo { set; get; }
        public List<OrderShopProductInfo> OrderShopProductInfos { set; get; }
             
    }
    public class OrderShopProductInfo
    {
        public string PID { set; get; }
        public string Name { set; get; }
        public string Img { set; get; }
        public float Price { set; get; }
        public int Num { set; get; }
        public string Type { set; get; }
    }
    public class ShopProductInfo
    {
        public string PID { set; get; }
        public string Name { set; get; }
        public string Img { set; get; }
        public string Price { set; get; }
        public string OldOPrice { set; get; }
        public int StockNum { set; get; }
        public ProductImgs[] Types { set; get; }

        public ProductImgs[] ProImgs { set; get; }

        public DataTable ProImgData;

    }
    public class ProductImgs
    {
        public string SImgID { set; get; }
        public string Remarks { set; get; }
        public string Remarks1 { set; get; }
    }

}
