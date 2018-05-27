namespace UniversitySite
{
    partial class FindInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RBIntramural = new System.Windows.Forms.RadioButton();
            this.RBExtramural = new System.Windows.Forms.RadioButton();
            this.RBPart = new System.Windows.Forms.RadioButton();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(53, 115);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(244, 26);
            this.textYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Form of education";
            // 
            // RBIntramural
            // 
            this.RBIntramural.AutoSize = true;
            this.RBIntramural.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBIntramural.Location = new System.Drawing.Point(430, 172);
            this.RBIntramural.Name = "RBIntramural";
            this.RBIntramural.Size = new System.Drawing.Size(137, 31);
            this.RBIntramural.TabIndex = 3;
            this.RBIntramural.TabStop = true;
            this.RBIntramural.Text = "Intramural";
            this.RBIntramural.UseVisualStyleBackColor = true;
            // 
            // RBExtramural
            // 
            this.RBExtramural.AutoSize = true;
            this.RBExtramural.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBExtramural.Location = new System.Drawing.Point(430, 224);
            this.RBExtramural.Name = "RBExtramural";
            this.RBExtramural.Size = new System.Drawing.Size(142, 31);
            this.RBExtramural.TabIndex = 4;
            this.RBExtramural.TabStop = true;
            this.RBExtramural.Text = "Extramural";
            this.RBExtramural.UseVisualStyleBackColor = true;
            // 
            // RBPart
            // 
            this.RBPart.AutoSize = true;
            this.RBPart.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBPart.Location = new System.Drawing.Point(430, 120);
            this.RBPart.Name = "RBPart";
            this.RBPart.Size = new System.Drawing.Size(133, 31);
            this.RBPart.TabIndex = 5;
            this.RBPart.TabStop = true;
            this.RBPart.Text = "Part-Time";
            this.RBPart.UseVisualStyleBackColor = true;
            // 
            // ButtonFind
            // 
            this.ButtonFind.BackColor = System.Drawing.Color.PowderBlue;
            this.ButtonFind.Font = new System.Drawing.Font("Baskerville Old Face", 12F);
            this.ButtonFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonFind.Location = new System.Drawing.Point(166, 320);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(397, 41);
            this.ButtonFind.TabIndex = 6;
            this.ButtonFind.Text = "Go!";
            this.ButtonFind.UseVisualStyleBackColor = false;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // FindInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 453);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.RBPart);
            this.Controls.Add(this.RBExtramural);
            this.Controls.Add(this.RBIntramural);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindInfo_FormClosing);
            this.Load += new System.EventHandler(this.FindInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBIntramural;
        private System.Windows.Forms.RadioButton RBExtramural;
        private System.Windows.Forms.RadioButton RBPart;
        private System.Windows.Forms.Button ButtonFind;
    }
}