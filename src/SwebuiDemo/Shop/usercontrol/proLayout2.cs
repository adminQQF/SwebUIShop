using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo.Demo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class proLayout2 : SwebUserControl
    {
        private void demoMap_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            string text = ((Panel)sender).Name;
            switch (text)
            {
                case "item1":
                    panel1.Visible = true;
                    break;
                case "item2":
                    panel2.Visible = true;
                    break;
                case "item3":
                    panel3.Visible = true;
                    break;
                case "item4":
                    panel4.Visible = true;
                    break;
                case "item5":
                    panel5.Visible = true;
                    break;
            }
        }

        private void panel1_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            string text = ((Panel)sender).Name;
            switch (text)
            {
                case "item1":
                    panel1.Visible = false;
                    break;
                case "item2":
                    panel2.Visible = false;
                    break;
                case "item3":
                    panel3.Visible = false;
                    break;
                case "item4":
                    panel4.Visible = false;
                    break;
                case "item5":
                    panel5.Visible = false;
                    break;
            }
        }
    }
}