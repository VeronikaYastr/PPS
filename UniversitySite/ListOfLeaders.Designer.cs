namespace UniversitySite
{
    partial class ListOfLeaders
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
            this.dataGridLeaders = new System.Windows.Forms.DataGridView();
            this.FirstColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLeaders
            // 
            this.dataGridLeaders.AllowUserToAddRows = false;
            this.dataGridLeaders.AllowUserToDeleteRows = false;
            this.dataGridLeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridLeaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridLeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstColumn,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridLeaders.Location = new System.Drawing.Point(12, 134);
            this.dataGridLeaders.Name = "dataGridLeaders";
            this.dataGridLeaders.ReadOnly = true;
            this.dataGridLeaders.RowTemplate.Height = 28;
            this.dataGridLeaders.Size = new System.Drawing.Size(1110, 517);
            this.dataGridLeaders.TabIndex = 0;
            // 
            // FirstColumn
            // 
            this.FirstColumn.HeaderText = "Name";
            this.FirstColumn.Name = "FirstColumn";
            this.FirstColumn.ReadOnly = true;
            this.FirstColumn.Width = 87;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ScDegree";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 117;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ScRank";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 102;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "StartDate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Speciality";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 112;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Faculty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 96;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Department";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of leaders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F);
            this.label2.Location = new System.Drawing.Point(427, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 2;
            // 
            // ListOfLeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridLeaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListOfLeaders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfLeaders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListOfLeaders_FormClosing);
            this.Load += new System.EventHandler(this.ListOfLeaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLeaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
    }
}