
namespace UI_Prototype_1
{
    partial class Gostergeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gostergeler));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.attitudeIndicatorInstrumentControl1 = new UI_Prototype_1.AttitudeIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new UI_Prototype_1.HeadingIndicatorInstrumentControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1152, 556);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.BackgroundImage")));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Minimize.BorderRadius = 0;
            this.btn_Minimize.ButtonText = "";
            this.btn_Minimize.CausesValidation = false;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Minimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Minimize.Iconimage = null;
            this.btn_Minimize.Iconimage_right = null;
            this.btn_Minimize.Iconimage_right_Selected = null;
            this.btn_Minimize.Iconimage_Selected = null;
            this.btn_Minimize.IconMarginLeft = 0;
            this.btn_Minimize.IconMarginRight = 0;
            this.btn_Minimize.IconRightVisible = true;
            this.btn_Minimize.IconRightZoom = 0D;
            this.btn_Minimize.IconVisible = true;
            this.btn_Minimize.IconZoom = 90D;
            this.btn_Minimize.IsTab = false;
            this.btn_Minimize.Location = new System.Drawing.Point(1224, 16);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Minimize.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_Minimize.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.selected = false;
            this.btn_Minimize.Size = new System.Drawing.Size(75, 58);
            this.btn_Minimize.TabIndex = 33;
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Minimize.Textcolor = System.Drawing.Color.White;
            this.btn_Minimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.CausesValidation = false;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = null;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(1332, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(75, 58);
            this.btnClose.TabIndex = 32;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(13, 106);
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
            this.gMap.Size = new System.Drawing.Size(848, 342);
            this.gMap.TabIndex = 34;
            this.gMap.Zoom = 13D;
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(879, 106);
            this.txtRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(182, 342);
            this.txtRead.TabIndex = 38;
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(300, 510);
            this.attitudeIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(214, 205);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 7;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(47, 510);
            this.headingIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(4);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(215, 209);
            this.headingIndicatorInstrumentControl1.TabIndex = 6;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // Gostergeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 771);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gostergeler";
            this.Text = "Gostergeler";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gostergeler_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
       
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Minimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Timer timer2;
    }
}