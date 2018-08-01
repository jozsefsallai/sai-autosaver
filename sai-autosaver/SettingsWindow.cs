using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sai_autosaver
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        public static string AppPath = Path.Combine(Environment.CurrentDirectory);
        public static bool DEBUG_MODE = false; // Change to true when debugging.
        public static int multiplier = DEBUG_MODE ? 10000 : 5 * 60000;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public void GracefullyExit(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Application.Exit();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("sai").Length == 0)
            {
                GracefullyExit("Error: No instance of PaintTool SAI is currenntly running.\nPlease open SAI first!");
            }

            if (!File.Exists("config.ini"))
            {
                string contents = "SaveInterval=1" + Environment.NewLine;
                File.WriteAllText(Path.Combine(AppPath, "config.ini"), contents);
            }

            string iniContents = String.Empty;

            using (FileStream fs = File.Open(Path.Combine(AppPath, "config.ini"), FileMode.Open))
            using (StreamReader reader = new StreamReader(fs))
            {
                iniContents = reader.ReadToEnd();
            }

            if (iniContents.Length > 0)
            {
                string[] lines = iniContents.Split(new char[] { '\n' });
                Dictionary<string, string> config = new Dictionary<string, string>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] keyAndValue = line.Split(new char[] { '=' });
                    config.Add(keyAndValue[0].Trim(), keyAndValue[1].Trim());
                }

                if (config.ContainsKey("SaveInterval"))
                {
                    string SaveInterval = config["SaveInterval"];
                    int interval = 0;
                    Int32.TryParse(SaveInterval, out interval);
                    intervalTrackbar.Value = interval;
                }
                else
                {
                    GracefullyExit("Error: Invalid configuration file.");
                }
            }
            else
            {
                GracefullyExit("Error: Invalid configuration file.");
            }

            int component = intervalTrackbar.Value * 5;
            currentInterval.Text = component.ToString() + " minutes";

            int timerInterval = intervalTrackbar.Value * multiplier;
            if (timerInterval == 0)
            {
                Trigger.Enabled = false;
            }
            else
            {
                Trigger.Interval = timerInterval;
                Trigger.Enabled = true;
            }
        }

        private void intervalTrackbar_Scroll(object sender, EventArgs e)
        {
            int component = intervalTrackbar.Value * 5;
            if (component == 0)
            {
                currentInterval.Text = "Disabled.";
            }
            else
            {
                currentInterval.Text = component.ToString() + " minutes";
            }

            Trigger.Enabled = false;
            applyButton.Enabled = true;
        }

        private void Trigger_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("sai");

            foreach (Process p in processes)
            {
                IntPtr windowHandle = p.MainWindowHandle;

                if (GetForegroundWindow() == windowHandle)
                {
                    SendKeys.Send("^{s}");

                    if (DEBUG_MODE)
                    {
                        taskbarIcon.BalloonTipTitle = "Tick!";
                        taskbarIcon.BalloonTipText = "SAI is the active window. CTRL+S should have been sent.";
                        taskbarIcon.ShowBalloonTip(20000);
                    }
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            int timerInterval = intervalTrackbar.Value * multiplier;

            if (timerInterval == 0)
            {
                Trigger.Enabled = false;
            }
            else
            {
                Trigger.Interval = timerInterval;
                Trigger.Enabled = true;
            }

            applyButton.Enabled = false;
            File.WriteAllText(Path.Combine(AppPath, "config.ini"), "SaveInterval=" + intervalTrackbar.Value);
        }

        private void SettingsWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                taskbarIcon.Visible = true;
                this.Hide();
            }
        }

        private void taskbarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void openSettingsMenuitem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                taskbarIcon.Visible = true;
                this.Hide();
            }
        }

        private void CheckifOpen_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("sai").Length == 0)
            {
                Application.Exit();
            }
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/jozsefsallai/sai-autosaver");
        }
    }
}
