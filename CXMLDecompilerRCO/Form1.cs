using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Net;
using System.Net.Sockets;

namespace CXMLDecompilerRCO
{
    public partial class Form1 : Form
    {
        private string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ipbox.Text = IniConfig.Newini.Read("PS4 IP", "IP");
            this.portbox.Text = IniConfig.Newini.Read("PS4 port", "port");
            //comboBox1.Items.Add("a");

        }
        private void butSaveIP_Click(object sender, EventArgs e)
        {
            try
            {
                if (ipbox.Text == "")
                {
                    MessageBox.Show("Enter a valid IP address");
                }
                else
                {
                    IniConfig.Newini.Write("PS4 IP", "ip", ipbox.Text);
                    IniConfig.Newini.Write("PS4 PORT", "port", portbox.Text);
                    MessageBox.Show("IP: " + ipbox.Text + "\n" + "port: " + portbox.Text);
                    //this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Error al cambiar la ip");
            }
        }
        private void openRCOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "RCO files (*.rco)|*.rco;|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.SafeFileName;
            label1.Text = path;
            label3.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openFileDialog1.SafeFileName != "" + label3.Text + ".rco")
                {
                    MessageBox.Show("This file should be." + label3.Text + ".rco", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    StreamWriter A = new StreamWriter(Application.StartupPath + "\\" + "DecompileRco.bat");
                    A.WriteLine("CXMLDecompiler.exe" + " " + label3.Text + ".rco");
                    A.Close();
                    if (File.Exists("DecompileRco.bat"))
                    {
                        this.labelBuild.Text = "Extract...";
                        Thread thread = new Thread(new ThreadStart(ThreadProc));
                        new Process
                        {
                            StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "DecompileRco.bat"
                            }
                        }.Start();
                        MessageBox.Show(" successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.labelBuild.Text = "Extract complete!";


                    }
                    else
                    {
                        MessageBox.Show("You're missing the targeted file! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openFileDialog1.SafeFileName != ""+ label3.Text +".xml")
                {
                    MessageBox.Show("This file should be." + label3.Text + ".xml", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    StreamWriter A = new StreamWriter(Application.StartupPath + "\\" + "RecompileRco.bat");
                    A.WriteLine("@echo off\ncolor a\nfor %%a in (*.RCO) DO CXMLDecompiler.exe" + " " + label3.Text + label4.Text + label2.Text + " -c " +
                    "\nDEL Output" + label4.Text + label3.Text + ".rco" + "\nmove -c Output" + "\nrename Output" + label4.Text + "-c " + label3.Text + ".rco" +
                    "\n%%a output");
                    A.Close();
                    if (File.Exists("RecompileRco.bat"))
                    {
                        this.labelBuild.Text = "Building...";
                        Thread thread = new Thread(new ThreadStart(ThreadProc));
                        new Process
                        {
                            StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "RecompileRco.bat"
                            }
                        }.Start();
                        MessageBox.Show("RCO successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.labelBuild.Text = "Build complete!";

                       
                    }
                    else
                    {
                        MessageBox.Show("You're missing the targeted file! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    var ovr = MessageBox.Show("Open the output folder", "Output", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (ovr == DialogResult.No)
                    {

                    }
                    else
                    {
                        Process.Start(@"Output");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public static void ThreadProc()
        {
           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ".XML Files|*.xml";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.SafeFileName;
            label2.Text = path;
            label3.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
        }

        public void ShowTHisForm(object form)
        {
            panelhome.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panelhome.Controls.Add(frm);
            panelhome.Tag = frm;
            frm.Show();
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new FNotification());
        }

        private void buttonPkgInstaller_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new FPkgInstaller());
        }

        private void buttonTopMenu_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new TopMenu());
        }
        private void buttonApplicationExit_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new ApplicationExit());
        }
        private void buttonLoginMgr_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new LoginMgr());
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowseRCO_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.CheckFileExists = true;
            opendialog.InitialDirectory = @"Output";
            opendialog.Multiselect = false;
            opendialog.Filter = "PS4 RCO File (*.RCO) | *.rco";
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = opendialog.FileName;
                darkTextBox3.Text = Path.GetFileName(opendialog.FileName);
                

            }
            try
            {
                int count = 0;
                string[] FilenameName;
                foreach (string item in opendialog.FileNames)
                {
                    FilenameName = item.Split('\\');
                    File.Copy(item, @"send\" + FilenameName[FilenameName.Length - 1]);
                    count++;
                    //Interaction.MsgBox("Move Package to Folder PKG ", MsgBoxStyle.Exclamation);

                }
                

            }
            catch
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                var di = new DirectoryInfo(Application.StartupPath + "/send");

                foreach (FileInfo fi in di.EnumerateFiles("*.rco"))

                    
                Refresh();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical);
            }
        }

        public void sendcheatsrco()
        {
            bool overwrite = false;
            try
            {
                var di = new DirectoryInfo(Application.StartupPath + "/send");

                var ftp = new FTP("", "");
                foreach (FileInfo fi in di.EnumerateFiles("*.rco"))
                {
                    if (File.Exists("ftp://" + ipbox.Text + ":" + portbox.Text + "/system_ex/app/NPXS20001/psm/Application/resource/" + fi.Name) & overwrite == true)
                    {
                        ftp.UploadFile(fi.FullName, "ftp://" + ipbox.Text + ":" + portbox.Text + "/system_ex/app/NPXS20001/psm/Application/resource/" + fi.Name);
                    }
                    else if (File.Exists("ftp://" + ipbox.Text + ":" + portbox.Text + "/system_ex/app/NPXS20001/psm/Application/resource/" + fi.Name) & overwrite == false)
                    {
                    }

                    else
                    {
                        ftp.UploadFile(fi.FullName, "ftp://" + ipbox.Text + ":" + portbox.Text + "/system_ex/app/NPXS20001/psm/Application/resource/" + fi.Name);
                    }
                }


                Interaction.MsgBox("Done! ", MsgBoxStyle.Exclamation);
                darkLabelSend.ForeColor = Color.FromArgb(255, 255, 255);
                darkLabelSend.Text = "Successful. ";
                UseWaitCursor = false;
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }
        private void buttonSendRCO_Click(object sender, EventArgs e)
        {
            var overwrite = MessageBox.Show("RCO","0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {

                if (overwrite == DialogResult.No)
                {

                }
                else if (ipbox.Text == "IP Here" | string.IsNullOrEmpty(ipbox.Text))
                {
                    Interaction.MsgBox("Please enter a IP", MsgBoxStyle.Critical);
                    darkLabelSend.ForeColor = Color.FromArgb(255, 53, 53);
                    darkLabelSend.Text = "Error ";
                }
                else
                {
                    Properties.MySettingsProperty.Settings.IP = ipbox.Text;
                    UseWaitCursor = true;
                    sendcheatsrco();
                    
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                darkLabelSend.ForeColor = Color.FromArgb(255, 53, 53);
                darkLabelSend.Text = "Error ";
            }
            try
            {

                StreamWriter A = new StreamWriter(Application.StartupPath + "\\" + "DRco.bat");
                A.WriteLine("@echo off\ncolor a\nDEL send"+"\\" + darkTextBox3.Text +"\n%%a output");
                A.Close();
                if (File.Exists("DRco.bat"))
                {
                    darkLabelSend.ForeColor = Color.FromArgb(255, 255, 255);
                    this.darkLabelSend.Text = "Send...";
                    Thread thread = new Thread(new ThreadStart(ThreadProc));
                    new Process
                    {
                        StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "DRco.bat"
                            }
                    }.Start();
                    darkLabelSend.ForeColor = Color.FromArgb(255, 255, 255);
                    this.darkLabelSend.Text = "complete!";


                }
                else
                {
                    MessageBox.Show("You're missing the targeted file! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch
            {
                
            }
        }

        private void darkCheckBoxPS4_CheckedChanged(object sender, EventArgs e)
        {
            buttonApplicationExit.Visible = true;
        }

        private void darkRadioButtonPS4_CheckedChanged(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            if (darkRadioButtonPS4.Checked)
            {
                buttonApplicationExit.Visible = true;
                buttonLoginMgr.Visible = true;
                buttonNotification.Visible = true;
                buttonPkgInstaller.Visible = true;
                buttonTopMenu.Visible = true;
                SettingsCore.Visible = true;
            }
            else
            {
                buttonApplicationExit.Visible = false;
                buttonLoginMgr.Visible = false;
                buttonNotification.Visible = false;
                buttonPkgInstaller.Visible = false;
                buttonTopMenu.Visible = false;
                SettingsCore.Visible = false;
            }

            
        }

        private void darkRadioButtonPS5_CheckedChanged(object sender, EventArgs e)
        {
            panelhome.Controls.Clear();
            if (darkRadioButtonPS5.Checked)
            {
                PS5buttonPkgInstaller.Visible = true;
                buttonPS5CommonAssets.Visible = true;
            }
            else
            {
                PS5buttonPkgInstaller.Visible = false;
                buttonPS5CommonAssets.Visible = false;
            }

        }

        private void PS5buttonPkgInstaller_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new PS5PkgInstaller());
        }

        private void buttonPS5CommonAssets_Click(object sender, EventArgs e)
        {
            ShowTHisForm(new CommonAssets()); 
        }
    }
}
