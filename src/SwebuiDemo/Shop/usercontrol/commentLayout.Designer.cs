using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class commentLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public commentLayout() : base()
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
            this.image2 = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.label3 = new Swebui.Controls.Label();
            this.label4 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.label5 = new Swebui.Controls.Label();
            this.image3 = new Swebui.Controls.Image();
            this.image4 = new Swebui.Controls.Image();
            this.image5 = new Swebui.Controls.Image();
            this.image6 = new Swebui.Controls.Image();
            this.image7 = new Swebui.Controls.Image();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1,
            this.image2});
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 0);
            // 
            // image1
            // 
            this.image1.DisplayMember = "user";
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(40, 40);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.DisplayMember = "username";
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            // 
            // image2
            // 
            this.image2.DisplayMember = "role";
            this.image2.Name = "image2";
            this.image2.ResouceData = null;
            this.image2.ResourceID = "";
            this.image2.Size = new System.Drawing.Size(76, 18);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.panel3,
            this.panel4});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 0);
            // 
            // label2
            // 
            this.label2.DisplayMember = "comment";
            this.label2.LineHeight = 1.2F;
            this.label2.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image3,
            this.image4,
            this.image5,
            this.image6,
            this.image7});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 42);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label3,
            this.label4,
            this.button1,
            this.label5});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 18);
            // 
            // label3
            // 
            this.label3.DisplayMember = "date";
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 20F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            // 
            // label4
            // 
            this.label4.DisplayMember = "type";
            this.label4.Flex = 1;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.White;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(30, 0);
            this.button1.Text = "”–”√";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 0);
            this.label5.Text = "(0)";
            // 
            // image3
            // 
            this.image3.BindDisplayValueGone = true;
            this.image3.DisplayMember = "commemtImg";
            this.image3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image3.Name = "image3";
            this.image3.ResouceData = null;
            this.image3.ResourceID = "";
            this.image3.Size = new System.Drawing.Size(45, 0);
            this.image3.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image3.Zooming = true;
            // 
            // image4
            // 
            this.image4.BindDisplayValueGone = true;
            this.image4.DisplayMember = "commemtImg1";
            this.image4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image4.Name = "image4";
            this.image4.ResouceData = null;
            this.image4.ResourceID = "";
            this.image4.Size = new System.Drawing.Size(45, 0);
            this.image4.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image4.Zooming = true;
            // 
            // image5
            // 
            this.image5.BindDisplayValueGone = true;
            this.image5.DisplayMember = "commemtImg2";
            this.image5.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image5.Name = "image5";
            this.image5.ResouceData = null;
            this.image5.ResourceID = "";
            this.image5.Size = new System.Drawing.Size(45, 0);
            this.image5.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image5.Zooming = true;
            // 
            // image6
            // 
            this.image6.BindDisplayValueGone = true;
            this.image6.DisplayMember = "commemtImg3";
            this.image6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image6.Name = "image6";
            this.image6.ResouceData = null;
            this.image6.ResourceID = "";
            this.image6.Size = new System.Drawing.Size(45, 0);
            this.image6.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image6.Zooming = true;
            // 
            // image7
            // 
            this.image7.BindDisplayValueGone = true;
            this.image7.DisplayMember = "commemtImg4";
            this.image7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.image7.Name = "image7";
            this.image7.ResouceData = null;
            this.image7.ResourceID = "";
            this.image7.Size = new System.Drawing.Size(45, 0);
            this.image7.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.image7.Zooming = true;
            // 
            // commentLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Padding = new Swebui.Controls.Padding(10F);
            this.Size = new System.Drawing.Size(750, 129);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Label label1;
        private Image image2;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Image image3;
        private Image image4;
        private Image image5;
        private Image image6;
        private Image image7;
    }
}