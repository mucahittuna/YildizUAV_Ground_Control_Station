namespace UI_Prototype_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHost = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAboutUs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMissions = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.bunifuGradientPanel1, "bunifuGradientPanel1");
            this.bunifuGradientPanel1.Controls.Add(this.txtPort);
            this.bunifuGradientPanel1.Controls.Add(this.txtHost);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btnConnect);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(158)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(158)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(158)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(158)))));
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuGradientPanel1_MouseDown);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(158)))));
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.ForeColor = System.Drawing.Color.White;
            this.txtPort.HintForeColor = System.Drawing.Color.Empty;
            this.txtPort.HintText = "";
            this.txtPort.isPassword = false;
            this.txtPort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtPort.LineIdleColor = System.Drawing.Color.White;
            this.txtPort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtPort.LineThickness = 3;
            this.txtPort.Name = "txtPort";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHost
            // 
            this.txtHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(158)))));
            this.txtHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtHost, "txtHost");
            this.txtHost.ForeColor = System.Drawing.Color.White;
            this.txtHost.HintForeColor = System.Drawing.Color.Empty;
            this.txtHost.HintText = "";
            this.txtHost.isPassword = false;
            this.txtHost.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtHost.LineIdleColor = System.Drawing.Color.White;
            this.txtHost.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtHost.LineThickness = 3;
            this.txtHost.Name = "txtHost";
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton4, "bunifuFlatButton4");
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.CausesValidation = false;
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton3, "bunifuFlatButton3");
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.CausesValidation = false;
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton2, "bunifuFlatButton2");
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.CausesValidation = false;
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnConnect
            // 
            this.btnConnect.Activecolor = System.Drawing.Color.Transparent;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.BorderRadius = 0;
            this.btnConnect.ButtonText = "";
            this.btnConnect.CausesValidation = false;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConnect.Iconimage = null;
            this.btnConnect.Iconimage_right = null;
            this.btnConnect.Iconimage_right_Selected = null;
            this.btnConnect.Iconimage_Selected = null;
            this.btnConnect.IconMarginLeft = 0;
            this.btnConnect.IconMarginRight = 0;
            this.btnConnect.IconRightVisible = true;
            this.btnConnect.IconRightZoom = 0D;
            this.btnConnect.IconVisible = true;
            this.btnConnect.IconZoom = 90D;
            this.btnConnect.IsTab = false;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConnect.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConnect.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnConnect.selected = false;
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Textcolor = System.Drawing.Color.White;
            this.btnConnect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // bunifuGradientPanel2
            // 
            resources.ApplyResources(this.bunifuGradientPanel2, "bunifuGradientPanel2");
            this.bunifuGradientPanel2.Controls.Add(this.btnSettings);
            this.bunifuGradientPanel2.Controls.Add(this.btnAboutUs);
            this.bunifuGradientPanel2.Controls.Add(this.btnMissions);
            this.bunifuGradientPanel2.Controls.Add(this.btnHome);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(155)))));
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.DarkRed;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "GÖSTERGELER";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 60D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSettings.selected = false;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Activecolor = System.Drawing.Color.DarkRed;
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAboutUs, "btnAboutUs");
            this.btnAboutUs.BorderRadius = 0;
            this.btnAboutUs.ButtonText = "DRONE BİLGİLERİ";
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.DisabledColor = System.Drawing.Color.Gray;
            this.btnAboutUs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAboutUs.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Iconimage")));
            this.btnAboutUs.Iconimage_right = null;
            this.btnAboutUs.Iconimage_right_Selected = null;
            this.btnAboutUs.Iconimage_Selected = null;
            this.btnAboutUs.IconMarginLeft = 0;
            this.btnAboutUs.IconMarginRight = 0;
            this.btnAboutUs.IconRightVisible = true;
            this.btnAboutUs.IconRightZoom = 0D;
            this.btnAboutUs.IconVisible = true;
            this.btnAboutUs.IconZoom = 60D;
            this.btnAboutUs.IsTab = false;
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAboutUs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnAboutUs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAboutUs.selected = false;
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAboutUs.Textcolor = System.Drawing.Color.White;
            this.btnAboutUs.TextFont = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnMissions
            // 
            this.btnMissions.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btnMissions.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMissions, "btnMissions");
            this.btnMissions.BorderRadius = 0;
            this.btnMissions.ButtonText = "HARİTA";
            this.btnMissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMissions.DisabledColor = System.Drawing.Color.Gray;
            this.btnMissions.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMissions.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMissions.Iconimage")));
            this.btnMissions.Iconimage_right = null;
            this.btnMissions.Iconimage_right_Selected = null;
            this.btnMissions.Iconimage_Selected = null;
            this.btnMissions.IconMarginLeft = 0;
            this.btnMissions.IconMarginRight = 0;
            this.btnMissions.IconRightVisible = true;
            this.btnMissions.IconRightZoom = 0D;
            this.btnMissions.IconVisible = true;
            this.btnMissions.IconZoom = 60D;
            this.btnMissions.IsTab = false;
            this.btnMissions.Name = "btnMissions";
            this.btnMissions.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMissions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnMissions.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMissions.selected = false;
            this.btnMissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMissions.Textcolor = System.Drawing.Color.White;
            this.btnMissions.TextFont = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMissions.Click += new System.EventHandler(this.btnMissions_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "UÇUŞ BİLGİLERİ";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 60D;
            this.btnHome.IsTab = false;
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuFlatButton1, "bunifuFlatButton1");
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(155)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuGradientPanel3
            // 
            resources.ApplyResources(this.bunifuGradientPanel3, "bunifuGradientPanel3");
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.SeaShell;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.bunifuGradientPanel4, "bunifuGradientPanel4");
            this.bunifuGradientPanel4.Controls.Add(this.lblStatus);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(168)))));
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(168)))));
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Name = "lblStatus";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnAboutUs;
        private Bunifu.Framework.UI.BunifuFlatButton btnMissions;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStatus;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
      
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHost;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPort;
    }
}

