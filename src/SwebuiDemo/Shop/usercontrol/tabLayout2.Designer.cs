using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class tabLayout2: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public tabLayout2() : base()
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
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.panel3 = new Swebui.Controls.Panel();
            this.label2 = new Swebui.Controls.Label();
            this.yxPanel = new Swebui.Controls.Panel();
            this.panel1 = new Swebui.Controls.Panel();
            this.checkBox1 = new Swebui.Controls.CheckBox();
            this.label3 = new Swebui.Controls.Label();
            this.checkBox2 = new Swebui.Controls.CheckBox();
            this.label4 = new Swebui.Controls.Label();
            this.checkBox3 = new Swebui.Controls.CheckBox();
            this.label5 = new Swebui.Controls.Label();
            this.checkBox4 = new Swebui.Controls.CheckBox();
            this.label6 = new Swebui.Controls.Label();
            this.checkBox5 = new Swebui.Controls.CheckBox();
            this.label7 = new Swebui.Controls.Label();
            this.checkBox6 = new Swebui.Controls.CheckBox();
            this.label8 = new Swebui.Controls.Label();
            this.listView1 = new Swebui.Controls.ListView();
            this.pagebtnPanel = new Swebui.Controls.Panel();
            // 
            // panel2
            // 
            this.panel2.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1});
            this.panel2.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 47);
            // 
            // label1
            // 
            this.label1.Border = new Swebui.Controls.Border(1F, 1F, 1F, 0F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.FontSize = 14F;
            this.label1.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.Text = "宝贝评论";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Border = new Swebui.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label2,
            this.yxPanel});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Swebui.Controls.Padding(24F, 14F, 24F, 14F);
            this.panel3.Size = new System.Drawing.Size(0, 112);
            // 
            // label2
            // 
            this.label2.FontSize = 16F;
            this.label2.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Right;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "大家印象：";
            // 
            // yxPanel
            // 
            this.yxPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.yxPanel.Flex = 1;
            this.yxPanel.Name = "yxPanel";
            this.yxPanel.Size = new System.Drawing.Size(1, 84);
            this.yxPanel.Wrap = Swebui.Controls.LayoutWrap.Wrap;
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1,
            this.label3,
            this.checkBox2,
            this.label4,
            this.checkBox3,
            this.label5,
            this.checkBox4,
            this.label6,
            this.checkBox5,
            this.label7,
            this.checkBox6,
            this.label8});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Margin = new Swebui.Controls.Margin(0F, 10F, 0F, 0F);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Swebui.Controls.Padding(10F);
            this.panel1.Size = new System.Drawing.Size(0, 46);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.BorderRadius = 0;
            this.checkBox1.Checked = true;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.FontSize = 12F;
            this.label3.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.Text = "全部";
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.BorderColor = System.Drawing.Color.Black;
            this.checkBox2.BorderRadius = 0;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 22);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.FontSize = 12F;
            this.label4.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "图片(53)";
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.BorderColor = System.Drawing.Color.Black;
            this.checkBox3.BorderRadius = 0;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 22);
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.FontSize = 12F;
            this.label5.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 0);
            this.label5.Text = "追评（9）";
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.BorderColor = System.Drawing.Color.Black;
            this.checkBox4.BorderRadius = 0;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(22, 22);
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.FontSize = 12F;
            this.label6.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 0);
            this.label6.Text = "好评";
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.BorderColor = System.Drawing.Color.Black;
            this.checkBox5.BorderRadius = 0;
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(22, 22);
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.FontSize = 12F;
            this.label7.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 0);
            this.label7.Text = "中评";
            // 
            // checkBox6
            // 
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.BorderColor = System.Drawing.Color.Black;
            this.checkBox6.BorderRadius = 0;
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(22, 22);
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.FontSize = 12F;
            this.label8.Margin = new Swebui.Controls.Margin(5F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 0);
            this.label8.Text = "差评";
            // 
            // listView1
            // 
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(0, 89);
            // 
            // pagebtnPanel
            // 
            this.pagebtnPanel.Direction = Swebui.Controls.LayoutDirection.Row;
            this.pagebtnPanel.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.FlexEnd;
            this.pagebtnPanel.Name = "pagebtnPanel";
            this.pagebtnPanel.Size = new System.Drawing.Size(0, 35);
            // 
            // tabLayout2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel2,
            this.panel3,
            this.panel1,
            this.listView1,
            this.pagebtnPanel});
            this.Size = new System.Drawing.Size(750, 0);
            this.Load += new System.EventHandler(this.tabLayout1_Load);

        }
        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel yxPanel;
        private Panel panel1;
        private CheckBox checkBox1;
        private Label label3;
        private CheckBox checkBox2;
        private Label label4;
        private CheckBox checkBox3;
        private Label label5;
        private CheckBox checkBox4;
        private Label label6;
        private CheckBox checkBox5;
        private Label label7;
        private CheckBox checkBox6;
        private Label label8;
        private ListView listView1;
        private Panel pagebtnPanel;
    }
}