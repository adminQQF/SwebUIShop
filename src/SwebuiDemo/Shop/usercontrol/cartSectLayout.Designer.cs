using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class cartSectLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public cartSectLayout() : base()
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
            this.checkBox1 = new Swebui.Controls.CheckBox();
            this.shopicon = new Swebui.Controls.Image();
            this.label1 = new Swebui.Controls.Label();
            this.shopnamebtn = new Swebui.Controls.Button();
            this.panel5 = new Swebui.Controls.Panel();
            this.image2 = new Swebui.Controls.Image();
            this.panel3 = new Swebui.Controls.Panel();
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1,
            this.shopicon,
            this.label1,
            this.shopnamebtn,
            this.panel5});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel1.Name = "panel1";
            this.panel1.Overflow = Swebui.Controls.LayoutOverflow.Hidden;
            this.panel1.Padding = new Swebui.Controls.Padding(15F, 16F, 0F, 16F);
            this.panel1.Size = new System.Drawing.Size(0, 38);
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // shopicon
            // 
            this.shopicon.Name = "shopicon";
            this.shopicon.ResouceData = null;
            this.shopicon.ResourceID = "";
            this.shopicon.Size = new System.Drawing.Size(15, 15);
            this.shopicon.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.FontSize = 12F;
            this.label1.Name = "label1";
            this.label1.Padding = new Swebui.Controls.Padding(0F, 0F, 5F, 0F);
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.Text = "µÍ∆Ã£∫";
            this.label1.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // shopnamebtn
            // 
            this.shopnamebtn.BackColor = System.Drawing.Color.White;
            this.shopnamebtn.DisplayMember = "shopname";
            this.shopnamebtn.FontSize = 12F;
            this.shopnamebtn.ForeColor = System.Drawing.Color.Black;
            this.shopnamebtn.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.shopnamebtn.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.shopnamebtn.Name = "shopnamebtn";
            this.shopnamebtn.NumberOfLines = 0;
            this.shopnamebtn.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.shopnamebtn.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.shopnamebtn.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.shopnamebtn.Size = new System.Drawing.Size(100, 36);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image2});
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(97, 38);
            // 
            // image2
            // 
            this.image2.Flex = 1;
            this.image2.Name = "image2";
            this.image2.ResouceData = null;
            this.image2.ResourceID = "";
            this.image2.Size = new System.Drawing.Size(0, 38);
            this.image2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Swebui.Controls.Border(1F, 1F, 1F, 0F);
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 0);
            // 
            // cartSectLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1,
            this.panel3});
            this.Size = new System.Drawing.Size(1200, 0);
            this.Load += new System.EventHandler(this.cartSectLayout_Load);

        }
        #endregion

        private Panel panel1;
        private Panel panel3;
        private CheckBox checkBox1;
        private Image shopicon;
        private Label label1;
        private Button shopnamebtn;
        private Panel panel5;
        private Image image2;
    }
}