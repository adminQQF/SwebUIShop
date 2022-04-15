using System;
using Swebui.Controls;
namespace SwebuiDemo
{
    partial class cartListLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public cartListLayout() : base()
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
            this.proImg = new Swebui.Controls.Image();
            this.panel2 = new Swebui.Controls.Panel();
            this.proName = new Swebui.Controls.Button();
            this.panel3 = new Swebui.Controls.Panel();
            this.promoImg1 = new Swebui.Controls.Image();
            this.promoImg2 = new Swebui.Controls.Image();
            this.promoImg3 = new Swebui.Controls.Image();
            this.promoImg4 = new Swebui.Controls.Image();
            this.panel4 = new Swebui.Controls.Panel();
            this.typeLab = new Swebui.Controls.Label();
            this.priceLab = new Swebui.Controls.Label();
            this.subBtn = new Swebui.Controls.Button();
            this.numText = new Swebui.Controls.TextBox();
            this.plusBtn = new Swebui.Controls.Button();
            this.allLab = new Swebui.Controls.Label();
            this.panel5 = new Swebui.Controls.Panel();
            this.favbtn = new Swebui.Controls.Button();
            this.delbtn = new Swebui.Controls.Button();
            this.findbtn = new Swebui.Controls.Button();
            // 
            // panel1
            // 
            this.panel1.Border = new Swebui.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.checkBox1,
            this.proImg,
            this.panel2,
            this.panel4,
            this.priceLab,
            this.subBtn,
            this.numText,
            this.plusBtn,
            this.allLab,
            this.panel5});
            this.panel1.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Swebui.Controls.Padding(25F, 16F, 0F, 16F);
            this.panel1.Size = new System.Drawing.Size(0, 132);
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
            // proImg
            // 
            this.proImg.DisplayMember = "proimg";
            this.proImg.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.proImg.Name = "proImg";
            this.proImg.ResourceID = "";
            this.proImg.Size = new System.Drawing.Size(80, 80);
            this.proImg.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.proName,
            this.panel3});
            this.panel2.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 80);
            // 
            // proName
            // 
            this.proName.BackColor = System.Drawing.Color.Transparent;
            this.proName.DisplayMember = "prodes";
            this.proName.FontSize = 12F;
            this.proName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.proName.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.proName.LineHeight = 12F;
            this.proName.Name = "proName";
            this.proName.NumberOfLines = 2;
            this.proName.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.proName.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.proName.Size = new System.Drawing.Size(226, 35);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.promoImg1,
            this.promoImg2,
            this.promoImg3,
            this.promoImg4});
            this.panel3.Direction = Swebui.Controls.LayoutDirection.Row;
            this.panel3.ItemAlign = Swebui.Controls.LayoutItemAlign.Center;
            this.panel3.Margin = new Swebui.Controls.Margin(0F, 16F, 0F, 0F);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 24);
            // 
            // promoImg1
            // 
            this.promoImg1.BindDisplayValueGone = true;
            this.promoImg1.DisplayMember = "promo1";
            this.promoImg1.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.promoImg1.Name = "promoImg1";
            this.promoImg1.ResourceID = "";
            this.promoImg1.Size = new System.Drawing.Size(14, 16);
            this.promoImg1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.promoImg1.Visible = false;
            // 
            // promoImg2
            // 
            this.promoImg2.BindDisplayValueGone = true;
            this.promoImg2.DisplayMember = "promo2";
            this.promoImg2.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.promoImg2.Name = "promoImg2";
            this.promoImg2.ResourceID = "";
            this.promoImg2.Size = new System.Drawing.Size(14, 16);
            this.promoImg2.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.promoImg2.Visible = false;
            // 
            // promoImg3
            // 
            this.promoImg3.BindDisplayValueGone = true;
            this.promoImg3.DisplayMember = "promo3";
            this.promoImg3.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.promoImg3.Name = "promoImg3";
            this.promoImg3.ResourceID = "";
            this.promoImg3.Size = new System.Drawing.Size(15, 16);
            this.promoImg3.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.promoImg3.Visible = false;
            // 
            // promoImg4
            // 
            this.promoImg4.BindDisplayValueGone = true;
            this.promoImg4.DisplayMember = "promo4";
            this.promoImg4.Margin = new Swebui.Controls.Margin(0F, 0F, 5F, 0F);
            this.promoImg4.Name = "promoImg4";
            this.promoImg4.ResourceID = "";
            this.promoImg4.Size = new System.Drawing.Size(15, 16);
            this.promoImg4.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            this.promoImg4.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.typeLab});
            this.panel4.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 80);
            // 
            // typeLab
            // 
            this.typeLab.DisplayMember = "type";
            this.typeLab.FontSize = 12F;
            this.typeLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.typeLab.Name = "typeLab";
            this.typeLab.Size = new System.Drawing.Size(0, 35);
            this.typeLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // priceLab
            // 
            this.priceLab.Bold = true;
            this.priceLab.DisplayMember = "price";
            this.priceLab.FontSize = 12F;
            this.priceLab.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(119, 34);
            this.priceLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.subBtn.Name = "subBtn";
            this.subBtn.NumberOfLines = 0;
            this.subBtn.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.subBtn.Size = new System.Drawing.Size(25, 25);
            this.subBtn.Text = "-";
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // numText
            // 
            this.numText.Border = new Swebui.Controls.Border(1F);
            this.numText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numText.DisplayMember = "num";
            this.numText.FontSize = 12F;
            this.numText.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Center;
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(41, 25);
            this.numText.TextChanged += new System.EventHandler(this.numText_TextChanged);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plusBtn.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.NumberOfLines = 0;
            this.plusBtn.SelectBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plusBtn.Size = new System.Drawing.Size(25, 25);
            this.plusBtn.Text = "+";
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // allLab
            // 
            this.allLab.Bold = true;
            this.allLab.DisplayMember = "all";
            this.allLab.FontSize = 12F;
            this.allLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.allLab.Margin = new Swebui.Controls.Margin(0F, 0F, 10F, 0F);
            this.allLab.Name = "allLab";
            this.allLab.Size = new System.Drawing.Size(119, 34);
            this.allLab.VerticalAlignment = Swebui.Controls.VerticalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.favbtn,
            this.delbtn,
            this.findbtn});
            this.panel5.Name = "panel5";
            this.panel5.RaiseMouseEvent = true;
            this.panel5.Size = new System.Drawing.Size(119, 0);
            this.panel5.MouseEnter += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel5_MouseEnter);
            this.panel5.MouseLeave += new Swebui.Controls.SwebMouseMoveEventHandler(this.panel5_MouseLeave);
            // 
            // favbtn
            // 
            this.favbtn.BackColor = System.Drawing.Color.Transparent;
            this.favbtn.FontSize = 12F;
            this.favbtn.ForeColor = System.Drawing.Color.Black;
            this.favbtn.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.favbtn.Name = "favbtn";
            this.favbtn.NumberOfLines = 0;
            this.favbtn.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.favbtn.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.favbtn.Size = new System.Drawing.Size(0, 25);
            this.favbtn.Text = "“∆»Î ’≤ÿº–";
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.Transparent;
            this.delbtn.FontSize = 12F;
            this.delbtn.ForeColor = System.Drawing.Color.Black;
            this.delbtn.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.delbtn.Name = "delbtn";
            this.delbtn.NumberOfLines = 0;
            this.delbtn.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.delbtn.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.delbtn.Size = new System.Drawing.Size(0, 25);
            this.delbtn.Text = "…æ≥˝";
            // 
            // findbtn
            // 
            this.findbtn.BackColor = System.Drawing.Color.Transparent;
            this.findbtn.FontSize = 12F;
            this.findbtn.ForeColor = System.Drawing.Color.Black;
            this.findbtn.HorizontalAlignment = Swebui.Controls.HorizontalAlignment.Left;
            this.findbtn.Name = "findbtn";
            this.findbtn.NumberOfLines = 0;
            this.findbtn.SelectBackgroundColor = System.Drawing.Color.Transparent;
            this.findbtn.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.findbtn.Size = new System.Drawing.Size(0, 25);
            this.findbtn.Text = "œ‡À∆±¶±¥";
            this.findbtn.Visible = false;
            // 
            // cartListLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Border = new Swebui.Controls.Border(0F, 0F, 0F, 1F);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(1198, 134);

        }
        #endregion

        private Panel panel1;
        private CheckBox checkBox1;
        private Image proImg;
        private Panel panel2;
        private Button proName;
        private Panel panel3;
        private Image promoImg1;
        private Image promoImg2;
        private Image promoImg3;
        private Image promoImg4;
        private Panel panel4;
        private Label typeLab;
        private Label priceLab;
        private Button subBtn;
        private TextBox numText;
        private Button plusBtn;
        private Label allLab;
        private Panel panel5;
        private Button favbtn;
        private Button delbtn;
        private Button findbtn;
    }
}