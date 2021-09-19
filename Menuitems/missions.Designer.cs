namespace UI_Prototype_1.Menuitems
{
    partial class missions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(missions));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtLattitude = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLongtitude = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 728);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1465, 43);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtLattitude
            // 
            this.txtLattitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLattitude.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtLattitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLattitude.HintForeColor = System.Drawing.Color.Empty;
            this.txtLattitude.HintText = "";
            this.txtLattitude.isPassword = false;
            this.txtLattitude.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLattitude.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLattitude.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLattitude.LineThickness = 3;
            this.txtLattitude.Location = new System.Drawing.Point(99, 215);
            this.txtLattitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLattitude.Name = "txtLattitude";
            this.txtLattitude.Size = new System.Drawing.Size(208, 35);
            this.txtLattitude.TabIndex = 11;
            this.txtLattitude.Text = "41,05149";
            this.txtLattitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLattitude.Visible = false;
            // 
            // txtLongtitude
            // 
            this.txtLongtitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongtitude.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtLongtitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLongtitude.HintForeColor = System.Drawing.Color.Empty;
            this.txtLongtitude.HintText = "";
            this.txtLongtitude.isPassword = false;
            this.txtLongtitude.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLongtitude.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLongtitude.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLongtitude.LineThickness = 3;
            this.txtLongtitude.Location = new System.Drawing.Point(99, 307);
            this.txtLongtitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongtitude.Name = "txtLongtitude";
            this.txtLongtitude.Size = new System.Drawing.Size(208, 35);
            this.txtLongtitude.TabIndex = 12;
            this.txtLongtitude.Text = "29,01191";
            this.txtLongtitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLongtitude.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Activecolor = System.Drawing.Color.Gold;
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
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
            this.btnLoad.Location = new System.Drawing.Point(86, 196);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Normalcolor = System.Drawing.Color.Gold;
            this.btnLoad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoad.selected = false;
            this.btnLoad.Size = new System.Drawing.Size(208, 35);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Uçuş Alanına Git";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Textcolor = System.Drawing.Color.White;
            this.btnLoad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
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
            this.gMap.Size = new System.Drawing.Size(1140, 540);
            this.gMap.TabIndex = 15;
            this.gMap.Zoom = 13D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 46);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // missions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtLongtitude);
            this.Controls.Add(this.txtLattitude);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "missions";
            this.Size = new System.Drawing.Size(1140, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLattitude;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLongtitude;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoad;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
