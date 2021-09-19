namespace UI_Prototype_1.Menuitems
{
    partial class settings
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
            this.txtRead = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(172, 155);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(279, 307);
            this.txtRead.TabIndex = 0;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(579, 155);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(279, 307);
            this.txtSend.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.Location = new System.Drawing.Point(727, 480);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 49);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtRead);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(1127, 653);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
    }
}
