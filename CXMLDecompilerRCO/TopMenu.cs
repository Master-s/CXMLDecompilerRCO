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
    public partial class TopMenu : Form
    {
        public TopMenu()
        {
            InitializeComponent();
        }

        private void buttonBintop_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "layout_system_area_scene2.bin")
                {

                    MessageBox.Show("This file should be. layout_system_area_scene2.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.labelNamePkg.Text = this.openFileDialog1.SafeFileName;
                    labelpsplus.Text = "PSPlus";
                    labelNotification.Text = "Notification";
                    labelFriend.Text = "Friend";
                    labelCommunity.Text = "Community";
                    labelEvent.Text = "Event";
                    labelMessages.Text = "Messages";
                    labelParty.Text = "Party";
                    labelProfile.Text = "Profile";
                    labelTrophy.Text = "Trophy";
                    labelSettings.Text = "Settings";
                    labelPower.Text = "Power";
                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        private void buttoncolor0_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox1.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelpsplus.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x320;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)//Notification
        {
            if (comboBox2.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox2.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelNotification.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x4A3;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)//Friend
        {
            if (comboBox3.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }

            if (comboBox3.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox3.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelFriend.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x934;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)//Community
        {
            if (comboBox4.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelCommunity.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0xC3C;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)//Event
        {
            if (comboBox5.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox5.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelEvent.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0xF37;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)//Messages
        {
            if (comboBox6.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }

            if (comboBox6.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox6.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelMessages.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x11B9;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button6_Click(object sender, EventArgs e)//Party
        {
            if (comboBox7.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox7.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelParty.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x132C;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button7_Click(object sender, EventArgs e)//Profile
        {
            if (comboBox8.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox8.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelProfile.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x143A;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button8_Click(object sender, EventArgs e)//Trophy
        {
            if (comboBox9.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox9.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelTrophy.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x16C8;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button9_Click(object sender, EventArgs e)//Settings
        {
            if (comboBox10.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox10.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelSettings.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x18ED;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }
        private void button10_Click(object sender, EventArgs e)//power
        {
            if (comboBox11.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox11.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.labelPower.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x1A60;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }

        private void buttonBintop2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "layout_contents_area_scene.bin")
                {

                    MessageBox.Show("This file should be. layout_contents_area_scene.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.labelNameBIN02.Text = this.openFileDialog1.SafeFileName;

                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void button11background_Click(object sender, EventArgs e)
        {
            if (darkComboBox1.Text == "Default")
            {
                comboBoxBackground.Enabled = true;
                if (comboBoxBackground.Text == "Default")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer0 = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00 };
                    this.panel2.BackColor = Color.Transparent;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer0);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Black")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer01 = new byte[] { 0x22, 0x22, 0x22, 0x2E, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x00, 0x00, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Black;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer01);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Green")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Lime;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer1);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "CyanAqua")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Cyan;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer2);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "BlueRibbon")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.FromArgb(0, 81, 255);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer3);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Blue")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Blue;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer4);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "White")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.White;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer5);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "BlazeOrange")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Orange;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer6);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Red")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Red;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer7);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "MagentaFuchsia")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Magenta;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer8);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Yellow")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                    this.panel2.BackColor = Color.Yellow;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer9);
                    binaryWriter.Close();
                }


            }

            if (darkComboBox1.Text == "Transparent")
            {
                if (comboBoxBackground.Text == "Default")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer0 = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00 };
                    this.panel2.BackColor = Color.Transparent;
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer0);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Black")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer01 = new byte[] { 0x22, 0x22, 0x22, 0x2E, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x00, 0x00, 0x3E, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118,0, 0, 0);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer01);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Green")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 54, 172, 64);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer1);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "CyanAqua")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 0, 255, 255);//FromArgb(118, 0,255,255);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer2);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "BlueRibbon")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 0, 81, 255);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer3);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Blue")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 0, 0, 255);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer4);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "White")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 255, 255, 255);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer5);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "BlazeOrange")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 255, 165, 0);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer6);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Red")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 255, 0, 0);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer7);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "MagentaFuchsia")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 255, 0, 255);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer8);
                    binaryWriter.Close();
                }
                if (comboBoxBackground.Text == "Yellow")
                {
                    BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                    byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3E };
                    this.panel2.BackColor = Color.FromArgb(118, 255, 255, 0);//FromArgb(118, 255,255,0);
                    binaryWriter.BaseStream.Position = 0x184;
                    binaryWriter.Write(buffer9);
                    binaryWriter.Close();
                }


            }


        }
    }
}
