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
            this.dgvTovar_na_sklade = new System.Windows.Forms.DataGridView();
            this.tbpPostTovar = new System.Windows.Forms.TabPage();
            this.dgvPost_tovar = new System.Windows.Forms.DataGridView();
            this.tbpFirmPostavki = new System.Windows.Forms.TabPage();
            this.dgvFirma_postavki = new System.Windows.Forms.DataGridView();
            this.tbpPostavshik = new System.Windows.Forms.TabPage();
            this.dgvPostavshiki = new System.Windows.Forms.DataGridView();
            this.tabPostavka = new System.Windows.Forms.TabPage();
            this.dgvPostavki = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tcnTable.SuspendLayout();
            this.tbpTovarNaSklade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovar_na_sklade)).BeginInit();
            this.tbpPostTovar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost_tovar)).BeginInit();
            this.tbpFirmPostavki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma_postavki)).BeginInit();
            this.tbpPostavshik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostavshiki)).BeginInit();
            this.tabPostavka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostavki)).BeginInit();
            this.SuspendLayout();
            // 
            // tcnTable
            // 
            this.tcnTable.Controls.Add(this.tbpTovarNaSklade);
            this.tcnTable.Controls.Add(this.tbpPostTovar);
            this.tcnTable.Controls.Add(this.tbpFirmPostavki);
            this.tcnTable.Controls.Add(this.tbpPostavshik);
            this.tcnTable.Controls.Add(this.tabPostavka);
            this.tcnTable.Location = new System.Drawing.Point(12, 41);
            this.tcnTable.Name = "tcnTable";
            this.tcnTable.SelectedIndex = 0;
            this.tcnTable.Size = new System.Drawing.Size(860, 325);
            this.tcnTable.TabIndex = 1;
            this.tcnTable.SelectedIndexChanged += new System.EventHandler(this.tcnTable_SelectedIndexChanged);
            // 
            // tbpTovarNaSklade
            // 
            this.tbpTovarNaSklade.Controls.Add(this.dgvTovar_na_sklade);
            this.tbpTovarNaSklade.Location = new System.Drawing.Point(4, 22);
            this.tbpTovarNaSklade.Name = "tbpTovarNaSklade";
            this.tbpTovarNaSklade.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTovarNaSklade.Size = new System.Drawing.Size(852, 299);
            this.tbpTovarNaSklade.TabIndex = 0;
            this.tbpTovarNaSklade.Text = "Товар на складе";
            this.tbpTovarNaSklade.UseVisualStyleBackColor = true;
            // 
            // dgvTovar_na_sklade
            // 
            this.dgvTovar_na_sklade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTovar_na_sklade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTovar_na_sklade.Location = new System.Drawing.Point(6, 6);
            this.dgvTovar_na_sklade.Name = "dgvTovar_na_sklade";
            this.dgvTovar_na_sklade.Size = new System.Drawing.Size(840, 287);
            this.dgvTovar_na_sklade.TabIndex = 0;
            this.dgvTovar_na_sklade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTovar_na_sklade_CellClick);
            // 
            // tbpPostTovar
            // 
            this.tbpPostTovar.Controls.Add(this.dgvPost_tovar);
            this.tbpPostTovar.Location = new System.Drawing.Point(4, 22);
            this.tbpPostTovar.Name = "tbpPostTovar";
            this.tbpPostTovar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPostTovar.Size = new System.Drawing.Size(852, 299);
            this.tbpPostTovar.TabIndex = 1;
            this.tbpPostTovar.Text = "Поставляемый товар";
            this.tbpPostTovar.UseVisualStyleBackColor = true;
            // 
            // dgvPost_tovar
            // 
            this.dgvPost_tovar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPost_tovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPost_tovar.Location = new System.Drawing.Point(6, 6);
            this.dgvPost_tovar.Name = "dgvPost_tovar";
            this.dgvPost_tovar.Size = new System.Drawing.Size(840, 287);
            this.dgvPost_tovar.TabIndex = 1;
            this.dgvPost_tovar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPost_tovar_CellClick);
            // 
            // tbpFirmPostavki
            // 
            this.tbpFirmPostavki.Controls.Add(this.dgvFirma_postavki);
            this.tbpFirmPostavki.Location = new System.Drawing.Point(4, 22);
            this.tbpFirmPostavki.Name = "tbpFirmPostavki";
            this.tbpFirmPostavki.Size = new System.Drawing.Size(852, 299);
            this.tbpFirmPostavki.TabIndex = 2;
            this.tbpFirmPostavki.Text = "Фирма поставки";
            this.tbpFirmPostavki.UseVisualStyleBackColor = true;
            this.tbpFirmPostavki.Visible = false;
            // 
            // dgvFirma_postavki
            // 
            this.dgvFirma_postavki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFirma_postavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirma_postavki.Location = new System.Drawing.Point(6, 6);
            this.dgvFirma_postavki.Name = "dgvFirma_postavki";
            this.dgvFirma_postavki.Size = new System.Drawing.Size(840, 287);
            this.dgvFirma_postavki.TabIndex = 1;
            this.dgvFirma_postavki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirma_postavki_CellClick);
            // 
            // tbpPostavshik
            // 
            this.tbpPostavshik.Controls.Add(this.dgvPostavshiki);
            this.tbpPostavshik.Location = new System.Drawing.Point(4, 22);
            this.tbpPostavshik.Name = "tbpPostavshik";
            this.tbpPostavshik.Size = new System.Drawing.Size(852, 299);
            this.tbpPostavshik.TabIndex = 3;
            this.tbpPostavshik.Text = "Поставщики";
            this.tbpPostavshik.UseVisualStyleBackColor = true;
            this.tbpPostavshik.Visible = false;
            // 
            // dgvPostavshiki
            // 
            this.dgvPostavshiki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPostavshiki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostavshiki.Location = new System.Drawing.Point(6, 6);
            this.dgvPostavshiki.Name = "dgvPostavshiki";
            this.dgvPostavshiki.Size = new System.Drawing.Size(840, 287);
            this.dgvPostavshiki.TabIndex = 1;
            this.dgvPostavshiki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostavshiki_CellClick);
            // 
            // tabPostavka
            // 
            this.tabPostavka.Controls.Add(this.dgvPostavki);
            this.tabPostavka.Location = new System.Drawing.Point(4, 22);
            this.tabPostavka.Name = "tabPostavka";
            this.tabPostavka.Size = new System.Drawing.Size(852, 299);
            this.tabPostavka.TabIndex = 4;
            this.tabPostavka.Text = "Поставки";
            this.tabPostavka.UseVisualStyleBackColor = true;
            this.tabPostavka.Visible = false;
            // 
            // dgvPostavki
            // 
            this.dgvPostavki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPostavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostavki.Location = new System.Drawing.Point(6, 6);
            this.dgvPostavki.Name = "dgvPostavki";
            this.dgvPostavki.Size = new System.Drawing.Size(840, 287);
            this.dgvPostavki.TabIndex = 1;
            this.dgvPostavki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostavki_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcnTable);
            this.Name = "SupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставка";
            this.Load += new System.EventHandler(this.SupplyForm_Load);
            this.tcnTable.ResumeLayout(false);
            this.tbpTovarNaSklade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTovar_na_sklade)).EndInit();
            this.tbpPostTovar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost_tovar)).EndInit();
            this.tbpFirmPostavki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirma_postavki)).EndInit();
            this.tbpPostavshik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostavshiki)).EndInit();
            this.tabPostavka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostavki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpTovarNaSklade;
        public System.Windows.Forms.TabPage tbpPostTovar;
        private System.Windows.Forms.TabPage tbpFirmPostavki;
        private System.Windows.Forms.TabPage tbpPostavshik;
        private System.Windows.Forms.TabPage tabPostavka;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvTovar_na_sklade;
        public System.Windows.Forms.DataGridView dgvPost_tovar;
        public System.Windows.Forms.DataGridView dgvFirma_postavki;
        public System.Windows.Forms.DataGridView dgvPostavshiki;
        public System.Windows.Forms.DataGridView dgvPostavki;
    }
}