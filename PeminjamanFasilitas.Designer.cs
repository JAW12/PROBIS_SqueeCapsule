namespace PROBIS_SqueeCapsule
{
    partial class PeminjamanFasilitas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanFasilitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokFasilitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSSearch = new System.Windows.Forms.Label();
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoKamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem,
            this.peminjamanFasilitasToolStripMenuItem,
            this.stokFasilitasToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // peminjamanFasilitasToolStripMenuItem
            // 
            this.peminjamanFasilitasToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peminjamanFasilitasToolStripMenuItem.ForeColor = System.Drawing.Color.SlateBlue;
            this.peminjamanFasilitasToolStripMenuItem.Name = "peminjamanFasilitasToolStripMenuItem";
            this.peminjamanFasilitasToolStripMenuItem.Size = new System.Drawing.Size(239, 29);
            this.peminjamanFasilitasToolStripMenuItem.Text = "Peminjaman Fasilitas";
            // 
            // stokFasilitasToolStripMenuItem
            // 
            this.stokFasilitasToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokFasilitasToolStripMenuItem.Name = "stokFasilitasToolStripMenuItem";
            this.stokFasilitasToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.stokFasilitasToolStripMenuItem.Text = "Stok Fasilitas";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(1130, 9);
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
            this.lblX.Location = new System.Drawing.Point(1153, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(116, 62);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(207, 29);
            this.tbSearch.TabIndex = 9;
            // 
            // lblSSearch
            // 
            this.lblSSearch.AutoSize = true;
            this.lblSSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSearch.Location = new System.Drawing.Point(19, 65);
            this.lblSSearch.Name = "lblSSearch";
            this.lblSSearch.Size = new System.Drawing.Size(91, 23);
            this.lblSSearch.TabIndex = 8;
            this.lblSSearch.Text = "Search :";
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
            this.Nama,
            this.Action});
            this.dgvKamar.Location = new System.Drawing.Point(12, 97);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.ReadOnly = true;
            this.dgvKamar.RowHeadersWidth = 51;
            this.dgvKamar.RowTemplate.Height = 24;
            this.dgvKamar.Size = new System.Drawing.Size(1158, 644);
            this.dgvKamar.TabIndex = 16;
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
            this.NoKamar.HeaderText = "Nomor Kamar";
            this.NoKamar.MinimumWidth = 6;
            this.NoKamar.Name = "NoKamar";
            this.NoKamar.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Tamu";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // PeminjamanFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dgvKamar);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSSearch);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PeminjamanFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeminjamanFasilitas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanFasilitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokFasilitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSSearch;
        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoKamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}