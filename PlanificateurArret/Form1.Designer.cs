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
            this.label1 = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.statut = new System.Windows.Forms.Label();
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.planningButtonn = new System.Windows.Forms.Button();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // currentTimeLabel
            // 
            resources.ApplyResources(this.currentTimeLabel, "currentTimeLabel");
            this.currentTimeLabel.Name = "currentTimeLabel";
            // 
            // linkWebsite
            // 
            resources.ApplyResources(this.linkWebsite, "linkWebsite");
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.TabStop = true;
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.planningButtonn);
            this.Controls.Add(this.checkBoxForce);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.linkWebsite);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButtonn);
            this.Controls.Add(this.checkBoxRestartt);
            this.Controls.Add(this.timePickerr);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timePickerr;
        private System.Windows.Forms.CheckBox checkBoxRestartt;
        private System.Windows.Forms.Button cancelButtonn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.Label statut;
        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.Button planningButtonn;
    }
}

