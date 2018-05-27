namespace UniversitySite
{
    partial class RequestFindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestFindForm));
            this.label1 = new System.Windows.Forms.Label();
            this.RBPlan = new System.Windows.Forms.RadioButton();
            this.RBSpecialities = new System.Windows.Forms.RadioButton();
            this.RBLeaders = new System.Windows.Forms.RadioButton();
            this.RBMaxScore = new System.Windows.Forms.RadioButton();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to see?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RBPlan
            // 
            this.RBPlan.AutoSize = true;
            this.RBPlan.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPlan.Location = new System.Drawing.Point(178, 145);
            this.RBPlan.Name = "RBPlan";
            this.RBPlan.Size = new System.Drawing.Size(204, 31);
            this.RBPlan.TabIndex = 1;
            this.RBPlan.TabStop = true;
            this.RBPlan.Text = "Plan of admission";
            this.RBPlan.UseVisualStyleBackColor = true;
            // 
            // RBSpecialities
            // 
            this.RBSpecialities.AutoSize = true;
            this.RBSpecialities.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSpecialities.Location = new System.Drawing.Point(178, 203);
            this.RBSpecialities.Name = "RBSpecialities";
            this.RBSpecialities.Size = new System.Drawing.Size(204, 31);
            this.RBSpecialities.TabIndex = 2;
            this.RBSpecialities.TabStop = true;
            this.RBSpecialities.Text = "List of specialities";
            this.RBSpecialities.UseVisualStyleBackColor = true;
            // 
            // RBLeaders
            // 
            this.RBLeaders.AutoSize = true;
            this.RBLeaders.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBLeaders.Location = new System.Drawing.Point(178, 259);
            this.RBLeaders.Name = "RBLeaders";
            this.RBLeaders.Size = new System.Drawing.Size(170, 31);
            this.RBLeaders.TabIndex = 3;
            this.RBLeaders.TabStop = true;
            this.RBLeaders.Text = "List of leaders";
            this.RBLeaders.UseVisualStyleBackColor = true;
            // 
            // RBMaxScore
            // 
            this.RBMaxScore.AutoSize = true;
            this.RBMaxScore.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMaxScore.Location = new System.Drawing.Point(178, 307);
            this.RBMaxScore.Name = "RBMaxScore";
            this.RBMaxScore.Size = new System.Drawing.Size(274, 31);
            this.RBMaxScore.TabIndex = 4;
            this.RBMaxScore.TabStop = true;
            this.RBMaxScore.Text = "Speciality with max score";
            this.RBMaxScore.UseVisualStyleBackColor = true;
            // 
            // ButtonFind
            // 
            this.ButtonFind.BackColor = System.Drawing.Color.PowderBlue;
            this.ButtonFind.Font = new System.Drawing.Font("Baskerville Old Face", 12F);
            this.ButtonFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonFind.Location = new System.Drawing.Point(136, 363);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(326, 41);
            this.ButtonFind.TabIndex = 7;
            this.ButtonFind.Text = "Find!";
            this.ButtonFind.UseVisualStyleBackColor = false;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // RequestFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 474);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.RBMaxScore);
            this.Controls.Add(this.RBLeaders);
            this.Controls.Add(this.RBSpecialities);
            this.Controls.Add(this.RBPlan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestFindForm";
            this.Text = "RequestFindForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestFindForm_FormClosing);
            this.Load += new System.EventHandler(this.RequestFindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBPlan;
        private System.Windows.Forms.RadioButton RBSpecialities;
        private System.Windows.Forms.RadioButton RBLeaders;
        private System.Windows.Forms.RadioButton RBMaxScore;
        private System.Windows.Forms.Button ButtonFind;
    }
}