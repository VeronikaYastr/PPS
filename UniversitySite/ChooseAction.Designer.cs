namespace UniversitySite
{
    partial class ChooseAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAction));
            this.RButtonAdd = new System.Windows.Forms.RadioButton();
            this.RButtonUpdate = new System.Windows.Forms.RadioButton();
            this.RButtonFind = new System.Windows.Forms.RadioButton();
            this.ButtonChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RButtonAdd
            // 
            this.RButtonAdd.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonAdd.Location = new System.Drawing.Point(218, 81);
            this.RButtonAdd.Name = "RButtonAdd";
            this.RButtonAdd.Size = new System.Drawing.Size(308, 79);
            this.RButtonAdd.TabIndex = 0;
            this.RButtonAdd.TabStop = true;
            this.RButtonAdd.Text = "Add Info";
            this.RButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RButtonAdd.UseVisualStyleBackColor = true;
            this.RButtonAdd.CheckedChanged += new System.EventHandler(this.RButtonAdd_CheckedChanged);
            // 
            // RButtonUpdate
            // 
            this.RButtonUpdate.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonUpdate.Location = new System.Drawing.Point(218, 166);
            this.RButtonUpdate.Name = "RButtonUpdate";
            this.RButtonUpdate.Size = new System.Drawing.Size(308, 79);
            this.RButtonUpdate.TabIndex = 1;
            this.RButtonUpdate.TabStop = true;
            this.RButtonUpdate.Text = "Update Info";
            this.RButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // RButtonFind
            // 
            this.RButtonFind.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButtonFind.Location = new System.Drawing.Point(218, 251);
            this.RButtonFind.Name = "RButtonFind";
            this.RButtonFind.Size = new System.Drawing.Size(308, 79);
            this.RButtonFind.TabIndex = 2;
            this.RButtonFind.TabStop = true;
            this.RButtonFind.Text = "Find Info";
            this.RButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RButtonFind.UseVisualStyleBackColor = true;
            // 
            // ButtonChoose
            // 
            this.ButtonChoose.BackColor = System.Drawing.Color.PowderBlue;
            this.ButtonChoose.Font = new System.Drawing.Font("Baskerville Old Face", 12F);
            this.ButtonChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonChoose.Location = new System.Drawing.Point(218, 352);
            this.ButtonChoose.Name = "ButtonChoose";
            this.ButtonChoose.Size = new System.Drawing.Size(308, 41);
            this.ButtonChoose.TabIndex = 3;
            this.ButtonChoose.Text = "Go!";
            this.ButtonChoose.UseVisualStyleBackColor = false;
            this.ButtonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 50);
            this.label1.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelName.Location = new System.Drawing.Point(615, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 25);
            this.labelName.TabIndex = 5;
            // 
            // ChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 466);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonChoose);
            this.Controls.Add(this.RButtonFind);
            this.Controls.Add(this.RButtonUpdate);
            this.Controls.Add(this.RButtonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseAction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseAction_FormClosing);
            this.Load += new System.EventHandler(this.ChooseAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RButtonAdd;
        private System.Windows.Forms.RadioButton RButtonUpdate;
        private System.Windows.Forms.RadioButton RButtonFind;
        private System.Windows.Forms.Button ButtonChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
    }
}