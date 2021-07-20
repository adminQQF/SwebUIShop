using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class tabLayout1: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public tabLayout1() : base()
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
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 10F);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Swebui.Controls.Padding(25F, 10F, 0F, 10F);
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // tabLayout1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(750, 0);
            this.Load += new System.EventHandler(this.tabLayout1_Load);

        }
        #endregion

        private Panel panel1;
    }
}