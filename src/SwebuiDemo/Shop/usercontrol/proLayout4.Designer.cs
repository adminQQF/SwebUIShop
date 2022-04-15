using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class proLayout4: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public proLayout4() : base()
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
            this.button1 = new Swebui.Controls.Button();
            this.panel2 = new Swebui.Controls.Panel();
            this.label1 = new Swebui.Controls.Label();
            this.label2 = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.button1,
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Swebui.Controls.Padding(2F);
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            // 
            // image1
            // 
            this.image1.DisplayMember = "proimg";
            this.image1.Name = "image1";
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(0, 180);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DisplayMember = "name";
            this.button1.FontSize = 12F;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button1.LineHeight = 15F;
            this.button1.Margin = new Swebui.Controls.Margin(0F, 5F, 0F, 5F);
            this.button1.Name = "button1";
            this.button1.NumberOfLines = 2;
            this.button1.SelectBackgroundColor = System.Drawing.Color.White;
            this.button1.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button1.Size = new System.Drawing.Size(0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.label1,
            this.label2});
            this.panel2.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            // 
            // label1
            // 
            this.label1.FontSize = 12F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.LineHeight = 12F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.Text = "гд";
            // 
            // label2
            // 
            this.label2.DisplayMember = "price";
            this.label2.FontSize = 12F;
            this.label2.LineHeight = 12F;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            // 
            // proLayout4
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(190, 270);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}