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
        private int minutesCurrent;
        private int hourCurrent;
        private int secondsCurrent;
        private string secondsStr;
        private string commandShutdown;
        private string commandRestart;
        public Form1()
        {
            InitializeComponent();
        }

        private void planningButton_Click(object sender, EventArgs e)
        {
            hourCurrent = DateTime.Now.Hour;
            minutesCurrent = DateTime.Now.Minute;
            secondsCurrent = hourCurrent * 3600 + minutesCurrent * 60;

            minutes = timePicker.Value.Minute;
            hour = timePicker.Value.Hour;
            seconds = (minutes * 60 + hour * 3600)-secondsCurrent;
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

            cmd.StandardInput.WriteLine("shutdown /a"); // cancel operation (used to reset here)

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

        }

    }
}
