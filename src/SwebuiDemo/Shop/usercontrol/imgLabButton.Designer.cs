using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class imgLabButton: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public imgLabButton()
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
            this.label1 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.RaiseMouseEvent = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseLeave);
            // 
            // image1
            // 
            this.image1.DisplayMember = "img";
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(95, 95);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            // 
            // imgLabButton
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(95, 123);
            this.Load += new System.EventHandler(this.imgPanel_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Label label1;
    }
}