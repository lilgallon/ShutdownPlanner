namespace PlanificateurArret
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timePickerr = new System.Windows.Forms.DateTimePicker();
            this.checkBoxRestartt = new System.Windows.Forms.CheckBox();
            this.cancelButtonn = new System.Windows.Forms.Button();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.statut = new System.Windows.Forms.Label();
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.planningButtonn = new System.Windows.Forms.Button();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.textReason = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInternet = new System.Windows.Forms.ToolStripButton();
            this.toolStripHelp = new System.Windows.Forms.ToolStripLabel();
            this.toolStripChrono = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePickerr
            // 
            resources.ApplyResources(this.timePickerr, "timePickerr");
            this.timePickerr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerr.Name = "timePickerr";
            // 
            // checkBoxRestartt
            // 
            resources.ApplyResources(this.checkBoxRestartt, "checkBoxRestartt");
            this.checkBoxRestartt.Name = "checkBoxRestartt";
            this.checkBoxRestartt.UseVisualStyleBackColor = false;
            // 
            // cancelButtonn
            // 
            resources.ApplyResources(this.cancelButtonn, "cancelButtonn");
            this.cancelButtonn.Name = "cancelButtonn";
            this.cancelButtonn.UseVisualStyleBackColor = true;
            this.cancelButtonn.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // currentTimeLabel
            // 
            resources.ApplyResources(this.currentTimeLabel, "currentTimeLabel");
            this.currentTimeLabel.Name = "currentTimeLabel";
            // 
            // statut
            // 
            resources.ApplyResources(this.statut, "statut");
            this.statut.Name = "statut";
            // 
            // checkBoxForce
            // 
            resources.ApplyResources(this.checkBoxForce, "checkBoxForce");
            this.checkBoxForce.Name = "checkBoxForce";
            this.checkBoxForce.UseVisualStyleBackColor = false;
            // 
            // planningButtonn
            // 
            resources.ApplyResources(this.planningButtonn, "planningButtonn");
            this.planningButtonn.Name = "planningButtonn";
            this.planningButtonn.UseVisualStyleBackColor = true;
            this.planningButtonn.Click += new System.EventHandler(this.planningButtonn_Click_1);
            // 
            // reasonLabel
            // 
            resources.ApplyResources(this.reasonLabel, "reasonLabel");
            this.reasonLabel.Name = "reasonLabel";
            // 
            // textReason
            // 
            resources.ApplyResources(this.textReason, "textReason");
            this.textReason.Name = "textReason";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInternet,
            this.toolStripHelp,
            this.toolStripSeparator,
            this.toolStripChrono});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButtonInternet
            // 
            this.toolStripButtonInternet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonInternet, "toolStripButtonInternet");
            this.toolStripButtonInternet.Name = "toolStripButtonInternet";
            this.toolStripButtonInternet.Click += new System.EventHandler(this.toolStripButtonInternet_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Name = "toolStripHelp";
            resources.ApplyResources(this.toolStripHelp, "toolStripHelp");
            this.toolStripHelp.Click += new System.EventHandler(this.toolStripHelp_Click);
            // 
            // toolStripChrono
            // 
            this.toolStripChrono.Name = "toolStripChrono";
            resources.ApplyResources(this.toolStripChrono, "toolStripChrono");
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textReason);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.planningButtonn);
            this.Controls.Add(this.checkBoxForce);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.cancelButtonn);
            this.Controls.Add(this.checkBoxRestartt);
            this.Controls.Add(this.timePickerr);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timePickerr;
        private System.Windows.Forms.CheckBox checkBoxRestartt;
        private System.Windows.Forms.Button cancelButtonn;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label statut;
        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.Button planningButtonn;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.TextBox textReason;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInternet;
        private System.Windows.Forms.ToolStripLabel toolStripHelp;
        private System.Windows.Forms.ToolStripLabel toolStripChrono;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}

