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
    public partial class LoginMgr : Form
    {
        public LoginMgr()
        {
            InitializeComponent();
        }

        private void buttonBinPkg_Click(object sender, EventArgs e)
        {
            
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "layout_user_list_panel.bin")
                {

                    MessageBox.Show("This file should be. layout_user_list_panel.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.labelNamePkg.Text = this.openFileDialog1.SafeFileName;

                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "defaultColor")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.Transparent;
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.Transparent;
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();

            }
            if (comboBox3.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 0, 255, 0);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 0, 255, 0);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 0, 255, 0);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 0, 255, 255);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 0, 255, 255);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 0, 255, 255);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 0, 81, 255);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 0, 81, 255);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 0, 81, 255);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 0, 0, 255);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 0, 0, 255);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 0, 0, 255);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 255, 255, 255);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 255, 255, 255);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 255, 255, 255);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 255, 165, 0);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 255, 165, 0);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 255, 165, 0);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 255, 0, 0);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 255, 0, 0);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 255, 0, 0);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 255, 0, 255);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 255, 0, 255);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 255, 0, 255);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
            if (comboBox3.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.label1.ForeColor = Color.FromArgb(118, 255, 255, 0);
                binaryWriter.BaseStream.Position = 0x4D6;//Who will use the PS4?
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
                BinaryWriter binaryWriter00 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer00 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.label2.ForeColor = Color.FromArgb(118, 255, 255, 0);
                binaryWriter00.BaseStream.Position = 0x732;//.You will be able to use all the previous user's device.
                binaryWriter00.Write(buffer00);
                binaryWriter00.Close();
                BinaryWriter binaryWriter001 = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer001 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.label3.ForeColor = Color.FromArgb(118, 255, 255, 0);
                binaryWriter001.BaseStream.Position = 0x812;//.The previous user will not be logged out of the PS4
                binaryWriter001.Write(buffer001);
                binaryWriter001.Close();
            }
        }

        private void button2New_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = ".BIN Files|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.openFileDialog1.SafeFileName != "layout_user_account_item.bin")
                {

                    MessageBox.Show("This file should be. layout_user_account_item.bin!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    this.label6.Text = this.openFileDialog1.SafeFileName;

                    MessageBox.Show(this.openFileDialog1.SafeFileName + " successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    label4.Enabled = true;
                    label5.Enabled = true;
                    comboBox4.Enabled = true;
                    buttonNew.Enabled = true;

                }
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {


            if (comboBox4.Text == "Default")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer0 = new byte[] { 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x9A, 0x99, 0x19, 0x3F, 0x00, 0x00, 0x00, 0x00 };
                this.label4.ForeColor = Color.Transparent;
                this.label5.ForeColor = Color.Transparent;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer0);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Black")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer01 = new byte[] { 0x22, 0x22, 0x22, 0x2E, 0x00, 0x00, 0x00, 0x2E, 0x00, 0x00, 0x00, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Black;
                this.label5.ForeColor = Color.Black;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer01);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Green")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer1 = new byte[] { 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x2F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Lime;
                this.label5.ForeColor = Color.Lime;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer1);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "CyanAqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer2 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Cyan;
                this.label5.ForeColor = Color.Cyan;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer2);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "BlueRibbon")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer3 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.FromArgb(0, 81, 255);
                this.label5.ForeColor = Color.FromArgb(0, 81, 255);
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer3);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer4 = new byte[] { 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x2E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Blue;
                this.label5.ForeColor = Color.Blue;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer4);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "White")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer5 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.White;
                this.label5.ForeColor = Color.White;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer5);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "BlazeOrange")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer6 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x3E, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Orange;
                this.label5.ForeColor = Color.Orange;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer6);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Red")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer7 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x1F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Red;
                this.label5.ForeColor = Color.Red;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer7);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "MagentaFuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer8 = new byte[] { 0xAD, 0xAC, 0xAC, 0x4E, 0xAD, 0xAC, 0xAC, 0x1F, 0xAD, 0xAC, 0xAC, 0x4F, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Magenta;
                this.label5.ForeColor = Color.Magenta;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer8);
                binaryWriter.Close();
            }
            if (comboBox4.Text == "Yellow")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(this.openFileDialog1.FileName));
                byte[] buffer9 = new byte[] { 0x92, 0x91, 0x91, 0x3F, 0xDE, 0xDC, 0xDC, 0x3F, 0xAD, 0xAC, 0xAC, 0x3E, 0x00, 0x00, 0x80, 0x3F };
                this.label4.ForeColor = Color.Yellow;
                this.label5.ForeColor = Color.Yellow;
                binaryWriter.BaseStream.Position = 0x336;
                binaryWriter.Write(buffer9);
                binaryWriter.Close();
            }
        }


    }
}
