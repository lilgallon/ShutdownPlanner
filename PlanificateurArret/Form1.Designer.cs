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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.planningButton.Location = new System.Drawing.Point(12, 189);
            this.planningButton.Name = "planningButton";
            this.planningButton.Size = new System.Drawing.Size(108, 49);
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
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(148, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 49);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Planificateur d\'arret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "par Lilian - V2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

