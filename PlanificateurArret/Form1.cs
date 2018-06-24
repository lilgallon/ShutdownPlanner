using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace PlanificateurArret
{
    public partial class Form1 : Form
    {
        private Process cmd = new Process();
        private bool planned = false;
        public bool english = false;

        public Form1()
        {
            InitializeComponent();
            infoLabel.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // schtasks.exe /change /TN pepe /ENABLE
            // https://technet.microsoft.com/en-us/library/cc755618(WS.10).aspx
            // https://technet.microsoft.com/en-us/library/cc772785(WS.10).aspx
            
            Timer timer = new Timer();
            timer.Interval = (1000); // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private int abs(int a)
        {
            if (a > 0)
                return a;
            else
                return -a;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            currentTimeLabel.Text = "Current time : " + DateTime.Now.ToString("HH:mm:ss tt");

            /* CHRONO
            if (planned)
            {
                string chronoMinutes, chronoHours, chronoSeconds;
                toolStripChrono.Visible = true;
 
                chronoSeconds = (abs(DateTime.Now.Second - plannedSeconds)).ToString();
                chronoMinutes = (abs(DateTime.Now.Minute - plannedMinutes)).ToString();
                chronoHours = (abs(DateTime.Now.Hour - plannedHours)).ToString();

                toolStripChrono.Text = "Arret dans : " + chronoHours + ":" + chronoMinutes + ":" + chronoSeconds;
                
            }
            else if (toolStripChrono.Visible)
            {
                toolStripChrono.Visible = false;
            }
            */
        }

        // CONSOLE
        private void consoleLaunch()
        {
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            // Hide the console
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
            infoLabel.Text = "";
        }


        private void planningButtonn_Click_1(object sender, EventArgs e)
        {
            
            string secondsStr, shutdownCommand, restartCommand, command, forceCommand, commentCommand, timerCommand, reason;
            int plannedMinutes, plannedHours, currentMinutes, currentHours, currentSeconds;
            int plannedSecondsTotal;
            // Planned is used to display the status message
            planned = true;

            // Get actual time
            currentHours = DateTime.Now.Hour;
            currentMinutes = DateTime.Now.Minute;
            currentSeconds = currentHours * 3600 + currentMinutes * 60;

            // Get planned time
            plannedMinutes = timePickerr.Value.Minute;
            plannedHours = timePickerr.Value.Hour;
            //plannedSeconds = timePickerr.Value.Second; used for the chrono
            int SECONDS_IN_A_DAY = 3600 * 60 * 24;
            plannedSecondsTotal = mod(((plannedMinutes * 60 + plannedHours * 3600) - currentSeconds), SECONDS_IN_A_DAY);

            if (plannedSecondsTotal < 60)
            {
                var confirmResult = MessageBox.Show("Are you sure to shutdown your computer RIGHT FAKING NOW ?",
                                     "Confirm ?",
                                     MessageBoxButtons.YesNo);
                if (confirmResult != DialogResult.Yes)
                {
                    planned = false;
                    return;
                }
            }

            infoLabel.Text = "Stops at " + plannedHours.ToString() + ":" + plannedMinutes.ToString() + ".";


            if (!textReason.Equals("Reason"))
            {
                reason = textReason.Text;
            }
            else
            {
                reason = "Shutdown planned by ShutdownPlaner";
            }

            // Used for the final command
            secondsStr = plannedSecondsTotal.ToString();
            shutdownCommand = "/s";
            restartCommand = "/r";
            forceCommand = "/f";
            commentCommand = "/c";
            timerCommand = "/t";

            // Launches the console
            consoleLaunch();
            // Cancels operation (used to reset here)
            cmd.StandardInput.WriteLine("shutdown /a"); 


            if (checkBoxRestartt.Checked)
            {
                if (checkBoxForce.Checked)
                {
                    // Force restart
                    command = "shutdown " + forceCommand + " " + restartCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + reason + "\"";
                }
                else
                {
                    // Normal restart
                    command = "shutdown " + restartCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + reason + "\"";
                }
            }
            else
            {
                if (checkBoxForce.Checked)
                {
                    // Force shutdown
                    command = "shutdown " + forceCommand + " " + shutdownCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + reason + "\"";
                }
                else
                {
                    // Normal shutdown
                    command = "shutdown " + shutdownCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + reason + "\"";
                }

            }

            // Writes the command
            cmd.StandardInput.WriteLine(command);
            // Closes the console
            consoleClose();
        }

        private int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        private void toolStripButtonInternet_Click(object sender, EventArgs e)
        {
            Process.Start("https://n3roo.github.io/");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help helpBox = new Help();
            helpBox.Show();
        }
    }

    
}
