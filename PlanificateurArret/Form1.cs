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
        public Form1()
        {
            InitializeComponent();
        }
        private void updateLabel()
        {
            statut.Text = "Statut : ";
            if (planned)
            {
                statut.ForeColor = System.Drawing.Color.Green;
                statut.Text += "Planifié.";
            }
            else
            {
                statut.ForeColor = System.Drawing.Color.Red;
                statut.Text += "Non planifié.";
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // schtasks.exe /change /TN pepe /ENABLE
            // https://technet.microsoft.com/en-us/library/cc755618(WS.10).aspx
            // https://technet.microsoft.com/en-us/library/cc772785(WS.10).aspx
            updateLabel();

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
            currentTimeLabel.Text = "Il est " + DateTime.Now.ToString("HH:mm:ss tt");
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
            updateLabel();
        }


        private void planningButtonn_Click_1(object sender, EventArgs e)
        {
            
            string secondsStr, shutdownCommand, restartCommand, command, forceCommand, commentCommand, timerCommand;
            int plannedMinutes, plannedHours, currentMinutes, currentHours, currentSeconds;
            int plannedSecondsTotal;
            // Planned is used to display the statut message
            planned = true;

            // Get actual time
            currentHours = DateTime.Now.Hour;
            currentMinutes = DateTime.Now.Minute;
            currentSeconds = currentHours * 3600 + currentMinutes * 60;


            // Get planned time
            plannedMinutes = timePickerr.Value.Minute;
            plannedHours = timePickerr.Value.Hour;
            //plannedSeconds = timePickerr.Value.Second; used for the chrono
            plannedSecondsTotal = (plannedMinutes * 60 + plannedHours * 3600) - currentSeconds;

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
                    command = "shutdown " + forceCommand + " " + restartCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + textReason + "\"";
                }
                else
                {
                    // Normal restart
                    command = "shutdown " + restartCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + textReason + "\"";
                }
            }
            else
            {
                if (checkBoxForce.Checked)
                {
                    // Force shutdown
                    command = "shutdown " + forceCommand + " " + shutdownCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + textReason + "\"";
                }
                else
                {
                    // Normal shutdown
                    command = "shutdown " + shutdownCommand + " " + timerCommand + " " + secondsStr + " " + commentCommand + " " + "\"" + textReason + "\"";
                }

            }

            // Writes the command
            cmd.StandardInput.WriteLine(command);
            // Closes the console
            consoleClose();

            updateLabel();
        }

        private void toolStripButtonInternet_Click(object sender, EventArgs e)
        {
            Process.Start("http://swellchaser.pagesperso-orange.fr");
        }


        // Help box
        private void toolStripHelp_Click(object sender, EventArgs e)
        {
            Form2 helpBox = new Form2();
            helpBox.Show();
        }

    }
    
    public class Form2 : Form
    {
        public Form2()
        {
            Text = "Aide";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Label helpText = new Label();
            helpText.Location = new Point(10, 10);
            helpText.Text = "L'option redémarrer permet de redemarrer l'ordinateur. L'option forcer force l'ordinateur lors de son extinction, " +
                "c'est à dire qu'aucun programme ne pourra empecher sa fermeture.";
        }
    }
    
}
