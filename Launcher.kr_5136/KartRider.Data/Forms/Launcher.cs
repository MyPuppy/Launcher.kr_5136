using KartRider.Common.Network;
using KartRider.Common.Utilities;
using KartRider.IO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Set_Data;

namespace KartRider
{
    public class Launcher : Form
    {
        public static bool GetKart = true;
        public static bool Options = true;
        public static bool OpenGetItem = false;
        public static short KartSN = 0;
        public static short KartOld_SN = 0;
        public static short LastKartSN = 0;
        public static short KartSN2 = 0;
        public static short KartOld_SN2 = 0;
        private string kartRiderDirectory = null;
        private string profilePath = null;
        public static string KartRider = "KartRider.exe";
        private Button Start_Button;
        private Button GetKart_Button;
        private Label label_DeveloperName;
        private Button Options_Button;

        public Launcher()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Start_Button = new System.Windows.Forms.Button();
            this.GetKart_Button = new System.Windows.Forms.Button();
            this.Options_Button = new System.Windows.Forms.Button();
            this.label_DeveloperName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(22, 20);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(133, 23);
            this.Start_Button.TabIndex = 364;
            this.Start_Button.Text = "게임 실행";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // GetKart_Button
            // 
            this.GetKart_Button.Location = new System.Drawing.Point(22, 49);
            this.GetKart_Button.Name = "GetKart_Button";
            this.GetKart_Button.Size = new System.Drawing.Size(133, 23);
            this.GetKart_Button.TabIndex = 365;
            this.GetKart_Button.Text = "아이템 추가";
            this.GetKart_Button.UseVisualStyleBackColor = true;
            this.GetKart_Button.Click += new System.EventHandler(this.GetKart_Button_Click);
            // 
            // Options_Button
            // 
            this.Options_Button.Location = new System.Drawing.Point(22, 78);
            this.Options_Button.Name = "Options_Button";
            this.Options_Button.Size = new System.Drawing.Size(133, 23);
            this.Options_Button.TabIndex = 366;
            this.Options_Button.Text = "강화 옵션";
            this.Options_Button.UseVisualStyleBackColor = true;
            this.Options_Button.Click += new System.EventHandler(this.Options_Button_Click);
            // 
            // label_DeveloperName
            // 
            this.label_DeveloperName.AutoSize = true;
            this.label_DeveloperName.BackColor = System.Drawing.SystemColors.Control;
            this.label_DeveloperName.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DeveloperName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_DeveloperName.Location = new System.Drawing.Point(2, 160);
            this.label_DeveloperName.Name = "label_DeveloperName";
            this.label_DeveloperName.Size = new System.Drawing.Size(30, 17);
            this.label_DeveloperName.TabIndex = 367;
            this.label_DeveloperName.Text = "Unk";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.label_DeveloperName);
            this.Controls.Add(this.Options_Button);
            this.Controls.Add(this.GetKart_Button);
            this.Controls.Add(this.Start_Button);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Process.GetProcessesByName("KartRider").Length != 0)
            {
                LauncherSystem.MessageBoxType1();
                e.Cancel = true;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (File.Exists(Launcher.KartRider))
            {
                if (Program.Developer_Name)
                {
                    label_DeveloperName.Text = "KartRider PV:" + Program.Version + " (by LAON)";
                }
                else
                {
                    label_DeveloperName.Text = "";
                }
                this.kartRiderDirectory = Environment.CurrentDirectory;
                string str = Path.Combine(this.kartRiderDirectory, "Profile", SessionGroup.Service);
                this.profilePath = Path.Combine(str, "launcher.xml");
                if (!Directory.Exists(str))
                {
                    Directory.CreateDirectory(str);
                }
                Console.WriteLine("Process: {0}", this.kartRiderDirectory + "\\" + Launcher.KartRider);
                Console.WriteLine("Profile: {0}", this.profilePath);
                RouterListener.Start();
                StartingLoad_ALL.StartingLoad();
            }
            else
            {
                LauncherSystem.MessageBoxType3();
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("KartRider").Length != 0)
            {
                LauncherSystem.MessageBoxType2();
            }
            else
            {
                (new Thread(() =>
                {
                    Start_Button.Enabled = false;
                    Launcher.GetKart = false;
                    Launcher.Options = false;
                    string str = this.profilePath;
                    string[] text = new string[] { "<?xml version='1.0' encoding='UTF-16'?>\r\n<profile>\r\n<username>", SetRider.UserID, "</username>\r\n</profile>" };
                    File.WriteAllText(str, string.Concat(text));
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Launcher.KartRider, "-profile:launcher")
                        {
                            WorkingDirectory = this.kartRiderDirectory
                        }
                    };
                    process.Start();
                    Thread.Sleep(1000);
                    Start_Button.Enabled = true;
                    Launcher.GetKart = true;
                    Launcher.Options = true;
                })).Start();
            }
        }

        private void GetKart_Button_Click(object sender, EventArgs e)
        {
            if (Launcher.GetKart)
            {
                Program.GetKartDlg = new GetKart();
                Program.GetKartDlg.ShowDialog();
            }
        }

        private void Options_Button_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("KartRider").Length != 0)
            {
                LauncherSystem.MessageBoxType1();
            }
            else
            {
                if (Launcher.Options)
                {
                    Program.OptionsDlg = new Options();
                    Program.OptionsDlg.ShowDialog();
                }
            }
        }
    }
}