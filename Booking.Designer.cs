using System;

namespace PROBIS_SqueeCapsule
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanFasilitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokFasilitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblSKamar = new System.Windows.Forms.Label();
            this.lblSingle = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblSSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSTanggal = new System.Windows.Forms.Label();
            this.dateTglAwal = new System.Windows.Forms.DateTimePicker();
            this.dateTglAkhir = new System.Windows.Forms.DateTimePicker();
            this.lblSPenghubung = new System.Windows.Forms.Label();
            this.lblSFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblH1 = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.Tgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglCIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglCOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblSSingle = new System.Windows.Forms.Label();
            this.lblSFamily = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.pbLaporan = new System.Windows.Forms.PictureBox();
            this.pbGrafik = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafik)).BeginInit();
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
            this.bookingToolStripMenuItem.ForeColor = System.Drawing.Color.SlateBlue;
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // peminjamanFasilitasToolStripMenuItem
            // 
            this.peminjamanFasilitasToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peminjamanFasilitasToolStripMenuItem.Name = "peminjamanFasilitasToolStripMenuItem";
            this.peminjamanFasilitasToolStripMenuItem.Size = new System.Drawing.Size(237, 29);
            this.peminjamanFasilitasToolStripMenuItem.Text = "Peminjaman Fasilitas";
            this.peminjamanFasilitasToolStripMenuItem.Click += new System.EventHandler(this.peminjamanFasilitasToolStripMenuItem_Click);
            // 
            // stokFasilitasToolStripMenuItem
            // 
            this.stokFasilitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanToolStripMenuItem});
            this.stokFasilitasToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokFasilitasToolStripMenuItem.Name = "stokFasilitasToolStripMenuItem";
            this.stokFasilitasToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.stokFasilitasToolStripMenuItem.Text = "Stok Fasilitas";
            this.stokFasilitasToolStripMenuItem.Click += new System.EventHandler(this.stokFasilitasToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.laporanToolStripMenuItem.Text = "Laporan Stok Fasilitas";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.logOutToolStripMenuItem.Text = "Keluar";
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
            // lblSKamar
            // 
            this.lblSKamar.AutoSize = true;
            this.lblSKamar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKamar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSKamar.Location = new System.Drawing.Point(20, 56);
            this.lblSKamar.Name = "lblSKamar";
            this.lblSKamar.Size = new System.Drawing.Size(154, 17);
            this.lblSKamar.TabIndex = 4;
            this.lblSKamar.Text = "Kamar Yang Tersedia";
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingle.Location = new System.Drawing.Point(110, 77);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(25, 25);
            this.lblSingle.TabIndex = 4;
            this.lblSingle.Text = "0";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(917, 56);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(253, 50);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "Tambah Booking";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblSSearch
            // 
            this.lblSSearch.AutoSize = true;
            this.lblSSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSearch.Location = new System.Drawing.Point(18, 139);
            this.lblSSearch.Name = "lblSSearch";
            this.lblSSearch.Size = new System.Drawing.Size(111, 23);
            this.lblSSearch.TabIndex = 6;
            this.lblSSearch.Text = "Pencarian:";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(135, 137);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(198, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lblSTanggal
            // 
            this.lblSTanggal.AutoSize = true;
            this.lblSTanggal.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTanggal.Location = new System.Drawing.Point(362, 139);
            this.lblSTanggal.Name = "lblSTanggal";
            this.lblSTanggal.Size = new System.Drawing.Size(93, 23);
            this.lblSTanggal.TabIndex = 8;
            this.lblSTanggal.Text = "Tanggal:";
            // 
            // dateTglAwal
            // 
            this.dateTglAwal.CustomFormat = "dd/MM/yyyy";
            this.dateTglAwal.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTglAwal.Location = new System.Drawing.Point(461, 136);
            this.dateTglAwal.Name = "dateTglAwal";
            this.dateTglAwal.Size = new System.Drawing.Size(152, 29);
            this.dateTglAwal.TabIndex = 2;
            this.dateTglAwal.ValueChanged += new System.EventHandler(this.dateTglAwal_ValueChanged);
            // 
            // dateTglAkhir
            // 
            this.dateTglAkhir.CustomFormat = "dd/MM/yyyy";
            this.dateTglAkhir.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTglAkhir.Location = new System.Drawing.Point(644, 136);
            this.dateTglAkhir.Name = "dateTglAkhir";
            this.dateTglAkhir.Size = new System.Drawing.Size(152, 29);
            this.dateTglAkhir.TabIndex = 3;
            this.dateTglAkhir.ValueChanged += new System.EventHandler(this.dateTglAkhir_ValueChanged);
            // 
            // lblSPenghubung
            // 
            this.lblSPenghubung.AutoSize = true;
            this.lblSPenghubung.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPenghubung.Location = new System.Drawing.Point(619, 139);
            this.lblSPenghubung.Name = "lblSPenghubung";
            this.lblSPenghubung.Size = new System.Drawing.Size(19, 23);
            this.lblSPenghubung.TabIndex = 10;
            this.lblSPenghubung.Text = "-";
            // 
            // lblSFilter
            // 
            this.lblSFilter.AutoSize = true;
            this.lblSFilter.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFilter.Location = new System.Drawing.Point(847, 139);
            this.lblSFilter.Name = "lblSFilter";
            this.lblSFilter.Size = new System.Drawing.Size(68, 23);
            this.lblSFilter.TabIndex = 12;
            this.lblSFilter.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFilter.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Semua Ditampilkan",
            "Dibatalkan",
            "Belum Check In",
            "Sedang Menginap",
            "Sudah Check Out"});
            this.cbFilter.Location = new System.Drawing.Point(934, 136);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(233, 30);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblH1
            // 
            this.lblH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH1.Location = new System.Drawing.Point(20, 119);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(1150, 2);
            this.lblH1.TabIndex = 14;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tgl,
            this.Nama,
            this.Kode,
            this.Jumlah,
            this.TglCIN,
            this.TglCOUT,
            this.Status,
            this.Action});
            this.dgvBooking.Location = new System.Drawing.Point(20, 179);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.RowTemplate.Height = 24;
            this.dgvBooking.Size = new System.Drawing.Size(1147, 562);
            this.dgvBooking.TabIndex = 5;
            this.dgvBooking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooking_CellDoubleClick);
            // 
            // Tgl
            // 
            this.Tgl.HeaderText = "Tgl";
            this.Tgl.MinimumWidth = 6;
            this.Tgl.Name = "Tgl";
            this.Tgl.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Pemesan";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Kode
            // 
            this.Kode.HeaderText = "Kode Booking";
            this.Kode.MinimumWidth = 6;
            this.Kode.Name = "Kode";
            this.Kode.ReadOnly = true;
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah Kamar";
            this.Jumlah.MinimumWidth = 6;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            // 
            // TglCIN
            // 
            this.TglCIN.HeaderText = "Tgl Check In";
            this.TglCIN.MinimumWidth = 6;
            this.TglCIN.Name = "TglCIN";
            this.TglCIN.ReadOnly = true;
            // 
            // TglCOUT
            // 
            this.TglCOUT.HeaderText = "Tgl Check Out";
            this.TglCOUT.MinimumWidth = 6;
            this.TglCOUT.Name = "TglCOUT";
            this.TglCOUT.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status Booking";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // lblSSingle
            // 
            this.lblSSingle.AutoSize = true;
            this.lblSSingle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSingle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSSingle.Location = new System.Drawing.Point(20, 77);
            this.lblSSingle.Name = "lblSSingle";
            this.lblSSingle.Size = new System.Drawing.Size(84, 25);
            this.lblSSingle.TabIndex = 4;
            this.lblSSingle.Text = "Single:";
            // 
            // lblSFamily
            // 
            this.lblSFamily.AutoSize = true;
            this.lblSFamily.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFamily.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSFamily.Location = new System.Drawing.Point(198, 77);
            this.lblSFamily.Name = "lblSFamily";
            this.lblSFamily.Size = new System.Drawing.Size(87, 25);
            this.lblSFamily.TabIndex = 4;
            this.lblSFamily.Text = "Family:";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamily.Location = new System.Drawing.Point(288, 77);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(25, 25);
            this.lblFamily.TabIndex = 4;
            this.lblFamily.Text = "0";
            // 
            // pbLaporan
            // 
            this.pbLaporan.BackgroundImage = global::PROBIS_SqueeCapsule.Properties.Resources.report;
            this.pbLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLaporan.Location = new System.Drawing.Point(809, 56);
            this.pbLaporan.Name = "pbLaporan";
            this.pbLaporan.Size = new System.Drawing.Size(48, 50);
            this.pbLaporan.TabIndex = 24;
            this.pbLaporan.TabStop = false;
            // 
            // pbGrafik
            // 
            this.pbGrafik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGrafik.BackgroundImage")));
            this.pbGrafik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGrafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGrafik.Location = new System.Drawing.Point(863, 56);
            this.pbGrafik.Name = "pbGrafik";
            this.pbGrafik.Size = new System.Drawing.Size(48, 50);
            this.pbGrafik.TabIndex = 24;
            this.pbGrafik.TabStop = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pbLaporan);
            this.Controls.Add(this.pbGrafik);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblSFilter);
            this.Controls.Add(this.dateTglAkhir);
            this.Controls.Add(this.lblSPenghubung);
            this.Controls.Add(this.dateTglAwal);
            this.Controls.Add(this.lblSTanggal);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSSearch);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.lblSFamily);
            this.Controls.Add(this.lblSingle);
            this.Controls.Add(this.lblSSingle);
            this.Controls.Add(this.lblSKamar);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Activated += new System.EventHandler(this.Booking_Activated);
            this.Shown += new System.EventHandler(this.Booking_Shown);
            this.VisibleChanged += new System.EventHandler(this.Booking_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Booking_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafik)).EndInit();
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
        private System.Windows.Forms.Label lblSKamar;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblSSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSTanggal;
        private System.Windows.Forms.DateTimePicker dateTglAwal;
        private System.Windows.Forms.DateTimePicker dateTglAkhir;
        private System.Windows.Forms.Label lblSPenghubung;
        private System.Windows.Forms.Label lblSFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.Label lblSSingle;
        private System.Windows.Forms.Label lblSFamily;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglCIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglCOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.PictureBox pbGrafik;
        private System.Windows.Forms.PictureBox pbLaporan;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
    }
}