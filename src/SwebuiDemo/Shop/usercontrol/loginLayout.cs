using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class loginLayout : SwebUserControl
    {

    
        private void imgPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            this.Close();
        }
        public string GetUser()
        {
            return textBox2.Text;
        }
        public string GetPsd()
        {
            return textBox1.Text;
        }

    }
}