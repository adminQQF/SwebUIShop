using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class proLayout2: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public proLayout2()
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
            this.item1 = new Swebui.Controls.Panel();
            this.image1 = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            this.panel1 = new Swebui.Controls.Panel();
            this.button1 = new Swebui.Controls.Button();
            this.panel6 = new Swebui.Controls.Panel();
            this.fontIcon1 = new Swebui.Controls.FontIcon();
            this.label6 = new Swebui.Controls.Label();
            this.label7 = new Swebui.Controls.Label();
            this.item2 = new Swebui.Controls.Panel();
            this.image2 = new Swebui.Controls.Image();
            this.label2 = new Swebui.Controls.Label();
            this.panel2 = new Swebui.Controls.Panel();
            this.button2 = new Swebui.Controls.Button();
            this.panel7 = new Swebui.Controls.Panel();
            this.fontIcon2 = new Swebui.Controls.FontIcon();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.item3 = new Swebui.Controls.Panel();
            this.image3 = new Swebui.Controls.Image();
            this.label3 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.button3 = new Swebui.Controls.Button();
            this.panel8 = new Swebui.Controls.Panel();
            this.fontIcon3 = new Swebui.Controls.FontIcon();
            this.label10 = new Swebui.Controls.Label();
            this.label11 = new Swebui.Controls.Label();
            this.item4 = new Swebui.Controls.Panel();
            this.image4 = new Swebui.Controls.Image();
            this.label4 = new Swebui.Controls.Label();
            this.panel4 = new Swebui.Controls.Panel();
            this.button4 = new Swebui.Controls.Button();
            this.panel9 = new Swebui.Controls.Panel();
            this.fontIcon4 = new Swebui.Controls.FontIcon();
            this.label12 = new Swebui.Controls.Label();
            this.label13 = new Swebui.Controls.Label();
            this.item5 = new Swebui.Controls.Panel();
            this.image5 = new Swebui.Controls.Image();
            this.label5 = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.button5 = new Swebui.Controls.Button();
            this.panel10 = new Swebui.Controls.Panel();
            this.fontIcon5 = new Swebui.Controls.FontIcon();
            this.label14 = new Swebui.Controls.Label();
            this.label15 = new Swebui.Controls.Label();
            // 
            // item1
            // 
            this.item1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.label1,
            this.panel1,
            this.panel6});
            this.item1.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.item1.Margin = new Swebui.Controls.Margin(7F, 0F, 2F, 0F);
            this.item1.Name = "item1";
            this.item1.Padding = new Swebui.Controls.Padding(7F, 0F, 7F, 0F);
            this.item1.RaiseMouseEvent = true;
            this.item1.Size = new System.Drawing.Size(229, 326);
            this.item1.Touchable = true;
            this.item1.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseEnter);
            this.item1.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseLeave);
            // 
            // image1
            // 
            this.image1.BorderRadius = 12;
            this.image1.DisplayMember = "proImg";
            this.image1.Location = new System.Drawing.Point(7, 0);
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(215, 215);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.DisplayMember = "des";
            this.label1.Location = new System.Drawing.Point(7, 228);
            this.label1.Name = "label1";
            this.label1.NumberOfLines = 2;
            this.label1.Size = new System.Drawing.Size(215, 50);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button1});
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel1.Location = new System.Drawing.Point(7, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 70);
            this.panel1.Visible = false;
            this.panel1.ZIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button1.BorderRadius = 12;
            this.button1.FontSize = 18F;
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(189, 31);
            this.button1.Text = "查找相似";
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon1,
            this.label6,
            this.label7});
            this.panel6.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel6.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexEnd;
            this.panel6.Location = new System.Drawing.Point(7, 280);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 25);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "jpy";
            this.fontIcon1.Size = new System.Drawing.Size(20, 16);
            // 
            // label6
            // 
            this.label6.DisplayMember = "price";
            this.label6.FontSize = 20F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label6.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label7
            // 
            this.label7.DisplayMember = "num";
            this.label7.FontSize = 14F;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Padding = new Swebui.Controls.Padding(5F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // item2
            // 
            this.item2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2,
            this.label2,
            this.panel2,
            this.panel7});
            this.item2.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.item2.Margin = new Swebui.Controls.Margin(7F, 0F, 2F, 0F);
            this.item2.Name = "item2";
            this.item2.Padding = new Swebui.Controls.Padding(7F, 0F, 7F, 0F);
            this.item2.RaiseMouseEvent = true;
            this.item2.Size = new System.Drawing.Size(229, 326);
            this.item2.Touchable = true;
            this.item2.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseEnter);
            this.item2.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseLeave);
            // 
            // image2
            // 
            this.image2.BorderRadius = 12;
            this.image2.DisplayMember = "proImg1";
            this.image2.Location = new System.Drawing.Point(7, 0);
            this.image2.Name = "image2";
            this.image2.ResouceData = null;
            this.image2.ResourceID = "";
            this.image2.Size = new System.Drawing.Size(215, 215);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label2
            // 
            this.label2.DisplayMember = "des1";
            this.label2.Location = new System.Drawing.Point(7, 228);
            this.label2.Name = "label2";
            this.label2.NumberOfLines = 2;
            this.label2.Size = new System.Drawing.Size(215, 50);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button2});
            this.panel2.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel2.Location = new System.Drawing.Point(7, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 70);
            this.panel2.Visible = false;
            this.panel2.ZIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button2.BorderRadius = 12;
            this.button2.FontSize = 18F;
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button2.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button2.Size = new System.Drawing.Size(189, 31);
            this.button2.Text = "查找相似";
            // 
            // panel7
            // 
            this.panel7.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon2,
            this.label8,
            this.label9});
            this.panel7.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel7.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexEnd;
            this.panel7.Location = new System.Drawing.Point(7, 280);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 25);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "jpy";
            this.fontIcon2.Size = new System.Drawing.Size(20, 16);
            // 
            // label8
            // 
            this.label8.DisplayMember = "price1";
            this.label8.FontSize = 20F;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label8.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label9
            // 
            this.label9.DisplayMember = "num1";
            this.label9.FontSize = 14F;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label9.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label9.Name = "label9";
            this.label9.Padding = new Swebui.Controls.Padding(5F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // item3
            // 
            this.item3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image3,
            this.label3,
            this.panel3,
            this.panel8});
            this.item3.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.item3.Margin = new Swebui.Controls.Margin(7F, 0F, 2F, 0F);
            this.item3.Name = "item3";
            this.item3.Padding = new Swebui.Controls.Padding(7F, 0F, 7F, 0F);
            this.item3.RaiseMouseEvent = true;
            this.item3.Size = new System.Drawing.Size(229, 326);
            this.item3.Touchable = true;
            this.item3.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseEnter);
            this.item3.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseLeave);
            // 
            // image3
            // 
            this.image3.BorderRadius = 12;
            this.image3.DisplayMember = "proImg2";
            this.image3.Location = new System.Drawing.Point(7, 0);
            this.image3.Name = "image3";
            this.image3.ResouceData = null;
            this.image3.ResourceID = "";
            this.image3.Size = new System.Drawing.Size(215, 215);
            this.image3.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label3
            // 
            this.label3.DisplayMember = "des2";
            this.label3.Location = new System.Drawing.Point(7, 228);
            this.label3.Name = "label3";
            this.label3.NumberOfLines = 2;
            this.label3.Size = new System.Drawing.Size(215, 50);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button3});
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel3.Location = new System.Drawing.Point(7, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 70);
            this.panel3.Visible = false;
            this.panel3.ZIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button3.BorderRadius = 12;
            this.button3.FontSize = 18F;
            this.button3.Name = "button3";
            this.button3.NumberOfLines = 0;
            this.button3.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button3.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button3.Size = new System.Drawing.Size(189, 31);
            this.button3.Text = "查找相似";
            // 
            // panel8
            // 
            this.panel8.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon3,
            this.label10,
            this.label11});
            this.panel8.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel8.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexEnd;
            this.panel8.Location = new System.Drawing.Point(7, 280);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 25);
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "jpy";
            this.fontIcon3.Size = new System.Drawing.Size(20, 16);
            // 
            // label10
            // 
            this.label10.DisplayMember = "price2";
            this.label10.FontSize = 20F;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label10.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label11
            // 
            this.label11.DisplayMember = "num2";
            this.label11.FontSize = 14F;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label11.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label11.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // item4
            // 
            this.item4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image4,
            this.label4,
            this.panel4,
            this.panel9});
            this.item4.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.item4.Margin = new Swebui.Controls.Margin(7F, 0F, 2F, 0F);
            this.item4.Name = "item4";
            this.item4.Padding = new Swebui.Controls.Padding(7F, 0F, 7F, 0F);
            this.item4.RaiseMouseEvent = true;
            this.item4.Size = new System.Drawing.Size(229, 326);
            this.item4.Touchable = true;
            this.item4.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseEnter);
            this.item4.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseLeave);
            // 
            // image4
            // 
            this.image4.BorderRadius = 12;
            this.image4.DisplayMember = "proImg3";
            this.image4.Location = new System.Drawing.Point(7, 0);
            this.image4.Name = "image4";
            this.image4.ResouceData = null;
            this.image4.ResourceID = "";
            this.image4.Size = new System.Drawing.Size(215, 215);
            this.image4.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label4
            // 
            this.label4.DisplayMember = "des3";
            this.label4.Location = new System.Drawing.Point(7, 228);
            this.label4.Name = "label4";
            this.label4.NumberOfLines = 2;
            this.label4.Size = new System.Drawing.Size(215, 50);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button4});
            this.panel4.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel4.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel4.Location = new System.Drawing.Point(7, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 70);
            this.panel4.Visible = false;
            this.panel4.ZIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button4.BorderRadius = 12;
            this.button4.FontSize = 18F;
            this.button4.Name = "button4";
            this.button4.NumberOfLines = 0;
            this.button4.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button4.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button4.Size = new System.Drawing.Size(189, 31);
            this.button4.Text = "查找相似";
            // 
            // panel9
            // 
            this.panel9.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon4,
            this.label12,
            this.label13});
            this.panel9.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel9.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexEnd;
            this.panel9.Location = new System.Drawing.Point(7, 280);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(215, 25);
            // 
            // fontIcon4
            // 
            this.fontIcon4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.fontIcon4.Name = "fontIcon4";
            this.fontIcon4.ResourceID = "jpy";
            this.fontIcon4.Size = new System.Drawing.Size(20, 16);
            // 
            // label12
            // 
            this.label12.DisplayMember = "price3";
            this.label12.FontSize = 20F;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label12.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label13
            // 
            this.label13.DisplayMember = "num3";
            this.label13.FontSize = 14F;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label13.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label13.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // item5
            // 
            this.item5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image5,
            this.label5,
            this.panel5,
            this.panel10});
            this.item5.Layout = Swebui.Controls.LayoutPosition.Absolute;
            this.item5.Margin = new Swebui.Controls.Margin(7F, 0F, 2F, 0F);
            this.item5.Name = "item5";
            this.item5.Padding = new Swebui.Controls.Padding(7F, 0F, 7F, 0F);
            this.item5.RaiseMouseEvent = true;
            this.item5.Size = new System.Drawing.Size(229, 326);
            this.item5.Touchable = true;
            this.item5.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseEnter);
            this.item5.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel1_MouseLeave);
            // 
            // image5
            // 
            this.image5.BorderRadius = 12;
            this.image5.DisplayMember = "proImg4";
            this.image5.Location = new System.Drawing.Point(7, 0);
            this.image5.Name = "image5";
            this.image5.ResouceData = null;
            this.image5.ResourceID = "";
            this.image5.Size = new System.Drawing.Size(215, 215);
            this.image5.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label5
            // 
            this.label5.DisplayMember = "des4";
            this.label5.Location = new System.Drawing.Point(7, 228);
            this.label5.Name = "label5";
            this.label5.NumberOfLines = 2;
            this.label5.Size = new System.Drawing.Size(215, 50);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button5});
            this.panel5.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel5.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.panel5.Location = new System.Drawing.Point(7, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 70);
            this.panel5.Visible = false;
            this.panel5.ZIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button5.BorderRadius = 12;
            this.button5.FontSize = 18F;
            this.button5.Name = "button5";
            this.button5.NumberOfLines = 0;
            this.button5.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button5.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button5.Size = new System.Drawing.Size(189, 31);
            this.button5.Text = "查找相似";
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.fontIcon5,
            this.label14,
            this.label15});
            this.panel10.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel10.ItemAlign = Swebui.Controls.LayoutItemAlign.FlexEnd;
            this.panel10.Location = new System.Drawing.Point(7, 280);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(215, 25);
            // 
            // fontIcon5
            // 
            this.fontIcon5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.fontIcon5.Name = "fontIcon5";
            this.fontIcon5.ResourceID = "jpy";
            this.fontIcon5.Size = new System.Drawing.Size(20, 16);
            // 
            // label14
            // 
            this.label14.DisplayMember = "price4";
            this.label14.FontSize = 20F;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.label14.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 25);
            this.label14.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // label15
            // 
            this.label15.DisplayMember = "num4";
            this.label15.FontSize = 14F;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label15.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label15.Margin = new Swebui.Controls.Margin(5F, 0F, 0F, 0F);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 25);
            this.label15.VerticalAlignment = Swebui.Controls.VerticalAlignment.Bottom;
            // 
            // proLayout2
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.item1,
            this.item2,
            this.item3,
            this.item4,
            this.item5});
            this.Direction = Swebui.Controls.LayoutDirection.Row;
            this.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.Size = new System.Drawing.Size(1200, 326);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel item1;
        private Image image1;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Panel item2;
        private Image image2;
        private Label label2;
        private Panel panel2;
        private Button button2;
        private Panel item3;
        private Image image3;
        private Label label3;
        private Panel panel3;
        private Button button3;
        private Panel item4;
        private Image image4;
        private Label label4;
        private Panel panel4;
        private Button button4;
        private Panel item5;
        private Image image5;
        private Label label5;
        private Panel panel5;
        private Button button5;
        private Panel panel6;
        private FontIcon fontIcon1;
        private Label label6;
        private Label label7;
        private Panel panel7;
        private FontIcon fontIcon2;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private FontIcon fontIcon3;
        private Label label10;
        private Label label11;
        private Panel panel9;
        private FontIcon fontIcon4;
        private Label label12;
        private Label label13;
        private Panel panel10;
        private FontIcon fontIcon5;
        private Label label14;
        private Label label15;
    }
}