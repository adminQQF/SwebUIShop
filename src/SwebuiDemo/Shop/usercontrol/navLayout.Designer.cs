using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class navLayout : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public navLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1,
            this.button2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 29);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Flex = 1;
            this.button1.FontSize = 12F;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(213, 0);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.button2.IconName = "fa fa-caret-square-o-down";
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.Padding = new Swebui.Controls.Padding(2F);
            this.button2.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button2.Size = new System.Drawing.Size(12, 12);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.panel2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Swebui.Controls.Padding(10F, 0F, 0F, 0F);
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.Visible = false;
            // 
            // navLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
    }
}