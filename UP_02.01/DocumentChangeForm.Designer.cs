namespace UP_02._01
{
    partial class DocumentChangeForm
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
            this.tbpDocument = new System.Windows.Forms.TabPage();
            this.dgvVidDocument = new System.Windows.Forms.DataGridView();
            this.tbpOrder = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tcnDocument = new System.Windows.Forms.TabControl();
            this.tbpWord = new System.Windows.Forms.TabPage();
            this.tbpExcel = new System.Windows.Forms.TabPage();
            this.tbpSalary = new System.Windows.Forms.TabPage();
            this.tbpKadrPerestanovki = new System.Windows.Forms.TabPage();
            this.tabKadrUchet = new System.Windows.Forms.TabPage();
            this.dgvTabelSalary = new System.Windows.Forms.DataGridView();
            this.dgvKadrPerestanovki = new System.Windows.Forms.DataGridView();
            this.dgvKadrUchet = new System.Windows.Forms.DataGridView();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.tcnTable.SuspendLayout();
            this.tbpDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).BeginInit();
            this.tbpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tcnDocument.SuspendLayout();
            this.tbpWord.SuspendLayout();
            this.tbpExcel.SuspendLayout();
            this.tbpSalary.SuspendLayout();
            this.tbpKadrPerestanovki.SuspendLayout();
            this.tabKadrUchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrPerestanovki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrUchet)).BeginInit();
            this.SuspendLayout();
            // 
            // tcnTable
            // 
            this.tcnTable.Controls.Add(this.tbpDocument);
            this.tcnTable.Controls.Add(this.tbpOrder);
            this.tcnTable.Controls.Add(this.tbpSalary);
            this.tcnTable.Controls.Add(this.tbpKadrPerestanovki);
            this.tcnTable.Controls.Add(this.tabKadrUchet);
            this.tcnTable.Location = new System.Drawing.Point(12, 78);
            this.tcnTable.Name = "tcnTable";
            this.tcnTable.SelectedIndex = 0;
            this.tcnTable.Size = new System.Drawing.Size(860, 325);
            this.tcnTable.TabIndex = 0;
            // 
            // tbpDocument
            // 
            this.tbpDocument.Controls.Add(this.dgvVidDocument);
            this.tbpDocument.Location = new System.Drawing.Point(4, 22);
            this.tbpDocument.Name = "tbpDocument";
            this.tbpDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDocument.Size = new System.Drawing.Size(852, 299);
            this.tbpDocument.TabIndex = 0;
            this.tbpDocument.Text = "Виды документов";
            this.tbpDocument.UseVisualStyleBackColor = true;
            // 
            // dgvVidDocument
            // 
            this.dgvVidDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVidDocument.Location = new System.Drawing.Point(6, 6);
            this.dgvVidDocument.Name = "dgvVidDocument";
            this.dgvVidDocument.Size = new System.Drawing.Size(840, 287);
            this.dgvVidDocument.TabIndex = 0;
            // 
            // tbpOrder
            // 
            this.tbpOrder.Controls.Add(this.dgvOrder);
            this.tbpOrder.Location = new System.Drawing.Point(4, 22);
            this.tbpOrder.Name = "tbpOrder";
            this.tbpOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrder.Size = new System.Drawing.Size(852, 299);
            this.tbpOrder.TabIndex = 1;
            this.tbpOrder.Text = "Договора";
            this.tbpOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(840, 287);
            this.dgvOrder.TabIndex = 1;
            // 
            // tcnDocument
            // 
            this.tcnDocument.Controls.Add(this.tbpWord);
            this.tcnDocument.Controls.Add(this.tbpExcel);
            this.tcnDocument.Location = new System.Drawing.Point(743, 456);
            this.tcnDocument.Name = "tcnDocument";
            this.tcnDocument.SelectedIndex = 0;
            this.tcnDocument.Size = new System.Drawing.Size(125, 128);
            this.tcnDocument.TabIndex = 1;
            // 
            // tbpWord
            // 
            this.tbpWord.Controls.Add(this.btnWord);
            this.tbpWord.Location = new System.Drawing.Point(4, 22);
            this.tbpWord.Name = "tbpWord";
            this.tbpWord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWord.Size = new System.Drawing.Size(117, 102);
            this.tbpWord.TabIndex = 0;
            this.tbpWord.Text = "Word";
            this.tbpWord.UseVisualStyleBackColor = true;
            // 
            // tbpExcel
            // 
            this.tbpExcel.Controls.Add(this.btnExcel);
            this.tbpExcel.Location = new System.Drawing.Point(4, 22);
            this.tbpExcel.Name = "tbpExcel";
            this.tbpExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExcel.Size = new System.Drawing.Size(117, 102);
            this.tbpExcel.TabIndex = 1;
            this.tbpExcel.Text = "Excel";
            this.tbpExcel.UseVisualStyleBackColor = true;
            // 
            // tbpSalary
            // 
            this.tbpSalary.Controls.Add(this.dgvTabelSalary);
            this.tbpSalary.Location = new System.Drawing.Point(4, 22);
            this.tbpSalary.Name = "tbpSalary";
            this.tbpSalary.Size = new System.Drawing.Size(852, 299);
            this.tbpSalary.TabIndex = 2;
            this.tbpSalary.Text = "Заработная плата";
            this.tbpSalary.UseVisualStyleBackColor = true;
            this.tbpSalary.Visible = false;
            // 
            // tbpKadrPerestanovki
            // 
            this.tbpKadrPerestanovki.Controls.Add(this.dgvKadrPerestanovki);
            this.tbpKadrPerestanovki.Location = new System.Drawing.Point(4, 22);
            this.tbpKadrPerestanovki.Name = "tbpKadrPerestanovki";
            this.tbpKadrPerestanovki.Size = new System.Drawing.Size(852, 299);
            this.tbpKadrPerestanovki.TabIndex = 3;
            this.tbpKadrPerestanovki.Text = "Кадровые перестановки";
            this.tbpKadrPerestanovki.UseVisualStyleBackColor = true;
            this.tbpKadrPerestanovki.Visible = false;
            // 
            // tabKadrUchet
            // 
            this.tabKadrUchet.Controls.Add(this.dgvKadrUchet);
            this.tabKadrUchet.Location = new System.Drawing.Point(4, 22);
            this.tabKadrUchet.Name = "tabKadrUchet";
            this.tabKadrUchet.Size = new System.Drawing.Size(852, 299);
            this.tabKadrUchet.TabIndex = 4;
            this.tabKadrUchet.Text = "Кадровый учёт";
            this.tabKadrUchet.UseVisualStyleBackColor = true;
            this.tabKadrUchet.Visible = false;
            // 
            // dgvTabelSalary
            // 
            this.dgvTabelSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelSalary.Location = new System.Drawing.Point(6, 6);
            this.dgvTabelSalary.Name = "dgvTabelSalary";
            this.dgvTabelSalary.Size = new System.Drawing.Size(840, 287);
            this.dgvTabelSalary.TabIndex = 1;
            // 
            // dgvKadrPerestanovki
            // 
            this.dgvKadrPerestanovki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadrPerestanovki.Location = new System.Drawing.Point(6, 6);
            this.dgvKadrPerestanovki.Name = "dgvKadrPerestanovki";
            this.dgvKadrPerestanovki.Size = new System.Drawing.Size(840, 287);
            this.dgvKadrPerestanovki.TabIndex = 1;
            // 
            // dgvKadrUchet
            // 
            this.dgvKadrUchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadrUchet.Location = new System.Drawing.Point(6, 6);
            this.dgvKadrUchet.Name = "dgvKadrUchet";
            this.dgvKadrUchet.Size = new System.Drawing.Size(840, 287);
            this.dgvKadrUchet.TabIndex = 1;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(22, 41);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 23);
            this.btnWord.TabIndex = 0;
            this.btnWord.Text = "Создать";
            this.btnWord.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(21, 40);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Создать";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // DocumentChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tcnDocument);
            this.Controls.Add(this.tcnTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocumentChangeForm";
            this.Text = "Изменение документов";
            this.Load += new System.EventHandler(this.DocumentChangeForm_Load);
            this.tcnTable.ResumeLayout(false);
            this.tbpDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).EndInit();
            this.tbpOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tcnDocument.ResumeLayout(false);
            this.tbpWord.ResumeLayout(false);
            this.tbpExcel.ResumeLayout(false);
            this.tbpSalary.ResumeLayout(false);
            this.tbpKadrPerestanovki.ResumeLayout(false);
            this.tabKadrUchet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrPerestanovki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrUchet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpDocument;
        private System.Windows.Forms.TabPage tbpOrder;
        private System.Windows.Forms.DataGridView dgvVidDocument;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TabControl tcnDocument;
        private System.Windows.Forms.TabPage tbpWord;
        private System.Windows.Forms.TabPage tbpExcel;
        private System.Windows.Forms.TabPage tbpSalary;
        private System.Windows.Forms.DataGridView dgvTabelSalary;
        private System.Windows.Forms.TabPage tbpKadrPerestanovki;
        private System.Windows.Forms.DataGridView dgvKadrPerestanovki;
        private System.Windows.Forms.TabPage tabKadrUchet;
        private System.Windows.Forms.DataGridView dgvKadrUchet;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
    }
}