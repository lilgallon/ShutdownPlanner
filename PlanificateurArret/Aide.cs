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

namespace PlanificateurArret
{
    
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void linkLabelLicence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://creativecommons.org/licenses/by-nc-nd/3.0/fr/");
        }
    }
}
