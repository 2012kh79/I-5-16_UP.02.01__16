namespace UP_02._01
{
    partial class ApplicationForm
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
            this.pnTabel = new System.Windows.Forms.Panel();
            this.dgvApplicationForm = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTabel
            // 
            this.pnTabel.Controls.Add(this.dgvApplicationForm);
            this.pnTabel.Location = new System.Drawing.Point(12, 78);
            this.pnTabel.Name = "pnTabel";
            this.pnTabel.Size = new System.Drawing.Size(860, 325);
            this.pnTabel.TabIndex = 0;
            // 
            // dgvApplicationForm
            // 
            this.dgvApplicationForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplicationForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationForm.Location = new System.Drawing.Point(3, 3);
            this.dgvApplicationForm.Name = "dgvApplicationForm";
            this.dgvApplicationForm.ReadOnly = true;
            this.dgvApplicationForm.Size = new System.Drawing.Size(854, 319);
            this.dgvApplicationForm.TabIndex = 0;
            this.dgvApplicationForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicationForm_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnTabel);
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкета соискателя";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.pnTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTabel;
        public System.Windows.Forms.DataGridView dgvApplicationForm;
        private System.Windows.Forms.Button button1;
    }
}