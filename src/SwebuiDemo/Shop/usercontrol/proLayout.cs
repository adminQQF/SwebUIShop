using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class proLayout : SwebUserControl
    {
        public proLayout(string img, string title,string description) : base()
        {
            InitializeComponent();
            image1.ResourceID = img;
            titleLab.Text = title;
            desLab.Text = description;

        }
        private void demoMap_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            shopDetail shopDetail = new shopDetail(((shopIndex)this.Form).GetUser(), "");
           this.Form.Show(shopDetail, (onj, args) =>
            {
                if (string.IsNullOrEmpty(shopDetail.nextpage) == false)
                {
                   ((shopIndex)this.Form). ShowPage(shopDetail.nextpage);
                }
            });
        }
    }
}