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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.planningButton = new System.Windows.Forms.Button();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "H:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(101, 88);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(81, 20);
            this.timePicker.TabIndex = 0;
            // 
            // planningButton
            // 
            this.planningButton.Location = new System.Drawing.Point(67, 151);
            this.planningButton.Name = "planningButton";
            this.planningButton.Size = new System.Drawing.Size(137, 54);
            this.planningButton.TabIndex = 1;
            this.planningButton.Text = "Planifier";
            this.planningButton.UseVisualStyleBackColor = true;
            this.planningButton.Click += new System.EventHandler(this.planningButton_Click);
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.AutoSize = true;
            this.checkBoxRestart.Location = new System.Drawing.Point(101, 123);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(81, 17);
            this.checkBoxRestart.TabIndex = 2;
            this.checkBoxRestart.Text = "Redémarrer";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.planningButton);
            this.Controls.Add(this.timePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button planningButton;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.CheckBox checkBoxRestart;
    }
}

