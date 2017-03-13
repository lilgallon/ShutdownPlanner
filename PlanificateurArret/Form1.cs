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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            consoleLaunch();
            cmd.StandardInput.WriteLine("shutdown /a");
            consoleClose();
            planned = false;
            updateLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // schtasks.exe /change /TN pepe /ENABLE
            // https://technet.microsoft.com/en-us/library/cc755618(WS.10).aspx
            // https://technet.microsoft.com/en-us/library/cc772785(WS.10).aspx
            currentTimeLabel.Text = "Il est " + DateTime.Now.ToString("HH:mm:ss tt");
            updateLabel();

            Timer timer = new Timer();
            timer.Interval = (1000); // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = "Il est " + DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void updateLabel()
        {
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

        private void planningButtonn_Click_1(object sender, EventArgs e)
        {
            int minutesPlanned, hoursPlanned, secondsPlanned, currentMinutes, currentHours, currentSeconds;
            string secondsStr, commandShutdown, commandRestart, command, commandForce;
            // Planned is used to display the statut message
            planned = true;

            // Get actual time
            currentHours = DateTime.Now.Hour;
            currentMinutes = DateTime.Now.Minute;
            currentSeconds = currentHours * 3600 + currentMinutes * 60;

            // Get planned time
            minutesPlanned = timePickerr.Value.Minute;
            hoursPlanned = timePickerr.Value.Hour;
            secondsPlanned = (minutesPlanned * 60 + hoursPlanned * 3600) - currentSeconds;

            // Used for the final command
            secondsStr = secondsPlanned.ToString();
            commandShutdown = "/s";
            commandRestart = "/a";
            commandForce = "/f";



            // Launches the console
            consoleLaunch();
            // Cancels operation (used to reset here)
            cmd.StandardInput.WriteLine("shutdown /a"); 


            if (checkBoxRestartt.Checked)
            {
                if (checkBoxForce.Checked)
                {
                    // Force restart
                    command = "shutdown " + commandForce + " " + commandRestart + " /t " + secondsStr;
                }
                else
                {
                    // Normal restart
                    command = "shutdown " + commandRestart + " /t " + secondsStr;
                }
            }
            else
            {
                if (checkBoxForce.Checked)
                {
                    // Force shutdown
                    command = "shutdown " + commandForce + " " + commandShutdown + " /t " + secondsStr;
                }
                else
                {
                    // Normal shutdown
                    command = "shutdown " + commandShutdown + " /t " + secondsStr;
                }

            }

            // Writes the command
            cmd.StandardInput.WriteLine(command);
            // Closes the console
            consoleClose();

            updateLabel();
        }
    }
}
