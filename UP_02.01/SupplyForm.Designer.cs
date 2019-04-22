namespace UP_02._01
{
    partial class SupplyForm
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
            this.tbpTovarNaSklade = new System.Windows.Forms.TabPage();
            this.dgvVidDocument = new System.Windows.Forms.DataGridView();
            this.tbpPostTovar = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tbpFirmPostavki = new System.Windows.Forms.TabPage();
            this.dgvTabelSalary = new System.Windows.Forms.DataGridView();
            this.tbpPostavshik = new System.Windows.Forms.TabPage();
            this.dgvKadrPerestanovki = new System.Windows.Forms.DataGridView();
            this.tabPostavka = new System.Windows.Forms.TabPage();
            this.dgvKadrUchet = new System.Windows.Forms.DataGridView();
            this.tcnTable.SuspendLayout();
            this.tbpTovarNaSklade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).BeginInit();
            this.tbpPostTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tbpFirmPostavki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelSalary)).BeginInit();
            this.tbpPostavshik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrPerestanovki)).BeginInit();
            this.tabPostavka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrUchet)).BeginInit();
            this.SuspendLayout();
            // 
            // tcnTable
            // 
            this.tcnTable.Controls.Add(this.tbpTovarNaSklade);
            this.tcnTable.Controls.Add(this.tbpPostTovar);
            this.tcnTable.Controls.Add(this.tbpFirmPostavki);
            this.tcnTable.Controls.Add(this.tbpPostavshik);
            this.tcnTable.Controls.Add(this.tabPostavka);
            this.tcnTable.Location = new System.Drawing.Point(12, 12);
            this.tcnTable.Name = "tcnTable";
            this.tcnTable.SelectedIndex = 0;
            this.tcnTable.Size = new System.Drawing.Size(860, 325);
            this.tcnTable.TabIndex = 1;
            // 
            // tbpTovarNaSklade
            // 
            this.tbpTovarNaSklade.Controls.Add(this.dgvVidDocument);
            this.tbpTovarNaSklade.Location = new System.Drawing.Point(4, 22);
            this.tbpTovarNaSklade.Name = "tbpTovarNaSklade";
            this.tbpTovarNaSklade.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTovarNaSklade.Size = new System.Drawing.Size(852, 299);
            this.tbpTovarNaSklade.TabIndex = 0;
            this.tbpTovarNaSklade.Text = "Товар на складе";
            this.tbpTovarNaSklade.UseVisualStyleBackColor = true;
            // 
            // dgvVidDocument
            // 
            this.dgvVidDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVidDocument.Location = new System.Drawing.Point(6, 6);
            this.dgvVidDocument.Name = "dgvVidDocument";
            this.dgvVidDocument.Size = new System.Drawing.Size(840, 287);
            this.dgvVidDocument.TabIndex = 0;
            // 
            // tbpPostTovar
            // 
            this.tbpPostTovar.Controls.Add(this.dgvOrder);
            this.tbpPostTovar.Location = new System.Drawing.Point(4, 22);
            this.tbpPostTovar.Name = "tbpPostTovar";
            this.tbpPostTovar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPostTovar.Size = new System.Drawing.Size(852, 299);
            this.tbpPostTovar.TabIndex = 1;
            this.tbpPostTovar.Text = "Поставляемый товар";
            this.tbpPostTovar.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(840, 287);
            this.dgvOrder.TabIndex = 1;
            // 
            // tbpFirmPostavki
            // 
            this.tbpFirmPostavki.Controls.Add(this.dgvTabelSalary);
            this.tbpFirmPostavki.Location = new System.Drawing.Point(4, 22);
            this.tbpFirmPostavki.Name = "tbpFirmPostavki";
            this.tbpFirmPostavki.Size = new System.Drawing.Size(852, 299);
            this.tbpFirmPostavki.TabIndex = 2;
            this.tbpFirmPostavki.Text = "Фирма поставки";
            this.tbpFirmPostavki.UseVisualStyleBackColor = true;
            this.tbpFirmPostavki.Visible = false;
            // 
            // dgvTabelSalary
            // 
            this.dgvTabelSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelSalary.Location = new System.Drawing.Point(6, 6);
            this.dgvTabelSalary.Name = "dgvTabelSalary";
            this.dgvTabelSalary.Size = new System.Drawing.Size(840, 287);
            this.dgvTabelSalary.TabIndex = 1;
            // 
            // tbpPostavshik
            // 
            this.tbpPostavshik.Controls.Add(this.dgvKadrPerestanovki);
            this.tbpPostavshik.Location = new System.Drawing.Point(4, 22);
            this.tbpPostavshik.Name = "tbpPostavshik";
            this.tbpPostavshik.Size = new System.Drawing.Size(852, 299);
            this.tbpPostavshik.TabIndex = 3;
            this.tbpPostavshik.Text = "Поставщики";
            this.tbpPostavshik.UseVisualStyleBackColor = true;
            this.tbpPostavshik.Visible = false;
            // 
            // dgvKadrPerestanovki
            // 
            this.dgvKadrPerestanovki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadrPerestanovki.Location = new System.Drawing.Point(6, 6);
            this.dgvKadrPerestanovki.Name = "dgvKadrPerestanovki";
            this.dgvKadrPerestanovki.Size = new System.Drawing.Size(840, 287);
            this.dgvKadrPerestanovki.TabIndex = 1;
            // 
            // tabPostavka
            // 
            this.tabPostavka.Controls.Add(this.dgvKadrUchet);
            this.tabPostavka.Location = new System.Drawing.Point(4, 22);
            this.tabPostavka.Name = "tabPostavka";
            this.tabPostavka.Size = new System.Drawing.Size(852, 299);
            this.tabPostavka.TabIndex = 4;
            this.tabPostavka.Text = "Поставки";
            this.tabPostavka.UseVisualStyleBackColor = true;
            this.tabPostavka.Visible = false;
            // 
            // dgvKadrUchet
            // 
            this.dgvKadrUchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadrUchet.Location = new System.Drawing.Point(6, 6);
            this.dgvKadrUchet.Name = "dgvKadrUchet";
            this.dgvKadrUchet.Size = new System.Drawing.Size(840, 287);
            this.dgvKadrUchet.TabIndex = 1;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tcnTable);
            this.Name = "SupplyForm";
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.tcnTable.ResumeLayout(false);
            this.tbpTovarNaSklade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).EndInit();
            this.tbpPostTovar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tbpFirmPostavki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelSalary)).EndInit();
            this.tbpPostavshik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrPerestanovki)).EndInit();
            this.tabPostavka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrUchet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpTovarNaSklade;
        private System.Windows.Forms.DataGridView dgvVidDocument;
        public System.Windows.Forms.TabPage tbpPostTovar;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TabPage tbpFirmPostavki;
        private System.Windows.Forms.DataGridView dgvTabelSalary;
        private System.Windows.Forms.TabPage tbpPostavshik;
        private System.Windows.Forms.DataGridView dgvKadrPerestanovki;
        private System.Windows.Forms.TabPage tabPostavka;
        private System.Windows.Forms.DataGridView dgvKadrUchet;
    }
}