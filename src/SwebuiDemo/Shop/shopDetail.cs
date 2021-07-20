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
            //����pid������Ӧ ����
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

            //��Ӳ�Ʒͼ�Լ���ɫ����
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


            // ��� ��������
            catePanel.Controls.Add(new cateLayout("�鿴���б���", new string[] { " ������", " ����Ʒ", " ���۸�", " ���ղ� " }));
            catePanel.Controls.Add(new cateLayout("��Ʒ", null));
            catePanel.Controls.Add(new cateLayout("����̼�", null));
            catePanel.Controls.Add(new cateLayout("��������", null));
            catePanel.Controls.Add(new cateLayout("���̿���", null));
            catePanel.Controls.Add(new cateLayout("������װ", null));
            catePanel.Controls.Add(new cateLayout("�� �� ����", null));
            catePanel.Controls.Add(new cateLayout("�� ��", null));
            catePanel.Controls.Add(new cateLayout("�в������׿�", null));
            catePanel.Controls.Add(new cateLayout("�͵�����", null));
            catePanel.Controls.Add(new cateLayout("���ΰڼ�����", null));
            catePanel.Controls.Add(new cateLayout("�����ؼ�", null));

            // ��� �������а�
            DataTable dt = new DataTable();
            dt.Columns.Add("proImg");
            dt.Columns.Add("namelab");
            dt.Columns.Add("pricelab");
            dt.Columns.Add("lab");
            dt.Columns.Add("num");
            for (int i = 0; i < 3; i++)
            {
                dt.Rows.Add("bp1.jpg", "��ŷ�����Ʒ�����������벣�������������ˮ��ɳ������������", "��20.25", "���۳�", "1205");
                dt.Rows.Add("bp2.jpg", "��ʽ��߲�����ߵ���������ˮ����ˮ��ɳ������Ʒ���������װ", "��17.00", "���۳�", "371");
            }
            salewlist.TemplateControl = new proLayout3();
            salewlist.DataSource = dt;
            salewlist.DataBind();

            dt.Rows.Clear();
            for (int i = 0; i < 3; i++)
            {
                dt.Rows.Add("bp1.jpg", "��ŷ�����Ʒ�����������벣�������������ˮ��ɳ������������", "��20.25", "���ղ�", "1205");
                dt.Rows.Add("bp2.jpg", "��ʽ��߲�����ߵ���������ˮ����ˮ��ɳ������Ʒ���������װ", "��17.00", "���ղ�", "371");

            }
            collectlist.TemplateControl = new proLayout3();
            collectlist.DataSource = dt;
            collectlist.DataBind();

            //��ӱ����Ƽ�
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("proimg");
            dt1.Columns.Add("name");
            dt1.Columns.Add("price");
            for (int i = 0; i < 4; i++)
                dt1.Rows.Add("b-de-pro1", "ŷʽ�����Ʒ̨����ܸ�������ܵ����̵���ˮ����������走���", "6.80");
            recommendList.TemplateControl = new proLayout4();
            recommendList.DataSource = dt1;
            recommendList.DataBind();
            #region" Tab"
            //tab
            tabLayout1 tab1 = new tabLayout1(new string[] { "����: ����", "���: ŷʽ", "��ɫ���ࣺ��ɫ����� ��ɫ����� ��ɫ����� ��ɫ����� ӣ����ɫԲ�� ӣ����ɫԲ�� ��ɫ��˿Բ�� ��ɫ����Բ�� Ҷ��ƽ��", "��ͼ��Դ: ����ʵ��ͼ" }, new string[] { "detail1.jpg", "detail2.jpg", "detail3.jpg", "detail4.jpg", "detail5.jpg" });
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
     <h3 style = 'font-size: 16px;font-weight: 600; border-bottom: 1px solid #eee; margin-bottom: 15px;'>�۸�˵��</h3> 
 <p style= 'color: #fe702f;' > ���߼۸� </p > <p style= ' color: #666;margin-bottom: 15px;' >ָ��Ʒ��ר��ۡ����Ƽۡ���Ʒ���ۼۡ�����ָ���ۻ����Ʒ������չʾ�������ۼ۵ȣ�<strong style = 'color: #333;
