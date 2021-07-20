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
    partial class shopIndex : SwebForm
    {
        private string username;
        private string psd;
        private bool isLogin = false;
        public shopIndex() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void shopIndex_Load(object sender, EventArgs e)
        {
            //searchingbox

            string[] hotwords = new string[] { " �¿�����ȹ", " �ļ��� ", "����T�� ", "ʱ��ŮЬ ", "�̿�", " ����ȹ ", "��ʿ���� ", "ǽֽ", " �г���¼��", " �¿���Ь ", "���� ", "ʱ��Ů�� ", "ɳ��" };
            for (int i = 0; i < hotwords.Length; i++)
                hotPabel.Controls.Add(new Button()
                {
                    Text = hotwords[i],
                    FontSize = 12,
                    Margin = new Margin(0, 0, 5, 0),
                    Size = new System.Drawing.Size(0, 0),
                    ForeColor = System.Drawing.Color.Black,
                    BackColor = System.Drawing.Color.Transparent
                });
            #region"��ർ����"
            string[] nodesText = DataProvider.GetNavigationItemText();
            for (int i = 0; i < nodesText.Length; i++)
            {
                Button button = new Button()
                {
                    Text = nodesText[i],
                    BackColor = System.Drawing.Color.White,
                    ForeColor = System.Drawing.Color.FromArgb(120, 120, 120),
                    FontSize = 14,
                    Size = new System.Drawing.Size(200, 34),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    RaiseMouseEvent = true,
                    Padding = new Padding(10, 0, 10, 0),
                    Tag = i
                };
                button.MouseLeave += navButton_MouseOut;
                button.MouseEnter += navButton_MouseOver;
                leftPanel.Controls.Add(button);
            }
            #endregion

            #region"��� ��¼ ע�� ���갴ť  "
            if (isLogin == false)
            {
                Button loginBtn = new Button()
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                    BorderRadius = 7,
                    FontSize = 14F,
                    Margin = new Swebui.Controls.Margin(12F, 0F, 5F, 0F),
                    Name = "button16",
                    NumberOfLines = 0,
                    SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None,
                    Size = new System.Drawing.Size(92, 25),
                    Text = "��¼"
                };
                loginBtn.Click += loginBtn_Press;
                Button regBtn = new Button()
                {

                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                    BorderRadius = 7,
                    FontSize = 14F,
                    Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F),
                    Name = "button18",
                    NumberOfLines = 0,
                    SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None,
                    Size = new System.Drawing.Size(75, 25),
                    Text = "ע��"
                };
                regBtn.Click += regBtn_Press;
                Button kdBtn = new Button()
                {
                    BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                    BorderRadius = 7,
                    FontSize = 14F,
                    Margin = new Swebui.Controls.Margin(5F, 0F, 5F, 0F),
                    Name = "button17",
                    NumberOfLines = 0,
                    SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None,
                    Size = new System.Drawing.Size(75, 25),
                    Text = "����"
                };
                kdBtn.Click += kdBtn_Press;
                LoginPanel.Controls.Add(loginBtn);
                LoginPanel.Controls.Add(regBtn);
                LoginPanel.Controls.Add(kdBtn);
            }

            #endregion

            #region"pageview"
            // 
            pageView1.TemplateControl = new imgLayout();
            DataTable dt = new DataTable();
            dt.Columns.Add("img");
            dt.Rows.Add("p1.jpg");
            dt.Rows.Add("p2.jpg");
            dt.Rows.Add("p3.png");
            dt.Rows.Add("p4.jpg");
            dt.Rows.Add("p5.jpg");
            pageView1.DataSource = dt;
            pageView1.DataBind();

            pageView2.TemplateControl = new imgLayout2();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("img");
            dt2.Columns.Add("img2");
            dt2.Rows.Add("p6.jpg", "p7.jpg");
            dt2.Rows.Add("p8.jpg", "p9.jpg");
            dt2.Rows.Add("p10.jpg", "p11.jpg");
            pageView2.DataSource = dt2;
            pageView2.DataBind();

            #endregion
            #region"�кû�"
            //
            string[] titles = new string[] { "Pure Cashmere ��ů��֯ñ", "��̥��ͥ���������ִ�", "  �ܴ� �ŷ��ƽ�70��ʵ������", "�ܴ� ��Լ�߹���", "��Ȼ��Ϫ�غ������׹" };
            string[] imgs = new string[] { "pro1.jpg", "pro2.jpg", "pro3.jpg", "pro4.jpg", "pro5.jpg" };
            string[] descriptionn = new string[] { "�����֯ñ������пɰ���ñ��˫��װ����ƣ��ǳ��в�θУ�����Ҳ����������Լ�����ͣ�����Ĵ��������ϣ��������ֱ�ů��", "�������ܺúܸߵ�����ϲ����۸ߵ������վ�տ����ζ����ֱ�����е��Σ����ء�", "�ܴ�Ʒ��ƾ����רҵ�����ʵ��鱦������ƣ�������ȫ���˵�һ�鱦Ʒ�Ƶ��������������ߵ�ϲ�����������������ʴ�����ɣ�������������ݻ����Ӿ����ܣ����Ͼ�ϸ���������գ�����չ��Ů�����Ŷ������ʣ�����������������������鶯���С�", "���������´������˽Կɼ�Ԧ��", "��Ȼ��Ϫ�غ����飬������󣬺ڵĺ�Ũ����18k�ƽ���Ƕ��ʯ��ͷ������ʮ�㡣" };
            for (int i = 0; i < 5; i++)
            {
                proPanel.Controls.Add(new proLayout(imgs[i], titles[i], descriptionn[i])
                {
                    Margin = new Margin(20, 0, 0, 0)
                });
            }
            #endregion
            #region"listview"
            //

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
            for (int i = 0; i < 10; i++)
            {
                dt3.Rows.Add("list1.jpg", "�轺�͵�Сѧ����͵��ˮ���ͷ��̲����汦����ͯ���ȵ������", "19.8", "77�˹���",
                "list2.jpg", "��ʽ��平���οմ�������������̨¶̨�������ն��ƴ�ɴΨ��С��", "39.8", "737+�˹���",
                "list3.jpg", "��ų����������̼���ˮ�ܷ�������̼ܵ�ˮ���������ˮ�������", "39.8", "77�˹���",
                "list4.jpg", "��ʽɳ��̺��ɳ�����̺��ŷ���к�������ɫ����֯����ɳ����̺", "139.8", "737�˹���",
                "list5.jpg", "Lototo��ʽ�;�ins���մ��봴����Է������������������óԷ�", "139.8", "44�˹���");
            }
            listView1.DataSource = dt3;
            listView1.TemplateControl = new proLayout2();
            listView1.DataBind();
            #endregion
        }

        #region "dialogpanel��leftpanel����"
        private void leftPanel_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            if (e.Position != SwebMouseMovePosition.Right)
            {
                dialogPanel.Visible = false;
            }
            else
            {
                dialogPanel.Visible = true;
            }
        }

        private void leftPanel_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            if (dialogPanel.Visible == false)
                dialogPanel.Visible = true;

        }

        private void dialogPanel_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            if (e.Position != SwebMouseMovePosition.Left)
            {
                dialogPanel.Visible = false;
                int selectIndex = Convert.ToInt32(dialogPanel.Tag);
                ((Button)leftPanel.Controls[selectIndex]).BackColor = System.Drawing.Color.White;
                ((Button)leftPanel.Controls[selectIndex]).ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);

            }
        }

        private void dialogPanel_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {

        }
        private void navButton_MouseOver(object sender, SwebMouseMoveEventArgs e)
        {
            if (dialogPanel.Visible == true)
            {
                int selectIndex = Convert.ToInt32(dialogPanel.Tag);
                if (leftPanel.Controls[selectIndex] != sender)
                {
                    ((Button)leftPanel.Controls[selectIndex]).BackColor = System.Drawing.Color.White;
                    ((Button)leftPanel.Controls[selectIndex]).ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                }
            }

            ((Button)sender).BackColor = System.Drawing.Color.FromArgb(255, 228, 220);
            ((Button)sender).ForeColor = System.Drawing.Color.FromArgb(249, 74, 20);


            diaLeft.Controls.Clear();
            diaRight.Controls.Clear();
            string text = ((Button)sender).Tag.ToString();
            dialogPanel.Tag = text;
            List<NavData> navDatas = DataProvider.GetNavDatas();
            switch (text)
            {
                case "0":
                    GetDialogContent(navDatas[0]);
                    break;
                case "1":
                    GetDialogContent(navDatas[1]);
                    break;
                default:
                    GetDialogContent(navDatas[2]);
                    break;
            }
        }

        private void navButton_MouseOut(object sender, SwebMouseMoveEventArgs e)
        {
            if (e.Position != SwebMouseMovePosition.Right)
            {
                ((Button)sender).BackColor = System.Drawing.Color.White;
                ((Button)sender).ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            }
        }

        private void GetDialogContent(NavData navData)
        {


            for (int j = 0; j < navData.Labels.Length; j++)
            {
                diaLeft.Controls.Add(new Label()
                {
                    Text = navData.Labels[j],
                    ForeColor = System.Drawing.Color.FromArgb(120, 120, 120),
                    FontSize = 16,
                    Size = new System.Drawing.Size(0, 0),
                    Bold = true,
                    Margin = new Margin(0, 10, 0, 10)

                }); ;
                Panel panel = new Panel() { Layout = LayoutPosition.Relative, Direction = LayoutDirection.Row, Wrap = LayoutWrap.Wrap, Size = new Size(427, 0) };
                for (int k = 0; k < navData.Buttons[j].Length; k++)
                {
                    string[] buttons = navData.Buttons[j];
                    panel.Controls.Add(new Button()
                    {
                        Text = buttons[k],
                        BackColor = System.Drawing.Color.White,
                        ForeColor = System.Drawing.Color.FromArgb(120, 120, 120),
                        FontSize = 12,
                        Margin = new Margin(0, 5, 5, 5),
                        Size = new System.Drawing.Size(0, 26),
                    });
                }
                diaLeft.Controls.Add(panel);
            }
            diaRight.Controls.Add(new Label()
            {
                Text = "����ϲ��",
                ForeColor = System.Drawing.Color.FromArgb(120, 120, 120),
                FontSize = 16,
                Size = new System.Drawing.Size(0, 20),
                Bold = true,
                Margin = new Margin(15, 10, 0, 0)
            });
            Panel _panel = new Panel() { Layout = LayoutPosition.Relative, Direction = LayoutDirection.Row, Wrap = LayoutWrap.Wrap, Width = 250, Height = 526 };
            for (int i = 0; i < navData.Imgs.Length; i++)
            {
                _panel.Controls.Add(new imgLabButton(navData.Imgs[i] + ".jpg", navData.Imgs[i])
                {
                    Margin = new Margin(15, 0, 0, 10)
                });
            }
            diaRight.Controls.Add(_panel);

        }
        #endregion

        private void pageView1_PageIndexChanged(object sender, EventArgs e)
        {
            page1Current.Text = pageView1.PageIndex.ToString();
        }

        private void noBtn1_MouseOver(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            switch (text)
            {
                case "����":
                    Button btn1 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "���ڼ�ǿ���ҹ��(������)�Ϲ������Ĺ���",
                        Bold = true
                    };
                    notice.Controls.Clear();
                    notice.Controls.Add(btn1);
                    noBtn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    noBtn2.BorderColor = noBtn3.BorderColor = noBtn4.BorderColor = noBtn5.BorderColor = System.Drawing.Color.White;
                    break;
                case "����":
                    Button btn2 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "�������Ա���������ҵ",
                        Bold = true
                    };

                    Button btn3 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "���Ա����������۷���",
                        Bold = true
                    };

                    notice.Controls.Clear();
                    notice.Controls.Add(btn2);
                    notice.Controls.Add(btn3);
                    noBtn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    noBtn1.BorderColor = noBtn3.BorderColor = noBtn4.BorderColor = noBtn5.BorderColor = System.Drawing.Color.White;
                    break;
                case "��ȫ":
                    Button btn4 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "ħ�����蹫����Ŀ     ��ĸ���������ȣ�",
                        Bold = true
                    };

                    notice.Controls.Clear();
                    notice.Controls.Add(btn4);
                    noBtn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    noBtn1.BorderColor = noBtn2.BorderColor = noBtn4.BorderColor = noBtn5.BorderColor = System.Drawing.Color.White;
                    break;
                case "����":
                    Button btn5 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "���﹫��\"��˹��\"",
                        Bold = true
                    };
                    Button btn6 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "���﹫����̳",
                        Bold = true
                    };

                    notice.Controls.Clear();
                    notice.Controls.Add(btn5);
                    notice.Controls.Add(btn6);
                    noBtn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    noBtn1.BorderColor = noBtn2.BorderColor = noBtn3.BorderColor = noBtn5.BorderColor = System.Drawing.Color.White;
                    break;
                case "ǧţ":
                    Button btn7 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "ǧţͷ��",
                        Bold = true
                    };

                    Button btn8 = new Button()
                    {
                        BackColor = System.Drawing.Color.White,
                        Flex = 1,
                        ForeColor = System.Drawing.Color.Black,
                        SelectBackgroundColor = System.Drawing.Color.White,
                        SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                        Size = new System.Drawing.Size(0, 24),
                        Text = "���ֿ���",
                        Bold = true
                    };

                    notice.Controls.Clear();
                    notice.Controls.Add(btn7);
                    notice.Controls.Add(btn8);
                    noBtn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    noBtn1.BorderColor = noBtn2.BorderColor = noBtn3.BorderColor = noBtn4.BorderColor = System.Drawing.Color.White;
                    break;
            }
        }

        #region "���кû�������panel ��� ��ͣ���뿪�¼�"
        private void panel30_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            ((Panel)sender).BorderColor = System.Drawing.Color.FromArgb(249, 74, 20);
        }

        private void panel30_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            ((Panel)sender).BorderColor = System.Drawing.Color.White;
        }

        #endregion

        #region"��¼�����¼�"
        /// <summary>
        /// �û�ͷ�����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void avatarPanel_Press(object sender, EventArgs e)
        {
            if (isLogin)
            {
                ShowPage("�ҵ�");
            }
        }
        /// <summary>
        /// ��¼��ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Press(object sender, EventArgs e)
        {
            loginLayout loginLayout = new loginLayout();
            ShowDialog(loginLayout, (obj, args) =>
            {
                if (loginLayout.ShowResult == ShowResult.Yes)
                {
                    username = loginLayout.GetUser();
                    psd = loginLayout.GetPsd();
                    isLogin = true;
                    ChangeLoginPanelContent();
                }
            });
        }
        /// <summary>
        /// ע�ᰴť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regBtn_Press(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ���갴ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kdBtn_Press(object sender, EventArgs e)
        {

        }

        private void ChangeLoginPanelContent()
        {
            UserInfo userInfo = DataProvider.GetUserInfo(username);

            userLab.Text = username;
            LoginPanel.Controls.Clear();
            string[] texts = new string[] { "���ջ�", "������", "������", "������" };
            string[] nums = new string[] { userInfo.WaitConfirm.ToString(), userInfo.WaitSend.ToString(), userInfo.WaitPay.ToString(), userInfo.WaitRate.ToString() };
            for (int i = 0; i < texts.Length; i++)
            {
                Panel panel = new Panel()
                {
                    Flex = 1,
                    Size = new Size(0, 0)
                };
                Label label = new Label()
                {
                    Text = nums[i],
                    FontSize = 14,
                    ForeColor = Color.FromArgb(255, 68, 0),
                    Size = new Size(0, 0),
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Bold = true
                };
                Button button = new Button()
                {
                    BackColor = Color.White,
                    SelectBackgroundColor = Color.White,
                    SelectColor = Color.FromArgb(255, 68, 0),
                    FontSize = 12,
                    Size = new Size(0, 0),
                    Text = texts[i],
                    ForeColor = Color.Black,
                    Margin = new Margin(0, 5, 0, 0)
                };
                button.Click += UserInfoBtn_Press;
                panel.Controls.Add(label);
                panel.Controls.Add(button);
                LoginPanel.Controls.Add(panel);
            }
        }
        private void UserInfoBtn_Press(object sender, EventArgs e)
        {
            Toast(((Button)sender).Text);
        }
        #endregion
        public void ShowPage( string pagename)
        {
            switch (pagename)
            {
                case"��ҳ":
                    break;
                case "���ﳵ":
                    shopCart shopCart = new shopCart();
                    Show(shopCart, (onj, args) =>
                     {
                         if (string.IsNullOrEmpty(shopCart.nextpage) == false)
                         {
                             ShowPage(shopCart.nextpage);
                         }
                     });
                    break;
                case "��Ʒ����":
                    shopDetail shopDetail = new shopDetail(username,"");
                    Show(shopDetail, (onj, args) =>
                    {
                        if (string.IsNullOrEmpty(shopDetail.nextpage) == false)
                        {
                            ShowPage(shopDetail.nextpage);
                        }
                    });
                    break;
                case "�ҵ�":
                    shopMY shopMY = new shopMY(username,psd);
                    Show(shopMY, (onj, args) =>
                    {
                        if (string.IsNullOrEmpty(shopMY.nextpage) == false)
                        {
                            ShowPage(shopMY.nextpage);
                        }
                    });
                    break;

            }

        }

        public string GetUser()
        {
            return username;
        }
    }
}

public class NavData
{
    public string[] Labels { set; get; }
    public List<string[]> Buttons { set; get; }
    public string[] Imgs { set; get; }
    public NavData(string[] labels, List<string[]> buttons, string[] imgs)
    {
        Labels = labels;
        Buttons = buttons;
        Imgs = imgs;
    }
    public NavData() { }
}
