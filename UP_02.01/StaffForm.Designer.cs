namespace UP_02._01
{
    partial class StaffForm
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
            this.tbpTabRabVremeny = new System.Windows.Forms.TabPage();
            this.dgvTabel_rab = new System.Windows.Forms.DataGridView();
            this.tbpDoljnost = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.tabSotr = new System.Windows.Forms.TabPage();
            this.dgvSotr = new System.Windows.Forms.DataGridView();
            this.tbpAccount = new System.Windows.Forms.TabPage();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tcnTable.SuspendLayout();
            this.tbpTabRabVremeny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabel_rab)).BeginInit();
            this.tbpDoljnost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabSotr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSotr)).BeginInit();
            this.tbpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tcnTable
            // 
            this.tcnTable.Controls.Add(this.tbpTabRabVremeny);
            this.tcnTable.Controls.Add(this.tbpDoljnost);
            this.tcnTable.Controls.Add(this.tabRole);
            this.tcnTable.Controls.Add(this.tabSotr);
            this.tcnTable.Controls.Add(this.tbpAccount);
            this.tcnTable.Location = new System.Drawing.Point(12, 78);
            this.tcnTable.Name = "tcnTable";
            this.tcnTable.SelectedIndex = 0;
            this.tcnTable.Size = new System.Drawing.Size(860, 300);
            this.tcnTable.TabIndex = 1;
            this.tcnTable.SelectedIndexChanged += new System.EventHandler(this.tcnTable_SelectedIndexChanged);
            // 
            // tbpTabRabVremeny
            // 
            this.tbpTabRabVremeny.Controls.Add(this.dgvTabel_rab);
            this.tbpTabRabVremeny.Location = new System.Drawing.Point(4, 22);
            this.tbpTabRabVremeny.Name = "tbpTabRabVremeny";
            this.tbpTabRabVremeny.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTabRabVremeny.Size = new System.Drawing.Size(852, 274);
            this.tbpTabRabVremeny.TabIndex = 0;
            this.tbpTabRabVremeny.Text = "Табель рабочего времени";
            this.tbpTabRabVremeny.UseVisualStyleBackColor = true;
            // 
            // dgvTabel_rab
            // 
            this.dgvTabel_rab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTabel_rab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabel_rab.Location = new System.Drawing.Point(6, 6);
            this.dgvTabel_rab.Name = "dgvTabel_rab";
            this.dgvTabel_rab.Size = new System.Drawing.Size(840, 272);
            this.dgvTabel_rab.TabIndex = 0;
            this.dgvTabel_rab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabel_rab_CellClick);
            // 
            // tbpDoljnost
            // 
            this.tbpDoljnost.Controls.Add(this.dgvOrder);
            this.tbpDoljnost.Location = new System.Drawing.Point(4, 22);
            this.tbpDoljnost.Name = "tbpDoljnost";
            this.tbpDoljnost.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDoljnost.Size = new System.Drawing.Size(852, 274);
            this.tbpDoljnost.TabIndex = 1;
            this.tbpDoljnost.Text = "Должности";
            this.tbpDoljnost.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(840, 262);
            this.dgvOrder.TabIndex = 1;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.dgvRole);
            this.tabRole.Location = new System.Drawing.Point(4, 22);
            this.tabRole.Name = "tabRole";
            this.tabRole.Size = new System.Drawing.Size(852, 274);
            this.tabRole.TabIndex = 2;
            this.tabRole.Text = "Роли";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // dgvRole
            // 
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Location = new System.Drawing.Point(6, -6);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.Size = new System.Drawing.Size(840, 287);
            this.dgvRole.TabIndex = 2;
            this.dgvRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellClick);
            // 
            // tabSotr
            // 
            this.tabSotr.Controls.Add(this.dgvSotr);
            this.tabSotr.Location = new System.Drawing.Point(4, 22);
            this.tabSotr.Name = "tabSotr";
            this.tabSotr.Size = new System.Drawing.Size(852, 274);
            this.tabSotr.TabIndex = 3;
            this.tabSotr.Text = "Сотрудники";
            this.tabSotr.UseVisualStyleBackColor = true;
            // 
            // dgvSotr
            // 
            this.dgvSotr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSotr.Location = new System.Drawing.Point(6, -6);
            this.dgvSotr.Name = "dgvSotr";
            this.dgvSotr.Size = new System.Drawing.Size(840, 287);
            this.dgvSotr.TabIndex = 2;
            this.dgvSotr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSotr_CellClick);
            // 
            // tbpAccount
            // 
            this.tbpAccount.Controls.Add(this.dgvAccount);
            this.tbpAccount.Location = new System.Drawing.Point(4, 22);
            this.tbpAccount.Name = "tbpAccount";
            this.tbpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAccount.Size = new System.Drawing.Size(852, 274);
            this.tbpAccount.TabIndex = 4;
            this.tbpAccount.Text = "Аккаунты";
            this.tbpAccount.UseVisualStyleBackColor = true;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(6, -6);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(840, 287);
            this.dgvAccount.TabIndex = 1;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tcnTable);
            this.Name = "StaffForm";
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.tcnTable.ResumeLayout(false);
            this.tbpTabRabVremeny.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabel_rab)).EndInit();
            this.tbpDoljnost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabSotr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSotr)).EndInit();
            this.tbpAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcnTable;
        private System.Windows.Forms.TabPage tbpTabRabVremeny;
        private System.Windows.Forms.DataGridView dgvTabel_rab;
        private System.Windows.Forms.TabPage tbpDoljnost;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabPage tabSotr;
        private System.Windows.Forms.TabPage tbpAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.DataGridView dgvSotr;
    }
}