namespace UP_02._01
{
    partial class AppConfigForm
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
            this.nudTopMerg = new System.Windows.Forms.NumericUpDown();
            this.nudLeftMerg = new System.Windows.Forms.NumericUpDown();
            this.nudBottomMerg = new System.Windows.Forms.NumericUpDown();
            this.nudRightMerg = new System.Windows.Forms.NumericUpDown();
            this.lbPath = new System.Windows.Forms.Label();
            this.btBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.pnPage = new System.Windows.Forms.Panel();
            this.pnText = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMerg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMerg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMerg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMerg)).BeginInit();
            this.pnPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTopMerg
            // 
            this.nudTopMerg.DecimalPlaces = 1;
            this.nudTopMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTopMerg.Location = new System.Drawing.Point(215, 75);
            this.nudTopMerg.Name = "nudTopMerg";
            this.nudTopMerg.Size = new System.Drawing.Size(120, 20);
            this.nudTopMerg.TabIndex = 0;
            this.nudTopMerg.ValueChanged += new System.EventHandler(this.nudTopMerg_ValueChanged);
            // 
            // nudLeftMerg
            // 
            this.nudLeftMerg.DecimalPlaces = 1;
            this.nudLeftMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLeftMerg.Location = new System.Drawing.Point(10, 168);
            this.nudLeftMerg.Name = "nudLeftMerg";
            this.nudLeftMerg.Size = new System.Drawing.Size(120, 20);
            this.nudLeftMerg.TabIndex = 1;
            this.nudLeftMerg.ValueChanged += new System.EventHandler(this.nudLeftMerg_ValueChanged);
            // 
            // nudBottomMerg
            // 
            this.nudBottomMerg.DecimalPlaces = 1;
            this.nudBottomMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBottomMerg.Location = new System.Drawing.Point(215, 280);
            this.nudBottomMerg.Name = "nudBottomMerg";
            this.nudBottomMerg.Size = new System.Drawing.Size(120, 20);
            this.nudBottomMerg.TabIndex = 2;
            this.nudBottomMerg.ValueChanged += new System.EventHandler(this.nudBottomMerg_ValueChanged);
            // 
            // nudRightMerg
            // 
            this.nudRightMerg.DecimalPlaces = 1;
            this.nudRightMerg.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRightMerg.Location = new System.Drawing.Point(445, 180);
            this.nudRightMerg.Name = "nudRightMerg";
            this.nudRightMerg.Size = new System.Drawing.Size(120, 20);
            this.nudRightMerg.TabIndex = 3;
            this.nudRightMerg.ValueChanged += new System.EventHandler(this.nudRightMerg_ValueChanged);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(24, 29);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(217, 13);
            this.lbPath.TabIndex = 4;
            this.lbPath.Text = "Выберите папку сохранения документов:";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(247, 23);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(24, 24);
            this.btBrowse.TabIndex = 5;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(349, 365);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(430, 365);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pnPage
            // 
            this.pnPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPage.Controls.Add(this.pnText);
            this.pnPage.Location = new System.Drawing.Point(136, 101);
            this.pnPage.Name = "pnPage";
            this.pnPage.Size = new System.Drawing.Size(303, 173);
            this.pnPage.TabIndex = 8;
            // 
            // pnText
            // 
            this.pnText.BackColor = System.Drawing.Color.Gray;
            this.pnText.Location = new System.Drawing.Point(-1, -1);
            this.pnText.Name = "pnText";
            this.pnText.Size = new System.Drawing.Size(148, 173);
            this.pnText.TabIndex = 0;
            // 
            // AppConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 415);
            this.Controls.Add(this.pnPage);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.nudRightMerg);
            this.Controls.Add(this.nudBottomMerg);
            this.Controls.Add(this.nudLeftMerg);
            this.Controls.Add(this.nudTopMerg);
            this.Name = "AppConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppConfig";
            this.Load += new System.EventHandler(this.AppConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopMerg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftMerg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBottomMerg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightMerg)).EndInit();
            this.pnPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTopMerg;
        private System.Windows.Forms.NumericUpDown nudLeftMerg;
        private System.Windows.Forms.NumericUpDown nudBottomMerg;
        private System.Windows.Forms.NumericUpDown nudRightMerg;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel pnPage;
        private System.Windows.Forms.Panel pnText;
    }
}