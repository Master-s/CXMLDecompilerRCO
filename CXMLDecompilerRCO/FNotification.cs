using CXMLDecompilerRCO.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CXMLDecompilerRCO
{
    public partial class FNotification : Form
    {
        public FNotification()
        {
            InitializeComponent();
            panel7.BackColor = Color.FromArgb(190, 0, 0, 0);
            panelcolor2.BackColor = Color.FromArgb(255, 255, 254);
        }

        private void buttonBin_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "layout_notification_msg_panel.bin")
                {

                    MessageBox.Show("This file should be. layout_notification_msg_panel.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.labelbin.Text = this.openFileDialog1.SafeFileName;
                    label5.Text = "NotificationMsgPanel";
                    label6.Text = "UserNamePanel";
                    label7.Text = "UserNameSeparator";
                    label8.Text = "UserAvatar";
                    pictureBox1.Image = Resources.tex_bg_notification;
                    pictureBox2.Image = Resources.tex_bg_notification0;
                    pictureBox3.Image = Resources.psnotification0;
                    pictureBox4.Image = Resources.psnotificationc1;
                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //color
            //NotificationMsgPanel
            if (comboBox1.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00, 0x0A };
                this.labelColor1.BackColor = Color.Transparent;
                this.labelColor1.Text = "9A 99 19 3F 9A 99 19 3F 9A 99 19 3F 00 00 00 00 0A";
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Transparent;
                this.panel6.BackColor = Color.Transparent;
            }
            if (comboBox1.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.BackColor = Color.Lime;
                this.labelColor1.Text = "AD AC AC 3E AD AC AC 4E AD AC AC 2F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Lime;
                this.panel6.BackColor = Color.Lime;
            }
            if (comboBox1.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "AD AC AC 2E AD AC AC 4E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Cyan;
                this.panel6.BackColor = Color.Cyan;
            }
            if (comboBox1.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "AD AC AC 2E AD AC AC 3E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                this.panel5.BackColor = Color.FromArgb(0, 81, 255);
                this.panel6.BackColor = Color.FromArgb(0, 81, 255);
            }
            if (comboBox1.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.ForeColor = Color.Blue;
                this.labelColor1.Text = "AD AC AC 2E AD AC AC 2E AD AC AC 3F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Blue;
                this.panel6.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "AD AC AC 4E AD AC AC 4E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.White;
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                this.panel5.BackColor = Color.White;
                this.panel6.BackColor = Color.White;
            }
            if (comboBox1.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "AD AC AC 4E AD AC AC 3E AD AC AC 1F 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Orange;
                this.panel6.BackColor = Color.Orange;
            }
            if (comboBox1.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 1F 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Red;
                this.panel6.BackColor = Color.Red;
            }
            if (comboBox1.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 4F 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Magenta;
                this.panel6.BackColor = Color.Magenta;
            }
            if (comboBox1.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor1.Text = "92 91 91 3F DE DC DC 3F AD AC AC 3E 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Yellow;
                this.panel6.BackColor = Color.Yellow;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0xF2, 0xF0, 0xF0, 0x3E, 0xF2, 0xF0, 0xF0, 0x3E, 0xF2, 0xF0, 0xF0, 0x3E, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.BackColor = Color.Transparent;
                this.labelColor2.Text = "F2 F0 F0 3E F2 F0 F0 3E F2 F0 F0 3E 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Transparent;
            }
            if (comboBox2.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.BackColor = Color.Lime;
                this.labelColor2.Text = "AD AC AC 3E AD AC AC 4E AD AC AC 2F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Lime;
            }
            if (comboBox2.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.Text = "AD AC AC 2E AD AC AC 4E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor2.BackColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Cyan;
            }
            if (comboBox2.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.BackColor = Color.FromArgb(0, 81, 255);
                this.labelColor2.Text = "AD AC AC 2E AD AC AC 3E AD AC AC 3F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                this.panel7.BackColor = Color.FromArgb(0, 81, 255);
            }
            if (comboBox2.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.BackColor = Color.Blue;
                this.labelColor2.Text = "AD AC AC 2E AD AC AC 2E AD AC AC 3F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Blue;
            }
            if (comboBox2.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 4E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor2.BackColor = Color.White;
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                this.panel7.BackColor = Color.White;
            }
            if (comboBox2.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 3E AD AC AC 1F 00 00 80 3F 0A";
                this.labelColor2.BackColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Orange;
            }
            if (comboBox2.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 1F 00 00 80 3F 0A";
                this.labelColor2.BackColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Red;
            }
            if (comboBox2.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 4F 00 00 80 3F 0A";
                this.labelColor2.BackColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Magenta;
            }
            if (comboBox2.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F, 0x0A };
                this.labelColor2.Text = "92 91 91 3F DE DC DC 3F AD AC AC 3E 00 00 80 3F 0A";
                this.labelColor2.BackColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x217;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                this.panel7.BackColor = Color.Yellow;
            }
        }
        //UserNameSeparator
        private void buttonInner_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x00, 0x00, 0xF2, 0xF0, 0xF0, 0x3E, 0xCA, 0xC8, 0x48, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x60, 0x42, 0x00, 0x00, 0x25, 0x44, 0x00, 0x00, 0x00, 0x40, 0x01, 0x55 };
                this.labelColor3.BackColor = Color.Transparent;
                this.labelColor3.Text = "F2 F0 F0 3E F2 F0 F0 3E F2 F0 F0 3E 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Transparent;
            }
            if (comboBox3.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.BackColor = Color.Lime;
                this.labelColor3.Text = "AD AC AC 3E AD AC AC 4E AD AC AC 2F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Lime;
            }
            if (comboBox3.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.Text = "AD AC AC 2E AD AC AC 4E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor3.BackColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Cyan;
            }
            if (comboBox3.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.BackColor = Color.FromArgb(0, 81, 255);
                this.labelColor3.Text = "AD AC AC 2E AD AC AC 3E AD AC AC 3F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.FromArgb(0, 81, 255);
            }
            if (comboBox3.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.BackColor = Color.Blue;
                this.labelColor3.Text = "AD AC AC 2E AD AC AC 2E AD AC AC 3F 00 00 80 3F 0A";
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Blue;
            }
            if (comboBox3.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.Text = "AD AC AC 4E AD AC AC 4E AD AC AC 3F 00 00 80 3F 0A";
                this.labelColor3.BackColor = Color.White;
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.White;
            }
            if (comboBox3.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.Text = "AD AC AC 4E AD AC AC 3E AD AC AC 1F 00 00 80 3F 0A";
                this.labelColor3.BackColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Orange;
            }
            if (comboBox3.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 1F 00 00 80 3F 0A";
                this.labelColor3.BackColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Red;
            }
            if (comboBox3.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 4F 00 00 80 3F 0A";
                this.labelColor3.BackColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Magenta;
            }
            if (comboBox3.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F, 0x0A,
                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x55, 0x73, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x53, 0x65, 0x70, 0x61, 0x72,
                 0x61, 0x74, 0x6F, 0x72, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x55, 0x42, 0x00, 0x00, 0xFA, 0x44, 0x00, 0x00, 0xDC, 0x41, 0x01, 0x55 };
                this.labelColor3.Text = "92 91 91 3F DE DC DC 3F AD AC AC 3E 00 00 80 3F 0A";
                this.labelColor3.BackColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x27B;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                this.panelcolor2.BackColor = Color.Yellow;
            }
        }
        //Avatar
        private void buttonAvatar_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "defaultAvatar")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x90, 0x41, 0x00, 0x00, 0x00, 0x42, 0x00, 0x00, 0x00, 0x42, 0x01, 0x55 };
                this.location3.BackColor = Color.Transparent;
                this.location3.Text = "00 00 00 00 90 41 00 00 00 42 00 00 00 42 01 55";
                binaryWriter.BaseStream.Position = 0x36A;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureAvatar0.Image = Resources.Avatar028x28;
                pictureAvatar1.Image = null;
                pictureAvatar2.Image = null;
                pictureAvatar3.Image = null;
            }
            if (comboBox4.Text == "Left")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xC2, 0xC2, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x43, 0x00, 0x00, 0x18, 0x43, 0x01, 0x55 };
                this.location3.Text = "C2 C2 00 00 00 00 00 00 00 43 00 00 18 43 01 55";
                binaryWriter.BaseStream.Position = 0x36A;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                pictureAvatar0.Image = null;
                pictureAvatar1.Image = Resources.Avatar080x80_01;
                pictureAvatar2.Image = Resources.Avatar080x80_02;
                pictureAvatar3.Image = Resources.Avatar080x80_03;
            }
        }
    }

}
