using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        FakeDatabase database;
        public Form1()
        {
            InitializeComponent();
            database = new FakeDatabase();
            SelectProgram.DataSource = database.DataBase;
            MyAppNotifyIcon.Icon = this.Icon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            MyAppTimer.Interval = 20000;
            MyAppTimer.Start();
        }

        private void Form1_Activate(object sender, EventArgs e)
        {
            MyAppTimer.Stop();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var text = SelectProgram.SelectedCells[0].Value.ToString();
            switch (text)
            {
                case "Lab3txt":
                    Process.Start(@"C:\Temp\Lab3.txt");
                    MyAppNotifyIcon.ShowBalloonTip(20, "StartProcess", @"C:\Temp\Lab3.txt", ToolTipIcon.Info);
                    break;
                case "Lab3csv":
                    //Process.Start(@"C:\Temp\Lab3.csv");
                    MyAppNotifyIcon.ShowBalloonTip(20, "StartProcess", @"C:\Temp\Lab3.csv", ToolTipIcon.Info);
                    break;
                case "Chrome":
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", ParamsText.Text);
                    MyAppNotifyIcon.ShowBalloonTip(20, "StartProcess", @"Chrome", ToolTipIcon.Info);
                    break;
                case "Word":
                    Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.EXE", "/f \"" + ParamsText.Text + "\"");
                    MyAppNotifyIcon.ShowBalloonTip(20, "StartProcess", @"MSWord", ToolTipIcon.Info);
                    break;

            }
        }

        private void MyAppNotifyIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void MyAppNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void MyAppTimer_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            MyAppNotifyIcon.ShowBalloonTip(10, "I'm here!", "Application was minimized because of inactive", ToolTipIcon.Warning);
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            MyOpenFileDialog.ShowDialog();
            string fileName = MyOpenFileDialog.FileName;
            ParamsText.Text = fileName;
        }
    }
}
