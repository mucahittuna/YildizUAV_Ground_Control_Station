
namespace UI_Prototype_1
{
    partial class Harita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Harita));
            this.BtnRouteSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtLongtitude = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLattitude = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblHiz = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRouteSend
            // 
            this.BtnRouteSend.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.BtnRouteSend.BackColor = System.Drawing.Color.Transparent;
            this.BtnRouteSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRouteSend.BorderRadius = 0;
            this.BtnRouteSend.ButtonText = "Rotayı Gönder";
            this.BtnRouteSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRouteSend.DisabledColor = System.Drawing.Color.Gray;
            this.BtnRouteSend.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnRouteSend.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnRouteSend.Iconimage")));
            this.BtnRouteSend.Iconimage_right = null;
            this.BtnRouteSend.Iconimage_right_Selected = null;
            this.BtnRouteSend.Iconimage_Selected = null;
            this.BtnRouteSend.IconMarginLeft = 0;
            this.BtnRouteSend.IconMarginRight = 0;
            this.BtnRouteSend.IconRightVisible = true;
            this.BtnRouteSend.IconRightZoom = 0D;
            this.BtnRouteSend.IconVisible = true;
            this.BtnRouteSend.IconZoom = 90D;
            this.BtnRouteSend.IsTab = false;
            this.BtnRouteSend.Location = new System.Drawing.Point(1550, 522);
            this.BtnRouteSend.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRouteSend.Name = "BtnRouteSend";
            this.BtnRouteSend.Normalcolor = System.Drawing.Color.Transparent;
            this.BtnRouteSend.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.BtnRouteSend.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnRouteSend.selected = false;
            this.BtnRouteSend.Size = new System.Drawing.Size(384, 96);
            this.BtnRouteSend.TabIndex = 28;
            this.BtnRouteSend.Text = "Rotayı Gönder";
            this.BtnRouteSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRouteSend.Textcolor = System.Drawing.Color.White;
            this.BtnRouteSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRouteSend.Click += new System.EventHandler(this.BtnRouteSend_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Rotayı Sıfırla";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1550, 637);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(384, 96);
            this.bunifuFlatButton1.TabIndex = 27;
            this.bunifuFlatButton1.Text = "Rotayı Sıfırla";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1607, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Boylam :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1607, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enlem :";
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(16, 52);
            this.gMap.Margin = new System.Windows.Forms.Padding(4);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1525, 681);
            this.gMap.TabIndex = 24;
            this.gMap.Zoom = 13D;
            // 
            // btnLoad
            // 
            this.btnLoad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.BorderRadius = 0;
            this.btnLoad.ButtonText = "Uçuş Alanına Git";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLoad.Iconimage")));
            this.btnLoad.Iconimage_right = null;
            this.btnLoad.Iconimage_right_Selected = null;
            this.btnLoad.Iconimage_Selected = null;
            this.btnLoad.IconMarginLeft = 0;
            this.btnLoad.IconMarginRight = 0;
            this.btnLoad.IconRightVisible = true;
            this.btnLoad.IconRightZoom = 0D;
            this.btnLoad.IconVisible = true;
            this.btnLoad.IconZoom = 90D;
            this.btnLoad.IsTab = false;
            this.btnLoad.Location = new System.Drawing.Point(1550, 416);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLoad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.btnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoad.selected = false;
            this.btnLoad.Size = new System.Drawing.Size(384, 96);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Uçuş Alanına Git";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Textcolor = System.Drawing.Color.White;
            this.btnLoad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtLongtitude
            // 
            this.txtLongtitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongtitude.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtLongtitude.ForeColor = System.Drawing.Color.White;
            this.txtLongtitude.HintForeColor = System.Drawing.Color.Empty;
            this.txtLongtitude.HintText = "";
            this.txtLongtitude.isPassword = false;
            this.txtLongtitude.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtLongtitude.LineIdleColor = System.Drawing.Color.White;
            this.txtLongtitude.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtLongtitude.LineThickness = 3;
            this.txtLongtitude.Location = new System.Drawing.Point(1613, 294);
            this.txtLongtitude.Margin = new System.Windows.Forms.Padding(5);
            this.txtLongtitude.Name = "txtLongtitude";
            this.txtLongtitude.Size = new System.Drawing.Size(277, 43);
            this.txtLongtitude.TabIndex = 22;
            this.txtLongtitude.Text = "29,0085271";
            this.txtLongtitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLattitude
            // 
            this.txtLattitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLattitude.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtLattitude.ForeColor = System.Drawing.Color.White;
            this.txtLattitude.HintForeColor = System.Drawing.Color.Empty;
            this.txtLattitude.HintText = "";
            this.txtLattitude.isPassword = false;
            this.txtLattitude.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtLattitude.LineIdleColor = System.Drawing.Color.White;
            this.txtLattitude.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(46)))), ((int)(((byte)(200)))));
            this.txtLattitude.LineThickness = 3;
            this.txtLattitude.Location = new System.Drawing.Point(1613, 181);
            this.txtLattitude.Margin = new System.Windows.Forms.Padding(5);
            this.txtLattitude.Name = "txtLattitude";
            this.txtLattitude.Size = new System.Drawing.Size(277, 43);
            this.txtLattitude.TabIndex = 21;
            this.txtLattitude.Text = "40,2308389";
            this.txtLattitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.BackgroundImage")));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1876, 16);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(75, 58);
            this.bunifuFlatButton3.TabIndex = 29;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.BackgroundImage")));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(1763, 16);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(75, 58);
            this.bunifuFlatButton4.TabIndex = 30;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 30;
            this.trackBar1.Location = new System.Drawing.Point(124, 767);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(500, 38);
            this.trackBar1.TabIndex = 31;
            // 
            // lblHiz
            // 
            this.lblHiz.AutoSize = true;
            this.lblHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHiz.ForeColor = System.Drawing.Color.White;
            this.lblHiz.Location = new System.Drawing.Point(673, 767);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(81, 29);
            this.lblHiz.TabIndex = 32;
            this.lblHiz.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 767);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "HIZ :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Harita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1942, 835);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHiz);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.BtnRouteSend);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtLongtitude);
            this.Controls.Add(this.txtLattitude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Harita";
            this.Text = "E";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Harita_FormClosed);
            this.Load += new System.EventHandler(this.Harita_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Harita_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnRouteSend;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLongtitude;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLattitude;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblHiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}