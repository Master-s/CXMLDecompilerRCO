
namespace CXMLDecompilerRCO
{
    partial class CommonAssets
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Progress0 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBinPkg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CXMLDecompilerRCO.Properties.Resources.PS5PKG00;
            this.panel1.Controls.Add(this.pictureBoxHome);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Progress0);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonBinPkg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 507);
            this.panel1.TabIndex = 111;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHome.Location = new System.Drawing.Point(12, 133);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 115;
            this.pictureBoxHome.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(99, 3);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(413, 31);
            this.textBox10.TabIndex = 114;
            this.textBox10.Text = ".";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Aqua",
            "Blue",
            "Chartreuse",
            "DarkGoldenrod",
            "EGGPLANT",
            "Fuchsia",
            "Gold"});
            this.comboBox1.Location = new System.Drawing.Point(12, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 111;
            // 
            // Progress0
            // 
            this.Progress0.AutoSize = true;
            this.Progress0.BackColor = System.Drawing.Color.Transparent;
            this.Progress0.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress0.ForeColor = System.Drawing.Color.White;
            this.Progress0.Location = new System.Drawing.Point(11, 65);
            this.Progress0.Name = "Progress0";
            this.Progress0.Size = new System.Drawing.Size(52, 13);
            this.Progress0.TabIndex = 113;
            this.Progress0.Text = "Progress";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 112;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonBinPkg
            // 
            this.buttonBinPkg.BackColor = System.Drawing.Color.Transparent;
            this.buttonBinPkg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBinPkg.ForeColor = System.Drawing.Color.White;
            this.buttonBinPkg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBinPkg.Location = new System.Drawing.Point(3, 3);
            this.buttonBinPkg.Name = "buttonBinPkg";
            this.buttonBinPkg.Size = new System.Drawing.Size(90, 27);
            this.buttonBinPkg.TabIndex = 109;
            this.buttonBinPkg.Text = "Open Folder";
            this.buttonBinPkg.UseVisualStyleBackColor = false;
            this.buttonBinPkg.Click += new System.EventHandler(this.buttonBinPkg_Click);
            // 
            // CommonAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommonAssets";
            this.Text = "CommonAssets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBinPkg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Progress0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.PictureBox pictureBoxHome;
    }
}