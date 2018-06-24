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
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.planningButtonn = new System.Windows.Forms.Button();
            this.textReason = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // textReason
            // 
            resources.ApplyResources(this.textReason, "textReason");
            this.textReason.Name = "textReason";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRestartt);
            this.groupBox1.Controls.Add(this.checkBoxForce);
            this.groupBox1.Controls.Add(this.textReason);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.infoLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.timePickerr);
            this.groupBox2.Controls.Add(this.currentTimeLabel);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.planningButtonn);
            this.Controls.Add(this.cancelButtonn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timePickerr;
        private System.Windows.Forms.CheckBox checkBoxRestartt;
        private System.Windows.Forms.Button cancelButtonn;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.Button planningButtonn;
        private System.Windows.Forms.TextBox textReason;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
    }
}

