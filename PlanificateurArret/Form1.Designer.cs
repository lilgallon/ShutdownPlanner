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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.planningButton = new System.Windows.Forms.Button();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            resources.ApplyResources(this.timePicker, "timePicker");
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Name = "timePicker";
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // planningButton
            // 
            resources.ApplyResources(this.planningButton, "planningButton");
            this.planningButton.Name = "planningButton";
            this.planningButton.UseVisualStyleBackColor = true;
            this.planningButton.Click += new System.EventHandler(this.planningButton_Click);
            // 
            // checkBoxRestart
            // 
            resources.ApplyResources(this.checkBoxRestart, "checkBoxRestart");
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.linkWebsite);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.planningButton);
            this.Controls.Add(this.timePicker);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button planningButton;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.CheckBox checkBoxRestart;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.Label label2;
    }
}

