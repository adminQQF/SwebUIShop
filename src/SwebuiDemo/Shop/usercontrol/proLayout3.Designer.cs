using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class proLayout3: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public proLayout3() : base()
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
            this.label2 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label2,
            this.panel2,
            this.button1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.panel1.Margin = new Swebui.Controls.Margin(20F, 20F, 0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // image1
            // 
            this.image1.Border = new Swebui.Controls.Border(1F);
            this.image1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.image1.DisplayMember = "proImg";
            this.image1.Location = new System.Drawing.Point(11, 6);
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(42, 42);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label2
            // 
            this.label2.DisplayMember = "pricelab";
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(65, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label4,
            this.label5});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Location = new System.Drawing.Point(65, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 18);
            // 
            // label3
            // 
            this.label3.DisplayMember = "lab";
            this.label3.FontSize = 12F;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            // 
            // label4
            // 
            this.label4.DisplayMember = "num";
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            // 
            // label5
            // 
            this.label5.FontSize = 12F;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 0);
            this.label5.Text = "¼þ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DisplayMember = "namelab";
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(65, 0);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 1;
            this.button1.SelectBackgroundColor = System.Drawing.Color.White;
            this.button1.SelectColor = System.Drawing.Color.Black;
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(96, 18);
            // 
            // proLayout3
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(198, 80);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}