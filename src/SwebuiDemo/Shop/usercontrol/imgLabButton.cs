using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class imgLabButton : SwebUserControl
    {

  
        public imgLabButton(string img,string text) : base()
        {
            InitializeComponent();
            image1.ResourceID = img;
            label1.Text = text;

        }
        private void imgPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(255, 68, 0);
        }

        private void panel1_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
      
    }
}