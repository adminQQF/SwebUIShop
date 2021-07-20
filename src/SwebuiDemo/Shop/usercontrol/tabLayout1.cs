using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class tabLayout1 : SwebUserControl
    {
        private string [] Prams;
        private string[] Images;
        public tabLayout1(string []prams,string [] images) : base()
        {
            InitializeComponent();
            Prams = prams;
            Images = images;
        }
        private void tabLayout1_Load(object sender, EventArgs e)
        {
            if (Prams != null)
            {
                for (int i = 0; i < Prams.Length; i++)
                    panel1.Controls.Add(new Label()
                    {
                        Text = Prams[i],
                        Size = new System.Drawing.Size(206, 24),
                        Margin = new Margin(0, 0, 20, 0),
                        NumberOfLines = 1
                    }); ; 
            }
            if(Images!=null)
            {
                for(int i=0;i<Images.Length;i++)
                {
                    this.Controls.Add(new Image() { 
                    Width=750,
                    Height=350,
                    ResourceID=Images[i],
                    SizeMode= ImageSizeMode.Stretch
                    });
                }
            }
        }
    }
}