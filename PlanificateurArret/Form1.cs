using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PlanificateurArret
{
    public partial class Form1 : Form
    {
        private int minutes;
        private int hour;
        private int seconds;
        private string secondsStr;
        private string commandShutdown;
        private string commandRestart;
        public Form1()
        {
            InitializeComponent();
        }

        private void planningButton_Click(object sender, EventArgs e)
        {

            minutes = timePicker.Value.Minute;
            hour = timePicker.Value.Hour;
            seconds = minutes * 60 + hour * 3600;
            secondsStr = seconds.ToString();
            commandShutdown = "shutdown -s -t " + secondsStr;
            commandRestart = "shutdown -a -t " + secondsStr;

            // Console
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            if (checkBoxRestart.Checked)
            {
                cmd.StandardInput.WriteLine(commandRestart);
            }
            else
            {
                cmd.StandardInput.WriteLine(commandShutdown);
            }
      
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

            // System.Diagnostics.Process.Start("CMD.exe", secondsStr);
            // envoyer la planif
        }

    }
}
