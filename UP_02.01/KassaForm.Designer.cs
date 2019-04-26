namespace UP_02._01
{
    partial class KassaForm
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
            this.pnSelection = new System.Windows.Forms.Panel();
            this.dgvSelection = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pnCart = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btCheckWord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).BeginInit();
            this.pnCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.dgvSelection);
            this.pnSelection.Location = new System.Drawing.Point(12, 78);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(860, 200);
            this.pnSelection.TabIndex = 0;
            // 
            // dgvSelection
            // 
            this.dgvSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelection.Location = new System.Drawing.Point(3, 3);
            this.dgvSelection.Name = "dgvSelection";
            this.dgvSelection.Size = new System.Drawing.Size(854, 194);
            this.dgvSelection.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Обычный покупатель",
            "Льготник"});
            this.checkedListBox1.Location = new System.Drawing.Point(729, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(136, 34);
            this.checkedListBox1.TabIndex = 1;
            // 
            // pnCart
            // 
            this.pnCart.Controls.Add(this.dgvCart);
            this.pnCart.Location = new System.Drawing.Point(15, 293);
            this.pnCart.Name = "pnCart";
            this.pnCart.Size = new System.Drawing.Size(860, 150);
            this.pnCart.TabIndex = 1;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(3, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(854, 144);
            this.dgvCart.TabIndex = 0;
            // 
            // btCheckWord
            // 
            this.btCheckWord.Location = new System.Drawing.Point(631, 26);
            this.btCheckWord.Name = "btCheckWord";
            this.btCheckWord.Size = new System.Drawing.Size(75, 23);
            this.btCheckWord.TabIndex = 2;
            this.btCheckWord.Text = "Чек";
            this.btCheckWord.UseVisualStyleBackColor = true;
            this.btCheckWord.Click += new System.EventHandler(this.btWordCheck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KassaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCheckWord);
            this.Controls.Add(this.pnCart);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pnSelection);
            this.Name = "KassaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Касса";
            this.Load += new System.EventHandler(this.KassaForm_Load);
            this.pnSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).EndInit();
            this.pnCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.DataGridView dgvSelection;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel pnCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btCheckWord;
        private System.Windows.Forms.Button button1;
    }
}