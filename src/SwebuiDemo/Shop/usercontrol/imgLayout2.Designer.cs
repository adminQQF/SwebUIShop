using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class imgLayout2 : SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public imgLayout2()
            : base()
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
            this.image1 = new Swebui.Controls.Image();
            this.image2 = new Swebui.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.image2});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // image1
            // 
            this.image1.BorderRadius = 20;
            this.image1.DisplayMember = "img";
            this.image1.Flex = 1;
            this.image1.Margin = new Swebui.Controls.Margin(10F, 5F, 5F, 5F);
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(266, 0);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // image2
            // 
            this.image2.BorderRadius = 20;
            this.image2.DisplayMember = "img2";
            this.image2.Flex = 1;
            this.image2.Margin = new Swebui.Controls.Margin(5F, 5F, 10F, 5F);
            this.image2.Name = "image2";
            this.image2.ResouceData = null;
            this.image2.ResourceID = "";
            this.image2.Size = new System.Drawing.Size(0, 0);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // imgLayout2
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(520, 200);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Image image2;
    }
}