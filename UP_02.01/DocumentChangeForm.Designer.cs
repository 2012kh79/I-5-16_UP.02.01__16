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
            this.dgvDogovor = new System.Windows.Forms.DataGridView();
            this.tbpSalary = new System.Windows.Forms.TabPage();
            this.dgvTabelSarplaty = new System.Windows.Forms.DataGridView();
            this.tbpKadrPerestanovki = new System.Windows.Forms.TabPage();
            this.dgvKadrPerestanovki = new System.Windows.Forms.DataGridView();
            this.tabKadrUchet = new System.Windows.Forms.TabPage();
            this.dgvKadrUchet = new System.Windows.Forms.DataGridView();
            this.tbpFirma = new System.Windows.Forms.TabPage();
            this.dgvFirma = new System.Windows.Forms.DataGridView();
            this.tbpIdentTovParty = new System.Windows.Forms.TabPage();
            this.dgvIdentTovParty = new System.Windows.Forms.DataGridView();
            this.tbpVihDocument = new System.Windows.Forms.TabPage();
            this.dgvVihCocument = new System.Windows.Forms.DataGridView();
            this.tcnDocument = new System.Windows.Forms.TabControl();
            this.tbpWord = new System.Windows.Forms.TabPage();
            this.btKadr_UchetWord = new System.Windows.Forms.Button();
            this.tbpExcel = new System.Windows.Forms.TabPage();
            this.btKadr_UchetExcel = new System.Windows.Forms.Button();
            this.btVih_DocWord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcnTable.SuspendLayout();
            this.tbpDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).BeginInit();
            this.tbpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogovor)).BeginInit();
            this.tbpSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelSarplaty)).BeginInit();
            this.tbpKadrPerestanovki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrPerestanovki)).BeginInit();
            this.tabKadrUchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrUchet)).BeginInit();
            this.tbpFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).BeginInit();
            this.tbpIdentTovParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdentTovParty)).BeginInit();
            this.tbpVihDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVihCocument)).BeginInit();
            this.tcnDocument.SuspendLayout();
            this.tbpWord.SuspendLayout();
            this.tbpExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcnTable
            // 
            this.tcnTable.Controls.Add(this.tbpDocument);
            this.tcnTable.Controls.Add(this.tbpOrder);
            this.tcnTable.Controls.Add(this.tbpSalary);
            this.tcnTable.Controls.Add(this.tbpKadrPerestanovki);
            this.tcnTable.Controls.Add(this.tabKadrUchet);
            this.tcnTable.Controls.Add(this.tbpFirma);
            this.tcnTable.Controls.Add(this.tbpIdentTovParty);
            this.tcnTable.Controls.Add(this.tbpVihDocument);
            this.tcnTable.Location = new System.Drawing.Point(12, 78);
            this.tcnTable.Name = "tcnTable";
            this.tcnTable.SelectedIndex = 0;
            this.tcnTable.Size = new System.Drawing.Size(860, 300);
            this.tcnTable.TabIndex = 0;
            this.tcnTable.SelectedIndexChanged += new System.EventHandler(this.tcnTable_SelectedIndexChanged);
            // 
            // tbpDocument
            // 
            this.tbpDocument.Controls.Add(this.dgvVidDocument);
            this.tbpDocument.Location = new System.Drawing.Point(4, 22);
            this.tbpDocument.Name = "tbpDocument";
            this.tbpDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDocument.Size = new System.Drawing.Size(852, 274);
            this.tbpDocument.TabIndex = 0;
            this.tbpDocument.Text = "Виды документов";
            this.tbpDocument.UseVisualStyleBackColor = true;
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
            // tbpOrder
            // 
            this.tbpOrder.Controls.Add(this.dgvDogovor);
            this.tbpOrder.Location = new System.Drawing.Point(4, 22);
            this.tbpOrder.Name = "tbpOrder";
            this.tbpOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrder.Size = new System.Drawing.Size(852, 274);
            this.tbpOrder.TabIndex = 1;
            this.tbpOrder.Text = "Договора";
            this.tbpOrder.UseVisualStyleBackColor = true;
            // 
            // dgvDogovor
            // 
            this.dgvDogovor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDogovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogovor.Location = new System.Drawing.Point(6, 6);
            this.dgvDogovor.Name = "dgvDogovor";
            this.dgvDogovor.Size = new System.Drawing.Size(840, 287);
            this.dgvDogovor.TabIndex = 1;
            this.dgvDogovor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogovor_CellClick);
            // 
            // tbpSalary
            // 
            this.tbpSalary.Controls.Add(this.dgvTabelSarplaty);
            this.tbpSalary.Location = new System.Drawing.Point(4, 22);
            this.tbpSalary.Name = "tbpSalary";
            this.tbpSalary.Size = new System.Drawing.Size(852, 274);
            this.tbpSalary.TabIndex = 2;
            this.tbpSalary.Text = "Заработная плата";
            this.tbpSalary.UseVisualStyleBackColor = true;
            this.tbpSalary.Visible = false;
            // 
            // dgvTabelSarplaty
            // 
            this.dgvTabelSarplaty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTabelSarplaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelSarplaty.Location = new System.Drawing.Point(6, 6);
            this.dgvTabelSarplaty.Name = "dgvTabelSarplaty";
            this.dgvTabelSarplaty.Size = new System.Drawing.Size(840, 287);
            this.dgvTabelSarplaty.TabIndex = 1;
            this.dgvTabelSarplaty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabelSarplaty_CellClick);
            // 
            // tbpKadrPerestanovki
            // 
            this.tbpKadrPerestanovki.Controls.Add(this.dgvKadrPerestanovki);
            this.tbpKadrPerestanovki.Location = new System.Drawing.Point(4, 22);
            this.tbpKadrPerestanovki.Name = "tbpKadrPerestanovki";
            this.tbpKadrPerestanovki.Size = new System.Drawing.Size(852, 274);
            this.tbpKadrPerestanovki.TabIndex = 3;
            this.tbpKadrPerestanovki.Text = "Кадровые перестановки";
            this.tbpKadrPerestanovki.UseVisualStyleBackColor = true;
            this.tbpKadrPerestanovki.Visible = false;
            // 
            // dgvKadrPerestanovki
            // 
            this.dgvKadrPerestanovki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKadrPerestanovki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadrPerestanovki.Location = new System.Drawing.Point(6, 6);
            this.dgvKadrPerestanovki.Name = "dgvKadrPerestanovki";
            this.dgvKadrPerestanovki.Size = new System.Drawing.Size(840, 287);
            this.dgvKadrPerestanovki.TabIndex = 1;
            this.dgvKadrPerestanovki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKadrPerestanovki_CellClick);
            // 
            // tabKadrUchet
            // 
            this.tabKadrUchet.Controls.Add(this.dgvKadrUchet);
            this.tabKadrUchet.Location = new System.Drawing.Point(4, 22);
            this.tabKadrUchet.Name = "tabKadrUchet";
            this.tabKadrUchet.Size = new System.Drawing.Size(852, 274);
            this.tabKadrUchet.TabIndex = 4;
            this.tabKadrUchet.Text = "Кадровый учёт";
            this.tabKadrUchet.UseVisualStyleBackColor = true;
            this.tabKadrUchet.Visible = false;
            // 
            // dgvKadrUchet
            // 
            this.dgvKadrUchet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKadrUchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKadrUchet.Location = new System.Drawing.Point(6, 6);
            this.dgvKadrUchet.Name = "dgvKadrUchet";
            this.dgvKadrUchet.Size = new System.Drawing.Size(840, 287);
            this.dgvKadrUchet.TabIndex = 1;
            this.dgvKadrUchet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKadrUchet_CellClick);
            // 
            // tbpFirma
            // 
            this.tbpFirma.Controls.Add(this.dgvFirma);
            this.tbpFirma.Location = new System.Drawing.Point(4, 22);
            this.tbpFirma.Name = "tbpFirma";
            this.tbpFirma.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFirma.Size = new System.Drawing.Size(852, 274);
            this.tbpFirma.TabIndex = 6;
            this.tbpFirma.Text = "Фирма";
            this.tbpFirma.UseVisualStyleBackColor = true;
            // 
            // dgvFirma
            // 
            this.dgvFirma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFirma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirma.Location = new System.Drawing.Point(6, 6);
            this.dgvFirma.Name = "dgvFirma";
            this.dgvFirma.Size = new System.Drawing.Size(840, 287);
            this.dgvFirma.TabIndex = 2;
            this.dgvFirma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirma_CellClick);
            // 
            // tbpIdentTovParty
            // 
            this.tbpIdentTovParty.Controls.Add(this.dgvIdentTovParty);
            this.tbpIdentTovParty.Location = new System.Drawing.Point(4, 22);
            this.tbpIdentTovParty.Name = "tbpIdentTovParty";
            this.tbpIdentTovParty.Size = new System.Drawing.Size(852, 274);
            this.tbpIdentTovParty.TabIndex = 7;
            this.tbpIdentTovParty.Text = "Идентификация товарной партии";
            this.tbpIdentTovParty.UseVisualStyleBackColor = true;
            // 
            // dgvIdentTovParty
            // 
            this.dgvIdentTovParty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIdentTovParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdentTovParty.Location = new System.Drawing.Point(6, 6);
            this.dgvIdentTovParty.Name = "dgvIdentTovParty";
            this.dgvIdentTovParty.Size = new System.Drawing.Size(840, 287);
            this.dgvIdentTovParty.TabIndex = 2;
            this.dgvIdentTovParty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIdentTovParty_CellClick);
            // 
            // tbpVihDocument
            // 
            this.tbpVihDocument.Controls.Add(this.dgvVihCocument);
            this.tbpVihDocument.Location = new System.Drawing.Point(4, 22);
            this.tbpVihDocument.Name = "tbpVihDocument";
            this.tbpVihDocument.Size = new System.Drawing.Size(852, 274);
            this.tbpVihDocument.TabIndex = 5;
            this.tbpVihDocument.Text = "Выходные документы";
            this.tbpVihDocument.UseVisualStyleBackColor = true;
            // 
            // dgvVihCocument
            // 
            this.dgvVihCocument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVihCocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVihCocument.Location = new System.Drawing.Point(6, 6);
            this.dgvVihCocument.Name = "dgvVihCocument";
            this.dgvVihCocument.Size = new System.Drawing.Size(840, 287);
            this.dgvVihCocument.TabIndex = 2;
            this.dgvVihCocument.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVihCocument_CellClick);
            // 
            // tcnDocument
            // 
            this.tcnDocument.Controls.Add(this.tbpWord);
            this.tcnDocument.Controls.Add(this.tbpExcel);
            this.tcnDocument.Location = new System.Drawing.Point(760, 568);
            this.tcnDocument.Name = "tcnDocument";
            this.tcnDocument.SelectedIndex = 0;
            this.tcnDocument.Size = new System.Drawing.Size(97, 62);
            this.tcnDocument.TabIndex = 1;
            // 
            // tbpWord
            // 
            this.tbpWord.Controls.Add(this.btKadr_UchetWord);
            this.tbpWord.Location = new System.Drawing.Point(4, 22);
            this.tbpWord.Name = "tbpWord";
            this.tbpWord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWord.Size = new System.Drawing.Size(89, 36);
            this.tbpWord.TabIndex = 0;
            this.tbpWord.Text = "Word";
            this.tbpWord.UseVisualStyleBackColor = true;
            // 
            // btKadr_UchetWord
            // 
            this.btKadr_UchetWord.Location = new System.Drawing.Point(8, 7);
            this.btKadr_UchetWord.Name = "btKadr_UchetWord";
            this.btKadr_UchetWord.Size = new System.Drawing.Size(75, 23);
            this.btKadr_UchetWord.TabIndex = 0;
            this.btKadr_UchetWord.Text = "Создать";
            this.btKadr_UchetWord.UseVisualStyleBackColor = true;
            this.btKadr_UchetWord.Click += new System.EventHandler(this.btKadr_UchetWord_Click);
            // 
            // tbpExcel
            // 
            this.tbpExcel.Controls.Add(this.btKadr_UchetExcel);
            this.tbpExcel.Location = new System.Drawing.Point(4, 22);
            this.tbpExcel.Name = "tbpExcel";
            this.tbpExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExcel.Size = new System.Drawing.Size(89, 36);
            this.tbpExcel.TabIndex = 1;
            this.tbpExcel.Text = "Excel";
            this.tbpExcel.UseVisualStyleBackColor = true;
            // 
            // btKadr_UchetExcel
            // 
            this.btKadr_UchetExcel.Location = new System.Drawing.Point(6, 6);
            this.btKadr_UchetExcel.Name = "btKadr_UchetExcel";
            this.btKadr_UchetExcel.Size = new System.Drawing.Size(75, 23);
            this.btKadr_UchetExcel.TabIndex = 1;
            this.btKadr_UchetExcel.Text = "Создать";
            this.btKadr_UchetExcel.UseVisualStyleBackColor = true;
            this.btKadr_UchetExcel.Click += new System.EventHandler(this.btKadr_UchetExcel_Click);
            // 
            // btVih_DocWord
            // 
            this.btVih_DocWord.Location = new System.Drawing.Point(766, 508);
            this.btVih_DocWord.Name = "btVih_DocWord";
            this.btVih_DocWord.Size = new System.Drawing.Size(78, 53);
            this.btVih_DocWord.TabIndex = 2;
            this.btVih_DocWord.Text = "Выходные документы";
            this.btVih_DocWord.UseVisualStyleBackColor = true;
            this.btVih_DocWord.Click += new System.EventHandler(this.btVih_DocWord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocumentChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btVih_DocWord);
            this.Controls.Add(this.tcnDocument);
            this.Controls.Add(this.tcnTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DocumentChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение документов";
            this.Load += new System.EventHandler(this.DocumentChangeForm_Load);
            this.tcnTable.ResumeLayout(false);
            this.tbpDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVidDocument)).EndInit();
            this.tbpOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogovor)).EndInit();
            this.tbpSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelSarplaty)).EndInit();
            this.tbpKadrPerestanovki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrPerestanovki)).EndInit();
            this.tabKadrUchet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKadrUchet)).EndInit();
            this.tbpFirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma)).EndInit();
            this.tbpIdentTovParty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdentTovParty)).EndInit();
            this.tbpVihDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVihCocument)).EndInit();
            this.tcnDocument.ResumeLayout(false);
            this.tbpWord.ResumeLayout(false);
            this.tbpExcel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpDocument;
        private System.Windows.Forms.TabPage tbpOrder;
        private System.Windows.Forms.DataGridView dgvVidDocument;
        private System.Windows.Forms.DataGridView dgvDogovor;
        private System.Windows.Forms.TabControl tcnDocument;
        private System.Windows.Forms.TabPage tbpWord;
        private System.Windows.Forms.TabPage tbpExcel;
        private System.Windows.Forms.TabPage tbpSalary;
        private System.Windows.Forms.DataGridView dgvTabelSarplaty;
        private System.Windows.Forms.TabPage tbpKadrPerestanovki;
        private System.Windows.Forms.DataGridView dgvKadrPerestanovki;
        private System.Windows.Forms.TabPage tabKadrUchet;
        private System.Windows.Forms.DataGridView dgvKadrUchet;
        private System.Windows.Forms.Button btKadr_UchetWord;
        private System.Windows.Forms.Button btKadr_UchetExcel;
        private System.Windows.Forms.TabPage tbpVihDocument;
        private System.Windows.Forms.TabPage tbpFirma;
        private System.Windows.Forms.DataGridView dgvFirma;
        private System.Windows.Forms.TabPage tbpIdentTovParty;
        private System.Windows.Forms.DataGridView dgvIdentTovParty;
        private System.Windows.Forms.DataGridView dgvVihCocument;
        private System.Windows.Forms.Button btVih_DocWord;
        private System.Windows.Forms.Button button1;
    }
}