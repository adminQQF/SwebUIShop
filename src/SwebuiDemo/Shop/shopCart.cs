using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;
using SwebuiDemo.Demo;

namespace SwebuiDemo
{
    partial class shopCart : Swebui.Controls.SwebForm
    {
        public shopCart() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public shopCart(string username, string psd) : base()
        {
            InitializeComponent();
            this.username = username;
            this.psd = psd;
        }
        private string username;
        private string psd;
        public string nextpage;

        private void SwebForm1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username) == false)
            {
                userBtn.Text = username;
            }
            TabPageControl tabPage = new TabPageControl() { Flex = 1 };
            shopCartTabLayout shopCartTabLayout = new shopCartTabLayout();
            tabPage.Controls.Add(shopCartTabLayout);
            tabPage.ItemAlign = LayoutItemAlign.Center;
            tabPageView1.Controls.Add(tabPage);
            tabPageView1.Height = shopCartTabLayout.Height + 10;
            this.Height = 360 + tabPageView1.Height;



            DataTable dt3 = new DataTable();
            dt3.Columns.Add("proImg");
            dt3.Columns.Add("des");
            dt3.Columns.Add("price");
            dt3.Columns.Add("num");
            dt3.Columns.Add("proImg1");
            dt3.Columns.Add("des1");
            dt3.Columns.Add("price1");
            dt3.Columns.Add("num1");
            dt3.Columns.Add("proImg2");
            dt3.Columns.Add("des2");
            dt3.Columns.Add("price2");
            dt3.Columns.Add("num2");
            dt3.Columns.Add("proImg3");
            dt3.Columns.Add("des3");
            dt3.Columns.Add("price3");
            dt3.Columns.Add("num3");
            dt3.Columns.Add("proImg4");
            dt3.Columns.Add("des4");
            dt3.Columns.Add("price4");
            dt3.Columns.Add("num4");

            dt3.Rows.Add("list1.jpg", "硅胶餐垫小学生午餐垫防水防油防烫餐桌垫宝宝儿童隔热垫课桌垫", "19.8", "77人购买",
            "list2.jpg", "美式乡村钩针镂空窗帘客厅卧室阳台露台别墅文艺定制窗纱唯美小众", "39.8", "737+人购买",
            "list3.jpg", "大号厨房塑料碗盘架沥水架放晾碗架盘架滴水碗筷收纳沥水篮沥碗架", "39.8", "77人购买",
            "list4.jpg", "美式沙发毯子沙发巾盖毯北欧地中海客厅纯色棉针织流苏沙发线毯", "139.8", "737人购买",
            "list5.jpg", "Lototo日式餐具ins风陶瓷碗创意个性饭碗大碗汤碗拉面碗家用吃饭", "139.8", "44人购买");

            listView1.DataSource = dt3;
            listView1.TemplateControl = new proLayout2();
            listView1.DataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {   //根据按钮名称切换listview数据元
            string text = ((Button)sender).Name;
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

        }
        public void SetSelectAmount(string text)
        {
            AmoutLab.Text = text;
        }

    }
}