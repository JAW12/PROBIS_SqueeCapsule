namespace PROBIS_SqueeCapsule
{
    partial class BookingCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingCheckIn));
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblSSearch = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSJFamily = new System.Windows.Forms.Label();
            this.lblSJSingle = new System.Windows.Forms.Label();
            this.lblSJumlah = new System.Windows.Forms.Label();
            this.lblJFamily = new System.Windows.Forms.Label();
            this.lblJSingle = new System.Windows.Forms.Label();
            this.lblSPFamily = new System.Windows.Forms.Label();
            this.lblSPSingle = new System.Windows.Forms.Label();
            this.lblSPilih = new System.Windows.Forms.Label();
            this.lblPFamily = new System.Windows.Forms.Label();
            this.lblPSingle = new System.Windows.Forms.Label();
            this.lblSTFamily = new System.Windows.Forms.Label();
            this.lblSTSingle = new System.Windows.Forms.Label();
            this.lblSTersisa = new System.Windows.Forms.Label();
            this.lblTFamily = new System.Windows.Forms.Label();
            this.lblTSingle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(739, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(25, 25);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(762, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblH1
            // 
            this.lblH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH1.Location = new System.Drawing.Point(16, 429);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(774, 2);
            this.lblH1.TabIndex = 15;
            // 
            // lblSSearch
            // 
            this.lblSSearch.AutoSize = true;
            this.lblSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSSearch.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSearch.Location = new System.Drawing.Point(14, 54);
            this.lblSSearch.Name = "lblSSearch";
            this.lblSSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSSearch.TabIndex = 16;
            this.lblSSearch.Text = "Search";
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.Green;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(588, 536);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(200, 50);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "Kumpul";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(12, 536);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(88, 51);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 28);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvKamar
            // 
            this.dgvKamar.AllowUserToAddRows = false;
            this.dgvKamar.AllowUserToDeleteRows = false;
            this.dgvKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NoKamar,
            this.Jenis,
            this.Check});
            this.dgvKamar.Location = new System.Drawing.Point(16, 86);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersWidth = 51;
            this.dgvKamar.RowTemplate.Height = 24;
            this.dgvKamar.Size = new System.Drawing.Size(772, 332);
            this.dgvKamar.TabIndex = 1;
            this.dgvKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellClick);
            this.dgvKamar.VisibleChanged += new System.EventHandler(this.dgvKamar_VisibleChanged);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // NoKamar
            // 
            this.NoKamar.HeaderText = "No Kamar";
            this.NoKamar.MinimumWidth = 6;
            this.NoKamar.Name = "NoKamar";
            this.NoKamar.ReadOnly = true;
            // 
            // Jenis
            // 
            this.Jenis.HeaderText = "Jenis Kamar";
            this.Jenis.MinimumWidth = 6;
            this.Jenis.Name = "Jenis";
            this.Jenis.ReadOnly = true;
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            // 
            // lblSJFamily
            // 
            this.lblSJFamily.AutoSize = true;
            this.lblSJFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSJFamily.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJFamily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSJFamily.Location = new System.Drawing.Point(17, 497);
            this.lblSJFamily.Name = "lblSJFamily";
            this.lblSJFamily.Size = new System.Drawing.Size(74, 20);
            this.lblSJFamily.TabIndex = 25;
            this.lblSJFamily.Text = "Family:";
            // 
            // lblSJSingle
            // 
            this.lblSJSingle.AutoSize = true;
            this.lblSJSingle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJSingle.Location = new System.Drawing.Point(17, 468);
            this.lblSJSingle.Name = "lblSJSingle";
            this.lblSJSingle.Size = new System.Drawing.Size(71, 20);
            this.lblSJSingle.TabIndex = 26;
            this.lblSJSingle.Text = "Single:";
            // 
            // lblSJumlah
            // 
            this.lblSJumlah.AutoSize = true;
            this.lblSJumlah.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJumlah.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSJumlah.Location = new System.Drawing.Point(17, 444);
            this.lblSJumlah.Name = "lblSJumlah";
            this.lblSJumlah.Size = new System.Drawing.Size(106, 17);
            this.lblSJumlah.TabIndex = 27;
            this.lblSJumlah.Text = "Jumlah Kamar";
            // 
            // lblJFamily
            // 
            this.lblJFamily.AutoSize = true;
            this.lblJFamily.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJFamily.Location = new System.Drawing.Point(94, 497);
            this.lblJFamily.Name = "lblJFamily";
            this.lblJFamily.Size = new System.Drawing.Size(20, 20);
            this.lblJFamily.TabIndex = 28;
            this.lblJFamily.Text = "3";
            // 
            // lblJSingle
            // 
            this.lblJSingle.AutoSize = true;
            this.lblJSingle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJSingle.Location = new System.Drawing.Point(94, 468);
            this.lblJSingle.Name = "lblJSingle";
            this.lblJSingle.Size = new System.Drawing.Size(20, 20);
            this.lblJSingle.TabIndex = 29;
            this.lblJSingle.Text = "3";
            // 
            // lblSPFamily
            // 
            this.lblSPFamily.AutoSize = true;
            this.lblSPFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSPFamily.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPFamily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSPFamily.Location = new System.Drawing.Point(222, 497);
            this.lblSPFamily.Name = "lblSPFamily";
            this.lblSPFamily.Size = new System.Drawing.Size(74, 20);
            this.lblSPFamily.TabIndex = 30;
            this.lblSPFamily.Text = "Family:";
            // 
            // lblSPSingle
            // 
            this.lblSPSingle.AutoSize = true;
            this.lblSPSingle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPSingle.Location = new System.Drawing.Point(222, 468);
            this.lblSPSingle.Name = "lblSPSingle";
            this.lblSPSingle.Size = new System.Drawing.Size(71, 20);
            this.lblSPSingle.TabIndex = 31;
            this.lblSPSingle.Text = "Single:";
            // 
            // lblSPilih
            // 
            this.lblSPilih.AutoSize = true;
            this.lblSPilih.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPilih.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSPilih.Location = new System.Drawing.Point(223, 444);
            this.lblSPilih.Name = "lblSPilih";
            this.lblSPilih.Size = new System.Drawing.Size(88, 17);
            this.lblSPilih.TabIndex = 32;
            this.lblSPilih.Text = "Yang Dipilih";
            // 
            // lblPFamily
            // 
            this.lblPFamily.AutoSize = true;
            this.lblPFamily.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFamily.Location = new System.Drawing.Point(299, 497);
            this.lblPFamily.Name = "lblPFamily";
            this.lblPFamily.Size = new System.Drawing.Size(96, 20);
            this.lblPFamily.TabIndex = 33;
            this.lblPFamily.Text = "F1, F2 (2)";
            // 
            // lblPSingle
            // 
            this.lblPSingle.AutoSize = true;
            this.lblPSingle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSingle.Location = new System.Drawing.Point(299, 468);
            this.lblPSingle.Name = "lblPSingle";
            this.lblPSingle.Size = new System.Drawing.Size(135, 20);
            this.lblPSingle.TabIndex = 34;
            this.lblPSingle.Text = "A1, A3, A5 (3)";
            // 
            // lblSTFamily
            // 
            this.lblSTFamily.AutoSize = true;
            this.lblSTFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSTFamily.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTFamily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSTFamily.Location = new System.Drawing.Point(585, 497);
            this.lblSTFamily.Name = "lblSTFamily";
            this.lblSTFamily.Size = new System.Drawing.Size(74, 20);
            this.lblSTFamily.TabIndex = 35;
            this.lblSTFamily.Text = "Family:";
            // 
            // lblSTSingle
            // 
            this.lblSTSingle.AutoSize = true;
            this.lblSTSingle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTSingle.Location = new System.Drawing.Point(585, 468);
            this.lblSTSingle.Name = "lblSTSingle";
            this.lblSTSingle.Size = new System.Drawing.Size(71, 20);
            this.lblSTSingle.TabIndex = 36;
            this.lblSTSingle.Text = "Single:";
            // 
            // lblSTersisa
            // 
            this.lblSTersisa.AutoSize = true;
            this.lblSTersisa.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTersisa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSTersisa.Location = new System.Drawing.Point(585, 444);
            this.lblSTersisa.Name = "lblSTersisa";
            this.lblSTersisa.Size = new System.Drawing.Size(56, 17);
            this.lblSTersisa.TabIndex = 37;
            this.lblSTersisa.Text = "Tersisa";
            // 
            // lblTFamily
            // 
            this.lblTFamily.AutoSize = true;
            this.lblTFamily.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFamily.Location = new System.Drawing.Point(662, 497);
            this.lblTFamily.Name = "lblTFamily";
            this.lblTFamily.Size = new System.Drawing.Size(20, 20);
            this.lblTFamily.TabIndex = 38;
            this.lblTFamily.Text = "1";
            // 
            // lblTSingle
            // 
            this.lblTSingle.AutoSize = true;
            this.lblTSingle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSingle.Location = new System.Drawing.Point(662, 468);
            this.lblTSingle.Name = "lblTSingle";
            this.lblTSingle.Size = new System.Drawing.Size(20, 20);
            this.lblTSingle.TabIndex = 39;
            this.lblTSingle.Text = "0";
            // 
            // BookingCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblSTFamily);
            this.Controls.Add(this.lblSTSingle);
            this.Controls.Add(this.lblSTersisa);
            this.Controls.Add(this.lblTFamily);
            this.Controls.Add(this.lblTSingle);
            this.Controls.Add(this.lblSPFamily);
            this.Controls.Add(this.lblSPSingle);
            this.Controls.Add(this.lblSPilih);
            this.Controls.Add(this.lblPFamily);
            this.Controls.Add(this.lblPSingle);
            this.Controls.Add(this.lblSJFamily);
            this.Controls.Add(this.lblSJSingle);
            this.Controls.Add(this.lblSJumlah);
            this.Controls.Add(this.lblJFamily);
            this.Controls.Add(this.lblJSingle);
            this.Controls.Add(this.dgvKamar);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblSSearch);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingCheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblSSearch;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.Label lblSJFamily;
        private System.Windows.Forms.Label lblSJSingle;
        private System.Windows.Forms.Label lblSJumlah;
        private System.Windows.Forms.Label lblJFamily;
        private System.Windows.Forms.Label lblJSingle;
        private System.Windows.Forms.Label lblSPFamily;
        private System.Windows.Forms.Label lblSPSingle;
        private System.Windows.Forms.Label lblSPilih;
        private System.Windows.Forms.Label lblPFamily;
        private System.Windows.Forms.Label lblPSingle;
        private System.Windows.Forms.Label lblSTFamily;
        private System.Windows.Forms.Label lblSTSingle;
        private System.Windows.Forms.Label lblSTersisa;
        private System.Windows.Forms.Label lblTFamily;
        private System.Windows.Forms.Label lblTSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}