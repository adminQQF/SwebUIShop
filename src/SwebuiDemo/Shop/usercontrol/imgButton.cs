using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Swebui.Controls;


namespace SwebuiDemo
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class imgButton : SwebUserControl
    {

        public Color UnSelectBorderColor = Color.White;
        public bool IsSelect => _IsSelect;
        private bool _IsSelect = false;
        public int Index = 0;
        public imgButton(string img) : base()
        {
            InitializeComponent();
            image1.ResourceID = img;

        }
        private void imgPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, SwebMouseMoveEventArgs e)
        {
            panel1.BorderColor = Color.FromArgb(255, 68, 0);
        }

        private void panel1_MouseLeave(object sender, SwebMouseMoveEventArgs e)
        {
            if (_IsSelect == false)
                panel1.BorderColor = UnSelectBorderColor;
        }
        public event EventHandler ImagePress;
        private void panel1_Press(object sender, EventArgs e)
        {
            _IsSelect = !_IsSelect;
            if(panel1.BorderColor != UnSelectBorderColor)
            {
                panel1.BorderColor = Color.FromArgb(255, 68, 0);
            }
            else
            {
                panel1.BorderColor = UnSelectBorderColor;
            }
            OnImagePress();
        }
        private void OnImagePress()
        {
            if (ImagePress != null) ImagePress.Invoke(this, new EventArgs());
        }
        public void SetBorderColor( Color color)
        {
            panel1.BorderColor = color;
        }
    }
}