using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;

namespace SwebuiDemo
{
    partial class shopMY : Swebui.Controls.SwebForm
    {
        public string nextpage;
        private string username;
        private string psd;
        public shopMY() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public shopMY(string name,string psd):base(){
            InitializeComponent();
            this.username = name;
            this.psd = psd;
            }
        private void shopMY_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username) == false)
            {
                userBtn.Text = username;
                nameLab.Text = username;
                UserInfo userInfo = DataProvider.GetUserInfo(username);
                waitConfirmLab.Text = userInfo.WaitConfirm.ToString();
                waitPayLab.Text = userInfo.WaitPay.ToString();
                waitRateLab.Text = userInfo.WaitRate.ToString();
                waitSendLab.Text = userInfo.WaitSend.ToString();
                buyerDisputeListLab.Text = userInfo.buyerDisputeList.ToString();
            }


            // 添加全部功能 
            navPanel.Controls.Add(new navLayout( "我的购物车",null ));
            navPanel.Controls.Add(new navLayout("已买到的宝贝", new string[] { "我的拍卖", "机票酒店保险", "我的彩票", "官方集运" }));
            navPanel.Controls.Add(new  navLayout("购买过的店铺" ,null));
            navPanel.Controls.Add(new navLayout( "我的发票", new string[] {"开票信息","发票管理"}) );
            navPanel.Controls.Add(new navLayout("我的收藏", null));
            navPanel.Controls.Add(new navLayout("我的积分",null));
            navPanel.Controls.Add(new navLayout("我的优惠信息",null));
            navPanel.Controls.Add(new navLayout("评价管理",null));
            navPanel.Controls.Add(new navLayout( "退款维权",  new string[] { "退款管理", "投诉管理", "举报管理 " } ));
            navPanel.Controls.Add(new navLayout("我的足迹", null));
            navPanel.Controls.Add(new navLayout("流量钱包", null));

            //我的物流
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("proimg");
            dataTable.Columns.Add("wl");
            dataTable.Columns.Add("date");
            dataTable.Columns.Add("isShow");
            for (int i =1; i <6; i++)
            {
                dataTable.Rows.Add("pro" + i.ToString() + ".jpg", "浙江嘉兴xxxxxxxxxx(12345678944)-派件中",DateTime.Now.ToString(),true);
            }
            myWlLayout myWlLayout = new myWlLayout();
            wlList.TemplateControl = myWlLayout;
            wlList.DataSource = dataTable;
            wlList.DataBind();
            

            //我的日历
            string[] weeks = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
          
            dayLab.Text = DateTime.Now.Day.ToString();
            weekLab.Text = weeks[Convert.ToInt16(DateTime.Now.DayOfWeek)];
            yearLab.Text = DateTime.Now.Date.ToString("yyyy,MM");

            //根据浏览，猜我喜欢
            DataTable dt = new DataTable();
            dt.Columns.Add("proimg");
            dt.Columns.Add("price");
            dt.Columns.Add("oldprice");
            dt.Columns.Add("prodes");
            dt.Columns.Add("sales");
            dt.Columns.Add("proimg1");
            dt.Columns.Add("price1");
            dt.Columns.Add("oldprice1");
            dt.Columns.Add("prodes1");
            dt.Columns.Add("sales1");
            dt.Columns.Add("proimg2");
            dt.Columns.Add("price2");
            dt.Columns.Add("oldprice2");
            dt.Columns.Add("prodes2");
            dt.Columns.Add("sales2");
            for(int i=1;i<6;i++)
            {
                dt.Rows.Add("pro"+i.ToString()+".jpg","￥55","￥75.2", "满额包邮/多肉故事馆《瑞典魔男》花期中开花型多肉阳台庭院植物", "月销:55", "pro" + i.ToString() + ".jpg", "￥55", "￥75.2", "满额包邮/多肉故事馆《瑞典魔男》花期中开花型多肉阳台庭院植物","月销:55", "pro" + i.ToString() + ".jpg", "￥55", "￥75.2", "满额包邮/多肉故事馆《瑞典魔男》花期中开花型多肉阳台庭院植物", "月销:55");
            }
            favList.TemplateControl = new myProLayout();
            favList.DataSource = dt;
            favList.DataBind();

        }


        private void NavButton_Click(object sender, EventArgs e)
        {


        }
        private void button9_Click(object sender, EventArgs e)
        {
            nextpage = "首页";
            this.Close();

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel37_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            ((FontIcon)((Panel)sender).Controls[0]).ForeColor = Color.FromArgb(255, 68, 0);
            ((Label)((Panel)sender).Controls[1]).ForeColor = Color.FromArgb(255, 68, 0);
        }

        private void panel37_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            ((FontIcon)((Panel)sender).Controls[0]).ForeColor = Color.FromArgb(174, 161, 159);
            ((Label)((Panel)sender).Controls[1]).ForeColor = Color.Black;
        }


        //favList ，点击替换数据源重新绑定
        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void wlMoreBtn_Click(object sender, EventArgs e)
        {
            if (wlMoreBtn.Text == "展开更多信息")
            {
                wlPanel.Height = wlPanel.Height + 98 * 2;
                wlMoreBtn.Text = "收起";
            }
            else {
                wlMoreBtn.Text ="展开更多信息";
                wlPanel.Height = wlPanel.Height - 98 * 2;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nextpage = "购物车";
            this.Close();

        }
    }

  
}