using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class navLayout : SwebUserControl
    {
        private string Item;
        private string[] SubItems;
        public navLayout(string item,string []subtems) : base()
        {
            InitializeComponent();
            Item = item;
            SubItems = subtems;

        }
        private void demoMap_Load(object sender, EventArgs e)
        {
            button1.Text = Item;
            if (SubItems != null)
            {
                for(int i = 0; i < SubItems.Length; i++)
                {
                    Button button = new Button() {
                        Text = SubItems[i],
                        Size=new Size(0,0),
                        FontSize = 12,
                        BackColor = Color.Transparent,
                        ForeColor = Color.Black,
                        SelectBackgroundColor = Color.Transparent,
                        SelectColor = Color.FromArgb(255,68,0)
                    };
                    button.Click += button1_Click;
                    panel2.Controls.Add(button);
                }
            }
            else
            {
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.IconName == "fa fa-caret-square-o-down")
            {
                button2.IconName = "fa fa-caret-square-o-up";
                panel2.Visible = true;
            }
            else
            {
                button2.IconName = "fa fa-caret-square-o-down";
                panel2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //按钮事件处理
            Toast(((Button)sender).Text);
           
        }
    }
}