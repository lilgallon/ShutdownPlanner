using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PlanificateurArret
{
    public partial class Form1 : Form
    {
        private Process cmd = new Process();
        private bool planned = false;
        public Form1()
        {
            InitializeComponent();
        }




        private void consoleLaunch()
        {
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
        }

        private void consoleClose()
        {
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private void planningButton_Click(object sender, EventArgs e)
        {
            int minutes, hour, seconds, minutesCurrent, hourCurrent, secondsCurrent;
            string secondsStr, commandShutdown, commandRestart, command, commandForce;
            planned = true;

            hourCurrent = DateTime.Now.Hour;
            minutesCurrent = DateTime.Now.Minute;
            secondsCurrent = hourCurrent * 3600 + minutesCurrent * 60;

            minutes = timePicker.Value.Minute;
            hour = timePicker.Value.Hour;
            seconds = (minutes * 60 + hour * 3600) - secondsCurrent;
            secondsStr = seconds.ToString();
            commandShutdown = "/s";
            commandRestart = "/a" ;
            commandForce = "/f";



            // Console

            consoleLaunch();

            cmd.StandardInput.WriteLine("shutdown /a"); // cancel operation (used to reset here)

            if (checkBoxRestart.Checked)
            {
                if (checkBoxForce.Checked)
                {
                    command = "shutdown " + commandForce + " " +  commandRestart + " /t " + secondsStr;
                }
                else
                {
                    command = "shutdown " + commandRestart + " /t " + secondsStr;
                }
            }
            else
            {
                if (checkBoxForce.Checked)
                {
                    command = "shutdown " + commandForce + " " + commandShutdown + " /t " + secondsStr;
                }
                else
                {
                    command = "shutdown " + commandShutdown + " /t " + secondsStr;
                }
                
            }

            cmd.StandardInput.WriteLine(command);

            consoleClose();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            consoleLaunch();
            cmd.StandardInput.WriteLine("shutdown /a");
            consoleClose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentTimeLabel.Text = "Il est " + DateTime.Now.ToString("HH:mm:ss tt");
            statut.Text = "Statut : ";
            if (planned)
            {
                statut.Text += "Planifié.";
            }
            else
            {
                statut.Text += "Non planifié.";
            }
            Refresh();
            
        }

        private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://swellchaser.pagesperso-orange.fr");
        }
    }
}
