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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CXMLDecompilerRCO
{
    public partial class CommonAssets : Form
    {
        public CommonAssets()
        {
            InitializeComponent();
        }

        private void buttonBinPkg_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            //textBox10.Text = folderBrowserDialog1.SelectedPath;
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.InitialDirectory = "ReactNative.Components.CommonAssets//files//original//";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox10.Text = dialog.FileName;
                pictureBoxHome.Image = PS5.iconidhome;
                //MessageBox.Show("You selected: " + dialog.FileName);

            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Default")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text+"\\"+ "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x46, 0x46, 0x46, 0x46, 0x46, 0x46 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.iconidhome;
                //this.pictureBoxBar.Location = new Point(2, 54);

            }
            if (comboBox1.Text == "Aqua")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x30, 0x30, 0x46, 0x46, 0x46, 0x46 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.AquaIconidhome;

            }
            if (comboBox1.Text == "Blue")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x30, 0x30, 0x30, 0x30, 0x46, 0x46 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.BlueIconidhome;

            }
            if (comboBox1.Text == "Chartreuse")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x37, 0x46, 0x46, 0x46, 0x30, 0x30 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.ChartreuseIconidhome;

            }
            if (comboBox1.Text == "DarkGoldenrod")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x42, 0x38, 0x38, 0x36, 0x30, 0x42 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.DarkGoldenrodIconidhome;

            }
            if (comboBox1.Text == "EGGPLANT")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x33, 0x31, 0x31, 0x34, 0x33, 0x32 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.EGGPLANTIconidhome;

            }
            if (comboBox1.Text == "Fuchsia")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x46, 0x46, 0x30, 0x30, 0x46, 0x46 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.FuchsiaIconidhome;

            }
            if (comboBox1.Text == "Gold")
            {
                BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(textBox10.Text + "\\" + "iconid_home.txt"));
                byte[] buffer = new byte[] { 0x46, 0x46, 0x44, 0x37, 0x30, 0x30 };
                binaryWriter.BaseStream.Position = 0x2F5;
                binaryWriter.Write(buffer);
                binaryWriter.Close();
                pictureBoxHome.Image = PS5.GoldIconidhome;

            }
        }
    }
}
