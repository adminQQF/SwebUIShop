using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    partial class shopDetail : SwebForm
    {
        private ShopInfo _shopInfo;
        private ShopProductInfo _shopProductInfo;
        private string username;
        public string nextpage;

        public shopDetail(string usernamer, string pid)
        {
            InitializeComponent();
            //根据pid查找相应 数据
            _shopInfo = DataProvider.GetShopInfo();
            _shopProductInfo = DataProvider.GetShopProductInfo("");
        }
        private void shopDetail_Load(object sender, EventArgs e)
        {
            if (_shopInfo != null) 
                shopLab1.Text = shopLab.Text = _shopInfo.Name;
            if (string.IsNullOrEmpty(username) == false)
            {
                userBtn.Text = username;
            }

            //添加产品图以及颜色分类
            for (int i = 0; i < _shopProductInfo.ProImgs.Length; i++)
            {
                imgButton imgButton = new imgButton(_shopProductInfo.ProImgs[i].SImgID)
                {
                    Size = new Size(50, 50),
                    Margin = new Margin(0, 0, 5, 0),
                    Index = i
                };
                imgButton.ImagePress += imgButton_Press;
                subImagePanel.Controls.Add(imgButton);
                imgButton imgButton1 = new imgButton(_shopProductInfo.Types[i].SImgID)
                {
                    Size = new Size(36, 36),
                    Margin = new Margin(0, 0, 5, 0),
                    UnSelectBorderColor = Color.FromArgb(232, 232, 232),
                    Index = i
                };
                imgButton1.ImagePress += imgButton_Press;
                optionsPanel.Controls.Add(imgButton1);
            }

            pageView1.TemplateControl = new detailImgLayout();
            pageView1.DataSource = _shopProductInfo.ProImgData;
            pageView1.DataBind();


            // 添加 宝贝分类
            catePanel.Controls.Add(new cateLayout("查看所有宝贝", new string[] { " 按销量", " 按新品", " 按价格", " 按收藏 " }));
            catePanel.Controls.Add(new cateLayout("新品", null));
            catePanel.Controls.Add(new cateLayout("多层盘架", null));
            catePanel.Controls.Add(new cateLayout("点心托盘", null));
            catePanel.Controls.Add(new cateLayout("餐盘烤盘", null));
            catePanel.Controls.Add(new cateLayout("杯具套装", null));
            catePanel.Controls.Add(new cateLayout("杯 壶 杯架", null));
            catePanel.Controls.Add(new cateLayout("碗 碟", null));
            catePanel.Controls.Add(new cateLayout("夹铲刀叉勺筷", null));
            catePanel.Controls.Add(new cateLayout("餐垫桌垫", null));
            catePanel.Controls.Add(new cateLayout("首饰摆件收纳", null));
            catePanel.Controls.Add(new cateLayout("惊爆特价", null));

            // 添加 宝贝排行榜
            DataTable dt = new DataTable();
            dt.Columns.Add("proImg");
            dt.Columns.Add("namelab");
            dt.Columns.Add("pricelab");
            dt.Columns.Add("lab");
            dt.Columns.Add("num");
            for (int i = 0; i < 3; i++)
            {
                dt.Rows.Add("bp1.jpg", "北欧金边甜品碗银耳燕窝碗玻璃花边碗家用糖水碗沙拉碗点心碗碟子", "￥20.25", "已售出", "1205");
                dt.Rows.Add("bp2.jpg", "日式金边玻璃碗高档燕窝碗糖水碗盅水果沙拉碗甜品碗家用碗套装", "￥17.00", "已售出", "371");
            }
            salewlist.TemplateControl = new proLayout3();
            salewlist.DataSource = dt;
            salewlist.DataBind();

            dt.Rows.Clear();
            for (int i = 0; i < 3; i++)
            {
                dt.Rows.Add("bp1.jpg", "北欧金边甜品碗银耳燕窝碗玻璃花边碗家用糖水碗沙拉碗点心碗碟子", "￥20.25", "已收藏", "1205");
                dt.Rows.Add("bp2.jpg", "日式金边玻璃碗高档燕窝碗糖水碗盅水果沙拉碗甜品碗家用碗套装", "￥17.00", "已收藏", "371");

            }
            collectlist.TemplateControl = new proLayout3();
            collectlist.DataSource = dt;
            collectlist.DataBind();

            //添加宝贝推荐
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("proimg");
            dt1.Columns.Add("name");
            dt1.Columns.Add("price");
            for (int i = 0; i < 4; i++)
                dt1.Rows.Add("b-de-pro1", "欧式多层甜品台蛋糕架浮雕三层架蛋糕盘点心水果托盘下午茶蛋糕架", "6.80");
            recommendList.TemplateControl = new proLayout4();
            recommendList.DataSource = dt1;
            recommendList.DataBind();
            #region" Tab"
            //tab
            tabLayout1 tab1 = new tabLayout1(new string[] { "材质: 金属", "风格: 欧式", "颜色分类：金色三层架 金色两层架 银色三层架 银色两层架 樱花粉色圆盘 樱花白色圆盘 白色蕾丝圆盘 白色花边圆盘 叶纹平盘", "主图来源: 自主实拍图" }, new string[] { "detail1.jpg", "detail2.jpg", "detail3.jpg", "detail4.jpg", "detail5.jpg" });
            tab1.Flex = 1;
            TabPageControl tagControl = new TabPageControl();
            tagControl.Padding = new Padding(0, 10, 0, 0);
            tagControl.ItemAlign = LayoutItemAlign.Center;
            tagControl.Controls.Add(tab1);

            TabPageControl tagControl1 = new TabPageControl();
            tagControl1.Padding = new Padding(0, 10, 0, 0);
            tagControl1.ItemAlign = LayoutItemAlign.Center;
            tagControl1.Controls.Add(new tabLayout2());

            TabPageControl tagControl2 = new TabPageControl();
            tagControl2.Padding = new Padding(0, 10, 0, 0);
            tagControl2.ItemAlign = LayoutItemAlign.Center;
            tagControl2.Controls.Add(new tabLayout3());

            tabPageView1.Controls.Add(tagControl);
            tabPageView1.Controls.Add(tagControl1);
            tabPageView1.Controls.Add(tagControl2);
            tabPageView1.PageIndex = 0;
            #endregion

            #region"htmlview"
            //htmliew

            htmlView1.HTML = @"<div style='width: 750px; margin-top: 15px;font-size:12px;line-height:1.5;display:contents'> 
     <h3 style = 'font-size: 16px;font-weight: 600; border-bottom: 1px solid #eee; margin-bottom: 15px;'>价格说明</h3> 
 <p style= 'color: #fe702f;' > 划线价格 </p > <p style= ' color: #666;margin-bottom: 15px;' >指商品的专柜价、吊牌价、正品零售价、厂商指导价或该商品的曾经展示过的销售价等，<strong style = 'color: #333;
font-weight: 600; '>并非原价</strong>，仅供参考。</p>   <p  style = 'color: #fe702f;' > 未划线价格 </p >    <p  style = 'color: #666;margin-bottom: 15px;' >指商品的<strong style = 'color: #333; font-weight: 600;' > 实时标价 </strong >，不因表述的差异改变性质。具体成交价格根据商品参加活动，或会员使用优惠券、积分等发生变化，最终以订单结算页价格为准。</p >
                  <p  style = 'color: #666;margin-bottom: 15px;' >商家详情页（含主图）以图片或文字形式标注的一口价、促销价、优惠价等价格可能是在使用优惠券、满减或特定优惠活动和时段等情形下的价格，具体请以结算页面的标价、优惠条件或活动规则为准。</p >
                   <p style = 'color: #666;margin-bottom: 15px;' >此说明仅当出现价格比较时有效，具体请参见《淘宝价格发布规范》。若商家单独对划线价格进行说明的，以商家的表述为准。</p>
                    </div > 
<div style='display:block'>
<div style='width: 728px;clear: both;font-size:12px;   padding: 10px;    background: #FFFBF1; border: 1px solid #FFC7B2;'>
<div style=' margin-bottom: 10px;padiving-bottom: 10px;display:flex '>
 <div style=' display: inline-block; width: 68px; font-weight: 700;height:103px'><p>安全提示：</p></div>
 <div style=' display:inline-block;width:560px;margin-inline-start: 40px;line-height:normal !important '><p>交易中请勿使用<em style='color: #f40;font-style: normal;'>阿里旺旺</em>以外的聊天工具沟通，不要接收<em  style='color: #f40; font-style: normal;'>可疑文件</em>和不要点击<em  style='color: #f40; font-style: normal;'>不明来源</em>的链接，支付前核实好域名和支付详情。
 淘宝不会以订单有问题，让您提供任何<em  style='color: #f40;'>银行卡</em>、<em  style='color: #f40;'>密码</em>、<em  style='color: #f40;'>手机验证码</em>！遇到可疑情况可在钱盾“诈骗举报”中进行举报, <a href='https://img.alicdn.com/tps/i1/TB1XL5ZGFXXXXbDXFXXAz6UFXXX-16-16.png' target='_top'>安全推荐</a></p>
 </div></div> <div style='display:flex'>  <div style=' display: inline-block; width: 68px; font-weight: 700; height:80px;'><p>内容申明：</p></div>
 <div style=' display: inline-block ;width:560px;margin-inline-start: 40px;'><p>淘宝为第三方交易平台及互联网信息服务提供者，淘宝（含网站、客户端等）所展示的商品/服务的标题、价格、详情等信息内容系由店铺经营者发布，其真实性、准确性和合法性均由店铺经营者负责。淘宝提醒用户购买商品/服务前注意谨慎核实。如用户对商品/服务的标题、价格、详情等任何信息有任何疑问的，请在购买前通过阿里旺旺与店铺经营者沟通确认；淘宝存在海量店铺，如用户发现店铺内有任何违法/侵权信息，请立即向淘宝举报并提供有效线索。</p></div>
   </div> </div></div>
</body>";
            #endregion
        }
        /// <summary>
        /// 产品图以及颜色分类选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgButton_Press(object sender, EventArgs e)
        {
            pageView1.PageIndex = ((imgButton)sender).Index;

            foreach (imgButton imgbtn in ((imgButton)sender).Parent.Controls)
            {
                if (imgbtn != ((imgButton)sender))
                {
                    imgbtn.SetBorderColor(Color.White);
                }
            }
        }
        private void button10_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BorderColor = Color.FromArgb(255, 68, 0);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BorderColor = Color.White;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(numText.Text) - 1) < 0)
                numText.Text = "0";
            else
                numText.Text = (Convert.ToInt32(numText.Text) - 1).ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            numText.Text = (Convert.ToInt32(numText.Text) + 1).ToString();
        }

        //销售量排行
        private void saleBtn_MouseEnter(object sender, EventArgs e)
        {
            collectBtn.BackColor = Color.Transparent;
            collectlist.Visible = false;
            salewlist.Visible = true;
        }

        private void collectBtn_MouseEnter(object sender, EventArgs e)
        {
            saleBtn.BackColor = Color.Transparent;
            salewlist.Visible = false;
            collectlist.Visible = true;
        }

        private void tabBtn1_Click(object sender, EventArgs e)
        {
            string text = ((Button)sender).Name;
            switch (text)
            {
                case "tabBtn1":
                    tabBtn1.BackColor = Color.White;
                    tabBtn1.ForeColor = Color.FromArgb(255, 68, 0);
                    tabBtn2.BackColor = tabBtn3.BackColor = Color.Transparent;
                    tabBtn2.ForeColor = tabBtn3.ForeColor = Color.Black;
                    tabPageView1.PageIndex = 0;
                    break;

                case "tabBtn2":
                    tabBtn2.BackColor = Color.White;
                    tabBtn2.ForeColor = Color.FromArgb(255, 68, 0);
                    tabBtn1.BackColor = tabBtn3.BackColor = Color.Transparent;
                    tabBtn1.ForeColor = tabBtn3.ForeColor = Color.Black;
                    tabPageView1.PageIndex = 1;
                    break;

                case "tabBtn3":
                    tabBtn3.BackColor = Color.White;
                    tabBtn3.ForeColor = Color.FromArgb(255, 68, 0);
                    tabBtn2.BackColor = tabBtn1.BackColor = Color.Transparent;
                    tabBtn2.ForeColor = tabBtn1.ForeColor = Color.Black;
                    tabPageView1.PageIndex = 2;
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nextpage = "首页";
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nextpage = "我的";
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nextpage = "购物车";
            this.Close();
        }
    }



}