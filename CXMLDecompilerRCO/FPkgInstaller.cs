using CXMLDecompilerRCO.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXMLDecompilerRCO
{
    public partial class FPkgInstaller : Form
    {
        public FPkgInstaller()
        {
            InitializeComponent();
            panel5.BackColor = Color.FromArgb(190, 0, 0, 0);
        }

        private void buttonBinPkg_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "Progress.bin")
                {

                    MessageBox.Show("This file should be. Progress.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.labelNamePkg.Text = this.openFileDialog1.SafeFileName;
                    label5.Text = "Progress";
                    label6.Text = "title";
                    label7.Text = "bar";
                    label8.Text = "file";
                    pictureBoxpkg0.Image = Resources.PkgInstaller01;
                    pictureBoxpkg1.Image = Resources.PkgInstaller02;
                    pictureBoxBar.Image = Resources.bar_01;
                    Namepkg.Text = "Orbis Theme_V0102.pkg";
                    labInstalling.Text = "Installing...";
                    labelfile.Text = "1 / 1";
                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)//colos_Progress
        {
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

            }
            if (comboBox1.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0x39, 0x39, 0x39, 0x3E, 0x39, 0x39, 0x39, 0x4E, 0x39, 0x39, 0x39, 0x2F, 0x39, 0x39, 0x39, 0x3F, 0x0A };
                this.labelColor2.BackColor = Color.Lime;
                this.labelColor2.Text = "39 39 39 3E 39 39 39 4E 39 39 39 2F 39 39 39 3F 0A ";
                binaryWriter.BaseStream.Position = 0x12B;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                this.panel5.BackColor = Color.Lime;

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
            }
        }
        
        private void button4_Click(object sender, EventArgs e)//Color_title
        {
            if (comboBox2.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00 };
                this.labelColor2.BackColor = Color.Transparent;
                this.labelColor2.Text = "9A 99 19 3F 9A 99 19 3F 9A 99 19 3F 00 00 00 00 ";
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00 };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00 };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Transparent;
                this.labInstalling.ForeColor = Color.Transparent;
                this.labelfile.ForeColor = Color.Transparent;

            }
            if (comboBox2.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.BackColor = Color.Lime;
                this.labelColor2.Text = "AD AC AC 3E AD AC AC 4E AD AC AC 2F 00 00 80 3F ";
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Lime;
                this.labInstalling.ForeColor = Color.Lime;
                this.labelfile.ForeColor = Color.Lime;

            }
            if (comboBox2.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.Text = "AD AC AC 2E AD AC AC 4E AD AC AC 3F 00 00 80 3F ";
                this.labelColor2.BackColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Cyan;
                this.labInstalling.ForeColor = Color.Cyan;
                this.labelfile.ForeColor = Color.Cyan;

            }
            if (comboBox2.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.Text = "AD AC AC 2E AD AC AC 3E AD AC AC 3F 00 00 80 3F ";
                this.labelColor2.BackColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.FromArgb(0, 81, 255);
                this.labInstalling.ForeColor = Color.FromArgb(0, 81, 255);
                this.labelfile.ForeColor = Color.FromArgb(0, 81, 255);

            }
            if (comboBox2.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.BackColor = Color.Blue;
                this.labelColor2.Text = "AD AC AC 2E AD AC AC 2E AD AC AC 3F 00 00 80 3F ";
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Blue;
                this.labInstalling.ForeColor = Color.Blue;
                this.labelfile.ForeColor = Color.Blue;

            }
            if (comboBox2.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 4E AD AC AC 3F 00 00 80 3F ";
                this.labelColor2.BackColor = Color.White;
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.White;
                this.labInstalling.ForeColor = Color.White;
                this.labelfile.ForeColor = Color.White;

            }
            if (comboBox2.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 3E AD AC AC 1F 00 00 80 3F ";
                this.labelColor2.BackColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Orange;
                this.labInstalling.ForeColor = Color.Orange;
                this.labelfile.ForeColor = Color.Orange;

            }
            if (comboBox2.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 1F 00 00 80 3F ";
                this.labelColor2.BackColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Red;
                this.labInstalling.ForeColor = Color.Red;
                this.labelfile.ForeColor = Color.Red;

            }
            if (comboBox2.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor2.Text = "AD AC AC 4E AD AC AC 1F AD AC AC 4F 00 00 80 3F ";
                this.labelColor2.BackColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Magenta;
                this.labInstalling.ForeColor = Color.Magenta;
                this.labelfile.ForeColor = Color.Magenta;

            }
            if (comboBox2.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelColor1.Text = "92 91 91 3F DE DC DC 3F AD AC AC 3E 00 00 80 3F 0A";
                this.labelColor1.BackColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x18B;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter1.BaseStream.Position = 0x27C;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter2.BaseStream.Position = 0x31D;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.ForeColor = Color.Yellow;
                this.labInstalling.ForeColor = Color.Yellow;
                this.labelfile.ForeColor = Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)//title location
        {
            if (comboBox3.Text == "Default")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x8D, 0x43, 0x00, 0x80, 0xA7, 0x44, 0x00, 0x00, 0x10, 0x42, 0x01, 0x55 };
                binaryWriter.BaseStream.Position = 0x1ED;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0x00, 0x00, 0x00, 0x80, 0xC9, 0x43, 0x00, 0x80, 0xA7, 0x44, 0x00, 0x00, 0x10, 0x42, 0x01, 0x55 };
                binaryWriter1.BaseStream.Position = 0x2E1;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x20, 0x43, 0x00, 0x80, 0xA7, 0x44, 0x00, 0x00, 0x10, 0x42, 0x01, 0x55 };
                binaryWriter2.BaseStream.Position = 0x37E;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.Location = new Point(89, 7);
                this.labInstalling.Location = new Point(118, 33);
                this.labelfile.Location = new Point(137, 65);
                this.Namepkg.ForeColor = Color.Transparent;
                this.labInstalling.ForeColor = Color.Transparent;
                this.labelfile.ForeColor = Color.Transparent;

            }
            if (comboBox3.Text == "Left")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));//Installing
                byte[] buffer = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x18, 0x44, 0x00, 0x00, 0x18, 0x44, 0x00, 0x00, 0x00, 0x44, 0x01, 0x55 };
                binaryWriter.BaseStream.Position = 0x1ED;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                BinaryWriter binaryWriter1 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));//file 1/1
                byte[] buffer01 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x18, 0x44, 0x00, 0x00, 0x18, 0x44, 0x00, 0x00, 0x00, 0x44, 0x01, 0x55 };
                binaryWriter1.BaseStream.Position = 0x2E1;
                binaryWriter1.Write(buffer01);
                binaryWriter1.Close();
                BinaryWriter binaryWriter2 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));//Namepkg
                byte[] buffer02 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x18, 0x40, 0x00, 0x00, 0x18, 0x44, 0x00, 0x00, 0x00, 0x44, 0x01, 0x55 };
                binaryWriter2.BaseStream.Position = 0x37E;
                binaryWriter2.Write(buffer02);
                binaryWriter2.Close();
                this.Namepkg.Location = new Point(23, 7);
                this.labInstalling.Location = new Point(23, 33);
                this.labelfile.Location = new Point(23, 65);

            }
        }

        private void buttonbar_Click(object sender, EventArgs e)//bar
        {
            if (comboBox4.Text == "Default")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));//bar
                byte[] buffer = new byte[] { 0x00, 0x00, 0x00, 0x80, 0xBB, 0x43, 0x00, 0x80, 0xA7, 0x44, 0x00, 0x00, 0x80, 0x41, 0x01, 0x55 };
                binaryWriter.BaseStream.Position = 0x23F;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                this.pictureBoxBar.Location = new Point(2, 54);

            }
            if (comboBox4.Text == "UP")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));//bar
                byte[] buffer1 = new byte[] { 0xC8, 0x41, 0x00, 0x00, 0x00, 0x00, 0x00, 0x60, 0xBD, 0x44, 0x00, 0x00, 0xF0, 0x41, 0x01, 0x55 };
                binaryWriter.BaseStream.Position = 0x23F;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                this.pictureBoxBar.Location = new Point(2, 2);

            }
            if (comboBox4.Text == "Down")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));//bar
                byte[] buffer2 = new byte[] { 0x00, 0x00, 0x00, 0x80, 0x34, 0x44, 0x00, 0x80, 0xA7, 0x44, 0x00, 0x00, 0x80, 0x40, 0x01, 0x55 };
                binaryWriter.BaseStream.Position = 0x23F;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                this.pictureBoxBar.Location = new Point(2, 85);

            }
        }
    }
}
