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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tbpCheckVidMed = new System.Windows.Forms.TabPage();
            this.tbpMedicament = new System.Windows.Forms.TabPage();
            this.tbpProdajaTovara = new System.Windows.Forms.TabPage();
            this.dgvCheckVidMed = new System.Windows.Forms.DataGridView();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.dgvProdajaTov = new System.Windows.Forms.DataGridView();
            this.tcnTable.SuspendLayout();
            this.tbpinstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).BeginInit();
            this.tbpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tbpCheckVidMed.SuspendLayout();
            this.tbpMedicament.SuspendLayout();
            this.tbpProdajaTovara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckVidMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
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
            this.dgvVidDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVidDocument.Location = new System.Drawing.Point(6, 6);
            this.dgvVidDocument.Name = "dgvVidDocument";
            this.dgvVidDocument.Size = new System.Drawing.Size(840, 287);
            this.dgvVidDocument.TabIndex = 0;
            // 
            // tbpIncome
            // 
            this.tbpIncome.Controls.Add(this.dgvOrder);
            this.tbpIncome.Location = new System.Drawing.Point(4, 22);
            this.tbpIncome.Name = "tbpIncome";
            this.tbpIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncome.Size = new System.Drawing.Size(852, 274);
            this.tbpIncome.TabIndex = 1;
            this.tbpIncome.Text = "Прибыль и расходы";
            this.tbpIncome.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(840, 287);
            this.dgvOrder.TabIndex = 1;
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
            // dgvCheckVidMed
            // 
            this.dgvCheckVidMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckVidMed.Location = new System.Drawing.Point(6, -6);
            this.dgvCheckVidMed.Name = "dgvCheckVidMed";
            this.dgvCheckVidMed.Size = new System.Drawing.Size(840, 287);
            this.dgvCheckVidMed.TabIndex = 2;
            // 
            // dgvMed
            // 
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Location = new System.Drawing.Point(6, -6);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(840, 287);
            this.dgvMed.TabIndex = 3;
            // 
            // dgvProdajaTov
            // 
            this.dgvProdajaTov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdajaTov.Location = new System.Drawing.Point(6, -6);
            this.dgvProdajaTov.Name = "dgvProdajaTov";
            this.dgvProdajaTov.Size = new System.Drawing.Size(840, 287);
            this.dgvProdajaTov.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tbpCheckVidMed.ResumeLayout(false);
            this.tbpMedicament.ResumeLayout(false);
            this.tbpProdajaTovara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckVidMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajaTov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpinstruction;
        private System.Windows.Forms.DataGridView dgvVidDocument;
        private System.Windows.Forms.TabPage tbpIncome;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TabPage tbpCheckVidMed;
        private System.Windows.Forms.DataGridView dgvCheckVidMed;
        private System.Windows.Forms.TabPage tbpMedicament;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.TabPage tbpProdajaTovara;
        private System.Windows.Forms.DataGridView dgvProdajaTov;
    }
}