using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class cateLayout : SwebUserControl
    {
        private string Item;
        private string[] SubItems;
        public cateLayout(string item,string[]subitems) : base()
        {
            InitializeComponent();
            Item = item;
            SubItems = subitems;

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
                        Size = new System.Drawing.Size(0,26),
                        FontSize = 12,
                        BackColor=Color.Transparent,
                        ForeColor=Color.Black
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
            if (button2.IconName == "fa fa-chevron-down")
            {
                button2.IconName = "fa fa-chevron-right";
                panel2.Visible = false;
            }
            else
            {
                button2.IconName = "fa fa-chevron-down";
                panel2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //按钮事件处理
            Toast(((Button)sender).Text);
           
        }
    }
}