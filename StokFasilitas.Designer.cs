namespace PROBIS_SqueeCapsule
{
    partial class StokFasilitas
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
            this.dgvFasilitas = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).BeginInit();
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
            this.peminjamanFasilitasToolStripMenuItem.Name = "peminjamanFasilitasToolStripMenuItem";
            this.peminjamanFasilitasToolStripMenuItem.Size = new System.Drawing.Size(239, 29);
            this.peminjamanFasilitasToolStripMenuItem.Text = "Peminjaman Fasilitas";
            // 
            // stokFasilitasToolStripMenuItem
            // 
            this.stokFasilitasToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokFasilitasToolStripMenuItem.ForeColor = System.Drawing.Color.SlateBlue;
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
            // dgvFasilitas
            // 
            this.dgvFasilitas.AllowUserToAddRows = false;
            this.dgvFasilitas.AllowUserToDeleteRows = false;
            this.dgvFasilitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFasilitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Nama,
            this.Jenis,
            this.Jumlah,
            this.Harga});
            this.dgvFasilitas.Location = new System.Drawing.Point(12, 54);
            this.dgvFasilitas.Name = "dgvFasilitas";
            this.dgvFasilitas.ReadOnly = true;
            this.dgvFasilitas.RowHeadersWidth = 51;
            this.dgvFasilitas.RowTemplate.Height = 24;
            this.dgvFasilitas.Size = new System.Drawing.Size(1158, 687);
            this.dgvFasilitas.TabIndex = 17;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Fasilitas";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Jenis
            // 
            this.Jenis.HeaderText = "Jenis Fasilitas";
            this.Jenis.MinimumWidth = 6;
            this.Jenis.Name = "Jenis";
            this.Jenis.ReadOnly = true;
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah Tersedia";
            this.Jumlah.MinimumWidth = 6;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga Peminjaman";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // StokFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dgvFasilitas);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StokFasilitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokFasilitas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFasilitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
    }
}