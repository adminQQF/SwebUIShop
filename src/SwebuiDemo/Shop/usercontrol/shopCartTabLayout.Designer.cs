using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class shopCartTabLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public shopCartTabLayout() : base()
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
            this.panel1 = new Swebui.Controls.Panel();
            this.checkBox2 = new Swebui.Controls.CheckBox();
            this.label5 = new Swebui.Controls.Label();
            this.panel6 = new Swebui.Controls.Panel();
            this.label6 = new Swebui.Controls.Label();
            this.panel7 = new Swebui.Controls.Panel();
            this.label7 = new Swebui.Controls.Label();
            this.label8 = new Swebui.Controls.Label();
            this.label9 = new Swebui.Controls.Label();
            this.label10 = new Swebui.Controls.Label();
            this.panel12 = new Swebui.Controls.Panel();
            this.checkBox1 = new Swebui.Controls.CheckBox();
            this.label3 = new Swebui.Controls.Label();
            this.panel13 = new Swebui.Controls.Panel();
            this.button21 = new Swebui.Controls.Button();
            this.button22 = new Swebui.Controls.Button();
            this.label4 = new Swebui.Controls.Label();
            this.numLab = new Swebui.Controls.Label();
            this.label12 = new Swebui.Controls.Label();
            this.label1 = new Swebui.Controls.Label();
            this.allLab = new Swebui.Controls.Label();
            this.button23 = new Swebui.Controls.Button();
            // 
            // panel2
            // 
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 10F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox2,
            this.label5,
            this.panel6,
            this.panel7,
            this.label7,
            this.label8,
            this.label9,
            this.label10});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 40);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.BorderColor = System.Drawing.Color.Black;
            this.checkBox2.BorderRadius = 0;
            this.checkBox2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 25);
            this.checkBox2.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.FontSize = 12F;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 35);
            this.label5.Text = "全选";
            this.label5.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label6});
            this.panel6.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 38);
            // 
            // label6
            // 
            this.label6.FontSize = 12F;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 38);
            this.label6.Text = "商品信息";
            this.label6.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 30);
            // 
            // label7
            // 
            this.label7.Bold = true;
            this.label7.DisplayMember = "price";
            this.label7.FontSize = 12F;
            this.label7.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 34);
            this.label7.Text = "单价";
            this.label7.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Bold = true;
            this.label8.DisplayMember = "all";
            this.label8.FontSize = 12F;
            this.label8.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 34);
            this.label8.Text = "数量";
            this.label8.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Bold = true;
            this.label9.DisplayMember = "all";
            this.label9.FontSize = 12F;
            this.label9.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 34);
            this.label9.Text = "金额";
            this.label9.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label10
            // 
            this.label10.FontSize = 12F;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 35);
            this.label10.Text = "操作";
            this.label10.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel12.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1,
            this.label3,
            this.panel13,
            this.label4,
            this.numLab,
            this.label12,
            this.label1,
            this.allLab,
            this.button23});
            this.panel12.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel12.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel12.Margin = new Swebui.Controls.Margin(0F, 20F, 0F, 0F);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1200, 40);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.BorderRadius = 0;
            this.checkBox1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 25);
            this.checkBox1.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 0);
            this.label3.Text = "全选";
            this.label3.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel13
            // 
            this.panel13.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.button21,
            this.button22});
            this.panel13.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel13.Flex = 1;
            this.panel13.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(656, 35);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.FontSize = 12F;
            this.button21.ForeColor = System.Drawing.Color.Black;
            this.button21.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button21.Name = "button21";
            this.button21.NumberOfLines = 0;
            this.button21.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button21.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button21.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.Underline;
            this.button21.Size = new System.Drawing.Size(0, 0);
            this.button21.Text = "删除";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.FontSize = 12F;
            this.button22.ForeColor = System.Drawing.Color.Black;
            this.button22.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.button22.Name = "button22";
            this.button22.NumberOfLines = 0;
            this.button22.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.button22.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button22.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.Underline;
            this.button22.Size = new System.Drawing.Size(0, 0);
            this.button22.Text = "移入收藏夹";
            // 
            // label4
            // 
            this.label4.Bold = true;
            this.label4.DisplayMember = "all";
            this.label4.FontSize = 12F;
            this.label4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 0);
            this.label4.Text = "已选商品";
            this.label4.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // numLab
            // 
            this.numLab.Bold = true;
            this.numLab.DisplayMember = "all";
            this.numLab.FontSize = 18F;
            this.numLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.numLab.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.numLab.Name = "numLab";
            this.numLab.Size = new System.Drawing.Size(0, 0);
            this.numLab.Text = "0,0";
            this.numLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 0);
            this.label12.Text = "件";
            this.label12.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.DisplayMember = "all";
            this.label1.FontSize = 18F;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "合计（不含运费）：";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // allLab
            // 
            this.allLab.FontSize = 18F;
            this.allLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.allLab.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.allLab.Name = "allLab";
            this.allLab.Size = new System.Drawing.Size(0, 0);
            this.allLab.Text = "0,0";
            this.allLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button23.FontSize = 20F;
            this.button23.Name = "button23";
            this.button23.NumberOfLines = 0;
            this.button23.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button23.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button23.Size = new System.Drawing.Size(110, 40);
            this.button23.Text = "结算";
            // 
            // shopCartTabLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel2,
            this.panel12});
            this.Size = new System.Drawing.Size(1200, 2000);
            this.Load += new System.EventHandler(this.shopCartTabLayout_Load);

        }
        #endregion
        private Panel panel2;
        private Panel panel1;
        private CheckBox checkBox2;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel12;
        private CheckBox checkBox1;
        private Label label3;
        private Panel panel13;
        private Button button21;
        private Button button22;
        private Label label4;
        private Label numLab;
        private Label label12;
        private Label label1;
        private Label allLab;
        private Button button23;
    }
}