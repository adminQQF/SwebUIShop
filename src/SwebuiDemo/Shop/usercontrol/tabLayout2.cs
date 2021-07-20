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
            #region"评论"
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
                dt.Rows.Add("user.jpg", "user" + i.ToString(), "wg.gif", "盘子很好用也很好看值得购买" + i.ToString(), DateTime.Now.ToString(), "颜色分类：金色三层架", "b-de-pro2.jpg", "b-de-pro1.jpg");
            }
            commentLayout commentLayout = new commentLayout();
            listView1.Height = commentLayout.Height * dt.Rows.Count;
            listView1.TemplateControl = commentLayout;
            listView1.DataSource = dt;
            listView1.DataBind();

            #endregion

            // 大家印象按钮添加

            string[] buttons = new string[] { "质量很好(5)", "好用的很(2)", "性价比高(3)", "不占地(5)", "很实用(3)", "会回购(2)" };
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
            //添加页码按钮
            Button button1 = new Button()
            {
                Text = "上一页",
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
                Text = "下一页",
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
            if (text == "上一页")
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
                //根据页码查询数据并绑定
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
                    dt.Rows.Add("user.jpg", "user" + i.ToString(), "wg.gif", "盘子很好用也很好看值得购买" + i.ToString(), DateTime.Now.ToString(), "颜色分类：金色三层架", "b-de-pro2.jpg", "b-de-pro1.jpg");
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
            //可以通过判断 ((Button)sender).Name 来筛选数据重新绑定listview

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (SwebControl swebControl in panel1.Controls)
            {
                if (swebControl.Name.Contains("check"))
                    ((CheckBox)swebControl).Checked = false;
            }
            ((CheckBox)sender).Checked = true;
            //可以通过判断 ((CheckBox)sender).Name 来筛选数据重新绑定listview
        }
    }
}