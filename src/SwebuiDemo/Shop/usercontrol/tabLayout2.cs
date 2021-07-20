using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class tabLayout2 : SwebUserControl
    {

        private void tabLayout1_Load(object sender, EventArgs e)
        {
            #region"����"
            DataTable dt = new DataTable();
            dt.Columns.Add("user");
            dt.Columns.Add("username");
            dt.Columns.Add("role");
            dt.Columns.Add("comment");
            dt.Columns.Add("date");
            dt.Columns.Add("type");
            dt.Columns.Add("commemtImg");
            dt.Columns.Add("commemtImg1");
            dt.Columns.Add("commemtImg2");
            dt.Columns.Add("commemtImg3");
            dt.Columns.Add("commemtImg4");
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add("user.jpg", "user" + i.ToString(), "wg.gif", "���Ӻܺ���Ҳ�ܺÿ�ֵ�ù���" + i.ToString(), DateTime.Now.ToString(), "��ɫ���ࣺ��ɫ�����", "b-de-pro2.jpg", "b-de-pro1.jpg");
            }
            commentLayout commentLayout = new commentLayout();
            listView1.Height = commentLayout.Height * dt.Rows.Count;
            listView1.TemplateControl = commentLayout;
            listView1.DataSource = dt;
            listView1.DataBind();

            #endregion

            // ���ӡ��ť���

            string[] buttons = new string[] { "�����ܺ�(5)", "���õĺ�(2)", "�Լ۱ȸ�(3)", "��ռ��(5)", "��ʵ��(3)", "��ع�(2)" };
            for (int i = 0; i < buttons.Length; i++)
            {
                Button button = new Button()
                {
                    Text = buttons[i],
                    FontSize = 16,
                    BackColor = System.Drawing.Color.FromArgb(248, 140, 25),
                    BorderColor = System.Drawing.Color.FromArgb(248, 137, 22),
                    Border = new Border(2),
                    SelectBackgroundColor = System.Drawing.Color.White,
                    SelectColor = System.Drawing.Color.Black,
                    Margin = new Margin(0, 0, 10, 5)
                };
                button.Click += YXButton_ClickChanged;
                yxPanel.Controls.Add(button);
            }
            //���ҳ�밴ť
            Button button1 = new Button()
            {
                Text = "��һҳ",
                Padding = new Padding(10),
                Margin = new Margin(5),
                Border = new Border(1),
                BorderColor = Color.WhiteSmoke,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Size = new Size(0, 0)
            };
            Button button2 = new Button()
            {
                Text = "��һҳ",
                Padding = new Padding(10),
                Margin = new Margin(5),
                Border = new Border(1),
                BorderColor = Color.WhiteSmoke,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Size = new Size(0, 0)
            };
            button1.Click += NextPageButton_Press;
            button2.Click += NextPageButton_Press;
            pagebtnPanel.Controls.Add(button1);

            for (int i = 1; i < 5; i++)
            {
                Button button = new Button()
                {
                    Text = i.ToString(),
                    Tag = false,
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Size = new Size(0, 0),
                    Padding = new Padding(10),
                    Margin = new Margin(5),
                    Border = new Border(1),
                    BorderColor = Color.WhiteSmoke
                };
                if (i == 1)
                {
                    button.BackColor = Color.FromArgb(255, 68, 0);
                    button.ForeColor = Color.White;
                    button.Tag = true;
                }
                button.Click += PageButton_Press;
                pagebtnPanel.Controls.Add(button);
            }
            pagebtnPanel.Controls.Add(button2);

        }

        private void NextPageButton_Press(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            if (text == "��һҳ")
            {
                for (int i = 1; i < pagebtnPanel.Controls.Count - 1; i++)
                {
                    if (i > 1 && ((Button)pagebtnPanel.Controls[i]).BackColor == Color.FromArgb(255, 68, 0))
                    {
                        PageButton_Press(pagebtnPanel.Controls[i - 1], null);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 1; i < pagebtnPanel.Controls.Count - 1; i++)
                {
                    if (i < pagebtnPanel.Controls.Count - 2 && ((Button)pagebtnPanel.Controls[i]).BackColor == Color.FromArgb(255, 68, 0))
                    {
                        PageButton_Press(pagebtnPanel.Controls[i + 1], null);
                        break;
                    }
                }
            }
        }
        private void PageButton_Press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((bool)button.Tag == false)
            {
                //����ҳ���ѯ���ݲ���
                listView1.Rows.Clear();
                int i = Convert.ToInt32(((Button)sender).Text);
                DataTable dt = new DataTable();
                dt.Columns.Add("user");
                dt.Columns.Add("username");
                dt.Columns.Add("role");
                dt.Columns.Add("comment");
                dt.Columns.Add("date");
                dt.Columns.Add("type");
                dt.Columns.Add("commemtImg");
                dt.Columns.Add("commemtImg1");
                dt.Columns.Add("commemtImg2");
                dt.Columns.Add("commemtImg3");
                dt.Columns.Add("commemtImg4");
                int j = i + 10;
                for (; i < j; i++)
                {
                    dt.Rows.Add("user.jpg", "user" + i.ToString(), "wg.gif", "���Ӻܺ���Ҳ�ܺÿ�ֵ�ù���" + i.ToString(), DateTime.Now.ToString(), "��ɫ���ࣺ��ɫ�����", "b-de-pro2.jpg", "b-de-pro1.jpg");
                }
                listView1.DataSource = dt;
                listView1.DataBind();
                ((Button)sender).BackColor = Color.FromArgb(255, 68, 0);
                ((Button)sender).ForeColor = Color.White;
                ((Button)sender).Tag = true;
                foreach (Button _button in pagebtnPanel.Controls)
                {
                    if (_button != (Button)sender && _button.BackColor == Color.FromArgb(255, 68, 0))
                    {
                        _button.BackColor = Color.White;
                        _button.ForeColor = Color.Black;
                        _button.Tag = false;
                    }
                }
            }

        }
        private void YXButton_ClickChanged(object sender, EventArgs e)
        {
            //����ͨ���ж� ((Button)sender).Name ��ɸѡ�������°�listview

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (SwebControl swebControl in panel1.Controls)
            {
                if (swebControl.Name.Contains("check"))
                    ((CheckBox)swebControl).Checked = false;
            }
            ((CheckBox)sender).Checked = true;
            //����ͨ���ж� ((CheckBox)sender).Name ��ɸѡ�������°�listview
        }
    }
}