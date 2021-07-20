using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class myWlLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public myWlLayout() : base()
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
            this.image1 = new Swebui.Controls.Image();
            this.panel1 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            // 
            // image1
            // 
            this.image1.DisplayMember = "proimg";
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(70, 70);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Margin = new Swebui.Controls.Margin(30F, 0F, 0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            // 
            // label1
            // 
            this.label1.DisplayMember = "wl";
            this.label1.FontSize = 12F;
            this.label1.Name = "label1";
            this.label1.NumberOfLines = 1;
            this.label1.Size = new System.Drawing.Size(360, 35);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.button1});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // label2
            // 
            this.label2.DisplayMember = "date";
            this.label2.FontSize = 12F;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FontSize = 12F;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.White;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.Text = "查看物理信息";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Swebui.Controls.Border(1F);
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.button2.FontSize = 12F;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Margin = new Swebui.Controls.Margin(0F, 0F, 15F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.SelectBackgroundColor = System.Drawing.Color.White;
            this.button2.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button2.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button2.Size = new System.Drawing.Size(62, 26);
            this.button2.Text = "确认收货";
            // 
            // myWlLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel1,
            this.button2});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Padding = new Swebui.Controls.Padding(15F, 13F, 10F, 13F);
            this.Size = new System.Drawing.Size(724, 98);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Image image1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}