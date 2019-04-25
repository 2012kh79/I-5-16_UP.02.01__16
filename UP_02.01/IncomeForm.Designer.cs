namespace UP_02._01
{
    partial class IncomeForm
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
            this.tcnTable = new System.Windows.Forms.TabControl();
            this.tbpinstruction = new System.Windows.Forms.TabPage();
            this.dgvVidDocument = new System.Windows.Forms.DataGridView();
            this.tbpIncome = new System.Windows.Forms.TabPage();
            this.dgvPribil_i_rashodi = new System.Windows.Forms.DataGridView();
            this.tbpCheckVidMed = new System.Windows.Forms.TabPage();
            this.dgvCheckVidMed = new System.Windows.Forms.DataGridView();
            this.tbpMedicament = new System.Windows.Forms.TabPage();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.tbpProdajaTovara = new System.Windows.Forms.TabPage();
            this.dgvProdajaTov = new System.Windows.Forms.DataGridView();
            this.tcnTable.SuspendLayout();
            this.tbpinstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).BeginInit();
            this.tbpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPribil_i_rashodi)).BeginInit();
            this.tbpCheckVidMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckVidMed)).BeginInit();
            this.tbpMedicament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.tbpProdajaTovara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajaTov)).BeginInit();
            this.SuspendLayout();
            // 
            // tcnTable
            // 
            this.tcnTable.Controls.Add(this.tbpinstruction);
            this.tcnTable.Controls.Add(this.tbpIncome);
            this.tcnTable.Controls.Add(this.tbpCheckVidMed);
            this.tcnTable.Controls.Add(this.tbpMedicament);
            this.tcnTable.Controls.Add(this.tbpProdajaTovara);
            this.tcnTable.Location = new System.Drawing.Point(12, 78);
            this.tcnTable.Name = "tcnTable";
            this.tcnTable.SelectedIndex = 0;
            this.tcnTable.Size = new System.Drawing.Size(860, 300);
            this.tcnTable.TabIndex = 2;
            this.tcnTable.SelectedIndexChanged += new System.EventHandler(this.tcnTable_SelectedIndexChanged);
            // 
            // tbpinstruction
            // 
            this.tbpinstruction.Controls.Add(this.dgvVidDocument);
            this.tbpinstruction.Location = new System.Drawing.Point(4, 22);
            this.tbpinstruction.Name = "tbpinstruction";
            this.tbpinstruction.Padding = new System.Windows.Forms.Padding(3);
            this.tbpinstruction.Size = new System.Drawing.Size(852, 274);
            this.tbpinstruction.TabIndex = 0;
            this.tbpinstruction.Text = "Инструкция";
            this.tbpinstruction.UseVisualStyleBackColor = true;
            // 
            // dgvVidDocument
            // 
            this.dgvVidDocument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVidDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVidDocument.Location = new System.Drawing.Point(6, 6);
            this.dgvVidDocument.Name = "dgvVidDocument";
            this.dgvVidDocument.Size = new System.Drawing.Size(840, 287);
            this.dgvVidDocument.TabIndex = 0;
            this.dgvVidDocument.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVidDocument_CellClick);
            // 
            // tbpIncome
            // 
            this.tbpIncome.Controls.Add(this.dgvPribil_i_rashodi);
            this.tbpIncome.Location = new System.Drawing.Point(4, 22);
            this.tbpIncome.Name = "tbpIncome";
            this.tbpIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncome.Size = new System.Drawing.Size(852, 274);
            this.tbpIncome.TabIndex = 1;
            this.tbpIncome.Text = "Прибыль и расходы";
            this.tbpIncome.UseVisualStyleBackColor = true;
            // 
            // dgvPribil_i_rashodi
            // 
            this.dgvPribil_i_rashodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPribil_i_rashodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPribil_i_rashodi.Location = new System.Drawing.Point(6, 6);
            this.dgvPribil_i_rashodi.Name = "dgvPribil_i_rashodi";
            this.dgvPribil_i_rashodi.Size = new System.Drawing.Size(840, 287);
            this.dgvPribil_i_rashodi.TabIndex = 1;
            this.dgvPribil_i_rashodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPribil_i_rashodi_CellClick);
            // 
            // tbpCheckVidMed
            // 
            this.tbpCheckVidMed.Controls.Add(this.dgvCheckVidMed);
            this.tbpCheckVidMed.Location = new System.Drawing.Point(4, 22);
            this.tbpCheckVidMed.Name = "tbpCheckVidMed";
            this.tbpCheckVidMed.Size = new System.Drawing.Size(852, 274);
            this.tbpCheckVidMed.TabIndex = 2;
            this.tbpCheckVidMed.Text = "Чек выданных медикаментов";
            this.tbpCheckVidMed.UseVisualStyleBackColor = true;
            // 
            // dgvCheckVidMed
            // 
            this.dgvCheckVidMed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCheckVidMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckVidMed.Location = new System.Drawing.Point(6, -6);
            this.dgvCheckVidMed.Name = "dgvCheckVidMed";
            this.dgvCheckVidMed.Size = new System.Drawing.Size(840, 287);
            this.dgvCheckVidMed.TabIndex = 2;
            this.dgvCheckVidMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckVidMed_CellClick);
            // 
            // tbpMedicament
            // 
            this.tbpMedicament.Controls.Add(this.dgvMed);
            this.tbpMedicament.Location = new System.Drawing.Point(4, 22);
            this.tbpMedicament.Name = "tbpMedicament";
            this.tbpMedicament.Size = new System.Drawing.Size(852, 274);
            this.tbpMedicament.TabIndex = 3;
            this.tbpMedicament.Text = "Медикаменты";
            this.tbpMedicament.UseVisualStyleBackColor = true;
            // 
            // dgvMed
            // 
            this.dgvMed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(6, -6);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(840, 287);
            this.dgvMed.TabIndex = 3;
            this.dgvMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMed_CellClick);
            // 
            // tbpProdajaTovara
            // 
            this.tbpProdajaTovara.Controls.Add(this.dgvProdajaTov);
            this.tbpProdajaTovara.Location = new System.Drawing.Point(4, 22);
            this.tbpProdajaTovara.Name = "tbpProdajaTovara";
            this.tbpProdajaTovara.Size = new System.Drawing.Size(852, 274);
            this.tbpProdajaTovara.TabIndex = 4;
            this.tbpProdajaTovara.Text = "Продажа товара";
            this.tbpProdajaTovara.UseVisualStyleBackColor = true;
            // 
            // dgvProdajaTov
            // 
            this.dgvProdajaTov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdajaTov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdajaTov.Location = new System.Drawing.Point(6, -6);
            this.dgvProdajaTov.Name = "dgvProdajaTov";
            this.dgvProdajaTov.Size = new System.Drawing.Size(840, 287);
            this.dgvProdajaTov.TabIndex = 3;
            this.dgvProdajaTov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdajaTov_CellClick);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tcnTable);
            this.Name = "IncomeForm";
            this.Text = "Доходы и расходы";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.tcnTable.ResumeLayout(false);
            this.tbpinstruction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).EndInit();
            this.tbpIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPribil_i_rashodi)).EndInit();
            this.tbpCheckVidMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckVidMed)).EndInit();
            this.tbpMedicament.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.tbpProdajaTovara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajaTov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpinstruction;
        private System.Windows.Forms.DataGridView dgvVidDocument;
        private System.Windows.Forms.TabPage tbpIncome;
        private System.Windows.Forms.DataGridView dgvPribil_i_rashodi;
        private System.Windows.Forms.TabPage tbpCheckVidMed;
        private System.Windows.Forms.DataGridView dgvCheckVidMed;
        private System.Windows.Forms.TabPage tbpMedicament;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.TabPage tbpProdajaTovara;
        private System.Windows.Forms.DataGridView dgvProdajaTov;
    }
}