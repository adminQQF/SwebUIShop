using System;
using Swebui.Controls;
namespace SwebuiDemo.Demo
{
    partial class proLayout: SwebUserControl
    {
        #region "SmobilerUserControl generated code "

        public proLayout() : base()
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
            this.titleLab = new Swebui.Controls.Button();
            this.desLab = new Swebui.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.image1,
            this.titleLab,
            this.desLab});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.BorderRadius = 12;
            this.image1.Name = "image1";
            this.image1.ResouceData = null;
            this.image1.ResourceID = "";
            this.image1.Size = new System.Drawing.Size(215, 215);
            this.image1.SizeMode = Swebui.Controls.ImageSizeMode.Zoom;
            // 
            // titleLab
            // 
            this.titleLab.BackColor = System.Drawing.Color.White;
            this.titleLab.FontSize = 16F;
            this.titleLab.ForeColor = System.Drawing.Color.Black;
            this.titleLab.Margin = new Swebui.Controls.Margin(0F, 5F, 0F, 0F);
            this.titleLab.Name = "titleLab";
            this.titleLab.NumberOfLines = 1;
            this.titleLab.SelectBackgroundColor = System.Drawing.Color.White;
            this.titleLab.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.titleLab.SelectTextDecorationLine = Swebui.Controls.TextDecorationLineType.None;
            this.titleLab.Size = new System.Drawing.Size(0, 25);
            this.titleLab.Click += new System.EventHandler(this.panel1_Press);
            // 
            // desLab
            // 
            this.desLab.FontSize = 14F;
            this.desLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.desLab.Name = "desLab";
            this.desLab.NumberOfLines = 1;
            this.desLab.Size = new System.Drawing.Size(0, 0);
            // 
            // proLayout
            // 
            this.Controls.AddRange(new Swebui.Controls.SwebControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(215, 270);
            this.Load += new System.EventHandler(this.demoMap_Load);

        }
        #endregion

        private Panel panel1;
        private Image image1;
        private Button titleLab;
        private Label desLab;
    }
}