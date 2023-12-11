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
    public partial class ApplicationExit : Form
    {
        public ApplicationExit()
        {
            InitializeComponent();
        }

        private void ApplicationExit_Load(object sender, EventArgs e)
        {

        }

        private void buttonBinPkg_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "layout_application_exit_scene.bin")
                {

                    MessageBox.Show("This file should be. layout_application_exit_scene.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.labelNamePkg.Text = this.openFileDialog1.SafeFileName;

                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.Transparent;
                this.button5.BackColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.Transparent;
                this.button5.BackColor = Color.Transparent;
                binaryWriter00.BaseStream.Position = 0x40D;
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
            }
            if (comboBox3.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 0, 255, 0);
                this.button5.BackColor = Color.FromArgb(118, 0, 255, 0);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x40D;
                binaryWriter01.Write(buffer02);
                binaryWriter01.Close();
            }
            if (comboBox3.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 0, 255, 255);
                this.button5.BackColor = Color.FromArgb(118, 0, 255, 255);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                BinaryWriter binaryWriter02 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer03 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter02.BaseStream.Position = 0x40D;
                binaryWriter02.Write(buffer03);
                binaryWriter02.Close();
            }
            if (comboBox3.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 0, 81, 255);
                this.button5.BackColor = Color.FromArgb(118, 0, 81, 255);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                BinaryWriter binaryWriter03 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer04 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter03.BaseStream.Position = 0x40D;
                binaryWriter03.Write(buffer04);
                binaryWriter03.Close();
            }
            if (comboBox3.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 0, 0, 255);
                this.button5.BackColor = Color.FromArgb(118, 0, 0, 255);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                BinaryWriter binaryWriter04 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer05 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter04.BaseStream.Position = 0x40D;
                binaryWriter04.Write(buffer05);
                binaryWriter04.Close();
            }
            if (comboBox3.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 255, 255, 255);
                this.button5.BackColor = Color.FromArgb(118, 255, 255, 255);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                BinaryWriter binaryWriter05 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer06 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter05.BaseStream.Position = 0x40D;
                binaryWriter05.Write(buffer06);
                binaryWriter05.Close();
            }
            if (comboBox3.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 255, 165, 0);
                this.button5.BackColor = Color.FromArgb(118, 255, 165, 0);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                BinaryWriter binaryWriter06 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer07 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter06.BaseStream.Position = 0x40D;
                binaryWriter06.Write(buffer07);
                binaryWriter06.Close();
            }
            if (comboBox3.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 255, 0, 0);
                this.button5.BackColor = Color.FromArgb(118, 255, 0, 0);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                BinaryWriter binaryWriter07 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer08 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter07.BaseStream.Position = 0x40D;
                binaryWriter07.Write(buffer08);
                binaryWriter07.Close();
            }
            if (comboBox3.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 255, 0, 255);
                this.button5.BackColor = Color.FromArgb(118, 255, 0, 255);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                BinaryWriter binaryWriter08 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer09 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter08.BaseStream.Position = 0x40D;
                binaryWriter08.Write(buffer09);
                binaryWriter08.Close();
            }
            if (comboBox3.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.button3.BackColor = Color.FromArgb(118, 255, 255, 0);
                this.button5.BackColor = Color.FromArgb(118, 255, 255, 0);
                binaryWriter.BaseStream.Position = 0x351;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                BinaryWriter binaryWriter09 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer10 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter09.BaseStream.Position = 0x40D;
                binaryWriter09.Write(buffer10);
                binaryWriter09.Close();
            }
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.Transparent;
                this.button5.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer01);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 0, 255, 0);
                this.button5.ForeColor = Color.FromArgb(118, 0, 255, 0);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer01);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 0, 255, 255);
                this.button5.ForeColor = Color.FromArgb(118, 0, 255, 255);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer02 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer02);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 0, 81, 255);
                this.button5.ForeColor = Color.FromArgb(118, 0, 81, 255);
                binaryWriter.BaseStream.Position = 0x257;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer03 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer03);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 0, 0, 255);
                this.button5.ForeColor = Color.FromArgb(118, 0, 0, 255);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer04 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer04);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 255, 255, 255);
                this.button5.ForeColor = Color.FromArgb(118, 255, 255, 255);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer05 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer05);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 255, 165, 0);
                this.button5.ForeColor = Color.FromArgb(118, 255, 165, 0);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer06 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer06);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 255, 0, 0);
                this.button5.ForeColor = Color.FromArgb(118, 255, 0, 0);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer07 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer07);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 255, 0, 255);
                this.button5.ForeColor = Color.FromArgb(118, 255, 0, 255);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer08 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer08);
                binaryWriter01.Close();
            }
            if (comboBox4.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.button3.ForeColor = Color.FromArgb(118, 255, 255, 0);
                this.button5.ForeColor = Color.FromArgb(118, 255, 255, 0);
                binaryWriter.BaseStream.Position = 0x2FD;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                BinaryWriter binaryWriter01 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer09 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                binaryWriter01.BaseStream.Position = 0x3B9;
                binaryWriter01.Write(buffer09);
                binaryWriter01.Close();
            }
        }
    }
}
