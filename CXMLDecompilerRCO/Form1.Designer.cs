
namespace CXMLDecompilerRCO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.darkContextMenu1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRCOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkTextBox3 = new DarkUI.Controls.DarkTextBox();
            this.darkLabelSend = new DarkUI.Controls.DarkLabel();
            this.buttonBrowseRCO = new System.Windows.Forms.Button();
            this.buttonSendRCO = new System.Windows.Forms.Button();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.butSaveIP = new System.Windows.Forms.Button();
            this.ipbox = new DarkUI.Controls.DarkTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.portbox = new DarkUI.Controls.DarkTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.labelBuild = new System.Windows.Forms.Label();
            this.buttonTopMenu = new System.Windows.Forms.Button();
            this.buttonApplicationExit = new System.Windows.Forms.Button();
            this.buttonPkgInstaller = new System.Windows.Forms.Button();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.darkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.panelhome = new System.Windows.Forms.Panel();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.darkContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.darkSectionPanel2.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.darkSectionPanel1.SuspendLayout();
            this.darkGroupBox3.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // darkContextMenu1
            // 
            this.darkContextMenu1.BackColor = System.Drawing.SystemColors.Control;
            this.darkContextMenu1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.darkContextMenu1.Location = new System.Drawing.Point(0, 0);
            this.darkContextMenu1.Name = "darkContextMenu1";
            this.darkContextMenu1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.darkContextMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.darkContextMenu1.Size = new System.Drawing.Size(1021, 24);
            this.darkContextMenu1.TabIndex = 0;
            this.darkContextMenu1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRCOToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Image = global::CXMLDecompilerRCO.Properties.Resources.open_folder0;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openRCOToolStripMenuItem
            // 
            this.openRCOToolStripMenuItem.Image = global::CXMLDecompilerRCO.Properties.Resources.open_folder0;
            this.openRCOToolStripMenuItem.Name = "openRCOToolStripMenuItem";
            this.openRCOToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openRCOToolStripMenuItem.Text = "Open RCO";
            this.openRCOToolStripMenuItem.Click += new System.EventHandler(this.openRCOToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CXMLDecompilerRCO.Properties.Resources.open_folder0;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Open XML";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(8, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "\\";
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(0, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = " ";
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CXMLDecompilerRCO.Properties.Resources.rco_logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 59);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.darkTextBox3);
            this.darkSectionPanel2.Controls.Add(this.darkLabelSend);
            this.darkSectionPanel2.Controls.Add(this.buttonBrowseRCO);
            this.darkSectionPanel2.Controls.Add(this.buttonSendRCO);
            this.darkSectionPanel2.Location = new System.Drawing.Point(877, 87);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = null;
            this.darkSectionPanel2.Size = new System.Drawing.Size(141, 503);
            this.darkSectionPanel2.TabIndex = 13;
            // 
            // darkTextBox3
            // 
            this.darkTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.darkTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.darkTextBox3.Location = new System.Drawing.Point(4, 87);
            this.darkTextBox3.Multiline = true;
            this.darkTextBox3.Name = "darkTextBox3";
            this.darkTextBox3.Size = new System.Drawing.Size(133, 110);
            this.darkTextBox3.TabIndex = 9;
            // 
            // darkLabelSend
            // 
            this.darkLabelSend.AutoSize = true;
            this.darkLabelSend.BackColor = System.Drawing.Color.DodgerBlue;
            this.darkLabelSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.darkLabelSend.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.darkLabelSend.ForeColor = System.Drawing.Color.White;
            this.darkLabelSend.Location = new System.Drawing.Point(2, 3);
            this.darkLabelSend.Name = "darkLabelSend";
            this.darkLabelSend.Size = new System.Drawing.Size(130, 20);
            this.darkLabelSend.TabIndex = 8;
            this.darkLabelSend.Text = "Send a file to PS4";
            // 
            // buttonBrowseRCO
            // 
            this.buttonBrowseRCO.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBrowseRCO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrowseRCO.ForeColor = System.Drawing.Color.White;
            this.buttonBrowseRCO.Location = new System.Drawing.Point(4, 29);
            this.buttonBrowseRCO.Name = "buttonBrowseRCO";
            this.buttonBrowseRCO.Size = new System.Drawing.Size(133, 23);
            this.buttonBrowseRCO.TabIndex = 6;
            this.buttonBrowseRCO.Text = "Browse RCO";
            this.buttonBrowseRCO.UseVisualStyleBackColor = false;
            this.buttonBrowseRCO.Click += new System.EventHandler(this.buttonBrowseRCO_Click);
            // 
            // buttonSendRCO
            // 
            this.buttonSendRCO.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSendRCO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendRCO.ForeColor = System.Drawing.Color.White;
            this.buttonSendRCO.Location = new System.Drawing.Point(4, 58);
            this.buttonSendRCO.Name = "buttonSendRCO";
            this.buttonSendRCO.Size = new System.Drawing.Size(133, 23);
            this.buttonSendRCO.TabIndex = 7;
            this.buttonSendRCO.Text = "Send RCO";
            this.buttonSendRCO.UseVisualStyleBackColor = false;
            this.buttonSendRCO.Click += new System.EventHandler(this.buttonSendRCO_Click);
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.darkGroupBox2.Controls.Add(this.butSaveIP);
            this.darkGroupBox2.Controls.Add(this.ipbox);
            this.darkGroupBox2.Controls.Add(this.label6);
            this.darkGroupBox2.Controls.Add(this.portbox);
            this.darkGroupBox2.Controls.Add(this.label5);
            this.darkGroupBox2.Location = new System.Drawing.Point(524, 25);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(350, 60);
            this.darkGroupBox2.TabIndex = 0;
            this.darkGroupBox2.TabStop = false;
            // 
            // butSaveIP
            // 
            this.butSaveIP.BackColor = System.Drawing.Color.DodgerBlue;
            this.butSaveIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSaveIP.ForeColor = System.Drawing.Color.White;
            this.butSaveIP.Location = new System.Drawing.Point(159, 5);
            this.butSaveIP.Name = "butSaveIP";
            this.butSaveIP.Size = new System.Drawing.Size(67, 22);
            this.butSaveIP.TabIndex = 6;
            this.butSaveIP.Text = "Save IP ";
            this.butSaveIP.UseVisualStyleBackColor = false;
            this.butSaveIP.Click += new System.EventHandler(this.butSaveIP_Click);
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.ipbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ipbox.Location = new System.Drawing.Point(45, 5);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(108, 23);
            this.ipbox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Port";
            // 
            // portbox
            // 
            this.portbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.portbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.portbox.Location = new System.Drawing.Point(45, 34);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(108, 23);
            this.portbox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "PS4 IP";
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.darkSectionPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkSectionPanel1.Controls.Add(this.labelBuild);
            this.darkSectionPanel1.Controls.Add(this.buttonTopMenu);
            this.darkSectionPanel1.Controls.Add(this.buttonApplicationExit);
            this.darkSectionPanel1.Controls.Add(this.buttonPkgInstaller);
            this.darkSectionPanel1.Controls.Add(this.buttonNotification);
            this.darkSectionPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.darkSectionPanel1.Location = new System.Drawing.Point(2, 87);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = null;
            this.darkSectionPanel1.Size = new System.Drawing.Size(141, 503);
            this.darkSectionPanel1.TabIndex = 11;
            // 
            // labelBuild
            // 
            this.labelBuild.AutoSize = true;
            this.labelBuild.BackColor = System.Drawing.Color.Transparent;
            this.labelBuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuild.ForeColor = System.Drawing.Color.White;
            this.labelBuild.Location = new System.Drawing.Point(-1, 1);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(14, 21);
            this.labelBuild.TabIndex = 6;
            this.labelBuild.Text = ".";
            // 
            // buttonTopMenu
            // 
            this.buttonTopMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonTopMenu.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonTopMenu.FlatAppearance.BorderSize = 2;
            this.buttonTopMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(222)))));
            this.buttonTopMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonTopMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopMenu.ForeColor = System.Drawing.Color.Black;
            this.buttonTopMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonTopMenu.Image")));
            this.buttonTopMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTopMenu.Location = new System.Drawing.Point(3, 154);
            this.buttonTopMenu.Name = "buttonTopMenu";
            this.buttonTopMenu.Size = new System.Drawing.Size(132, 42);
            this.buttonTopMenu.TabIndex = 10;
            this.buttonTopMenu.Text = "    TopMenu";
            this.buttonTopMenu.UseVisualStyleBackColor = false;
            this.buttonTopMenu.Click += new System.EventHandler(this.buttonTopMenu_Click);
            // 
            // buttonApplicationExit
            // 
            this.buttonApplicationExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonApplicationExit.Enabled = false;
            this.buttonApplicationExit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonApplicationExit.FlatAppearance.BorderSize = 2;
            this.buttonApplicationExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(222)))));
            this.buttonApplicationExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonApplicationExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplicationExit.ForeColor = System.Drawing.Color.Black;
            this.buttonApplicationExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonApplicationExit.Image")));
            this.buttonApplicationExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApplicationExit.Location = new System.Drawing.Point(3, 28);
            this.buttonApplicationExit.Name = "buttonApplicationExit";
            this.buttonApplicationExit.Size = new System.Drawing.Size(132, 42);
            this.buttonApplicationExit.TabIndex = 7;
            this.buttonApplicationExit.Text = "ApplicationExit";
            this.buttonApplicationExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonApplicationExit.UseVisualStyleBackColor = false;
            // 
            // buttonPkgInstaller
            // 
            this.buttonPkgInstaller.BackColor = System.Drawing.Color.Transparent;
            this.buttonPkgInstaller.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonPkgInstaller.FlatAppearance.BorderSize = 2;
            this.buttonPkgInstaller.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(222)))));
            this.buttonPkgInstaller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPkgInstaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPkgInstaller.ForeColor = System.Drawing.Color.Black;
            this.buttonPkgInstaller.Image = ((System.Drawing.Image)(resources.GetObject("buttonPkgInstaller.Image")));
            this.buttonPkgInstaller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPkgInstaller.Location = new System.Drawing.Point(3, 112);
            this.buttonPkgInstaller.Name = "buttonPkgInstaller";
            this.buttonPkgInstaller.Size = new System.Drawing.Size(132, 42);
            this.buttonPkgInstaller.TabIndex = 9;
            this.buttonPkgInstaller.Text = "       PkgInstaller";
            this.buttonPkgInstaller.UseVisualStyleBackColor = false;
            this.buttonPkgInstaller.Click += new System.EventHandler(this.buttonPkgInstaller_Click);
            // 
            // buttonNotification
            // 
            this.buttonNotification.BackColor = System.Drawing.Color.Transparent;
            this.buttonNotification.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonNotification.FlatAppearance.BorderSize = 2;
            this.buttonNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(222)))));
            this.buttonNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotification.ForeColor = System.Drawing.Color.Black;
            this.buttonNotification.Image = ((System.Drawing.Image)(resources.GetObject("buttonNotification.Image")));
            this.buttonNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotification.Location = new System.Drawing.Point(3, 70);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(132, 42);
            this.buttonNotification.TabIndex = 8;
            this.buttonNotification.Text = "       Notification";
            this.buttonNotification.UseVisualStyleBackColor = false;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // darkGroupBox3
            // 
            this.darkGroupBox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.darkGroupBox3.Controls.Add(this.panelhome);
            this.darkGroupBox3.Location = new System.Drawing.Point(146, 87);
            this.darkGroupBox3.Name = "darkGroupBox3";
            this.darkGroupBox3.Size = new System.Drawing.Size(729, 503);
            this.darkGroupBox3.TabIndex = 9;
            this.darkGroupBox3.TabStop = false;
            // 
            // panelhome
            // 
            this.panelhome.Location = new System.Drawing.Point(1, 1);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(727, 499);
            this.panelhome.TabIndex = 7;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.darkGroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.darkGroupBox1.Controls.Add(this.button1);
            this.darkGroupBox1.Controls.Add(this.label2);
            this.darkGroupBox1.Controls.Add(this.button2);
            this.darkGroupBox1.Controls.Add(this.label1);
            this.darkGroupBox1.Location = new System.Drawing.Point(146, 25);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(377, 60);
            this.darkGroupBox1.TabIndex = 0;
            this.darkGroupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decompile RCO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(140, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = ".";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Recompile RCO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CXMLDecompilerRCO.Properties.Resources.rco_logo;
            this.pictureBox2.Location = new System.Drawing.Point(877, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 59);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1021, 595);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.darkGroupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.darkContextMenu1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.darkContextMenu1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CXMLDecompilerRCO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.darkContextMenu1.ResumeLayout(false);
            this.darkContextMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkGroupBox3.ResumeLayout(false);
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip darkContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRCOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBuild;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.Button buttonApplicationExit;
        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.Button buttonPkgInstaller;
        private System.Windows.Forms.Button buttonTopMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private System.Windows.Forms.Label label3;
        private DarkUI.Controls.DarkTextBox portbox;
        private DarkUI.Controls.DarkTextBox ipbox;
        private DarkUI.Controls.DarkGroupBox darkGroupBox3;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private System.Windows.Forms.Button buttonSendRCO;
        private System.Windows.Forms.Button buttonBrowseRCO;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkLabel darkLabelSend;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DarkUI.Controls.DarkTextBox darkTextBox3;
        private System.Windows.Forms.Button butSaveIP;
    }
}

