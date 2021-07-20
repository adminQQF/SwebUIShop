using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class loginLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public loginLayout()
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
            this.label1 = new Swebui.Controls.Label();
            this.textBox2 = new Swebui.Controls.TextBox();
            this.textBox1 = new Swebui.Controls.TextBox();
            this.button1 = new Swebui.Controls.Button();
            this.button2 = new Swebui.Controls.Button();
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 20F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 35);
            this.label1.Text = "用户登录";
            // 
            // textBox2
            // 
            this.textBox2.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 20F);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 35);
            this.textBox2.WaterMarkText = "请输入用户名";
            // 
            // textBox1
            // 
            this.textBox1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 20F);
            this.textBox1.Name = "textBox1";
            this.textBox1.SecurityMode = true;
            this.textBox1.Size = new System.Drawing.Size(200, 35);
            this.textBox1.WaterMarkText = "请输入密码";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.Margin = new Swebui.Controls.Margin(0F, 0F, 0F, 20F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 0;
            this.button1.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button1.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.Text = "登陆";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button2.Name = "button2";
            this.button2.NumberOfLines = 0;
            this.button2.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.button2.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.button2.Size = new System.Drawing.Size(200, 35);
            this.button2.Text = "取消";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.textBox2,
            this.textBox1,
            this.button1,
            this.button2});
            this.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.JustifyAlign = Swebui.Controls.LayoutJustifyAlign.Center;
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.imgPanel_Load);

        }
        #endregion

        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}