font-weight: 600; '>����ԭ��</strong>�������ο���</p>   <p  style = 'color: #fe702f;' > δ���߼۸� </p >    <p  style = 'color: #666;margin-bottom: 15px;' >ָ��Ʒ��<strong style = 'color: #333; font-weight: 600;' > ʵʱ��� </strong >����������Ĳ���ı����ʡ�����ɽ��۸������Ʒ�μӻ�����Աʹ���Ż�ȯ�����ֵȷ����仯�������Զ�������ҳ�۸�Ϊ׼��</p >
                  <p  style = 'color: #666;margin-bottom: 15px;' >�̼�����ҳ������ͼ����ͼƬ��������ʽ��ע��һ�ڼۡ������ۡ��Żݼ۵ȼ۸��������ʹ���Ż�ȯ���������ض��Żݻ��ʱ�ε������µļ۸񣬾������Խ���ҳ��ı�ۡ��Ż�����������Ϊ׼��</p >
                   <p style = 'color: #666;margin-bottom: 15px;' >��˵���������ּ۸�Ƚ�ʱ��Ч��������μ����Ա��۸񷢲��淶�������̼ҵ����Ի��߼۸����˵���ģ����̼ҵı���Ϊ׼��</p>
                    </div > 
<div style='display:block'>
<div style='width: 728px;clear: both;font-size:12px;   padding: 10px;    background: #FFFBF1; border: 1px solid #FFC7B2;'>
<div style=' margin-bottom: 10px;padiving-bottom: 10px;display:flex '>
 <div style=' display: inline-block; width: 68px; font-weight: 700;height:103px'><p>��ȫ��ʾ��</p></div>
 <div style=' display:inline-block;width:560px;margin-inline-start: 40px;line-height:normal !important '><p>����������ʹ��<em style='color: #f40;font-style: normal;'>��������</em>��������칤�߹�ͨ����Ҫ����<em  style='color: #f40; font-style: normal;'>�����ļ�</em>�Ͳ�Ҫ���<em  style='color: #f40; font-style: normal;'>������Դ</em>�����ӣ�֧��ǰ��ʵ��������֧�����顣
 �Ա������Զ��������⣬�����ṩ�κ�<em  style='color: #f40;'>���п�</em>��<em  style='color: #f40;'>����</em>��<em  style='color: #f40;'>�ֻ���֤��</em>�����������������Ǯ�ܡ�թƭ�ٱ����н��оٱ�, <a href='https://img.alicdn.com/tps/i1/TB1XL5ZGFXXXXbDXFXXAz6UFXXX-16-16.png' target='_top'>��ȫ�Ƽ�</a></p>
 </div></div> <div style='display:flex'>  <div style=' display: inline-block; width: 68px; font-weight: 700; height:80px;'><p>����������</p></div>
 <div style=' display: inline-block ;width:560px;margin-inline-start: 40px;'><p>�Ա�Ϊ����������ƽ̨����������Ϣ�����ṩ�ߣ��Ա�������վ���ͻ��˵ȣ���չʾ����Ʒ/����ı��⡢�۸��������Ϣ����ϵ�ɵ��̾�Ӫ�߷���������ʵ�ԡ�׼ȷ�ԺͺϷ��Ծ��ɵ��̾�Ӫ�߸����Ա������û�������Ʒ/����ǰע�������ʵ�����û�����Ʒ/����ı��⡢�۸�������κ���Ϣ���κ����ʵģ����ڹ���ǰͨ��������������̾�Ӫ�߹�ͨȷ�ϣ��Ա����ں������̣����û����ֵ��������κ�Υ��/��Ȩ��Ϣ�����������Ա��ٱ����ṩ��Ч������</p></div>
   </div> </div></div>
</body>";
            #endregion
        }
        /// <summary>
        /// ��Ʒͼ�Լ���ɫ����ѡ��ť
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

        //����������
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
            nextpage = "��ҳ";
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nextpage = "�ҵ�";
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nextpage = "���ﳵ";
            this.Close();
        }
    }



}