using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class myProLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public myProLayout() : base()
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
            this.panel2 = new Swebui.Controls.Panel();
            this.panel3 = new Swebui.Controls.Panel();
            this.panel4 = new Swebui.Controls.Panel();
            this.panel5 = new Swebui.Controls.Panel();
            this.panel6 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            this.label3 = new Swebui.Controls.Label();
            this.image2 = new Swebui.Controls.Image();
            this.label4 = new Swebui.Controls.Label();
            this.label5 = new Swebui.Controls.Label();
            this.button2 = new Swebui.Controls.Button();
            this.label6 = new Swebui.Controls.Label();
            this.image3 = new Swebui.Controls.Image();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.button3 = new Swebui.Controls.Button();
            this.label9 = new Swebui.Controls.Label();
            this.button1 = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.panel2,
            this.button1,
            this.label3});
            this.panel1.Margin = new Swebui.Controls.Margin(8F, 0F, 8F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 315);
            this.panel1.Touchable = true;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Margin = new Swebui.Controls.Margin(16F, 13F, 12F, 12F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2,
            this.panel4,
            this.button2,
            this.label6});
            this.panel3.Margin = new Swebui.Controls.Margin(8F, 0F, 8F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 315);
            this.panel3.Touchable = true;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label4,
            this.label5});
            this.panel4.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel4.Margin = new Swebui.Controls.Margin(16F, 13F, 12F, 12F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Swebui.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image3,
            this.panel6,
            this.button3,
            this.label9});
            this.panel5.Margin = new Swebui.Controls.Margin(8F, 0F, 8F, 0F);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 315);
            this.panel5.Touchable = true;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label7,
            this.label8});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.Margin = new Swebui.Controls.Margin(16F, 13F, 12F, 12F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 0);
            // 
            // image1
            // 
            this.image1.DisplayMember = "proimg";
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(0, 220);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.DisplayMember = "price";
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label2
            // 
            this.label2.DisplayMember = "oldprice";
            this.label2.FontSize = 14F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.LineThrough = true;
            this.label2.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label3
            // 
            this.label3.DisplayMember = "sales";
            this.label3.FontSize = 12F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label3.Margin = new Swebui.Controls.Margin(16F, 13F, 12F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            // 
            // image2
            // 
            this.image2.DisplayMember = "proimg1";
            this.image2.Name = "image2";
            this.image2.ResouceData = null;
            this.image2.ResourceID = "";
            this.image2.Size = new System.Drawing.Size(0, 220);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label4
            // 
            this.label4.Bold = true;
            this.label4.DisplayMember = "price1";
            this.label4.FontSize = 16F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label5
            // 
            this.label5.DisplayMember = "oldprice1";
            this.label5.FontSize = 14F;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.LineThrough = true;
            this.label5.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.DisplayMember = "prodes1";
            this.button2.FontSize = 12F;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.button2.Margin = new Swebui.Controls.Margin(16F, 0F, 12F, 0F);
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 1;
            this.button2.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button2.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button2.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button2.Size = new System.Drawing.Size(0, 14);
            // 
            // label6
            // 
            this.label6.DisplayMember = "sales1";
            this.label6.FontSize = 12F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label6.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label6.Margin = new Swebui.Controls.Margin(16F, 13F, 12F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 0);
            // 
            // image3
            // 
            this.image3.DisplayMember = "proimg2";
            this.image3.Name = "image3";
            this.image3.ResouceData = null;
            this.image3.ResourceID = "";
            this.image3.Size = new System.Drawing.Size(0, 220);
            this.image3.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label7
            // 
            this.label7.Bold = true;
            this.label7.DisplayMember = "price2";
            this.label7.FontSize = 16F;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.DisplayMember = "oldprice2";
            this.label8.FontSize = 14F;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label8.LineThrough = true;
            this.label8.Margin = new Swebui.Controls.Margin(10F, 0F, 0F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.DisplayMember = "prodes2";
            this.button3.FontSize = 12F;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.button3.Margin = new Swebui.Controls.Margin(16F, 0F, 12F, 0F);
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 1;
            this.button3.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button3.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button3.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button3.Size = new System.Drawing.Size(0, 14);
            // 
            // label9
            // 
            this.label9.DisplayMember = "sales2";
            this.label9.FontSize = 12F;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label9.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label9.Margin = new Swebui.Controls.Margin(16F, 13F, 12F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DisplayMember = "prodes";
            this.button1.FontSize = 12F;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.button1.Margin = new Swebui.Controls.Margin(16F, 0F, 12F, 0F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 1;
            this.button1.SelectBackgroundColor = System.Drawing.Color.White;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(0, 14);
            // 
            // myProLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel3,
            this.panel5});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Size = new System.Drawing.Size(708, 335);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Image image2;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label6;
        private Panel panel5;
        private Image image3;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Button button3;
        private Label label9;
        private Button button1;
    }
}